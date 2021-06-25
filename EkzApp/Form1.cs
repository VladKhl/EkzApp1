using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkzApp
{
    public partial class Form1 : Form
    {
        int sum;
        int day;
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
            try
            {
                day = Convert.ToInt32(daytext.Text);
                sum = Convert.ToInt32(sumtext.Text);
                st1 = Convert.ToDouble(stavka1.Text);
                st2 = Convert.ToDouble(stavka2.Text);
                st3 = Convert.ToDouble(stavka3.Text);
                double stavka = 0;
                double nakop = 0;
                for (int i = 1; i <= day; i++)
                {
                    OutputTable.Rows.Add();
                    OutputTable["day", OutputTable.Rows.Count - 1].Value = i;
                    if (i <= 5) { stavka = st1; }
                    if ((i >= 6) && (i <= 10)) { stavka = st2; }
                    if (i >= 11) { stavka = st3; }
                    OutputTable["price", OutputTable.Rows.Count - 1].Value = stavka;
                    if (i == 1)
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
            }
            catch { MessageBox.Show("erorr"); }
        }
    }
  
}
