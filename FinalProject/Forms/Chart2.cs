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
    public partial class Chart2 : Form
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
        private int ctrIM = 0;
        private int ctrMV = 0;
        private int ctrMS = 0;
        private int ctrN = 0;
       
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
                if (c.ExtraOption.Name == "Internet pe Mobil")
                    this.ctrIM++;
                else if (c.ExtraOption.Name == "Muzica si Video")
                    this.ctrMV++;
                else if (c.ExtraOption.Name == "Minute si SMS Nationale")
                    this.ctrMS++;
                else
                    this.ctrN++;
            }
        }

        public Chart2()
        {
            InitializeComponent();
            ResizeRedraw = true;
            exportData();
            Data = new[]
            {
                new HorizontalBarChartValue("Internet pe Mobil", this.ctrIM, "blue"),
                new HorizontalBarChartValue("Muzica si Video", this.ctrMV, "red"),
                new HorizontalBarChartValue("Minute & SMS Nationale", this.ctrMS, "green"),
                new HorizontalBarChartValue("No ExtraOption", this.ctrN, "purple"),
            };
        }

        private void Chart2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Chart2_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;
            Font fontTitle = new Font("Calibri", 28);

            var scaleFactor = rectangle.Height / Data.Max(x => x.Value);

            var barWidth = (rectangle.Width - 200) / Data.Length;

            var maxBarHeight = rectangle.Height * 0.9;

            graphics.DrawString("ExtraOption Chart", fontTitle, new SolidBrush(Color.Black), 260, 10);

            for (int i = 0; i < Data.Length; i++)
            {
                var eachBarHeight = Data[i].Value * scaleFactor;

                graphics.FillRectangle(new SolidBrush(Color.FromName(Data[i].Color)),
                  25, 120 + i * (barWidth - 95), (float)(eachBarHeight * 1.5), (float)(barWidth * 0.2));
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
