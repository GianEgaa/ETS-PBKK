using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PBKK_Tickecting
{
    public partial class Daftar_Pencarian : Form
    {

        public string Dari { get; set; }
        public string Ke { get; set; }
        public string Kelas { get; set; }
        public string Tanggal { get; set; }
        public string Harga { get; set; }



        public Daftar_Pencarian()
        {
            InitializeComponent();

            
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gian\OneDrive\Dokumen\Ticket.mdf;Integrated Security=True;Connect Timeout=30");

        private void Daftar_Pencarian_Load(object sender, EventArgs e)
        {



            Con.Open();


            listView1.GridLines = false;
            listView1.View = View.Details;
            listView1.Select();

            /*listView1.Columns.Add("From",150);
            listView1.Columns.Add("To", 150);
            listView1.Columns.Add("Class", 150);
            listView1.Columns.Add("Date", 150);*/


            string query = "SELECT Dari, Ke, Kelas, Tanggal, DepartureTime, ArrivalTime, Price FROM dbo.data WHERE Dari=@From AND Ke=@To AND Kelas=@Class And Tanggal=@Date";
            // string query = "SELECT Dari, Ke, Kelas, Tanggal FROM dbo.data";

            SqlCommand cmd = new SqlCommand(query, Con);

            cmd.Parameters.AddWithValue("@From", this.Dari);
            cmd.Parameters.AddWithValue("@To", this.Ke);
            cmd.Parameters.AddWithValue("@Class", this.Kelas);
            cmd.Parameters.AddWithValue("@Date", this.Tanggal);


            MessageBox.Show(this.Dari + " " + this.Ke + " " + this.Kelas + " " + this.Tanggal);


            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lv.SubItems.Add(dr[5].ToString());
                lv.SubItems.Add(dr[6].ToString());
                listView1.Items.Add(lv);
            }
            
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string DariResult = listView1.SelectedItems[0].SubItems[0].Text;
            string KeResult= listView1.SelectedItems[0].SubItems[1].Text;
            string KelasResult = listView1.SelectedItems[0].SubItems[2].Text;
            string TanggalResult = listView1.SelectedItems[0].SubItems[3].Text;
            string DTResult = listView1.SelectedItems[0].SubItems[4].Text;
            string ARResult = listView1.SelectedItems[0].SubItems[5].Text;
            string Harga = listView1.SelectedItems[0].SubItems[6].Text;


            MessageBox.Show(DariResult + " " + KeResult + " " + KelasResult + " " + TanggalResult + " " + DTResult + " " + ARResult);

            Form2 form2 = new Form2();
            form2.Dari = DariResult;
            form2.Ke = KeResult;
            form2.Kelas = KelasResult;
            form2.Tanggal = TanggalResult;
            form2.DPTime = DTResult;
            form2.ARTime = ARResult;
            form2.Harga = Harga;

            form2.Show();
            this.Close();

        }

    }
}
