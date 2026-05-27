namespace PROIECT_PAW
{
    partial class FormEditRezervare
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblNumar = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblEtaj = new System.Windows.Forms.Label();
            this.tbNumarCamera = new System.Windows.Forms.TextBox();
            this.cbTipCamera = new System.Windows.Forms.ComboBox();
            this.tbPretCamera = new System.Windows.Forms.TextBox();
            this.cbEtajCamera = new System.Windows.Forms.ComboBox();
            this.lblDetalii = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.datePickerIn = new System.Windows.Forms.DateTimePicker();
            this.datePickerOut = new System.Windows.Forms.DateTimePicker();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientInput = new PROIECT_PAW.ClientInputControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold);
            this.lblCamera.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCamera.Location = new System.Drawing.Point(348, 10);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(110, 31);
            this.lblCamera.TabIndex = 1;
            this.lblCamera.Text = "Date Camera";
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Location = new System.Drawing.Point(348, 48);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(47, 16);
            this.lblNumar.TabIndex = 2;
            this.lblNumar.Text = "&Numar";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(348, 85);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(27, 16);
            this.lblTip.TabIndex = 3;
            this.lblTip.Text = "&Tip";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(348, 122);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(77, 16);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "&Pret/noapte";
            // 
            // lblEtaj
            // 
            this.lblEtaj.AutoSize = true;
            this.lblEtaj.Location = new System.Drawing.Point(348, 159);
            this.lblEtaj.Name = "lblEtaj";
            this.lblEtaj.Size = new System.Drawing.Size(30, 16);
            this.lblEtaj.TabIndex = 5;
            this.lblEtaj.Text = "&Etaj";
            // 
            // tbNumarCamera
            // 
            this.tbNumarCamera.Location = new System.Drawing.Point(460, 45);
            this.tbNumarCamera.Name = "tbNumarCamera";
            this.tbNumarCamera.Size = new System.Drawing.Size(110, 22);
            this.tbNumarCamera.TabIndex = 1;
            this.tbNumarCamera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCifre_KeyPress);
            // 
            // cbTipCamera
            // 
            this.cbTipCamera.FormattingEnabled = true;
            this.cbTipCamera.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Apartament"});
            this.cbTipCamera.Location = new System.Drawing.Point(460, 82);
            this.cbTipCamera.Name = "cbTipCamera";
            this.cbTipCamera.Size = new System.Drawing.Size(110, 24);
            this.cbTipCamera.TabIndex = 2;
            // 
            // tbPretCamera
            // 
            this.tbPretCamera.Location = new System.Drawing.Point(460, 119);
            this.tbPretCamera.Name = "tbPretCamera";
            this.tbPretCamera.Size = new System.Drawing.Size(110, 22);
            this.tbPretCamera.TabIndex = 3;
            this.tbPretCamera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            // 
            // cbEtajCamera
            // 
            this.cbEtajCamera.FormattingEnabled = true;
            this.cbEtajCamera.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbEtajCamera.Location = new System.Drawing.Point(460, 156);
            this.cbEtajCamera.Name = "cbEtajCamera";
            this.cbEtajCamera.Size = new System.Drawing.Size(110, 24);
            this.cbEtajCamera.TabIndex = 4;
            // 
            // lblDetalii
            // 
            this.lblDetalii.AutoSize = true;
            this.lblDetalii.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetalii.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblDetalii.Location = new System.Drawing.Point(600, 10);
            this.lblDetalii.Name = "lblDetalii";
            this.lblDetalii.Size = new System.Drawing.Size(140, 31);
            this.lblDetalii.TabIndex = 6;
            this.lblDetalii.Text = "Detalii Rezervare";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(600, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "I&D";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(600, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "&Status";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(600, 122);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(59, 16);
            this.lblIn.TabIndex = 9;
            this.lblIn.Text = "Check-&In";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(600, 159);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(69, 16);
            this.lblOut.TabIndex = 10;
            this.lblOut.Text = "Check-&Out";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(700, 45);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(90, 22);
            this.tbId.TabIndex = 5;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Confirmata",
            "In asteptare"});
            this.cbStatus.Location = new System.Drawing.Point(700, 82);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(130, 24);
            this.cbStatus.TabIndex = 6;
            // 
            // datePickerIn
            // 
            this.datePickerIn.Location = new System.Drawing.Point(700, 119);
            this.datePickerIn.Name = "datePickerIn";
            this.datePickerIn.Size = new System.Drawing.Size(239, 22);
            this.datePickerIn.TabIndex = 7;
            // 
            // datePickerOut
            // 
            this.datePickerOut.Location = new System.Drawing.Point(700, 156);
            this.datePickerOut.Name = "datePickerOut";
            this.datePickerOut.Size = new System.Drawing.Size(239, 22);
            this.datePickerOut.TabIndex = 8;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSalveaza.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSalveaza.Location = new System.Drawing.Point(316, 220);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(130, 45);
            this.btnSalveaza.TabIndex = 9;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.DarkRed;
            this.btnAnuleaza.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAnuleaza.Location = new System.Drawing.Point(490, 220);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(130, 45);
            this.btnAnuleaza.TabIndex = 10;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clientInput
            // 
            this.clientInput.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clientInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientInput.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.clientInput.Location = new System.Drawing.Point(12, 40);
            this.clientInput.Name = "clientInput";
            this.clientInput.Size = new System.Drawing.Size(320, 160);
            this.clientInput.TabIndex = 0;
            // 
            // FormEditRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(969, 285);
            this.Controls.Add(this.clientInput);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.tbNumarCamera);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.cbTipCamera);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.tbPretCamera);
            this.Controls.Add(this.lblEtaj);
            this.Controls.Add(this.cbEtajCamera);
            this.Controls.Add(this.lblDetalii);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.datePickerIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.datePickerOut);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAnuleaza);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditRezervare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editare Rezervare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PROIECT_PAW.ClientInputControl clientInput;

        private System.Windows.Forms.Label lblCamera, lblNumar, lblTip, lblPret, lblEtaj;
        private System.Windows.Forms.TextBox tbNumarCamera, tbPretCamera;
        private System.Windows.Forms.ComboBox cbTipCamera, cbEtajCamera;

        private System.Windows.Forms.Label lblDetalii, lblId, lblStatus, lblIn, lblOut;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker datePickerIn, datePickerOut;

        private System.Windows.Forms.Button btnSalveaza, btnAnuleaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}