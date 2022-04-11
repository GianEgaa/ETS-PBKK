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
    public partial class Form1 : Form
    {
        public static string setFrom = "";
        public static string setTo = "";
        public static string setDate = "";
        public static string setClass = "";
        public static byte setPassgr = 0;

        

        /*public class Cari
        {
            public Cari() { }
            public string Dari { get; set; }
            public string Ke { get; set; }
            public string Kelas { get; set; }
            public string Tanggal { get; set; }
            public string DpTime { get; set; }
            public string ArTime { get; set; }
        }*/


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelDate.Text += " ";
            labelDate.Text += DateTime.Now.ToLongTimeString();
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains(", Dewasa") == false)
            {
                textBox1.Text += ", Dewasa";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Daftar_Pencarian FormDP = new Daftar_Pencarian();

            /*var cari = new Cari();*/

            FormDP.Dari = comboBox1.GetItemText(this.comboBox1.SelectedItem);
            FormDP.Ke = comboBox2.GetItemText(this.comboBox2.SelectedItem);
            FormDP.Kelas = comboBox3.GetItemText(this.comboBox3.SelectedItem);
            FormDP.Tanggal = dateTimePicker1.Value.ToShortDateString();

            /*Global.Dari = comboBox1.GetItemText(this.comboBox1.SelectedItem);
            Global.Ke = comboBox2.GetItemText(this.comboBox2.SelectedItem);
            Global.Kelas = comboBox3.GetItemText(this.comboBox3.SelectedItem);
            Global.Tanggal = dateTimePicker1.Value.ToShortDateString();*/


            /*Console.WriteLine(comboBox1.GetItemText(this.comboBox1.SelectedItem));
            MessageBox.Show(Dari);*/



            FormDP.Show();



            this.Hide();


            /*Form2 f2 = new Form2();
            f2.Show();

            setFrom = comboBox1.GetItemText(this.comboBox1.SelectedItem);
            setTo = comboBox2.GetItemText(this.comboBox2.SelectedItem);
            setDate = dateTimePicker1.Value.ToShortDateString();
            setClass = comboBox2.GetItemText(this.comboBox2.SelectedItem);

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gian\OneDrive\Dokumen\Ticket.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();
                var sql = "SELECT * FROM dbo.data WHERE Dari=@setFrom and Ke=@setTo and Tanggal=@setDate";
                using (var cmd = new SqlCommand(sql, connection))
                {
                    System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
                    cmd.Parameters.AddWithValue("@setTo", setTo);
                    cmd.Parameters.AddWithValue("@setFrom", setFrom);
                    cmd.Parameters.AddWithValue("@setDate", setDate);

                    cmd.ExecuteNonQuery();
                }
            }

            
            this.Hide();*/

        }


    }
    
}
