using System;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class FormEditRezervare : Form
    {
        public Rezervare RezervareEditata { get; private set; }

        public FormEditRezervare(Rezervare r)
        {
            InitializeComponent();
            PopuleazaCampuri(r);
        }

        private void PopuleazaCampuri(Rezervare r)
        {
            clientInput.SetDate(r.Client.Nume, r.Client.Sex, r.Client.NrTelefon);

            tbNumarCamera.Text = r.Camera.Numar.ToString();
            cbTipCamera.Text = r.Camera.Tip;
            tbPretCamera.Text = r.Camera.PretNoapte.ToString();
            cbEtajCamera.Text = r.Camera.Etaj.ToString();

            tbId.Text = r.Id.ToString();
            cbStatus.Text = r.Status;
            datePickerIn.Value = r.DataCheckIn;
            datePickerOut.Value = r.DataCheckOut;

            RezervareEditata = r;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (!clientInput.Valideaza()) return;

            if (tbNumarCamera.Text == "")
            { errorProvider1.SetError(tbNumarCamera, "Completati numarul camerei!"); return; }
            if (cbTipCamera.Text == "")
            { errorProvider1.SetError(cbTipCamera, "Completati tipul!"); return; }
            if (tbPretCamera.Text == "")
            { errorProvider1.SetError(tbPretCamera, "Completati pretul!"); return; }
            if (cbEtajCamera.Text == "")
            { errorProvider1.SetError(cbEtajCamera, "Completati etajul!"); return; }
            if (cbStatus.Text == "")
            { errorProvider1.SetError(cbStatus, "Completati statusul!"); return; }

            if (datePickerOut.Value <= datePickerIn.Value)
            {
                MessageBox.Show("Check-out trebuie sa fie dupa check-in!",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            errorProvider1.Clear();

            Client client = new Client(
                clientInput.NumeClient,
                clientInput.Sex,
                clientInput.Telefon);

            Camera camera = new Camera(
                Convert.ToInt32(tbNumarCamera.Text),
                cbTipCamera.Text,
                (float)Convert.ToDouble(tbPretCamera.Text),
                Convert.ToInt32(cbEtajCamera.Text));

            RezervareEditata = new Rezervare(
                Convert.ToInt32(tbId.Text),
                client, camera,
                datePickerIn.Value,
                datePickerOut.Value,
                cbStatus.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            { e.Handled = true; return; }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }
    }
}