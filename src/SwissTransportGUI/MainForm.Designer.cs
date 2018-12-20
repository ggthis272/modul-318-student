namespace SwissTransportGUI
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.verbindungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationsfahrplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.googleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verbindungenToolStripMenuItem,
            this.stationsfahrplanToolStripMenuItem,
            this.googleMapsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(663, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // verbindungenToolStripMenuItem
            // 
            this.verbindungenToolStripMenuItem.Name = "verbindungenToolStripMenuItem";
            this.verbindungenToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.verbindungenToolStripMenuItem.Text = "Verbindungen";
            this.verbindungenToolStripMenuItem.Click += new System.EventHandler(this.VerbindungenToolStripMenuItem_Click);
            // 
            // stationsfahrplanToolStripMenuItem
            // 
            this.stationsfahrplanToolStripMenuItem.Name = "stationsfahrplanToolStripMenuItem";
            this.stationsfahrplanToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.stationsfahrplanToolStripMenuItem.Text = "Stationsfahrplan";
            this.stationsfahrplanToolStripMenuItem.Click += new System.EventHandler(this.StationsfahrplanToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 26);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(658, 541);
            this.mainPanel.TabIndex = 1;
            // 
            // googleMapsToolStripMenuItem
            // 
            this.googleMapsToolStripMenuItem.Name = "googleMapsToolStripMenuItem";
            this.googleMapsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.googleMapsToolStripMenuItem.Text = "Google Maps";
            this.googleMapsToolStripMenuItem.Click += new System.EventHandler(this.googleMapsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 573);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "SwissTransport";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem verbindungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationsfahrplanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleMapsToolStripMenuItem;
    }
}

