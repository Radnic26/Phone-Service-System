using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Main : Form
    {
        private int last = 0;
        private int pageNo = 1;
        List<Client> clients = new List<Client>();
        List<Subscription> subscriptions = new List<Subscription>();
        List<ExtraOption> extraOptions = new List<ExtraOption>();
        const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = accessdb2.accdb;Persist Security Info=True";
        public Main()
        {
            InitializeComponent();
        }

        private void InfoSButton_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Programmin\\C#\\FinalProject\\FinalProject\\FinalProject\\Subscriptions.txt");
        }

        private void InfoEButton_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\Programmin\\C#\\FinalProject\\FinalProject\\FinalProject\\ExtraOptions.txt");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Subscription subscription = new Subscription(SubscriptionCombo.Text);

            ExtraOption extraOption = new ExtraOption(ExtraCombo.Text);

            Client client = new Client(NameTB.Text, int.Parse(AgeTB.Text), EmailTB.Text, TelephoneTB.Text, CityTB.Text, subscription, extraOption);
            clients.Add(client);

            AddClient(client);

            DisplayInListView();

            NameTB.Clear();
            EmailTB.Clear();
            TelephoneTB.Clear();
            CityTB.Clear();
            AgeTB.Clear();
            SubscriptionCombo.ResetText();
            ExtraCombo.ResetText();
            try
            {
                Process[] processes = Process.GetProcessesByName("Notepad");
                for (int i = 0; i < 100; i++)
                    processes[i].Kill();
            }
            catch (IndexOutOfRangeException exc) { }
        }

         private void exportButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            string selectString = "SELECT * FROM Client";
            OleDbCommand cmd = new OleDbCommand(selectString, connection);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Subscription subscription = new Subscription(reader["Subscription"].ToString());

                ExtraOption extraOption = new ExtraOption(reader["ExtraOption"].ToString());

                Client client = new Client(reader["Name1"].ToString(), int.Parse(reader["Age"].ToString()), 
                    reader["Email"].ToString(), reader["Telephone"].ToString(), reader["City"].ToString(), subscription, extraOption);
                clients.Add(client);

            }
            DisplayInListView();

            reader.Close();
            connection.Close();
        }

        void AddClient(Client client)
        {
            var queryString = "INSERT INTO Client" +
                 "(Name1, Age, Email, City, Telephone, Subscription, ExtraOption)" +
                "VALUES (@Name1, @Age, @Email, @City, @Telephone, @Subscription, @ExtraOption)";

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                var command = new OleDbCommand(queryString, connection);
               
                command.Parameters.Add(new OleDbParameter("@Name1", client.Name));
                command.Parameters.Add(new OleDbParameter("@Age", client.Age));
                command.Parameters.Add(new OleDbParameter("@Email", client.Email));
                command.Parameters.Add(new OleDbParameter("@City", client.City));
                command.Parameters.Add(new OleDbParameter("@Telephone", client.TelNumber));
                command.Parameters.Add(new OleDbParameter("@Subscription", client.Subscription.Name));
                command.Parameters.Add(new OleDbParameter("@ExtraOption", client.ExtraOption.Name));

                command.ExecuteNonQuery();

                var getIdCommand = new OleDbCommand("SELECT @@Identity", connection);
                int id = (int)getIdCommand.ExecuteScalar();
                connection.Close();
                
            }
        }

        private void DisplayInListView()
        {
            listView.Items.Clear();
            if (clients != null)
            {
                foreach (Client client in clients)
                {
                    ListViewItem item = new ListViewItem(client.Name);
                    item.SubItems.Add(client.Age.ToString());
                    item.SubItems.Add(client.Email);
                    item.SubItems.Add(client.City);
                    item.SubItems.Add(client.TelNumber);
                    item.SubItems.Add(client.Subscription.Name);
                    item.SubItems.Add(client.Subscription.Price.ToString());
                    item.SubItems.Add(client.ExtraOption.Name);
                    item.SubItems.Add(client.ExtraOption.Price.ToString());

                    item.Tag = client;

                    listView.Items.Add(item);
                }
            }
            else
            {
                throw new CustomException();
            }
        }
        
        private void NameTB_Validated(object sender, EventArgs e)
        {
            NameErr.Clear();
        }

        private void EmailTB_Validating(object sender, CancelEventArgs e)
        {
            string Email = EmailTB.Text.Trim();
            if (string.IsNullOrEmpty(Email))
            {
                EmailErr.SetError(EmailTB, "You have to enter an email");
                e.Cancel = true;
            }
        }

        private void EmailTB_Validated(object sender, EventArgs e)
        {
            EmailErr.Clear();
        }

        private void AgeTB_Validating(object sender, CancelEventArgs e)
        {
            int age = int.Parse(AgeTB.Text);
            if (age < 5 || age > 120 || age == 0)
            {
                AgeErr.SetError(AgeTB, "Age must be bigger than 4"); 
                e.Cancel = true;
            }
        }

        private void AgeTB_Validated(object sender, EventArgs e)
        {
            AgeErr.Clear();
        }

        private void CityTB_Validating(object sender, CancelEventArgs e)
        {
            string city = CityTB.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                CityErr.SetError(CityTB, "You have to enter a city");
                e.Cancel = true;
            }
        }

        private void CityTB_Validated(object sender, EventArgs e)
        {
            CityErr.Clear();
        }

        private void TelephoneTB_Validating(object sender, CancelEventArgs e)
        {
            string tel = TelephoneTB.Text.Trim();
            if (string.IsNullOrEmpty(tel) || TelephoneTB.TextLength != 10)
            {
                TelephoneErr.SetError(TelephoneTB, "The telephone number must have 10 characters.");
                e.Cancel = true;
            }
        }

        private void TelephoneTB_Validated(object sender, EventArgs e)
        {
            TelephoneErr.Clear();
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems[0] != null)
            {
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clients.Remove(listView.SelectedItems[0].Tag as Client);
                    DisplayInListView();
                }
            }
        }
    
        private void serializeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Export in binary file";
            saveFile.Filter = "All dat files (*.dat)|*.dat";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveFile.FileName, FileMode.Create);
                formatter.Serialize(file, clients);
                file.Close();
            }
        }

        private void deserializeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           BinaryFormatter formatter = new BinaryFormatter();
           OpenFileDialog openFile = new OpenFileDialog();
           openFile.Title = "Select binary file to load data";
           openFile.Filter = "txt files (*.txt)|*.txt|DAT files (*.dat)|*.dat|All files (*.*)|*.*";
           openFile.FilterIndex = 2;

           if (openFile.ShowDialog() == DialogResult.OK)
               {
                  FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open);

                  clients = (List<Client>)formatter.Deserialize(fileStream);
                  fileStream.Close();

                  DisplayInListView();
              }
            
        }

        private void textToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Export";
            saveFile.Filter = "All text files (*.txt)|*.txt";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);
                writer.Write("CLIENT LIST\n\n");
                foreach (Client c in clients)
                {
                    writer.Write("Name: " + c.Name + "\nAge: " + c.Age + "\nEmail: " + c.Email + "\nCity: " + c.City + "\nTelephone: " + c.TelNumber);
                    writer.Write("\nSubscription: " + c.Subscription.Name + "\nPrice: " + c.Subscription.Price + "\nExtraOption: " + c.ExtraOption.Name + "\nPrice: " + c.ExtraOption.Price);
                    writer.Write("\n\n\n");
                }
                writer.Close();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                Client selected = listView.SelectedItems[0].Tag as Client;

                Edit editForm = new Edit(selected);
                editForm.ShowDialog();

                DisplayInListView();
            }
        }

        private void NameTB_Validating_1(object sender, CancelEventArgs e)
        {
            string Name = NameTB.Text.Trim();
            if (string.IsNullOrEmpty(Name))
            {
                NameErr.SetError(NameTB, "You have to enter a name");
                e.Cancel = true;
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode.ToString() == "A")
            {
                AddButton_Click(sender, e);
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                Client selected = listView.SelectedItems[0].Tag as Client;

                Edit editForm = new Edit(selected);
                editForm.ShowDialog();

                DisplayInListView();
            }
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Calibri", 20);
            Font fontTitle = new Font("Calibri", 30);
            Brush brush = new SolidBrush(Color.Black);

            PageSettings pageSettings = printDocument1.DefaultPageSettings;

            var TotalH = pageSettings.PaperSize.Height;
            var totalW = pageSettings.PaperSize.Width;

            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;

            var totalWritableW = totalW - (2 * marginLeft);

            var cellW = totalWritableW / 2;
            var cellH = 35;

            Pen pen = new Pen(brush);

            var xPos = 100;
            var yPos = 100;

            graphics.DrawString("List of Clients", fontTitle, brush, xPos, yPos - 70);
            graphics.DrawString("Page " + (pageNo), font, brush, xPos + 662, yPos + 960);
            pageNo++;
            yPos += 50;
            
            int i = last;

            for ( ; i < clients.Count; i++)
            {
                graphics.DrawString("Client " + (i + 1), font, brush, xPos, yPos);
                yPos += cellH;
                
                graphics.DrawRectangle(pen, xPos, yPos, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos, cellW , cellH);

                graphics.DrawRectangle(pen, xPos, yPos + cellH, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos + cellH, cellW, cellH);

                graphics.DrawRectangle(pen, xPos, yPos + 2*cellH, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos + 2*cellH, cellW, cellH);

                graphics.DrawRectangle(pen, xPos, yPos + 3*cellH, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos + 3*cellH, cellW, cellH);

                graphics.DrawRectangle(pen, xPos, yPos + 4*cellH, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos + 4*cellH, cellW, cellH);

                graphics.DrawRectangle(pen, xPos, yPos + 5*cellH, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos + 5*cellH, cellW, cellH);

                graphics.DrawRectangle(pen, xPos, yPos + 6*cellH, cellW - 150, cellH);
                graphics.DrawRectangle(pen, xPos + cellW - 150, yPos + 6*cellH, cellW, cellH);
                

                graphics.DrawString("Name", font, brush, xPos, yPos);
                graphics.DrawString(clients[i].Name, font, brush, xPos + cellW - 150, yPos);

                graphics.DrawString("Age", font, brush, xPos, yPos + cellH);
                graphics.DrawString(clients[i].Age.ToString(), font, brush, xPos + cellW - 150, yPos + cellH);

                graphics.DrawString("Email", font, brush, xPos, yPos + 2*cellH);
                graphics.DrawString(clients[i].Email, font, brush, xPos + cellW - 150, yPos + 2*cellH);

                graphics.DrawString("City", font, brush, xPos, yPos + 3*cellH);
                graphics.DrawString(clients[i].City, font, brush, xPos + cellW - 150, yPos + 3*cellH);

                graphics.DrawString("Telephone", font, brush, xPos, yPos + 4*cellH);
                graphics.DrawString(clients[i].TelNumber, font, brush, xPos + cellW - 150, yPos + 4*cellH);

                graphics.DrawString("Subscription", font, brush, xPos, yPos + 5*cellH);
                graphics.DrawString(clients[i].Subscription.Name, font, brush, xPos + cellW - 150, yPos + 5*cellH);

                graphics.DrawString("ExtraOption", font, brush, xPos, yPos + 6*cellH);
                graphics.DrawString(clients[i].ExtraOption.Name, font, brush, xPos + cellW - 150, yPos + 6*cellH);

                yPos += 8*cellH;

                if (yPos + cellH >= TotalH)
                {
                    e.HasMorePages = true;
                    last = i + 1;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }

        private void subscriptionChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.ShowDialog();
        }

        private void extraOptionChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart2 chart = new Chart2();
            chart.ShowDialog();
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataBaseForm dbform = new DataBaseForm();
            dbform.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
    }
}
