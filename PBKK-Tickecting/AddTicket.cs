using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

using System.Data.SqlClient;


namespace PBKK_Tickecting
{
    public partial class AddTicket : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;

        int i = 0;
        

        public AddTicket()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gian\OneDrive\Dokumen\Ticket.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                var sql = "INSERT INTO dbo.data(Id, Dari, Ke, Kelas, Tanggal, DepartureTime, ArrivalTime, Price) VALUES(@Id, @From, @To, @Class, @Date, @DepartureTime, @ArrivaTime, @Price )";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    string result1 = comboBox1.GetItemText(this.comboBox1.SelectedItem);
                    string result2 = comboBox2.GetItemText(this.comboBox2.SelectedItem);
                    string result3 = comboBox3.GetItemText(this.comboBox3.SelectedItem);

                    cmd.Parameters.AddWithValue("@Id", int.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@From", result1);
                    cmd.Parameters.AddWithValue("@To", result2);
                    cmd.Parameters.AddWithValue("@Class", result3);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@DepartureTime", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@ArrivaTime", textBox2.Text.ToString());
                    cmd.Parameters.AddWithValue("@Price", textBox4.Text.ToString());

                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void AddTicket_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.ParseExact(textBox1.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.ParseExact(textBox2.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
