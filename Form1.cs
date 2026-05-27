using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Form1 : Form
    {
        private const string FISIER_DATE = "rezervari.dat";
        List<Rezervare> listaRezervari = new List<Rezervare>();
        private readonly DatabaseHelper db = new DatabaseHelper();
        private ClientInputControl clientInput;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            clientInput = new ClientInputControl();
            clientInput.Location = new System.Drawing.Point(10, 40);
            this.Controls.Add(clientInput);

            db.CreeazaTabel();
            listaRezervari = db.GetToate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) GoalesteCampuri();
            if (e.KeyCode == Keys.F1) DeschideForm2();
            if (e.KeyCode == Keys.Enter) btnAdaugaRezervare_Click(sender, e);
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

        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            if (!clientInput.Valideaza()) return;

            if (tbNumarCamera.Text == "")
            { errorProvider1.SetError(tbNumarCamera, "Introduceti numarul camerei!"); return; }
            if (cbTipCamera.Text == "")
            { errorProvider1.SetError(cbTipCamera, "Introduceti tipul camerei!"); return; }
            if (tbPretCamera.Text == "")
            { errorProvider1.SetError(tbPretCamera, "Introduceti pretul!"); return; }
            if (cbEtajCamera.Text == "")
            { errorProvider1.SetError(cbEtajCamera, "Introduceti etajul!"); return; }

            if (tbIdRezervare.Text == "")
            { errorProvider1.SetError(tbIdRezervare, "Introduceti ID-ul rezervarii!"); return; }
            if (cbStatusRezervare.Text == "")
            { errorProvider1.SetError(cbStatusRezervare, "Introduceti statusul!"); return; }

            errorProvider1.Clear();
            try
            { 
                Client client = new Client(
                    clientInput.NumeClient,
                    clientInput.Sex,
                    clientInput.Telefon
                );

                int numar = Convert.ToInt32(tbNumarCamera.Text);
                string tip = cbTipCamera.Text;
                float pretNoapte = (float)Convert.ToDouble(tbPretCamera.Text);
                int etaj = Convert.ToInt32(cbEtajCamera.Text);
                Camera camera = new Camera(numar, tip, pretNoapte, etaj);

                int id = Convert.ToInt32(tbIdRezervare.Text);
                DateTime checkIn = dateTimePickerCheckIn.Value;
                DateTime checkOut = dateTimePickerCheckOut.Value;
                string status = cbStatusRezervare.Text;

                if (checkOut <= checkIn)
                    throw new Exception("Data de check-out trebuie sa fie dupa data de check-in!");

                Rezervare rezervare = new Rezervare(id, client, camera, checkIn, checkOut, status);
                tbSedereDurata.Text = rezervare.noptiSedere().ToString();
                tbCostTotal.Text = rezervare.costTotal().ToString("F2");

                MessageBox.Show(rezervare.ToString(), "Rezervare adaugata",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                listaRezervari.Add(rezervare);
                db.Adauga(rezervare);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { GoalesteCampuri(); }
        }

        private void afisareRezervari_Click(object sender, EventArgs e) => DeschideForm2();

        private void DeschideForm2()
        {
            new Form2(listaRezervari, db).Show();
        }

        private void meniuAfisareGrafice_Click(object sender, EventArgs e)
        {
            new FormGrafice(listaRezervari).Show();
        }

        private void SalveazaDate()
        {
            try
            {
                using (FileStream fs = new FileStream(FISIER_DATE, FileMode.Create, FileAccess.Write))
                    new BinaryFormatter().Serialize(fs, listaRezervari);
                MessageBox.Show("Date salvate! (" + listaRezervari.Count + " rezervari)",
                    "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestaureazaDate()
        {
            if (!File.Exists(FISIER_DATE))
            {
                MessageBox.Show("Nu există fisier de date salvat!", "Restaurare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (FileStream fs = new FileStream(FISIER_DATE, FileMode.Open, FileAccess.Read))
                    listaRezervari = (List<Rezervare>)new BinaryFormatter().Deserialize(fs);
                MessageBox.Show("Date restaurate! Total: " + listaRezervari.Count + " rezervari.",
                    "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la restaurare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void meniuSalvare_Click(object sender, EventArgs e) => SalveazaDate();
        private void meniuRestaurare_Click(object sender, EventArgs e) => RestaureazaDate();

        private void meniuIesire_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Doriti sa salvati datele inainte de iesire?",
                "Iesire", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) SalveazaDate();
            if (dr != DialogResult.Cancel) Application.Exit();
        }

        private void meniuStergeToate_Click(object sender, EventArgs e)
        {
            if (listaRezervari.Count == 0)
            {
                MessageBox.Show("Nu exista rezervari de sters.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Stergi toate cele " + listaRezervari.Count + " rezervari?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                listaRezervari.Clear();
                db.StergeToate();
                MessageBox.Show("Toate rezervarile au fost sterse.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void meniuDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Aplicatie de gestiune rezervari hotel\n\n" +
                "Taste rapide:\n" +
                "  Enter -> Adauga rezervare\n" +
                "  Esc -> Goleste campurile\n" +
                "  F1 -> Lista rezervarilor\n" +
                "  Ctrl+S -> Salvare\n" +
                "  Ctrl+R -> Restaurare\n" +
                "  Ctrl+N -> Adauga rezervare\n" +
                "  Ctrl+L -> Afisare rezervari\n" +
                "  Ctrl+G -> Grafice statistici",
                "Despre aplicatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GoalesteCampuri()
        {
            clientInput.Goleste();
            tbNumarCamera.Clear();
            tbPretCamera.Clear();
            tbIdRezervare.Clear();
            cbTipCamera.Text = "";
            cbEtajCamera.Text = "";
            cbStatusRezervare.Text = "";
            dateTimePickerCheckIn.Value = DateTime.Now;
            dateTimePickerCheckOut.Value = DateTime.Now;
            tbSedereDurata.Clear();
            tbCostTotal.Clear();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}