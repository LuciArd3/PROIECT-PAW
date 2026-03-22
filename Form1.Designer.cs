namespace PROIECT_PAW
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNumarCamera = new System.Windows.Forms.TextBox();
            this.tbPretCamera = new System.Windows.Forms.TextBox();
            this.cbTipCamera = new System.Windows.Forms.ComboBox();
            this.cbEtajCamera = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbIdRezervare = new System.Windows.Forms.TextBox();
            this.cbStatusRezervare = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.tbSedereDurata = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCostTotal = new System.Windows.Forms.TextBox();
            this.afisareRezervari = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "&CNP";
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(123, 101);
            this.tbNumeClient.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(112, 32);
            this.tbNumeClient.TabIndex = 6;
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdaugaRezervare.ForeColor = System.Drawing.Color.OldLace;
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(24, 415);
            this.btnAdaugaRezervare.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(211, 95);
            this.btnAdaugaRezervare.TabIndex = 7;
            this.btnAdaugaRezervare.Text = "Adauga Rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = false;
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date Client";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(123, 231);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(112, 32);
            this.tbTelefon.TabIndex = 9;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(123, 300);
            this.tbCNP.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(112, 32);
            this.tbCNP.TabIndex = 10;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.cbSex.Location = new System.Drawing.Point(123, 161);
            this.cbSex.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(112, 39);
            this.cbSex.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 40);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Camera";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "&Etaj";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "&Pret(noapte)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "&Tip";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 31);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numa&r";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbNumarCamera
            // 
            this.tbNumarCamera.Location = new System.Drawing.Point(421, 104);
            this.tbNumarCamera.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbNumarCamera.Name = "tbNumarCamera";
            this.tbNumarCamera.Size = new System.Drawing.Size(112, 32);
            this.tbNumarCamera.TabIndex = 18;
            // 
            // tbPretCamera
            // 
            this.tbPretCamera.Location = new System.Drawing.Point(441, 228);
            this.tbPretCamera.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbPretCamera.Name = "tbPretCamera";
            this.tbPretCamera.Size = new System.Drawing.Size(92, 32);
            this.tbPretCamera.TabIndex = 19;
            // 
            // cbTipCamera
            // 
            this.cbTipCamera.FormattingEnabled = true;
            this.cbTipCamera.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Apartament"});
            this.cbTipCamera.Location = new System.Drawing.Point(421, 156);
            this.cbTipCamera.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbTipCamera.Name = "cbTipCamera";
            this.cbTipCamera.Size = new System.Drawing.Size(112, 39);
            this.cbTipCamera.TabIndex = 20;
            // 
            // cbEtajCamera
            // 
            this.cbEtajCamera.FormattingEnabled = true;
            this.cbEtajCamera.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbEtajCamera.Location = new System.Drawing.Point(421, 292);
            this.cbEtajCamera.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbEtajCamera.Name = "cbEtajCamera";
            this.cbEtajCamera.Size = new System.Drawing.Size(112, 39);
            this.cbEtajCamera.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(733, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 40);
            this.label12.TabIndex = 23;
            this.label12.Text = "Detalii Rezervare";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(618, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 31);
            this.label13.TabIndex = 26;
            this.label13.Text = "Check-&In";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(618, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 31);
            this.label14.TabIndex = 25;
            this.label14.Text = "&Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(618, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 31);
            this.label15.TabIndex = 24;
            this.label15.Text = "I&D";
            // 
            // tbIdRezervare
            // 
            this.tbIdRezervare.Location = new System.Drawing.Point(704, 98);
            this.tbIdRezervare.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbIdRezervare.Name = "tbIdRezervare";
            this.tbIdRezervare.Size = new System.Drawing.Size(112, 32);
            this.tbIdRezervare.TabIndex = 27;
            // 
            // cbStatusRezervare
            // 
            this.cbStatusRezervare.FormattingEnabled = true;
            this.cbStatusRezervare.Items.AddRange(new object[] {
            "Confirmata",
            "In asteptare"});
            this.cbStatusRezervare.Location = new System.Drawing.Point(704, 156);
            this.cbStatusRezervare.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.cbStatusRezervare.Name = "cbStatusRezervare";
            this.cbStatusRezervare.Size = new System.Drawing.Size(112, 39);
            this.cbStatusRezervare.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 31);
            this.label11.TabIndex = 29;
            this.label11.Text = "Check-&Out";
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(711, 228);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(228, 32);
            this.dateTimePickerCheckIn.TabIndex = 30;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(711, 300);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(228, 32);
            this.dateTimePickerCheckOut.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(618, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 31);
            this.label16.TabIndex = 33;
            this.label16.Text = "Durata Sedere";
            // 
            // tbSedereDurata
            // 
            this.tbSedereDurata.Location = new System.Drawing.Point(740, 364);
            this.tbSedereDurata.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbSedereDurata.Name = "tbSedereDurata";
            this.tbSedereDurata.Size = new System.Drawing.Size(112, 32);
            this.tbSedereDurata.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(618, 428);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 31);
            this.label17.TabIndex = 35;
            this.label17.Text = "Cost Total";
            // 
            // tbCostTotal
            // 
            this.tbCostTotal.Location = new System.Drawing.Point(740, 425);
            this.tbCostTotal.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.tbCostTotal.Name = "tbCostTotal";
            this.tbCostTotal.Size = new System.Drawing.Size(112, 32);
            this.tbCostTotal.TabIndex = 36;
            // 
            // afisareRezervari
            // 
            this.afisareRezervari.BackColor = System.Drawing.Color.DarkRed;
            this.afisareRezervari.ForeColor = System.Drawing.Color.OldLace;
            this.afisareRezervari.Location = new System.Drawing.Point(322, 415);
            this.afisareRezervari.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.afisareRezervari.Name = "afisareRezervari";
            this.afisareRezervari.Size = new System.Drawing.Size(211, 95);
            this.afisareRezervari.TabIndex = 37;
            this.afisareRezervari.Text = "Afisare Rezervari";
            this.afisareRezervari.UseVisualStyleBackColor = false;
            this.afisareRezervari.Click += new System.EventHandler(this.afisareRezervari_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fisierToolStripMenuItem.Text = "Fisier";
            this.fisierToolStripMenuItem.Click += new System.EventHandler(this.fisierToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 526);
            this.Controls.Add(this.afisareRezervari);
            this.Controls.Add(this.tbCostTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbSedereDurata);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbStatusRezervare);
            this.Controls.Add(this.tbIdRezervare);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbEtajCamera);
            this.Controls.Add(this.cbTipCamera);
            this.Controls.Add(this.tbPretCamera);
            this.Controls.Add(this.tbNumarCamera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdaugaRezervare);
            this.Controls.Add(this.tbNumeClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "Form1";
            this.Text = "Rezervare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.Button btnAdaugaRezervare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNumarCamera;
        private System.Windows.Forms.TextBox tbPretCamera;
        private System.Windows.Forms.ComboBox cbTipCamera;
        private System.Windows.Forms.ComboBox cbEtajCamera;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbIdRezervare;
        private System.Windows.Forms.ComboBox cbStatusRezervare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbSedereDurata;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCostTotal;
        private System.Windows.Forms.Button afisareRezervari;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}