using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace FinalProject
{
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
            loadgrid();
        }

        private void loadgrid()
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            connection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Select * from [Client]";
            cmd.Connection = connection;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void DataBaseForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;
            Font fontTitle = new Font("Calibri", 28);

            graphics.DrawString("DataBase Data", fontTitle, new SolidBrush(Color.Black), 320, 10);
        }
    }
}
