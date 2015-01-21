using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Sunny_Portal_Monitor
{

    public partial class MainForm : Form
    {

        /*
         * Set global cookie container
         * this container must be used for all future requests in the same context/user-session
         */
        public static CookieContainer cookies = new CookieContainer();

        private readonly SettingsForm settingsForm = new SettingsForm();

        public MainForm()
        {
            InitializeComponent();
            intervalTimer.Interval = (Properties.Settings.Default.updateinterval * 1000); /* update interval must be in milliseconds. User enters seconds, so multiply by 1000 */
            intervalTimer.Start();

            loginPortal();
        }

        public void loginPortal()
        {
            /* 
             * Login request 
            */

            string loginUrl = "https://www.sunnyportal.com/Templates/Start.aspx";

            /* Create webrequest */
            HttpWebRequest loginRequest = (HttpWebRequest)WebRequest.Create(loginUrl);
            /* Set cookie store to global cookiestore variable */
            loginRequest.CookieContainer = cookies;
            /* If needed, fetch proxie credentials from internet explorer */
            loginRequest.Credentials = CredentialCache.DefaultCredentials;
            loginRequest.Proxy.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            /* Set request method and contenttype */
            loginRequest.Method = "POST";
            loginRequest.ContentType = "application/x-www-form-urlencoded";

            /* New Streamwriter */
            Stream loginStream = loginRequest.GetRequestStream();

            /*  Put together form data using user-settings properties */
            string postData = "__EVENTTARGET=&ctl00$ContentPlaceHolder1$Logincontrol1$txtUserName=" + Properties.Settings.Default.username + "&ctl00$ContentPlaceHolder1$Logincontrol1$txtPassword=" + Properties.Settings.Default.password + "&ctl00$ContentPlaceHolder1$Logincontrol1$LoginBtn=Login";
            byte[] postArray = Encoding.ASCII.GetBytes(postData);

            /* Send request stream */
            loginStream.Write(postArray, 0, postArray.Length);

            /* Receive response stream */
            StreamReader loginReader = new StreamReader(loginRequest.GetResponse().GetResponseStream());
            string loginResponseFromServer = loginReader.ReadToEnd();

            loginReader.Close();
            loginStream.Close();
        }

        public void getPortalData()
        {

            /* 
             * Data request 
             */

            string dataUrl = "https://www.sunnyportal.com/homemanager"; /* Optional with timestamp: "https://www.sunnyportal.com/homemanager?_=1421673259210" */

            /* Put together web request to fetch json-data*/
            HttpWebRequest dataRequest = (HttpWebRequest)WebRequest.Create(dataUrl);
            /* Set cookie store (once again) to global cookiestore variable */
            dataRequest.CookieContainer = cookies;
            /* If needed, fetch proxie credentials from internet explorer */
            dataRequest.Credentials = CredentialCache.DefaultCredentials;
            /* Receive response stream ... */
            WebResponse dataResponse = dataRequest.GetResponse();
            Stream dataStream = dataResponse.GetResponseStream();
            StreamReader dataReader = new StreamReader(dataStream);
            /* ... and wait for it to end */
            string dataResponseFromServer = dataReader.ReadToEnd();

            dataReader.Close();
            dataStream.Close();

            /* Deserialize response content (should be valid json */
            try
            {
                var deserialized = JsonConvert.DeserializeObject(dataResponseFromServer);
                SunnyPortalData portalData = JsonConvert.DeserializeObject<SunnyPortalData>(dataResponseFromServer);

                /* Convert to double and divide by 1000 to change unit to kilowats */

                double pv = Convert.ToDouble(portalData.PV) / 1000;
                double totalConsumption = Convert.ToDouble(portalData.TotalConsumption) / 1000;
                double gridConsumption = (pv - totalConsumption);
                
                /* Set colors for labels.*/
                if (gridConsumption > 0)
                {
                    gridConsumptionLabel.ForeColor = System.Drawing.Color.Green;
                    gridConsumptionLabel.Text = "+" + gridConsumptionLabel.Text;
                }
                else if (gridConsumption < 0)
                {
                    gridConsumptionLabel.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    gridConsumptionLabel.ForeColor = System.Drawing.Color.Orange;
                }

                /* Round retourned data, append "kW" and set label text. */
                pvLabel.Text = Math.Round(pv, 2) + " kW";
                totalConsumptionLabel.Text = Math.Round(totalConsumption, 2) + " kW";
                gridConsumptionLabel.Text = Math.Round(gridConsumption, 2) + " kW";
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }

        }

        /* function triggerd by interval-timer.*/ 
        private void intervalTimer_Tick(object sender, EventArgs e)
        {
            if ((Properties.Settings.Default.username != "") && (Properties.Settings.Default.password != ""))
            {
                getPortalData();
            }

        }

        /*
         * Launch settings dialog by clicking the icons
        */
        private void pvPicture_Click(object sender, EventArgs e)
        {
            if (!settingsForm.Visible)
            {
                settingsForm.ShowDialog();
            }
        }

        private void totalConsumptionPicture_Click(object sender, EventArgs e)
        {
            if (!settingsForm.Visible)
            {
                settingsForm.ShowDialog();
            }
        }

        private void gridConsumptionPicture_Click(object sender, EventArgs e)
        {
            if (!settingsForm.Visible)
            {
                settingsForm.ShowDialog();
            }
        }

    }

    /*
     * JSON mapping 
     * returned json-data will be mapped to this class.
     */

    public class SunnyPortalData
    {
        public string Timestamp { get; set; }
        public string PV { get; set; }
        public string FeedIn { get; set; }
        public string GridConsumption { get; set; }
        public string DirectConsumption { get; set; }
        public string SelfConsumption { get; set; }
        public string SelfSupply { get; set; }
        public string TotalConsumption { get; set; }
        public string DirectConsumptionQuote { get; set; }
        public string SelfConsumptionQuote { get; set; }
        public string AutarkyQuote { get; set; }
        public string BatteryIn { get; set; }
        public string BatteryOut { get; set; }
        public string BatteryChargeStatus { get; set; }
        public string OperationHealth { get; set; }
        public string BatteryStateOfHealth { get; set; }
        // public Array InfoMessages { get; set; }
        // public Array WarningMessages { get; set; }
        // public Array ErrorMessages { get; set; }
        // public string Info { get; set; }
    }
}
