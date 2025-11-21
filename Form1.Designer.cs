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
            this.lbLineal = new System.Windows.Forms.ListBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBusqBin = new System.Windows.Forms.Button();
            this.lbBinaria = new System.Windows.Forms.ListBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbPalabras = new System.Windows.Forms.ListBox();
            this.tbParrafo = new System.Windows.Forms.TextBox();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbObjeto = new System.Windows.Forms.TextBox();
            this.btnBusqObj = new System.Windows.Forms.Button();
            this.lbObjetos = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbNumeros = new System.Windows.Forms.ListBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tbElementosM = new System.Windows.Forms.TextBox();
            this.lbMatriz = new System.Windows.Forms.ListBox();
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
            // lbLineal
            // 
            this.lbLineal.FormattingEnabled = true;
            this.lbLineal.Location = new System.Drawing.Point(69, 87);
            this.lbLineal.Name = "lbLineal";
            this.lbLineal.Size = new System.Drawing.Size(120, 95);
            this.lbLineal.TabIndex = 2;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(69, 27);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 1;
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
            // lbBinaria
            // 
            this.lbBinaria.FormattingEnabled = true;
            this.lbBinaria.Location = new System.Drawing.Point(169, 109);
            this.lbBinaria.Name = "lbBinaria";
            this.lbBinaria.Size = new System.Drawing.Size(120, 95);
            this.lbBinaria.TabIndex = 1;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(169, 29);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbPalabras);
            this.tabPage3.Controls.Add(this.tbParrafo);
            this.tabPage3.Controls.Add(this.tbPalabra);
            this.tabPage3.Controls.Add(this.btnBuscarP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(554, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Búsqueda de Palabra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbPalabras
            // 
            this.lbPalabras.FormattingEnabled = true;
            this.lbPalabras.Location = new System.Drawing.Point(115, 149);
            this.lbPalabras.Name = "lbPalabras";
            this.lbPalabras.Size = new System.Drawing.Size(166, 147);
            this.lbPalabras.TabIndex = 3;
            // 
            // tbParrafo
            // 
            this.tbParrafo.Location = new System.Drawing.Point(115, 92);
            this.tbParrafo.Name = "tbParrafo";
            this.tbParrafo.Size = new System.Drawing.Size(233, 20);
            this.tbParrafo.TabIndex = 2;
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(115, 41);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(100, 20);
            this.tbPalabra.TabIndex = 1;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(389, 41);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(96, 44);
            this.btnBuscarP.TabIndex = 0;
            this.btnBuscarP.Text = "Buscar Palabra";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbObjeto);
            this.tabPage4.Controls.Add(this.btnBusqObj);
            this.tabPage4.Controls.Add(this.lbObjetos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(554, 361);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Búqueda de objetos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbObjeto
            // 
            this.tbObjeto.Location = new System.Drawing.Point(99, 65);
            this.tbObjeto.Name = "tbObjeto";
            this.tbObjeto.Size = new System.Drawing.Size(150, 20);
            this.tbObjeto.TabIndex = 2;
            this.tbObjeto.TextChanged += new System.EventHandler(this.tbObjeto_TextChanged);
            // 
            // btnBusqObj
            // 
            this.btnBusqObj.Location = new System.Drawing.Point(336, 65);
            this.btnBusqObj.Name = "btnBusqObj";
            this.btnBusqObj.Size = new System.Drawing.Size(87, 64);
            this.btnBusqObj.TabIndex = 1;
            this.btnBusqObj.Text = "Buscar objeto";
            this.btnBusqObj.UseVisualStyleBackColor = true;
            this.btnBusqObj.Click += new System.EventHandler(this.btnBusqObj_Click);
            // 
            // lbObjetos
            // 
            this.lbObjetos.FormattingEnabled = true;
            this.lbObjetos.Location = new System.Drawing.Point(99, 126);
            this.lbObjetos.Name = "lbObjetos";
            this.lbObjetos.Size = new System.Drawing.Size(175, 186);
            this.lbObjetos.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lbNumeros);
            this.tabPage5.Controls.Add(this.btnEjecutar);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(554, 361);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Máximo y mínimo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbNumeros
            // 
            this.lbNumeros.FormattingEnabled = true;
            this.lbNumeros.Location = new System.Drawing.Point(116, 85);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(178, 199);
            this.lbNumeros.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(335, 74);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(99, 66);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnCrear);
            this.tabPage6.Controls.Add(this.tbElementosM);
            this.tabPage6.Controls.Add(this.lbMatriz);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(554, 361);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Matriz 2D";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(375, 44);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 66);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tbElementosM
            // 
            this.tbElementosM.Location = new System.Drawing.Point(130, 44);
            this.tbElementosM.Name = "tbElementosM";
            this.tbElementosM.Size = new System.Drawing.Size(174, 20);
            this.tbElementosM.TabIndex = 1;
            // 
            // lbMatriz
            // 
            this.lbMatriz.FormattingEnabled = true;
            this.lbMatriz.Location = new System.Drawing.Point(130, 98);
            this.lbMatriz.Name = "lbMatriz";
            this.lbMatriz.Size = new System.Drawing.Size(199, 186);
            this.lbMatriz.TabIndex = 0;
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
        private System.Windows.Forms.ListBox lbPalabras;
        private System.Windows.Forms.TextBox tbParrafo;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.TextBox tbObjeto;
        private System.Windows.Forms.Button btnBusqObj;
        private System.Windows.Forms.ListBox lbObjetos;
        private System.Windows.Forms.ListBox lbNumeros;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox tbElementosM;
        private System.Windows.Forms.ListBox lbMatriz;
    }
}

