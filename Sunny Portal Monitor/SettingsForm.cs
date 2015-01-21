using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunny_Portal_Monitor
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            /* Set textfield values to settings stored in user properties */
            usernameTextfield.Text = Properties.Settings.Default.username;
            passwordTextfield.Text = Properties.Settings.Default.password;
            intervalTextfield.Text = Convert.ToString(Properties.Settings.Default.updateinterval);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /* Store textfield values to user properties */
            Properties.Settings.Default.username = usernameTextfield.Text;
            Properties.Settings.Default.password = passwordTextfield.Text;

            Int32 updateInterval = Convert.ToInt32(intervalTextfield.Text);

            /* Default to an update interval of 3 seconds in case the user enters lower update interval */
            if (updateInterval < 3)
            {
                Properties.Settings.Default.updateinterval = 3;
            }
            else
            {
                Properties.Settings.Default.updateinterval = Convert.ToInt32(intervalTextfield.Text);
            }

            /* Save the cahnges and close form */
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
