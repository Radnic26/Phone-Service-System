using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public string City { get; set; }

        public Subscription Subscription;

        public ExtraOption ExtraOption;

        public Client(string _Name, int _Age, string _Email, string _TelNumber, string _City, Subscription _Subscription, ExtraOption _ExtraOption)
        {
            this.Name = _Name;
            this.Age = _Age;
            this.Email = _Email;
            this.TelNumber = _TelNumber;
            this.City = _City;
            this.Subscription = _Subscription;
            this.ExtraOption = _ExtraOption;
        }
    }
}
