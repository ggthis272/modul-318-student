namespace SwissTransportGUI
{
    partial class VerbindungenControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerbindungenControl));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.cbNach = new System.Windows.Forms.ComboBox();
            this.cbVon = new System.Windows.Forms.ComboBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.btnSwap = new System.Windows.Forms.Button();
            this.Ebutton = new System.Windows.Forms.Button();
            this.ETextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd.MM.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(315, 116);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(91, 20);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2017, 5, 2, 0, 0, 0, 0);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.BackColor = System.Drawing.Color.Transparent;
            this.lblVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVon.Location = new System.Drawing.Point(268, 40);
            this.lblVon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(46, 20);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von:";
            this.lblVon.Click += new System.EventHandler(this.lblVon_Click);
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.BackColor = System.Drawing.Color.Transparent;
            this.lblNach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNach.Location = new System.Drawing.Point(259, 69);
            this.lblNach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(55, 20);
            this.lblNach.TabIndex = 0;
            this.lblNach.Text = "Nach:";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.BackColor = System.Drawing.Color.Transparent;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(20, 13);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(144, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Verbindungen";
            // 
            // cbNach
            // 
            this.cbNach.FormattingEnabled = true;
            this.cbNach.Location = new System.Drawing.Point(315, 68);
            this.cbNach.Margin = new System.Windows.Forms.Padding(2);
            this.cbNach.Name = "cbNach";
            this.cbNach.Size = new System.Drawing.Size(160, 21);
            this.cbNach.TabIndex = 2;
            this.cbNach.TextChanged += new System.EventHandler(this.CbNach_TextChanged);
            // 
            // cbVon
            // 
            this.cbVon.FormattingEnabled = true;
            this.cbVon.Location = new System.Drawing.Point(315, 39);
            this.cbVon.Margin = new System.Windows.Forms.Padding(2);
            this.cbVon.Name = "cbVon";
            this.cbVon.Size = new System.Drawing.Size(160, 21);
            this.cbVon.TabIndex = 1;
            this.cbVon.SelectedIndexChanged += new System.EventHandler(this.cbVon_SelectedIndexChanged);
            this.cbVon.TextChanged += new System.EventHandler(this.CbVon_TextChanged);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(425, 116);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2);
            this.timePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2017, 4, 27, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(50, 20);
            this.timePicker.TabIndex = 4;
            this.timePicker.Value = new System.DateTime(2017, 5, 2, 10, 10, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(247, 116);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(67, 20);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum:";
            this.lblDatum.Click += new System.EventHandler(this.lblDatum_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(488, 116);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lvConnections
            // 
            this.lvConnections.BackColor = System.Drawing.Color.Gainsboro;
            this.lvConnections.FullRowSelect = true;
            this.lvConnections.GridLines = true;
            this.lvConnections.Location = new System.Drawing.Point(43, 196);
            this.lvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(581, 305);
            this.lvConnections.TabIndex = 6;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            this.lvConnections.Visible = false;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(488, 54);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(78, 20);
            this.btnSwap.TabIndex = 0;
            this.btnSwap.TabStop = false;
            this.btnSwap.Text = "Tauschen";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // Ebutton
            // 
            this.Ebutton.Location = new System.Drawing.Point(580, 514);
            this.Ebutton.Name = "Ebutton";
            this.Ebutton.Size = new System.Drawing.Size(75, 23);
            this.Ebutton.TabIndex = 7;
            this.Ebutton.Text = "Send";
            this.Ebutton.UseVisualStyleBackColor = true;
            this.Ebutton.Click += new System.EventHandler(this.Ebutton_Click);
            // 
            // ETextbox
            // 
            this.ETextbox.Location = new System.Drawing.Point(315, 516);
            this.ETextbox.Name = "ETextbox";
            this.ETextbox.Size = new System.Drawing.Size(263, 20);
            this.ETextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(668, 5);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // VerbindungenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ETextbox);
            this.Controls.Add(this.Ebutton);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.cbNach);
            this.Controls.Add(this.cbVon);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VerbindungenControl";
            this.Size = new System.Drawing.Size(664, 546);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ComboBox cbNach;
        private System.Windows.Forms.ComboBox cbVon;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button Ebutton;
        private System.Windows.Forms.TextBox ETextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
