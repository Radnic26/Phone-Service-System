using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Edit : Form
    {
        Client _instance;    
        public Edit(Client client)
        {
            InitializeComponent();

            _instance = client;
            NameEditTB.Text = client.Name;
            AgeEditTB.Text = client.Age.ToString();
            EmailEditTB.Text = client.Email;
            CityEditTB.Text = client.City;
            TelephoneEditTB.Text = client.TelNumber;
            SubscriptionEditCombo.Text = client.Subscription.Name;
            ExtraEditCombo.Text = client.ExtraOption.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _instance.Name = NameEditTB.Text;
            _instance.Age = int.Parse(AgeEditTB.Text);
            _instance.Email = EmailEditTB.Text;
            _instance.City = CityEditTB.Text;
            _instance.TelNumber = TelephoneEditTB.Text;
            _instance.Subscription = new Subscription(SubscriptionEditCombo.Text);
            _instance.ExtraOption = new ExtraOption(ExtraEditCombo.Text);
            this.Close();
        }
    }
}
