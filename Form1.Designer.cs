namespace PROIECT_PAW
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuSalvare = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuRestaurare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.meniuIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuRezervari = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuAdaugaRezervare = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuAfisareRezervari = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.meniuStergeToate = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuGrafice = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuAfisareGrafice = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuAjutor = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuDespre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumarCamera = new System.Windows.Forms.TextBox();
            this.cbTipCamera = new System.Windows.Forms.ComboBox();
            this.tbPretCamera = new System.Windows.Forms.TextBox();
            this.cbEtajCamera = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIdRezervare = new System.Windows.Forms.TextBox();
            this.cbStatusRezervare = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSedereDurata = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCostTotal = new System.Windows.Forms.TextBox();
            this.afisareRezervari = new System.Windows.Forms.Button();
            this.btnGrafice = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // menuStrip1
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuFisier, this.meniuRezervari, this.meniuGrafice, this.meniuAjutor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 30);
            this.menuStrip1.TabIndex = 50;
            // meniuFisier
            this.meniuFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuSalvare, this.meniuRestaurare, this.toolStripSeparator1, this.meniuIesire});
            this.meniuFisier.Name = "meniuFisier";
            this.meniuFisier.Size = new System.Drawing.Size(57, 26);
            this.meniuFisier.Text = "&Fișier";
            // meniuSalvare
            this.meniuSalvare.Name = "meniuSalvare";
            this.meniuSalvare.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.meniuSalvare.Size = new System.Drawing.Size(273, 26);
            this.meniuSalvare.Text = "&Salvare  (Ctrl+S)";
            this.meniuSalvare.Click += new System.EventHandler(this.meniuSalvare_Click);
            // meniuRestaurare
            this.meniuRestaurare.Name = "meniuRestaurare";
            this.meniuRestaurare.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.meniuRestaurare.Size = new System.Drawing.Size(273, 26);
            this.meniuRestaurare.Text = "&Restaurare  (Ctrl+R)";
            this.meniuRestaurare.Click += new System.EventHandler(this.meniuRestaurare_Click);
            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // meniuIesire
            this.meniuIesire.Name = "meniuIesire";
            this.meniuIesire.Size = new System.Drawing.Size(273, 26);
            this.meniuIesire.Text = "Ie&șire";
            this.meniuIesire.Click += new System.EventHandler(this.meniuIesire_Click);
            // meniuRezervari
            this.meniuRezervari.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuAdaugaRezervare, this.meniuAfisareRezervari,
            this.toolStripSeparator2, this.meniuStergeToate});
            this.meniuRezervari.Name = "meniuRezervari";
            this.meniuRezervari.Size = new System.Drawing.Size(84, 26);
            this.meniuRezervari.Text = "&Rezervări";
            // meniuAdaugaRezervare
            this.meniuAdaugaRezervare.Name = "meniuAdaugaRezervare";
            this.meniuAdaugaRezervare.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.meniuAdaugaRezervare.Size = new System.Drawing.Size(324, 26);
            this.meniuAdaugaRezervare.Text = "&Adaugă rezervare  (Ctrl+N)";
            this.meniuAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // meniuAfisareRezervari
            this.meniuAfisareRezervari.Name = "meniuAfisareRezervari";
            this.meniuAfisareRezervari.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.meniuAfisareRezervari.Size = new System.Drawing.Size(324, 26);
            this.meniuAfisareRezervari.Text = "A&fisare rezervări  (Ctrl+L)";
            this.meniuAfisareRezervari.Click += new System.EventHandler(this.afisareRezervari_Click);
            // toolStripSeparator2
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(321, 6);
            // meniuStergeToate
            this.meniuStergeToate.Name = "meniuStergeToate";
            this.meniuStergeToate.Size = new System.Drawing.Size(324, 26);
            this.meniuStergeToate.Text = "Șt&erge toate rezervările";
            this.meniuStergeToate.Click += new System.EventHandler(this.meniuStergeToate_Click);
            // meniuGrafice
            this.meniuGrafice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuAfisareGrafice});
            this.meniuGrafice.Name = "meniuGrafice";
            this.meniuGrafice.Size = new System.Drawing.Size(70, 26);
            this.meniuGrafice.Text = "&Grafice";
            // meniuAfisareGrafice
            this.meniuAfisareGrafice.Name = "meniuAfisareGrafice";
            this.meniuAfisareGrafice.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.meniuAfisareGrafice.Size = new System.Drawing.Size(311, 26);
            this.meniuAfisareGrafice.Text = "&Statistici grafice  (Ctrl+G)";
            this.meniuAfisareGrafice.Click += new System.EventHandler(this.meniuAfisareGrafice_Click);
            // meniuAjutor
            this.meniuAjutor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuDespre});
            this.meniuAjutor.Name = "meniuAjutor";
            this.meniuAjutor.Size = new System.Drawing.Size(64, 26);
            this.meniuAjutor.Text = "&Ajutor";
            // meniuDespre
            this.meniuDespre.Name = "meniuDespre";
            this.meniuDespre.Size = new System.Drawing.Size(200, 26);
            this.meniuDespre.Text = "&Despre aplicație";
            this.meniuDespre.Click += new System.EventHandler(this.meniuDespre_Click);
            // btnAdaugaRezervare
            this.btnAdaugaRezervare.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdaugaRezervare.ForeColor = System.Drawing.Color.OldLace;
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(24, 360);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(185, 80);
            this.btnAdaugaRezervare.TabIndex = 12;
            this.btnAdaugaRezervare.Text = "Adauga Rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = false;
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F);
            this.label5.Location = new System.Drawing.Point(390, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 40);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Camera";
            // label10
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 31);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numa&r";
            // label9
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "&Tip";
            // label8
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "&Pret(noapte)";
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "&Etaj";
            // tbNumarCamera
            this.tbNumarCamera.Location = new System.Drawing.Point(440, 107);
            this.tbNumarCamera.Name = "tbNumarCamera";
            this.tbNumarCamera.Size = new System.Drawing.Size(110, 32);
            this.tbNumarCamera.TabIndex = 4;
            this.tbNumarCamera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCifre_KeyPress);
            // cbTipCamera
            this.cbTipCamera.FormattingEnabled = true;
            this.cbTipCamera.Items.AddRange(new object[] { "Single", "Double", "Apartament" });
            this.cbTipCamera.Location = new System.Drawing.Point(440, 162);
            this.cbTipCamera.Name = "cbTipCamera";
            this.cbTipCamera.Size = new System.Drawing.Size(120, 39);
            this.cbTipCamera.TabIndex = 5;
            // tbPretCamera
            this.tbPretCamera.Location = new System.Drawing.Point(460, 219);
            this.tbPretCamera.Name = "tbPretCamera";
            this.tbPretCamera.Size = new System.Drawing.Size(100, 32);
            this.tbPretCamera.TabIndex = 6;
            this.tbPretCamera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            // cbEtajCamera
            this.cbEtajCamera.FormattingEnabled = true;
            this.cbEtajCamera.Items.AddRange(new object[] { "0", "1", "2", "3" });
            this.cbEtajCamera.Location = new System.Drawing.Point(440, 272);
            this.cbEtajCamera.Name = "cbEtajCamera";
            this.cbEtajCamera.Size = new System.Drawing.Size(120, 39);
            this.cbEtajCamera.TabIndex = 7;
            // label12
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 18F);
            this.label12.Location = new System.Drawing.Point(660, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 40);
            this.label12.TabIndex = 23;
            this.label12.Text = "Detalii Rezervare";
            // label15
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(600, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 31);
            this.label15.TabIndex = 24;
            this.label15.Text = "I&D";
            // label14
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(600, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 31);
            this.label14.TabIndex = 25;
            this.label14.Text = "&Status";
            // label13
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(600, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 31);
            this.label13.TabIndex = 26;
            this.label13.Text = "Check-&In";
            // label11
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 31);
            this.label11.TabIndex = 29;
            this.label11.Text = "Check-&Out";
            // tbIdRezervare
            this.tbIdRezervare.Location = new System.Drawing.Point(700, 107);
            this.tbIdRezervare.Name = "tbIdRezervare";
            this.tbIdRezervare.Size = new System.Drawing.Size(110, 32);
            this.tbIdRezervare.TabIndex = 8;
            this.tbIdRezervare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCifre_KeyPress);
            // cbStatusRezervare
            this.cbStatusRezervare.FormattingEnabled = true;
            this.cbStatusRezervare.Items.AddRange(new object[] { "Confirmata", "In asteptare" });
            this.cbStatusRezervare.Location = new System.Drawing.Point(700, 162);
            this.cbStatusRezervare.Name = "cbStatusRezervare";
            this.cbStatusRezervare.Size = new System.Drawing.Size(150, 39);
            this.cbStatusRezervare.TabIndex = 9;
            // dateTimePickerCheckIn
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(700, 219);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(230, 32);
            this.dateTimePickerCheckIn.TabIndex = 10;
            // dateTimePickerCheckOut
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(700, 272);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(230, 32);
            this.dateTimePickerCheckOut.TabIndex = 11;
            // label16
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(600, 330);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 31);
            this.label16.TabIndex = 33;
            this.label16.Text = "Durata Sedere";
            // tbSedereDurata
            this.tbSedereDurata.Location = new System.Drawing.Point(775, 327);
            this.tbSedereDurata.Name = "tbSedereDurata";
            this.tbSedereDurata.ReadOnly = true;
            this.tbSedereDurata.Size = new System.Drawing.Size(110, 32);
            this.tbSedereDurata.TabIndex = 34;
            // label17
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(600, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 31);
            this.label17.TabIndex = 35;
            this.label17.Text = "Cost Total";
            // tbCostTotal
            this.tbCostTotal.Location = new System.Drawing.Point(775, 377);
            this.tbCostTotal.Name = "tbCostTotal";
            this.tbCostTotal.ReadOnly = true;
            this.tbCostTotal.Size = new System.Drawing.Size(110, 32);
            this.tbCostTotal.TabIndex = 36;
            // afisareRezervari
            this.afisareRezervari.BackColor = System.Drawing.Color.DarkRed;
            this.afisareRezervari.ForeColor = System.Drawing.Color.OldLace;
            this.afisareRezervari.Location = new System.Drawing.Point(220, 360);
            this.afisareRezervari.Name = "afisareRezervari";
            this.afisareRezervari.Size = new System.Drawing.Size(185, 80);
            this.afisareRezervari.TabIndex = 13;
            this.afisareRezervari.Text = "Afisare Rezervari";
            this.afisareRezervari.UseVisualStyleBackColor = false;
            this.afisareRezervari.Click += new System.EventHandler(this.afisareRezervari_Click);
            // btnGrafice
            this.btnGrafice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGrafice.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnGrafice.Location = new System.Drawing.Point(416, 360);
            this.btnGrafice.Name = "btnGrafice";
            this.btnGrafice.Size = new System.Drawing.Size(185, 80);
            this.btnGrafice.TabIndex = 14;
            this.btnGrafice.Text = "Grafice Statistici";
            this.btnGrafice.UseVisualStyleBackColor = false;
            this.btnGrafice.Click += new System.EventHandler(this.meniuAfisareGrafice_Click);
            // errorProvider1
            this.errorProvider1.ContainerControl = this;
            // contextMenuStrip1
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 470);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbNumarCamera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTipCamera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPretCamera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEtajCamera);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbIdRezervare);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbStatusRezervare);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbSedereDurata);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbCostTotal);
            this.Controls.Add(this.btnAdaugaRezervare);
            this.Controls.Add(this.afisareRezervari);
            this.Controls.Add(this.btnGrafice);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rezervare Hotel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuFisier;
        private System.Windows.Forms.ToolStripMenuItem meniuSalvare;
        private System.Windows.Forms.ToolStripMenuItem meniuRestaurare;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem meniuIesire;
        private System.Windows.Forms.ToolStripMenuItem meniuRezervari;
        private System.Windows.Forms.ToolStripMenuItem meniuAdaugaRezervare;
        private System.Windows.Forms.ToolStripMenuItem meniuAfisareRezervari;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem meniuStergeToate;
        private System.Windows.Forms.ToolStripMenuItem meniuGrafice;
        private System.Windows.Forms.ToolStripMenuItem meniuAfisareGrafice;
        private System.Windows.Forms.ToolStripMenuItem meniuAjutor;
        private System.Windows.Forms.ToolStripMenuItem meniuDespre;
        private System.Windows.Forms.Button btnAdaugaRezervare;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCostTotal;
        private System.Windows.Forms.Button afisareRezervari;
        private System.Windows.Forms.Button btnGrafice;
    }
}