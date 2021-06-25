namespace EkzApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputTable = new System.Windows.Forms.DataGridView();
            this.daylabel = new System.Windows.Forms.Label();
            this.daytext = new System.Windows.Forms.TextBox();
            this.summalabel = new System.Windows.Forms.Label();
            this.sumtext = new System.Windows.Forms.TextBox();
            this.procentlabel = new System.Windows.Forms.Label();
            this.procentlabel2 = new System.Windows.Forms.Label();
            this.procentlabel1 = new System.Windows.Forms.Label();
            this.procentlabel3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTable
            // 
            this.OutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputTable.Location = new System.Drawing.Point(459, 12);
            this.OutputTable.Name = "OutputTable";
            this.OutputTable.Size = new System.Drawing.Size(329, 426);
            this.OutputTable.TabIndex = 0;
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(12, 12);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(122, 13);
            this.daylabel.TabIndex = 1;
            this.daylabel.Text = "На сколько дней займ";
            // 
            // daytext
            // 
            this.daytext.Location = new System.Drawing.Point(15, 28);
            this.daytext.Name = "daytext";
            this.daytext.Size = new System.Drawing.Size(112, 20);
            this.daytext.TabIndex = 2;
            // 
            // summalabel
            // 
            this.summalabel.AutoSize = true;
            this.summalabel.Location = new System.Drawing.Point(12, 70);
            this.summalabel.Name = "summalabel";
            this.summalabel.Size = new System.Drawing.Size(76, 13);
            this.summalabel.TabIndex = 3;
            this.summalabel.Text = "Сумма займа";
            // 
            // sumtext
            // 
            this.sumtext.Location = new System.Drawing.Point(15, 86);
            this.sumtext.Name = "sumtext";
            this.sumtext.Size = new System.Drawing.Size(109, 20);
            this.sumtext.TabIndex = 4;
            // 
            // procentlabel
            // 
            this.procentlabel.AutoSize = true;
            this.procentlabel.Location = new System.Drawing.Point(12, 127);
            this.procentlabel.Name = "procentlabel";
            this.procentlabel.Size = new System.Drawing.Size(106, 13);
            this.procentlabel.TabIndex = 5;
            this.procentlabel.Text = "Процентная ставка";
            // 
            // procentlabel2
            // 
            this.procentlabel2.AutoSize = true;
            this.procentlabel2.Location = new System.Drawing.Point(12, 181);
            this.procentlabel2.Name = "procentlabel2";
            this.procentlabel2.Size = new System.Drawing.Size(79, 13);
            this.procentlabel2.TabIndex = 6;
            this.procentlabel2.Text = "с 6 по 10 день";
            // 
            // procentlabel1
            // 
            this.procentlabel1.AutoSize = true;
            this.procentlabel1.Location = new System.Drawing.Point(12, 154);
            this.procentlabel1.Name = "procentlabel1";
            this.procentlabel1.Size = new System.Drawing.Size(73, 13);
            this.procentlabel1.TabIndex = 7;
            this.procentlabel1.Text = "с 0 по 5 день";
            // 
            // procentlabel3
            // 
            this.procentlabel3.AutoSize = true;
            this.procentlabel3.Location = new System.Drawing.Point(12, 207);
            this.procentlabel3.Name = "procentlabel3";
            this.procentlabel3.Size = new System.Drawing.Size(73, 13);
            this.procentlabel3.TabIndex = 8;
            this.procentlabel3.Text = "после 11 дня";
            this.procentlabel3.Click += new System.EventHandler(this.procentlabel3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.procentlabel3);
            this.Controls.Add(this.procentlabel1);
            this.Controls.Add(this.procentlabel2);
            this.Controls.Add(this.procentlabel);
            this.Controls.Add(this.sumtext);
            this.Controls.Add(this.summalabel);
            this.Controls.Add(this.daytext);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.OutputTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OutputTable;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.TextBox daytext;
        private System.Windows.Forms.Label summalabel;
        private System.Windows.Forms.TextBox sumtext;
        private System.Windows.Forms.Label procentlabel;
        private System.Windows.Forms.Label procentlabel2;
        private System.Windows.Forms.Label procentlabel1;
        private System.Windows.Forms.Label procentlabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

