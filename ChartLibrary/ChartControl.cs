using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLibrary
{
    public partial class ChartControl : UserControl
    {
        public ChartValue[] Data { get; set; }
        List<String> listaLocala = new List<string>();

        public ChartControl(List<string> listaPrelucrata)
        {
            InitializeComponent();
            ResizeRedraw = true;
            listaLocala = listaPrelucrata;

            
        }

        private void ChartControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;

            float max = 0;
            foreach (String s in listaLocala)
            {
                string[] tokens = s.Split(';');
                float current = float.Parse(tokens[1]);

                if (current > max)
                {
                    max = current;
                }
            }
            var scaleFactor = rectangle.Height / max;
            var barWidth = (rectangle.Width - 300) / listaLocala.Count;
            var maxBarHeight = rectangle.Height * 0.9;
            for (int i = 0; i < listaLocala.Count; i++)
            {
                string[] tokens = listaLocala.ElementAt(i).Split(';');

                var eachBarHeight = float.Parse(tokens[1]) * scaleFactor;

                graphics.FillRectangle(new SolidBrush(Color.RoyalBlue),
                    i * barWidth, rectangle.Height - eachBarHeight, barWidth * 0.95f, eachBarHeight);

            }

            var xCoord = rectangle.Width - 300;
            var yCoord = 0;
            for (int i = 0; i < listaLocala.Count; i++)
            {
                string[] tokens = listaLocala.ElementAt(i).Split(';');

                graphics.FillRectangle(new SolidBrush(Color.RoyalBlue), xCoord, yCoord, 35, 35);

                graphics.DrawString(tokens[0] + ": " + tokens[1], new Font("Consolas", 10),
                    new SolidBrush(Color.RoyalBlue), xCoord + 35, yCoord + 20);

                yCoord += 35;
            }
        }
    }
}
