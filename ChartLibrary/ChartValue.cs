using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLibrary
{
   public class ChartValue
    {
        public string Label { get; set; }
        public float Value { get; set; }
        public string Color { get; set; }

        public ChartValue(string label, float value, string color)
        {
            Label = label;
            Value = value;
            Color = color;
        }
    }
}
