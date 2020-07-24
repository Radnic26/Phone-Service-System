using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Chart : Form
    {
        const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = accessdb2.accdb;Persist Security Info=True";
        private HorizontalBarChartValue[] _data;
        public HorizontalBarChartValue[] Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        List<Client> clients = new List<Client>();
        private int ctrSS = 0;
        private int ctrBB = 0;
        private int ctrMEP = 0;
       
        private void exportData()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string SelectString = "SELECT * FROM Client";
            OleDbCommand cmd = new OleDbCommand(SelectString, connection);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Subscription subscription = new Subscription(reader["Subscription"].ToString());

                ExtraOption extraOption = new ExtraOption(reader["ExtraOption"].ToString());

                Client client = new Client(reader["Name1"].ToString(), int.Parse(reader["Age"].ToString()),
                    reader["Email"].ToString(), reader["Telephone"].ToString(), reader["City"].ToString(), subscription, extraOption);
                clients.Add(client);
            }
            reader.Close();
            connection.Close();

            foreach (Client c in clients)
            {
                if (c.Subscription.Name == "Smart Student")
                    this.ctrSS++;
                else if (c.Subscription.Name == "Busy BusinessMan")
                    this.ctrBB++;
                else if (c.Subscription.Name == "Mega Extra Premium")
                    this.ctrMEP++;
            }
        }
        public Chart()
        {
            InitializeComponent();
            ResizeRedraw = true;
            exportData();
            Data = new[]
            {
                new HorizontalBarChartValue("Smart Student", this.ctrSS, "blue"),
                new HorizontalBarChartValue("Busy BusinessMan", this.ctrBB, "red"),
                new HorizontalBarChartValue("Mega Extra Premium", this.ctrMEP, "green"),
            };
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;
            Font fontTitle = new Font("Calibri", 28);

            var scaleFactor = rectangle.Height / Data.Max(x => x.Value);
            
            var barWidth = (rectangle.Width - 200) / Data.Length;

            var maxBarHeight = rectangle.Height * 0.9;

            graphics.DrawString("Subscription Chart", fontTitle, new SolidBrush(Color.Black), 260, 10); 

            for (int i = 0; i < Data.Length; i++)
            {
                var eachBarHeight = Data[i].Value * scaleFactor;

                graphics.FillRectangle(new SolidBrush(Color.FromName(Data[i].Color)),
                  25, 90 + i*(barWidth - 95), (float)(eachBarHeight * 1.5), (float)(barWidth * 0.2));
            }

            var xPos = 25;
            var yPos = 400;

            for (int i = 0; i < Data.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.FromName(Data[i].Color)), xPos, yPos, 35, 35);

                graphics.DrawString(Data[i].Label + " : " + Data[i].Value, Font,
                    new SolidBrush(Color.FromName(Data[i].Color)), xPos + 35, yPos + 15);

                xPos += 210;
            }
        }
    }
}
