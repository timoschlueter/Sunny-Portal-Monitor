namespace Sunny_Portal_Monitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pvLabel = new System.Windows.Forms.Label();
            this.gridConsumptionLabel = new System.Windows.Forms.Label();
            this.totalConsumptionLabel = new System.Windows.Forms.Label();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.gridConsumptionPicture = new System.Windows.Forms.PictureBox();
            this.totalConsumptionPicture = new System.Windows.Forms.PictureBox();
            this.pvPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumptionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalConsumptionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pvLabel
            // 
            this.pvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvLabel.Location = new System.Drawing.Point(46, 12);
            this.pvLabel.Name = "pvLabel";
            this.pvLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pvLabel.Size = new System.Drawing.Size(43, 28);
            this.pvLabel.TabIndex = 5;
            this.pvLabel.Text = "000";
            this.pvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridConsumptionLabel
            // 
            this.gridConsumptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridConsumptionLabel.Location = new System.Drawing.Point(219, 12);
            this.gridConsumptionLabel.Name = "gridConsumptionLabel";
            this.gridConsumptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridConsumptionLabel.Size = new System.Drawing.Size(43, 28);
            this.gridConsumptionLabel.TabIndex = 6;
            this.gridConsumptionLabel.Text = "000";
            this.gridConsumptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalConsumptionLabel
            // 
            this.totalConsumptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalConsumptionLabel.Location = new System.Drawing.Point(135, 12);
            this.totalConsumptionLabel.Name = "totalConsumptionLabel";
            this.totalConsumptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalConsumptionLabel.Size = new System.Drawing.Size(46, 28);
            this.totalConsumptionLabel.TabIndex = 7;
            this.totalConsumptionLabel.Text = "000";
            this.totalConsumptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intervalTimer
            // 
            this.intervalTimer.Tick += new System.EventHandler(this.intervalTimer_Tick);
            // 
            // gridConsumptionPicture
            // 
            this.gridConsumptionPicture.Image = global::Sunny_Portal_Monitor.Properties.Resources._1421760066_network_cable;
            this.gridConsumptionPicture.InitialImage = global::Sunny_Portal_Monitor.Properties.Resources._1421760063_sun;
            this.gridConsumptionPicture.Location = new System.Drawing.Point(187, 12);
            this.gridConsumptionPicture.Name = "gridConsumptionPicture";
            this.gridConsumptionPicture.Size = new System.Drawing.Size(28, 28);
            this.gridConsumptionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gridConsumptionPicture.TabIndex = 10;
            this.gridConsumptionPicture.TabStop = false;
            this.gridConsumptionPicture.Click += new System.EventHandler(this.gridConsumptionPicture_Click);
            // 
            // totalConsumptionPicture
            // 
            this.totalConsumptionPicture.Image = global::Sunny_Portal_Monitor.Properties.Resources._1421760065_home;
            this.totalConsumptionPicture.InitialImage = global::Sunny_Portal_Monitor.Properties.Resources._1421760063_sun;
            this.totalConsumptionPicture.Location = new System.Drawing.Point(101, 12);
            this.totalConsumptionPicture.Name = "totalConsumptionPicture";
            this.totalConsumptionPicture.Size = new System.Drawing.Size(28, 28);
            this.totalConsumptionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.totalConsumptionPicture.TabIndex = 9;
            this.totalConsumptionPicture.TabStop = false;
            this.totalConsumptionPicture.Click += new System.EventHandler(this.totalConsumptionPicture_Click);
            // 
            // pvPicture
            // 
            this.pvPicture.Image = global::Sunny_Portal_Monitor.Properties.Resources._1421760063_sun;
            this.pvPicture.InitialImage = global::Sunny_Portal_Monitor.Properties.Resources._1421760063_sun;
            this.pvPicture.Location = new System.Drawing.Point(12, 12);
            this.pvPicture.Name = "pvPicture";
            this.pvPicture.Size = new System.Drawing.Size(28, 28);
            this.pvPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pvPicture.TabIndex = 8;
            this.pvPicture.TabStop = false;
            this.pvPicture.Click += new System.EventHandler(this.pvPicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 55);
            this.Controls.Add(this.gridConsumptionPicture);
            this.Controls.Add(this.totalConsumptionPicture);
            this.Controls.Add(this.pvPicture);
            this.Controls.Add(this.totalConsumptionLabel);
            this.Controls.Add(this.gridConsumptionLabel);
            this.Controls.Add(this.pvLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sunny Portal Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.gridConsumptionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalConsumptionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pvLabel;
        private System.Windows.Forms.Label gridConsumptionLabel;
        private System.Windows.Forms.Label totalConsumptionLabel;
        private System.Windows.Forms.Timer intervalTimer;
        private System.Windows.Forms.PictureBox pvPicture;
        private System.Windows.Forms.PictureBox totalConsumptionPicture;
        private System.Windows.Forms.PictureBox gridConsumptionPicture;
    }
}

