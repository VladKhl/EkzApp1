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

namespace EkzApp
{
    public partial class Form1 : Form
    {
        double sum;
        double day;
        double st1;
        double st2;
        double st3;
        public Form1()
        {
            InitializeComponent();
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "День";
            column1.Width = 100; 
            column1.ReadOnly = true; 
            column1.Name = "day"; 
            column1.Frozen = true; 
            column1.CellTemplate = new DataGridViewTextBoxCell(); 

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Ставка";
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "%";
            column3.Name = "procent";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Сумма выплаты";
            column4.Name = "sprice";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            OutputTable.Columns.Add(column1);
            OutputTable.Columns.Add(column2);
            OutputTable.Columns.Add(column3);
            OutputTable.Columns.Add(column4);

            OutputTable.AllowUserToAddRows = false;

        }

        private void rachet_Click(object sender, EventArgs e)
        {
            int ssum = 0;
            int proc = 0;
            double effectst;
            try
            {
                day = Convert.ToDouble(daytext.Text);
                sum = Convert.ToDouble(sumtext.Text);
                //st1 = Convert.ToDouble(stavka1.Text);
                //st2 = Convert.ToDouble(stavka2.Text);
                //st3 = Convert.ToDouble(stavka3.Text);
                double stavka = 0;
                double nakop = 0;

                string[] ss = textBox1.Text.Split(' ');
                double[] arr = new double[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    arr[i] = Convert.ToDouble(ss[i]);
                }

                for (int i = 0; i < day; i++)
                {
                    stavka = arr[i];
                    OutputTable.Rows.Add();
                    OutputTable["day", OutputTable.Rows.Count - 1].Value = i+1;
                    //if (i <= 5) { stavka = st1; }
                    //if ((i >= 6) && (i <= 10)) { stavka = st2; }
                    //if (i >= 11) { stavka = st3; }
                    OutputTable["price", OutputTable.Rows.Count - 1].Value = stavka;
                    if (i == 0)
                    {
                        OutputTable["procent", OutputTable.Rows.Count - 1].Value = (sum / 100) * stavka;
                        OutputTable["sprice", OutputTable.Rows.Count - 1].Value = sum + (sum / 100) * stavka;
                        nakop = (sum / 100) * stavka;
                    }
                    else
                    {
                        OutputTable["procent", OutputTable.Rows.Count - 1].Value = nakop + ((sum / 100) * stavka);
                        OutputTable["sprice", OutputTable.Rows.Count - 1].Value = sum + nakop + ((sum / 100) * stavka);
                        nakop = nakop + (sum / 100) * stavka;
                    }
                }
                ssum = Convert.ToInt32(OutputTable[3, Convert.ToInt32(day - 1)].Value);
                proc = Convert.ToInt32(OutputTable[2, Convert.ToInt32(day - 1)].Value);
                effectst =  (proc / sum / day) * 100;
                obcsum.Text = Convert.ToString(ssum);
                procsum.Text = Convert.ToString(proc);
                steffect.Text = Convert.ToString(effectst);
            }
            catch { MessageBox.Show("erorr"); }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            OutputTable.Rows.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int rowCounter = OutputTable.RowCount;
            int columnCount = OutputTable.ColumnCount;
            string[] line = new string[columnCount];
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    for (int i = 0; i < OutputTable.RowCount; i++)
                    {
                        for (int j = 0; j < OutputTable.ColumnCount; j++)
                        {
                            line[j] = Convert.ToString((OutputTable.Rows[i].Cells[j].Value ?? ""));
                        }
                        writer.WriteLine(string.Join(";", line));
                    }
                }
            }
        }
    }
  
}
