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
    public partial class Form2 : Form
    {
        

        public string Dari { get; set; }
        public string Ke { get; set; }
        public string Kelas { get; set; }
        public string Tanggal { get; set; }
        public string DPTime { get; set; }
        public string ARTime { get; set; }
        public string Harga { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LabelRangkuman.Text = "From \n";
            LabelRangkuman.Text += "To \n";
            LabelRangkuman.Text += "Class \n";
            LabelRangkuman.Text += "Date \n";
            LabelRangkuman.Text += "Departure Time \n";
            LabelRangkuman.Text += "Arrival Time \n";
            LabelRangkuman.Text += "Harga \n";

            label6.Text = ": " + this.Dari + "\n";
            label6.Text += ": " + this.Ke + "\n";
            label6.Text += ": " + this.Kelas + "\n";
            label6.Text += ": " + this.Tanggal + "\n";
            label6.Text += ": " + this.DPTime + "\n";
            label6.Text += ": " + this.ARTime + "\n";
            label6.Text += ": " + this.Harga + "\n";

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Nama = textBoxNama.Text;
            form3.Nomor = textBoxNo.Text;
            form3.KWN = textBoxKwn.Text;
            form3.Dari = this.Dari;
            form3.Ke = this.Ke;
            form3.Kelas = this.Kelas;
            form3.Tanggal = this.Tanggal;
            form3.DPTime = this.DPTime;
            form3.ARTime = this.ARTime;
            form3.Harga = this.Harga;

            form3.Show();
            this.Close();
        }



    }
}
