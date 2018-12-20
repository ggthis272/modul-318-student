using System;

namespace SwissTransportGUI
{
    partial class GoogleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleControl));
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_station = new System.Windows.Forms.TextBox();
            this.WEB_google_maps = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.LBX_station = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_station
            // 
            this.TXT_station.Location = new System.Drawing.Point(26, 75);
            this.TXT_station.Name = "TXT_station";
            this.TXT_station.Size = new System.Drawing.Size(166, 20);
            this.TXT_station.TabIndex = 1;
            this.TXT_station.TextChanged += new System.EventHandler(this.TXT_station_TextChanged);
            // 
            // WEB_google_maps
            // 
            this.WEB_google_maps.Location = new System.Drawing.Point(26, 202);
            this.WEB_google_maps.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_google_maps.Name = "WEB_google_maps";
            this.WEB_google_maps.Size = new System.Drawing.Size(611, 315);
            this.WEB_google_maps.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Google Maps";
            // 
            // LBX_station
            // 
            this.LBX_station.FormattingEnabled = true;
            this.LBX_station.Location = new System.Drawing.Point(26, 101);
            this.LBX_station.Name = "LBX_station";
            this.LBX_station.Size = new System.Drawing.Size(166, 95);
            this.LBX_station.TabIndex = 2;
            this.LBX_station.SelectedIndexChanged += new System.EventHandler(this.LBX_station_SelectedIndexChanged);
            // 
            // GoogleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WEB_google_maps);
            this.Controls.Add(this.LBX_station);
            this.Controls.Add(this.TXT_station);
            this.Controls.Add(this.button1);
            this.Name = "GoogleControl";
            this.Size = new System.Drawing.Size(690, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LBX_station_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXT_station;
        private System.Windows.Forms.WebBrowser WEB_google_maps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBX_station;
    }
}
