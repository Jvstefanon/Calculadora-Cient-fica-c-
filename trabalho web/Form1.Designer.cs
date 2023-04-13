namespace Cientific_calulator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_tres = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_quatro = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_aoquard = new System.Windows.Forms.Button();
            this.btn_vzs = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn_dimini = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_masmen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(447, 29);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_um
            // 
            this.btn_um.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_um.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_um.Location = new System.Drawing.Point(12, 227);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(68, 54);
            this.btn_um.TabIndex = 1;
            this.btn_um.Text = "1";
            this.btn_um.UseVisualStyleBackColor = false;
            this.btn_um.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(90, 227);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(68, 54);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn_tres
            // 
            this.btn_tres.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tres.Location = new System.Drawing.Point(164, 227);
            this.btn_tres.Name = "btn_tres";
            this.btn_tres.Size = new System.Drawing.Size(68, 54);
            this.btn_tres.TabIndex = 3;
            this.btn_tres.Text = "3";
            this.btn_tres.UseVisualStyleBackColor = false;
            this.btn_tres.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(164, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 54);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(90, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn_quatro
            // 
            this.btn_quatro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quatro.Location = new System.Drawing.Point(12, 164);
            this.btn_quatro.Name = "btn_quatro";
            this.btn_quatro.Size = new System.Drawing.Size(68, 54);
            this.btn_quatro.TabIndex = 4;
            this.btn_quatro.Text = "4";
            this.btn_quatro.UseVisualStyleBackColor = false;
            this.btn_quatro.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(164, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 54);
            this.button7.TabIndex = 9;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(90, 104);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 54);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(12, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 54);
            this.button9.TabIndex = 7;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(164, 47);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(68, 51);
            this.btn_sair.TabIndex = 12;
            this.btn_sair.Text = "<-";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_limp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limp.Location = new System.Drawing.Point(90, 47);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(68, 51);
            this.btn_limp.TabIndex = 11;
            this.btn_limp.Text = "C";
            this.btn_limp.UseVisualStyleBackColor = false;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(12, 47);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(68, 54);
            this.btn_borrar.TabIndex = 10;
            this.btn_borrar.Text = "CE";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_raiz
            // 
            this.btn_raiz.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raiz.Location = new System.Drawing.Point(319, 47);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(68, 51);
            this.btn_raiz.TabIndex = 14;
            this.btn_raiz.Tag = "√";
            this.btn_raiz.Text = "√";
            this.btn_raiz.UseVisualStyleBackColor = false;
            this.btn_raiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn_aoquard
            // 
            this.btn_aoquard.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_aoquard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aoquard.Location = new System.Drawing.Point(393, 47);
            this.btn_aoquard.Name = "btn_aoquard";
            this.btn_aoquard.Size = new System.Drawing.Size(68, 51);
            this.btn_aoquard.TabIndex = 13;
            this.btn_aoquard.Tag = "²";
            this.btn_aoquard.Text = "x²";
            this.btn_aoquard.UseVisualStyleBackColor = false;
            this.btn_aoquard.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn_vzs
            // 
            this.btn_vzs.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_vzs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vzs.Location = new System.Drawing.Point(393, 104);
            this.btn_vzs.Name = "btn_vzs";
            this.btn_vzs.Size = new System.Drawing.Size(68, 54);
            this.btn_vzs.TabIndex = 16;
            this.btn_vzs.Tag = "X";
            this.btn_vzs.Text = "X";
            this.btn_vzs.UseVisualStyleBackColor = false;
            this.btn_vzs.Click += new System.EventHandler(this.clickOperador);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(319, 104);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 54);
            this.button16.TabIndex = 15;
            this.button16.Tag = "/";
            this.button16.Text = "⁄";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn_dimini
            // 
            this.btn_dimini.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_dimini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dimini.Location = new System.Drawing.Point(393, 164);
            this.btn_dimini.Name = "btn_dimini";
            this.btn_dimini.Size = new System.Drawing.Size(68, 54);
            this.btn_dimini.TabIndex = 18;
            this.btn_dimini.Tag = "-";
            this.btn_dimini.Text = "-";
            this.btn_dimini.UseVisualStyleBackColor = false;
            this.btn_dimini.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn_soma
            // 
            this.btn_soma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(319, 164);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(68, 54);
            this.btn_soma.TabIndex = 17;
            this.btn_soma.Tag = "+";
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = false;
            this.btn_soma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.Location = new System.Drawing.Point(317, 224);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(142, 54);
            this.btn_igual.TabIndex = 19;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_point
            // 
            this.btn_point.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.Location = new System.Drawing.Point(164, 287);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(68, 54);
            this.btn_point.TabIndex = 22;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.Location = new System.Drawing.Point(90, 287);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(68, 54);
            this.btn_zero.TabIndex = 21;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.adicionarNumero);
            // 
            // btn_masmen
            // 
            this.btn_masmen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_masmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_masmen.Location = new System.Drawing.Point(12, 287);
            this.btn_masmen.Name = "btn_masmen";
            this.btn_masmen.Size = new System.Drawing.Size(68, 54);
            this.btn_masmen.TabIndex = 20;
            this.btn_masmen.Text = "+/-";
            this.btn_masmen.UseVisualStyleBackColor = false;
            this.btn_masmen.Click += new System.EventHandler(this.btn_masmen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(471, 364);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_masmen);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_dimini);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_vzs);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.btn_aoquard);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_quatro);
            this.Controls.Add(this.btn_tres);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_um);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "²";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_tres;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_quatro;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Button btn_aoquard;
        private System.Windows.Forms.Button btn_vzs;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btn_dimini;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_masmen;
    }
}

