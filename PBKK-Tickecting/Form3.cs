using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBKK_Tickecting
{
    public partial class Form3 : Form
    {

        public string Dari { get; set; }
        public string Ke { get; set; }
        public string Kelas { get; set; }
        public string Tanggal { get; set; }
        public string DPTime { get; set; }
        public string ARTime { get; set; }
        public string Harga { get; set; }
        public string Nama { get; set; }
        public string KWN { get; set; }
        public string Nomor { get; set; }

        public Form3()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            LabelRangkuman.Text = "Nama \n";
            LabelRangkuman.Text += "Kewarganegaraan \n";
            LabelRangkuman.Text += "Nomor Pengenal \n\n\n";

            LabelRangkuman.Text += "From \n";
            LabelRangkuman.Text += "To \n";
            LabelRangkuman.Text += "Class \n";
            LabelRangkuman.Text += "Date \n";
            LabelRangkuman.Text += "Departure Time \n";
            LabelRangkuman.Text += "Arrival Time \n";
            LabelRangkuman.Text += "Harga \n";

            label2.Text = ": " + this.Nama + "\n";
            label2.Text += ": " + this.KWN + "\n";
            label2.Text += ": " + this.Nomor + "\n\n\n";

            label2.Text += ": " + this.Dari + "\n";
            label2.Text += ": " + this.Ke + "\n";
            label2.Text += ": " + this.Kelas + "\n";
            label2.Text += ": " + this.Tanggal + "\n";
            label2.Text += ": " + this.DPTime + "\n";
            label2.Text += ": " + this.ARTime + "\n";
            label2.Text += ": " + this.Harga + "\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Nama = this.Nama;
            form4.KWN = this.KWN;
            form4.Nomor = this.Nomor;
            form4.Dari = this.Dari;
            form4.Ke = this.Ke;
            form4.Tanggal = this.Tanggal;
            form4.DPTime = this.DPTime;
            form4.ARTime = this.ARTime;
            form4.Show();
        }
    }
}
