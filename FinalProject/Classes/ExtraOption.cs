using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class ExtraOption
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ExtraOption(string _Name)
        {
            this.Name = _Name;
            if (this.Name == "Internet pe Mobil")
                this.Price = 3.96;
            if (this.Name == "Muzica si Video")
                this.Price = 7.96;
            if (this.Name == "Minute si SMS Nationale")
                this.Price = 5.98;
            if (this.Name == "-")
                this.Price = 0;
        }
    }
}
