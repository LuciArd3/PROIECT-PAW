using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROIECT_PAW
{
    public partial class FormGrafice : Form
    {
        private readonly List<Rezervare> listaRezervari;

        public FormGrafice(List<Rezervare> lista)
        {
            InitializeComponent();
            listaRezervari = lista;
            IncarcaGrafice();
        }

        private void IncarcaGrafice()
        {
            if (listaRezervari == null || listaRezervari.Count == 0)
            {
                MessageBox.Show("Nu există rezervări de afișat!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DeseneazaPieRezervariTip();
            DeseneazaBarVenituri();
            DeseneazaBarStatus();
        }

        private void DeseneazaPieRezervariTip()
        {
            var grupate = listaRezervari
                .GroupBy(r => r.Camera.Tip)
                .Select(g => new { Tip = g.Key, Count = g.Count() })
                .ToList();

            chartTipuri.Series.Clear();
            chartTipuri.Titles.Clear();
            chartTipuri.Legends.Clear();

            chartTipuri.Titles.Add(new Title(
                "Rezervari pe tipul camerei:",
                Docking.Top,
                new Font("Segoe UI", 12, FontStyle.Bold),
                Color.DarkGoldenrod));

            var series = new Series("TipCamera")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "{0} ({P0})"
            };

            Color[] culori = { Color.SteelBlue, Color.DarkGoldenrod, Color.SeaGreen };
            int i = 0;
            foreach (var g in grupate)
            {
                var pt = series.Points.Add(g.Count);
                pt.LegendText = g.Tip;
                pt.Label = $"{g.Tip}\n{g.Count} rez.";
                pt.Color = culori[i % culori.Length];
                i++;
            }

            chartTipuri.Series.Add(series);

            var legenda = new Legend("Legenda") { Docking = Docking.Bottom };
            chartTipuri.Legends.Add(legenda);
            series.Legend = "Legenda";
            series.IsVisibleInLegend = true;
        }

        private void DeseneazaBarVenituri()
        {
            var grupate = listaRezervari
                .GroupBy(r => r.Camera.Tip)
                .Select(g => new { Tip = g.Key, Venit = g.Sum(r => r.costTotal()) })
                .OrderByDescending(g => g.Venit)
                .ToList();

            chartVenituri.Series.Clear();
            chartVenituri.Titles.Clear();
            chartVenituri.ChartAreas[0].AxisX.Title = "Tip cameră";
            chartVenituri.ChartAreas[0].AxisY.Title = "Venit total (RON)";
            chartVenituri.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chartVenituri.ChartAreas[0].BackColor = Color.FromArgb(30, 30, 30);
            chartVenituri.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DarkGoldenrod;
            chartVenituri.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DarkGoldenrod;
            chartVenituri.ChartAreas[0].AxisX.TitleForeColor = Color.DarkGoldenrod;
            chartVenituri.ChartAreas[0].AxisY.TitleForeColor = Color.DarkGoldenrod;

            chartVenituri.Titles.Add(new Title(
                "Venit total per tip cameră",
                Docking.Top,
                new Font("Segoe UI", 12, FontStyle.Bold),
                Color.DarkGoldenrod));

            var series = new Series("Venituri")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                Color = Color.DarkGoldenrod
            };

            foreach (var g in grupate)
                series.Points.AddXY(g.Tip, g.Venit);

            chartVenituri.Series.Add(series);
        }

        private void DeseneazaBarStatus()
        {
            var grupate = listaRezervari
                .GroupBy(r => r.Status)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToList();

            chartStatus.Series.Clear();
            chartStatus.Titles.Clear();
            chartStatus.ChartAreas[0].AxisX.Title = "Status";
            chartStatus.ChartAreas[0].AxisY.Title = "Număr rezervări";
            chartStatus.ChartAreas[0].BackColor = Color.FromArgb(30, 30, 30);
            chartStatus.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DarkGoldenrod;
            chartStatus.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DarkGoldenrod;
            chartStatus.ChartAreas[0].AxisX.TitleForeColor = Color.DarkGoldenrod;
            chartStatus.ChartAreas[0].AxisY.TitleForeColor = Color.DarkGoldenrod;
            chartStatus.ChartAreas[0].AxisY.Interval = 1;

            chartStatus.Titles.Add(new Title(
                "Rezervări pe status",
                Docking.Top,
                new Font("Segoe UI", 12, FontStyle.Bold),
                Color.DarkGoldenrod));

            Color[] culori = { Color.SeaGreen, Color.SteelBlue, Color.IndianRed };
            var series = new Series("Status") { ChartType = SeriesChartType.Bar };

            int i = 0;
            foreach (var g in grupate)
            {
                var pt = series.Points.AddXY(g.Status, g.Count);
                series.Points[pt].Color = culori[i % culori.Length];
                series.Points[pt].Label = g.Count.ToString();
                i++;
            }

            series.IsValueShownAsLabel = true;
            chartStatus.Series.Add(series);
        }

        private void btnReincarca_Click(object sender, EventArgs e) => IncarcaGrafice();

        private void chartTipuri_Click(object sender, EventArgs e)
        {

        }
    }
}
