using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class HorizontalBarChartValue
    {
        public String Label { get; set; }
        public float Value { get; set; }
        public String Color { get; set; }

        public HorizontalBarChartValue(String _label, float _value, String _color)
        {
            Label = _label;
            Value = _value;
            Color = _color;
        }
    }
}
