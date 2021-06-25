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
        int st1;
        int st2;
        int st3;
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
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Сумма выплаты";
            column4.Name = "cnt";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            OutputTable.Columns.Add(column1);
            OutputTable.Columns.Add(column2);
            OutputTable.Columns.Add(column3);
            OutputTable.Columns.Add(column4);

            OutputTable.AllowUserToAddRows = false;

        }
    }
}
