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
            this.stavka1 = new System.Windows.Forms.TextBox();
            this.stavka2 = new System.Windows.Forms.TextBox();
            this.stavka3 = new System.Windows.Forms.TextBox();
            this.rachet = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.sumvip = new System.Windows.Forms.Label();
            this.sumproc = new System.Windows.Forms.Label();
            this.effectst = new System.Windows.Forms.Label();
            this.obcsum = new System.Windows.Forms.TextBox();
            this.procsum = new System.Windows.Forms.TextBox();
            this.steffect = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTable
            // 
            this.OutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputTable.Location = new System.Drawing.Point(345, 12);
            this.OutputTable.Name = "OutputTable";
            this.OutputTable.Size = new System.Drawing.Size(443, 426);
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
            // 
            // stavka1
            // 
            this.stavka1.Location = new System.Drawing.Point(100, 151);
            this.stavka1.Name = "stavka1";
            this.stavka1.Size = new System.Drawing.Size(78, 20);
            this.stavka1.TabIndex = 9;
            // 
            // stavka2
            // 
            this.stavka2.Location = new System.Drawing.Point(100, 178);
            this.stavka2.Name = "stavka2";
            this.stavka2.Size = new System.Drawing.Size(78, 20);
            this.stavka2.TabIndex = 10;
            // 
            // stavka3
            // 
            this.stavka3.Location = new System.Drawing.Point(100, 207);
            this.stavka3.Name = "stavka3";
            this.stavka3.Size = new System.Drawing.Size(78, 20);
            this.stavka3.TabIndex = 11;
            // 
            // rachet
            // 
            this.rachet.Location = new System.Drawing.Point(16, 247);
            this.rachet.Name = "rachet";
            this.rachet.Size = new System.Drawing.Size(75, 22);
            this.rachet.TabIndex = 12;
            this.rachet.Text = "Расчитать";
            this.rachet.UseVisualStyleBackColor = true;
            this.rachet.Click += new System.EventHandler(this.rachet_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(16, 291);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(132, 21);
            this.clean.TabIndex = 13;
            this.clean.Text = "Очистить результат";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(15, 336);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(119, 21);
            this.save.TabIndex = 14;
            this.save.Text = "Сохранить таблицу";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // sumvip
            // 
            this.sumvip.AutoSize = true;
            this.sumvip.Location = new System.Drawing.Point(203, 12);
            this.sumvip.Name = "sumvip";
            this.sumvip.Size = new System.Drawing.Size(126, 13);
            this.sumvip.TabIndex = 15;
            this.sumvip.Text = "Общая сумма выплаты";
            // 
            // sumproc
            // 
            this.sumproc.AutoSize = true;
            this.sumproc.Location = new System.Drawing.Point(203, 70);
            this.sumproc.Name = "sumproc";
            this.sumproc.Size = new System.Drawing.Size(97, 13);
            this.sumproc.TabIndex = 16;
            this.sumproc.Text = "Сумма процентов";
            // 
            // effectst
            // 
            this.effectst.AutoSize = true;
            this.effectst.Location = new System.Drawing.Point(203, 127);
            this.effectst.Name = "effectst";
            this.effectst.Size = new System.Drawing.Size(115, 13);
            this.effectst.TabIndex = 17;
            this.effectst.Text = "Эффективная ставка";
            // 
            // obcsum
            // 
            this.obcsum.Location = new System.Drawing.Point(206, 28);
            this.obcsum.Name = "obcsum";
            this.obcsum.Size = new System.Drawing.Size(96, 20);
            this.obcsum.TabIndex = 18;
            // 
            // procsum
            // 
            this.procsum.Location = new System.Drawing.Point(206, 86);
            this.procsum.Name = "procsum";
            this.procsum.Size = new System.Drawing.Size(96, 20);
            this.procsum.TabIndex = 19;
            // 
            // steffect
            // 
            this.steffect.Location = new System.Drawing.Point(206, 151);
            this.steffect.Name = "steffect";
            this.steffect.Size = new System.Drawing.Size(96, 20);
            this.steffect.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.steffect);
            this.Controls.Add(this.procsum);
            this.Controls.Add(this.obcsum);
            this.Controls.Add(this.effectst);
            this.Controls.Add(this.sumproc);
            this.Controls.Add(this.sumvip);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.rachet);
            this.Controls.Add(this.stavka3);
            this.Controls.Add(this.stavka2);
            this.Controls.Add(this.stavka1);
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
        private System.Windows.Forms.TextBox stavka1;
        private System.Windows.Forms.TextBox stavka2;
        private System.Windows.Forms.TextBox stavka3;
        private System.Windows.Forms.Button rachet;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label sumvip;
        private System.Windows.Forms.Label sumproc;
        private System.Windows.Forms.Label effectst;
        private System.Windows.Forms.TextBox obcsum;
        private System.Windows.Forms.TextBox procsum;
        private System.Windows.Forms.TextBox steffect;
        private System.Windows.Forms.TextBox textBox1;
    }
}

