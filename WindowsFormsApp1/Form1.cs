using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strfilename;
            xlWorksheet = new Microsoft.Office.Interop.Excel.Worksheet();
            openFD.Filter = "exel office |*.xls; *xlsx";
            openFD.ShowDialog();
            strfilename = openFD.FileName;
            if (strfilename != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = new Microsoft.Office.Interop.Excel.Workbook();
                xlWorkbook = workbook;
                xlWorksheet = new Microsoft.Office.Interop.Excel.Worksheet();

                xlWorkbook = xlApp.Workbooks.Open(strfilename);
                xlWorksheet = xlWorkbook.Worksheets["students_list.xlsx"];
                xlRange = xlWorksheet.UsedRange;
                int i = 0;
                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    dataGridView1.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text,
                    xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text.xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text, xlRange.Cells[xlRow, 15].Text, xlRange.Cells[xlRow, 16].Text,
                    xlRange.Cells[xlRow, 17].Text, xlRange.Cells[xlRow, 18].Text, xlRange.Cells[xlRow, 19].Text, xlRange.Cells[xlRow, 20].Text, xlRange.Cells[xlRow, 21].Text);

                }
                xlWorkbook.Close();
                xlApp.Quit();
            }
           
       

        }
    }
}
