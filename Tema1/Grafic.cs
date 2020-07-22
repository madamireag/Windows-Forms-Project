using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema1.Models;

namespace Tema1
{
    public partial class Grafic : Form
    {
        public Grafic(List<Pariu> lista)
        {

            InitializeComponent();
            List<String> listaPrelucrata = new List<String>();
            foreach (Pariu each in lista)
            {
                listaPrelucrata.Add(each.CastigatorSelectat + ";" + each.Suma);
            }

            ChartLibrary.ChartControl barChart = new ChartLibrary.ChartControl(listaPrelucrata);

            barChart.Location = new System.Drawing.Point(12, 12);
            barChart.Name = "barChart1";
            barChart.Size = new System.Drawing.Size(776, 426);
            barChart.TabIndex = 0;

            this.Controls.Add(barChart);
        }

        private void Grafic_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
