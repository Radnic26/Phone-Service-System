using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class Subscription
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Subscription(string _Name)
        {
            this.Name = _Name;
            if (this.Name == "Smart Student")
                this.Price = 9;
            if (this.Name == "Busy BusinessMan")
                this.Price = 13;
            if (this.Name == "Mega Extra Premium")
                this.Price = 28;
        }
    }
}
