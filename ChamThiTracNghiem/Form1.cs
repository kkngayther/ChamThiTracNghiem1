using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamThiTracNghiem
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dt.Columns.Add("Question", typeof(string));
            dt.Columns.Add("Answer", typeof(string));
            dt.Columns.Add("Result", typeof(string));
            createTable();
            dataGridView1.Columns[2].ReadOnly = true;
            txtDung.ReadOnly = true;
            txtSai.ReadOnly = true;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string duongDan = txtDuongDan.Text + txtTenFile.Text;
            FileStream fs = new FileStream(duongDan, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            txtBangGhi.Text = sr.ReadToEnd();

            sr.Close();
            fs.Close();
        }
        private void createTable()
        {
            for (int i = 0; i < 50; i++)
            {
                String temp = "Question" + (i + 1).ToString();
                dt.Rows.Add(temp, "", "");
            }
            dataGridView1.DataSource = dt;
        }
        private void btnDapAn_Click(object sender, EventArgs e)
        {
            string[] dong = File.ReadAllLines(@"C:\\UIT\\C#\\ChamThiTracNghiem\\DapAn_01.txt");
            int correct = 0;
            int incorrect = 0;
            for (int i = 0; i < 50; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = dong[i];
                dataGridView1.Rows[i].Cells[1].Value = "A";
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == dong[i])
                    correct++;
                else
                    incorrect++;
            }
            txtDung.Text = correct.ToString();
            txtSai.Text = incorrect.ToString();
        }
    }
}
