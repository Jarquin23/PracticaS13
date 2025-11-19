namespace PracticaS13
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBusqLin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbLineal = new System.Windows.Forms.ListBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lbBinaria = new System.Windows.Forms.ListBox();
            this.btnBusqBin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBusqLin
            // 
            this.btnBusqLin.Location = new System.Drawing.Point(255, 41);
            this.btnBusqLin.Name = "btnBusqLin";
            this.btnBusqLin.Size = new System.Drawing.Size(75, 47);
            this.btnBusqLin.TabIndex = 0;
            this.btnBusqLin.Text = "Buscar Linealmente";
            this.btnBusqLin.UseVisualStyleBackColor = true;
            this.btnBusqLin.Click += new System.EventHandler(this.btnBusqLin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 387);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbLineal);
            this.tabPage1.Controls.Add(this.tbNumero);
            this.tabPage1.Controls.Add(this.btnBusqLin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Búsqueda Lineal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBusqBin);
            this.tabPage2.Controls.Add(this.lbBinaria);
            this.tabPage2.Controls.Add(this.tbNum);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Búsqueda Binaria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(554, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Búsqueda de Palabra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.listBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(554, 361);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Búqueda de objetos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBox5);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(554, 361);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Máximo y mínimo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Controls.Add(this.listBox6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(554, 361);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Matriz 2D";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(69, 27);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 1;
            // 
            // lbLineal
            // 
            this.lbLineal.FormattingEnabled = true;
            this.lbLineal.Location = new System.Drawing.Point(69, 87);
            this.lbLineal.Name = "lbLineal";
            this.lbLineal.Size = new System.Drawing.Size(120, 95);
            this.lbLineal.TabIndex = 2;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(169, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 0;
            // 
            // lbBinaria
            // 
            this.lbBinaria.FormattingEnabled = true;
            this.lbBinaria.Location = new System.Drawing.Point(169, 109);
            this.lbBinaria.Name = "lbBinaria";
            this.lbBinaria.Size = new System.Drawing.Size(120, 95);
            this.lbBinaria.TabIndex = 1;
            // 
            // btnBusqBin
            // 
            this.btnBusqBin.Location = new System.Drawing.Point(344, 58);
            this.btnBusqBin.Name = "btnBusqBin";
            this.btnBusqBin.Size = new System.Drawing.Size(98, 69);
            this.btnBusqBin.TabIndex = 2;
            this.btnBusqBin.Text = "Ejecutar Búsqueda bin.";
            this.btnBusqBin.UseVisualStyleBackColor = true;
            this.btnBusqBin.Click += new System.EventHandler(this.btnBusqBin_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(115, 190);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(148, 44);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(165, 164);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 95);
            this.listBox5.TabIndex = 1;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(195, 135);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(120, 95);
            this.listBox6.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(92, 110);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(421, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 416);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusqLin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbLineal;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnBusqBin;
        private System.Windows.Forms.ListBox lbBinaria;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox listBox6;
    }
}

