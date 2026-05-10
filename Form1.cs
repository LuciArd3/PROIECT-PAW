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

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  GoalesteCampuri();
            if (e.KeyCode == Keys.F1)      DeschideForm2();
            if (e.KeyCode == Keys.Enter)   btnAdaugaRezervare_Click(sender, e);
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
            if (tbNumeClient.Text == "")
                errorProvider1.SetError(tbNumeClient, "Introduceti numele!");
            else if (cbSex.Text == "")
                errorProvider1.SetError(cbSex, "Introduceti sexul!");
            else if (tbTelefon.Text == "")
                errorProvider1.SetError(tbTelefon, "Introduceti nr. de telefon!");
            else if (tbTelefon.Text.Length < 10)
                errorProvider1.SetError(tbTelefon, "Numarul de telefon trebuie sa aiba exact 10 cifre!");
            else if (tbNumarCamera.Text == "")
                errorProvider1.SetError(tbNumarCamera, "Introduceti numarul camerei!");
            else if (cbTipCamera.Text == "")
                errorProvider1.SetError(cbTipCamera, "Introduceti tipul camerei!");
            else if (tbPretCamera.Text == "")
                errorProvider1.SetError(tbPretCamera, "Introduceti pretul!");
            else if (cbEtajCamera.Text == "")
                errorProvider1.SetError(cbEtajCamera, "Introduceti etajul!");
            else if (tbIdRezervare.Text == "")
                errorProvider1.SetError(tbIdRezervare, "Introduceti ID-ul rezervarii!");
            else if (cbStatusRezervare.Text == "")
                errorProvider1.SetError(cbStatusRezervare, "Introduceti statusul!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string   nume       = tbNumeClient.Text;
                    char     sex        = Convert.ToChar(cbSex.Text);
                    string   telefon    = tbTelefon.Text;
                    Client   client     = new Client(nume, sex, telefon);

                    int      numar      = Convert.ToInt32(tbNumarCamera.Text);
                    string   tip        = cbTipCamera.Text;
                    float    pretNoapte = (float)Convert.ToDouble(tbPretCamera.Text);
                    int      etaj       = Convert.ToInt32(cbEtajCamera.Text);
                    Camera   camera     = new Camera(numar, tip, pretNoapte, etaj);

                    int      id         = Convert.ToInt32(tbIdRezervare.Text);
                    DateTime checkIn    = dateTimePickerCheckIn.Value;
                    DateTime checkOut   = dateTimePickerCheckOut.Value;
                    string   status     = cbStatusRezervare.Text;

                    if (checkOut <= checkIn)
                        throw new Exception("Data de check-out trebuie sa fie dupa data de check-in!");

                    Rezervare rezervare = new Rezervare(id, client, camera, checkIn, checkOut, status);
                    tbSedereDurata.Text = rezervare.noptiSedere().ToString();
                    tbCostTotal.Text    = rezervare.costTotal().ToString("F2");

                    MessageBox.Show(rezervare.ToString(), "Rezervare adăugată",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaRezervari.Add(rezervare);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { GoalesteCampuri(); }
            }
        }


        private void afisareRezervari_Click(object sender, EventArgs e) => DeschideForm2();

        private void DeschideForm2()
        {
            new Form2(listaRezervari).Show();
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
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                        .Serialize(fs, listaRezervari);
                MessageBox.Show("Date salvate! (" + listaRezervari.Count + " rezervări)",
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
                MessageBox.Show("Nu există fișier de date salvat!", "Restaurare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (FileStream fs = new FileStream(FISIER_DATE, FileMode.Open, FileAccess.Read))
                    listaRezervari = (List<Rezervare>)
                        new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
                            .Deserialize(fs);
                MessageBox.Show("Date restaurate! Total: " + listaRezervari.Count + " rezervări.",
                    "Restaurare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la restaurare: " + ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void meniuSalvare_Click(object sender, EventArgs e)    => SalveazaDate();
        private void meniuRestaurare_Click(object sender, EventArgs e) => RestaureazaDate();

        private void meniuIesire_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Doriți să salvați datele înainte de ieșire?",
                "Ieșire", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)    SalveazaDate();
            if (dr != DialogResult.Cancel) Application.Exit();
        }

        private void meniuStergeToate_Click(object sender, EventArgs e)
        {
            if (listaRezervari.Count == 0)
            { MessageBox.Show("Nu există rezervări de șters.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (MessageBox.Show("Ștergi toate cele " + listaRezervari.Count + " rezervări?",
                    "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                listaRezervari.Clear();
                MessageBox.Show("Toate rezervările au fost șterse.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void meniuDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Aplicație de gestiune rezervări hotel\n\n" +
                "Taste rapide:\n" +
                "  Enter    – Adaugă rezervare\n" +
                "  Escape   – Golește câmpurile\n" +
                "  F1       – Lista rezervărilor\n" +
                "  Ctrl+S   – Salvare\n" +
                "  Ctrl+R   – Restaurare\n" +
                "  Ctrl+N   – Adaugă rezervare\n" +
                "  Ctrl+L   – Afișare rezervări\n" +
                "  Ctrl+G   – Grafice statistici",
                "Despre aplicație", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GoalesteCampuri()
        {
            tbNumeClient.Clear();
            tbTelefon.Clear();
            tbNumarCamera.Clear();
            tbPretCamera.Clear();
            tbIdRezervare.Clear();
            cbSex.Text             = "";
            cbTipCamera.Text       = "";
            cbEtajCamera.Text      = "";
            cbStatusRezervare.Text = "";
            dateTimePickerCheckIn.Value  = DateTime.Now;
            dateTimePickerCheckOut.Value = DateTime.Now;
            tbSedereDurata.Clear();
            tbCostTotal.Clear();
        }
    }
}
