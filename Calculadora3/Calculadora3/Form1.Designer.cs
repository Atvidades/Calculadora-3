namespace Calculadora3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Resultado = new System.Windows.Forms.TextBox();
            this.BT_Limpar = new System.Windows.Forms.Button();
            this.BT_7 = new System.Windows.Forms.Button();
            this.BT_8 = new System.Windows.Forms.Button();
            this.BT_9 = new System.Windows.Forms.Button();
            this.BT_Divisao = new System.Windows.Forms.Button();
            this.BT_Multiplicacao = new System.Windows.Forms.Button();
            this.BT_6 = new System.Windows.Forms.Button();
            this.BT_5 = new System.Windows.Forms.Button();
            this.BT_4 = new System.Windows.Forms.Button();
            this.BT_Subtracao = new System.Windows.Forms.Button();
            this.BT_3 = new System.Windows.Forms.Button();
            this.BT_2 = new System.Windows.Forms.Button();
            this.BT_1 = new System.Windows.Forms.Button();
            this.BT_Soma = new System.Windows.Forms.Button();
            this.BT_IGUAL = new System.Windows.Forms.Button();
            this.BT_0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Resultado
            // 
            this.TB_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Resultado.Location = new System.Drawing.Point(12, 12);
            this.TB_Resultado.Multiline = true;
            this.TB_Resultado.Name = "TB_Resultado";
            this.TB_Resultado.Size = new System.Drawing.Size(526, 67);
            this.TB_Resultado.TabIndex = 0;
            this.TB_Resultado.Text = "0";
            this.TB_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BT_Limpar
            // 
            this.BT_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Limpar.Location = new System.Drawing.Point(441, 85);
            this.BT_Limpar.Name = "BT_Limpar";
            this.BT_Limpar.Size = new System.Drawing.Size(97, 138);
            this.BT_Limpar.TabIndex = 1;
            this.BT_Limpar.Text = "C";
            this.BT_Limpar.UseVisualStyleBackColor = true;
            this.BT_Limpar.Click += new System.EventHandler(this.BT_Limpar_Click);
            // 
            // BT_7
            // 
            this.BT_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_7.Location = new System.Drawing.Point(12, 85);
            this.BT_7.Name = "BT_7";
            this.BT_7.Size = new System.Drawing.Size(100, 66);
            this.BT_7.TabIndex = 2;
            this.BT_7.Text = "7";
            this.BT_7.UseVisualStyleBackColor = true;
            this.BT_7.Click += new System.EventHandler(this.BT_7_Click);
            // 
            // BT_8
            // 
            this.BT_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_8.Location = new System.Drawing.Point(118, 85);
            this.BT_8.Name = "BT_8";
            this.BT_8.Size = new System.Drawing.Size(100, 66);
            this.BT_8.TabIndex = 3;
            this.BT_8.Text = "8";
            this.BT_8.UseVisualStyleBackColor = true;
            this.BT_8.Click += new System.EventHandler(this.BT_8_Click);
            // 
            // BT_9
            // 
            this.BT_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_9.Location = new System.Drawing.Point(224, 85);
            this.BT_9.Name = "BT_9";
            this.BT_9.Size = new System.Drawing.Size(100, 66);
            this.BT_9.TabIndex = 4;
            this.BT_9.Text = "9";
            this.BT_9.UseVisualStyleBackColor = true;
            this.BT_9.Click += new System.EventHandler(this.BT_9_Click);
            // 
            // BT_Divisao
            // 
            this.BT_Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Divisao.Location = new System.Drawing.Point(330, 85);
            this.BT_Divisao.Name = "BT_Divisao";
            this.BT_Divisao.Size = new System.Drawing.Size(100, 66);
            this.BT_Divisao.TabIndex = 5;
            this.BT_Divisao.Text = "/";
            this.BT_Divisao.UseVisualStyleBackColor = true;
            this.BT_Divisao.Click += new System.EventHandler(this.BT_Divisao_Click);
            // 
            // BT_Multiplicacao
            // 
            this.BT_Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Multiplicacao.Location = new System.Drawing.Point(330, 157);
            this.BT_Multiplicacao.Name = "BT_Multiplicacao";
            this.BT_Multiplicacao.Size = new System.Drawing.Size(100, 66);
            this.BT_Multiplicacao.TabIndex = 9;
            this.BT_Multiplicacao.Text = "*";
            this.BT_Multiplicacao.UseVisualStyleBackColor = true;
            this.BT_Multiplicacao.Click += new System.EventHandler(this.BT_Multiplicacao_Click);
            // 
            // BT_6
            // 
            this.BT_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_6.Location = new System.Drawing.Point(224, 157);
            this.BT_6.Name = "BT_6";
            this.BT_6.Size = new System.Drawing.Size(100, 66);
            this.BT_6.TabIndex = 8;
            this.BT_6.Text = "6";
            this.BT_6.UseVisualStyleBackColor = true;
            this.BT_6.Click += new System.EventHandler(this.BT_6_Click);
            // 
            // BT_5
            // 
            this.BT_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_5.Location = new System.Drawing.Point(118, 157);
            this.BT_5.Name = "BT_5";
            this.BT_5.Size = new System.Drawing.Size(100, 66);
            this.BT_5.TabIndex = 7;
            this.BT_5.Text = "5";
            this.BT_5.UseVisualStyleBackColor = true;
            this.BT_5.Click += new System.EventHandler(this.BT_5_Click);
            // 
            // BT_4
            // 
            this.BT_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_4.Location = new System.Drawing.Point(12, 157);
            this.BT_4.Name = "BT_4";
            this.BT_4.Size = new System.Drawing.Size(100, 66);
            this.BT_4.TabIndex = 6;
            this.BT_4.Text = "4";
            this.BT_4.UseVisualStyleBackColor = true;
            this.BT_4.Click += new System.EventHandler(this.BT_4_Click);
            // 
            // BT_Subtracao
            // 
            this.BT_Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Subtracao.Location = new System.Drawing.Point(330, 229);
            this.BT_Subtracao.Name = "BT_Subtracao";
            this.BT_Subtracao.Size = new System.Drawing.Size(100, 66);
            this.BT_Subtracao.TabIndex = 13;
            this.BT_Subtracao.Text = "-";
            this.BT_Subtracao.UseVisualStyleBackColor = true;
            this.BT_Subtracao.Click += new System.EventHandler(this.BT_Subtracao_Click);
            // 
            // BT_3
            // 
            this.BT_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_3.Location = new System.Drawing.Point(224, 229);
            this.BT_3.Name = "BT_3";
            this.BT_3.Size = new System.Drawing.Size(100, 66);
            this.BT_3.TabIndex = 12;
            this.BT_3.Text = "3";
            this.BT_3.UseVisualStyleBackColor = true;
            this.BT_3.Click += new System.EventHandler(this.BT_3_Click);
            // 
            // BT_2
            // 
            this.BT_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_2.Location = new System.Drawing.Point(118, 229);
            this.BT_2.Name = "BT_2";
            this.BT_2.Size = new System.Drawing.Size(100, 66);
            this.BT_2.TabIndex = 11;
            this.BT_2.Text = "2";
            this.BT_2.UseVisualStyleBackColor = true;
            this.BT_2.Click += new System.EventHandler(this.BT_2_Click);
            // 
            // BT_1
            // 
            this.BT_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_1.Location = new System.Drawing.Point(12, 229);
            this.BT_1.Name = "BT_1";
            this.BT_1.Size = new System.Drawing.Size(100, 66);
            this.BT_1.TabIndex = 10;
            this.BT_1.Text = "1";
            this.BT_1.UseVisualStyleBackColor = true;
            this.BT_1.Click += new System.EventHandler(this.BT_1_Click);
            // 
            // BT_Soma
            // 
            this.BT_Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Soma.Location = new System.Drawing.Point(330, 301);
            this.BT_Soma.Name = "BT_Soma";
            this.BT_Soma.Size = new System.Drawing.Size(100, 66);
            this.BT_Soma.TabIndex = 17;
            this.BT_Soma.Text = "+";
            this.BT_Soma.UseVisualStyleBackColor = true;
            this.BT_Soma.Click += new System.EventHandler(this.BT_Soma_Click);
            // 
            // BT_IGUAL
            // 
            this.BT_IGUAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_IGUAL.Location = new System.Drawing.Point(441, 229);
            this.BT_IGUAL.Name = "BT_IGUAL";
            this.BT_IGUAL.Size = new System.Drawing.Size(97, 138);
            this.BT_IGUAL.TabIndex = 18;
            this.BT_IGUAL.Text = "=";
            this.BT_IGUAL.UseVisualStyleBackColor = true;
            this.BT_IGUAL.Click += new System.EventHandler(this.BT_IGUAL_Click);
            // 
            // BT_0
            // 
            this.BT_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_0.Location = new System.Drawing.Point(12, 301);
            this.BT_0.Name = "BT_0";
            this.BT_0.Size = new System.Drawing.Size(312, 66);
            this.BT_0.TabIndex = 19;
            this.BT_0.Text = "0";
            this.BT_0.UseVisualStyleBackColor = true;
            this.BT_0.Click += new System.EventHandler(this.BT_0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 376);
            this.Controls.Add(this.BT_0);
            this.Controls.Add(this.BT_IGUAL);
            this.Controls.Add(this.BT_Soma);
            this.Controls.Add(this.BT_Subtracao);
            this.Controls.Add(this.BT_3);
            this.Controls.Add(this.BT_2);
            this.Controls.Add(this.BT_1);
            this.Controls.Add(this.BT_Multiplicacao);
            this.Controls.Add(this.BT_6);
            this.Controls.Add(this.BT_5);
            this.Controls.Add(this.BT_4);
            this.Controls.Add(this.BT_Divisao);
            this.Controls.Add(this.BT_9);
            this.Controls.Add(this.BT_8);
            this.Controls.Add(this.BT_7);
            this.Controls.Add(this.BT_Limpar);
            this.Controls.Add(this.TB_Resultado);
            this.Name = "Form1";
            this.Text = "Bruno 1240463";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Resultado;
        private System.Windows.Forms.Button BT_Limpar;
        private System.Windows.Forms.Button BT_7;
        private System.Windows.Forms.Button BT_8;
        private System.Windows.Forms.Button BT_9;
        private System.Windows.Forms.Button BT_Divisao;
        private System.Windows.Forms.Button BT_Multiplicacao;
        private System.Windows.Forms.Button BT_6;
        private System.Windows.Forms.Button BT_5;
        private System.Windows.Forms.Button BT_4;
        private System.Windows.Forms.Button BT_Subtracao;
        private System.Windows.Forms.Button BT_3;
        private System.Windows.Forms.Button BT_2;
        private System.Windows.Forms.Button BT_1;
        private System.Windows.Forms.Button BT_Soma;
        private System.Windows.Forms.Button BT_IGUAL;
        private System.Windows.Forms.Button BT_0;
    }
}

