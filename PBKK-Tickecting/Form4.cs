using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Syncfusion.Pdf.Grid;

namespace PBKK_Tickecting
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string Dari { get; set; }
        public string Ke { get; set; }
        public string Kelas { get; set; }
        public string Tanggal { get; set; }
        public string DPTime { get; set; }
        public string ARTime { get; set; }
        public string Nama { get; set; }
        public string KWN { get; set; }
        public string Nomor { get; set; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            /* //Create a new PDF document.

             PdfDocument doc = new PdfDocument();

             doc.PageSettings.Orientation = PdfPageOrientation.Landscape;

             //Add a page.

             PdfSection section1 = doc.Sections.Add();
             section1.PageSettings.Size = PdfPageSize.A6;
             PdfPage page = doc.Pages.Add();


             //Create a PdfGrid.

             PdfGrid pdfGrid = new PdfGrid();

             //Create a DataTable.

             DataTable dataTable = new DataTable();

             //Add columns to the DataTable

             dataTable.Columns.Add("Nama");

             dataTable.Columns.Add("Kewarganegaraan");

             //Add rows to the DataTable.

             dataTable.Rows.Add(new object[] { this.Nama, this.KWN });

             dataTable.Rows.Add(new object[] { "", "" });
             dataTable.Rows.Add(new object[] { "Tujuan", "Dari"});
             dataTable.Rows.Add(new object[] { this.Ke, this.Dari });
             dataTable.Rows.Add(new object[] { "", "" });
             dataTable.Rows.Add(new object[] { "Tanggal", "" });
             dataTable.Rows.Add(new object[] { this.Tanggal, "" });

             dataTable.Rows.Add(new object[] { "", "" });
             dataTable.Rows.Add(new object[] { "Waktu Keberangkatan", "Waktu Kedatangan" });
             dataTable.Rows.Add(new object[] { this.DPTime, this.ARTime });



             //Assign data source.

             pdfGrid.DataSource = dataTable;

             //Draw grid to the page of PDF document.

             PdfStringFormat format = new PdfStringFormat();
             format.Alignment = PdfTextAlignment.Center;
             format.LineAlignment = PdfVerticalAlignment.Middle;
             //Specify the style for PdfGridCell
             PdfGridCellStyle cellStyle = new PdfGridCellStyle();
             cellStyle.Borders.Bottom.Color = new PdfColor(Color.Transparent);
             cellStyle.Borders.Top.Color = new PdfColor(Color.Transparent);
             cellStyle.StringFormat = format;
             pdfGrid.Draw(page, new PointF(10, 10));

             for (int i = 0; i < pdfGrid.Rows.Count; i++)
             {
                 for (int j = 0; j < pdfGrid.Rows[i].Cells.Count; j++)
                 {
                     //Apply style
                     pdfGrid.Rows[i].Cells[j].Style = cellStyle;
                 }
             }

             //Save the document.

             doc.Save(this.Nama + ".pdf");

             //close the document

             doc.Close(true);







             this.Close();*/

            //Create a new PDF document
            PdfDocument pdfDocument = new PdfDocument();

            pdfDocument.PageSettings.Orientation = PdfPageOrientation.Landscape;

            //Add a page to the document
            PdfSection section1 = pdfDocument.Sections.Add();
            section1.PageSettings.Size = new Size(600,200);
            PdfPage pdfPage = pdfDocument.Pages.Add();
            //Create a new PdfGrid
            PdfGrid pdfGrid = new PdfGrid();
            //Add columns
            pdfGrid.Columns.Add(4);
            string[] name = new string[3] { "Clay", "John", "Simons" };
            //Add header
            PdfGridRow header = pdfGrid.Rows.Add();
            header.Cells[0].Value = "Nama";
            header.Cells[1].Value = "Kewarganegaraan";
            header.Cells[2].Value = "Maskapai";
            header.Cells[3].Value = "Date";
            //Add style
            header.Style.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12, PdfFontStyle.Bold);
            //Add rows to the table

            
            for (int i = 0; i < 1; i++)
            {
                PdfGridRow row = pdfGrid.Rows.Add();
                row.Cells[0].Value = this.Nama;
                row.Cells[1].Value = this.KWN;
                row.Cells[2].Value = "Air-Asia";
                row.Cells[3].Value = this.Tanggal;
            }

            

            PdfGridRow footer = pdfGrid.Rows.Add();
            footer.Cells[0].Value = "Dari";
            footer.Cells[1].Value = "Ke";
            footer.Cells[2].Value = "Keberangkatan";
            footer.Cells[3].Value = "Kedatangan";

            footer.Style.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 12, PdfFontStyle.Bold);

            for (int i = 0; i < 1; i++)
            {
                PdfGridRow row = pdfGrid.Rows.Add();
                row.Cells[0].Value = this.Dari;
                row.Cells[1].Value = this.Ke;
                row.Cells[2].Value = this.DPTime;
                row.Cells[3].Value = this.ARTime;;
            }

            //Create and customize the string formats
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Middle;
            //Specify the style for PdfGridCell
            PdfGridCellStyle cellStyle = new PdfGridCellStyle();
            cellStyle.Borders.Bottom.Color = new PdfColor(Color.Transparent);
            cellStyle.Borders.Top.Color = new PdfColor(Color.Transparent);
            cellStyle.Borders.Left.Color = new PdfColor(Color.Transparent);
            cellStyle.Borders.Right.Color = new PdfColor(Color.Transparent);
            cellStyle.StringFormat = format;
            for (int i = 0; i < pdfGrid.Rows.Count; i++)
            {
                for (int j = 0; j < pdfGrid.Rows[i].Cells.Count; j++)
                {
                    //Apply style
                    pdfGrid.Rows[i].Cells[j].Style = cellStyle;
                }
            }
            //Draw the PdfGrid
            pdfGrid.Draw(pdfPage, PointF.Empty);
            //Save the document
            pdfDocument.Save(this.Nama + "-AirAsia" + ".pdf");
            //Close the document
            pdfDocument.Close(true);
            this.Close();

        }
    }
}
