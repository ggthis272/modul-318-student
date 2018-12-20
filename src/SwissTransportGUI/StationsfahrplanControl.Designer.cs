namespace SwissTransportGUI
{
    partial class StationsfahrplanControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationsfahrplanControl));
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lvBoard = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Transparent;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(18, 18);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(158, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Stationsfahrplan";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.BackColor = System.Drawing.Color.Transparent;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(247, 116);
            this.lblStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(72, 20);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "Station:";
            // 
            // cbStation
            // 
            this.cbStation.Location = new System.Drawing.Point(323, 117);
            this.cbStation.Margin = new System.Windows.Forms.Padding(2);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(130, 21);
            this.cbStation.TabIndex = 0;
            this.cbStation.SelectedIndexChanged += new System.EventHandler(this.cbStation_SelectedIndexChanged);
            this.cbStation.TextChanged += new System.EventHandler(this.CbStation_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(457, 117);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSuchen_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.BackColor = System.Drawing.Color.Transparent;
            this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.Location = new System.Drawing.Point(41, 174);
            this.lblStationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(111, 20);
            this.lblStationName.TabIndex = 0;
            this.lblStationName.Text = "Stationname";
            this.lblStationName.Visible = false;
            // 
            // lvBoard
            // 
            this.lvBoard.FullRowSelect = true;
            this.lvBoard.Location = new System.Drawing.Point(43, 196);
            this.lvBoard.Margin = new System.Windows.Forms.Padding(2);
            this.lvBoard.Name = "lvBoard";
            this.lvBoard.Size = new System.Drawing.Size(581, 305);
            this.lvBoard.TabIndex = 2;
            this.lvBoard.UseCompatibleStateImageBehavior = false;
            this.lvBoard.View = System.Windows.Forms.View.Details;
            this.lvBoard.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 101);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(0, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(669, 5);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // StationsfahrplanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvBoard);
            this.Controls.Add(this.lblStationName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StationsfahrplanControl";
            this.Size = new System.Drawing.Size(662, 545);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.ListView lvBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
