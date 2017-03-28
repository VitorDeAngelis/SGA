namespace SGA1.View
{
    partial class AdicionarCasa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NomeTB = new System.Windows.Forms.TextBox();
            this.EnderecoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CapMaxTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorDiTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumQuartosTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumBanheirosTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LareiraCB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // NomeTB
            // 
            this.NomeTB.Location = new System.Drawing.Point(79, 38);
            this.NomeTB.Name = "NomeTB";
            this.NomeTB.Size = new System.Drawing.Size(100, 20);
            this.NomeTB.TabIndex = 1;
            // 
            // EnderecoTB
            // 
            this.EnderecoTB.Location = new System.Drawing.Point(97, 64);
            this.EnderecoTB.Name = "EnderecoTB";
            this.EnderecoTB.Size = new System.Drawing.Size(82, 20);
            this.EnderecoTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // CapMaxTB
            // 
            this.CapMaxTB.Location = new System.Drawing.Point(54, 109);
            this.CapMaxTB.Name = "CapMaxTB";
            this.CapMaxTB.Size = new System.Drawing.Size(100, 20);
            this.CapMaxTB.TabIndex = 5;
            this.CapMaxTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CapMaxTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacidade Máxima";
            // 
            // ValorDiTB
            // 
            this.ValorDiTB.Location = new System.Drawing.Point(33, 148);
            this.ValorDiTB.Name = "ValorDiTB";
            this.ValorDiTB.Size = new System.Drawing.Size(100, 20);
            this.ValorDiTB.TabIndex = 7;
            this.ValorDiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorDiTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Diária";
            // 
            // NumQuartosTB
            // 
            this.NumQuartosTB.AcceptsReturn = true;
            this.NumQuartosTB.Location = new System.Drawing.Point(41, 209);
            this.NumQuartosTB.Name = "NumQuartosTB";
            this.NumQuartosTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumQuartosTB.Size = new System.Drawing.Size(100, 20);
            this.NumQuartosTB.TabIndex = 9;
            this.NumQuartosTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumQuartosTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número de quartos";
            // 
            // NumBanheirosTB
            // 
            this.NumBanheirosTB.Location = new System.Drawing.Point(41, 257);
            this.NumBanheirosTB.Name = "NumBanheirosTB";
            this.NumBanheirosTB.Size = new System.Drawing.Size(100, 20);
            this.NumBanheirosTB.TabIndex = 11;
            this.NumBanheirosTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumBanheirosTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(25, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número de banheiros";
            // 
            // LareiraCB
            // 
            this.LareiraCB.AutoSize = true;
            this.LareiraCB.Location = new System.Drawing.Point(473, 41);
            this.LareiraCB.Name = "LareiraCB";
            this.LareiraCB.Size = new System.Drawing.Size(58, 17);
            this.LareiraCB.TabIndex = 12;
            this.LareiraCB.Text = "Lareira";
            this.LareiraCB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdicionarCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LareiraCB);
            this.Controls.Add(this.NumBanheirosTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumQuartosTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValorDiTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CapMaxTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnderecoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeTB);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarCasa";
            this.Size = new System.Drawing.Size(639, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeTB;
        private System.Windows.Forms.TextBox EnderecoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CapMaxTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorDiTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumQuartosTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumBanheirosTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox LareiraCB;
        private System.Windows.Forms.Button button1;
    }
}
