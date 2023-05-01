namespace calculoFolhaSalarial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txNmFunc = new System.Windows.Forms.TextBox();
            this.txNumRes = new System.Windows.Forms.TextBox();
            this.txBsSalario = new System.Windows.Forms.TextBox();
            this.rbFContratado = new System.Windows.Forms.RadioButton();
            this.rbFPublico = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txPlSaude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txdesINSS = new System.Windows.Forms.TextBox();
            this.lbDescInss = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txSlLiquido = new System.Windows.Forms.TextBox();
            this.lblSlLiq = new System.Windows.Forms.Label();
            this.bntCalculaLiq = new System.Windows.Forms.Button();
            this.txVlPlSaude = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bntLimpaDados = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cálculo de Salário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registro do Funcionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salário Base:";
            // 
            // txNmFunc
            // 
            this.txNmFunc.Location = new System.Drawing.Point(15, 134);
            this.txNmFunc.Name = "txNmFunc";
            this.txNmFunc.Size = new System.Drawing.Size(195, 20);
            this.txNmFunc.TabIndex = 5;
            // 
            // txNumRes
            // 
            this.txNumRes.Location = new System.Drawing.Point(15, 191);
            this.txNumRes.Name = "txNumRes";
            this.txNumRes.Size = new System.Drawing.Size(195, 20);
            this.txNumRes.TabIndex = 6;
            // 
            // txBsSalario
            // 
            this.txBsSalario.Location = new System.Drawing.Point(248, 134);
            this.txBsSalario.Name = "txBsSalario";
            this.txBsSalario.Size = new System.Drawing.Size(195, 20);
            this.txBsSalario.TabIndex = 7;
            // 
            // rbFContratado
            // 
            this.rbFContratado.AutoSize = true;
            this.rbFContratado.Location = new System.Drawing.Point(15, 69);
            this.rbFContratado.Name = "rbFContratado";
            this.rbFContratado.Size = new System.Drawing.Size(123, 17);
            this.rbFContratado.TabIndex = 8;
            this.rbFContratado.TabStop = true;
            this.rbFContratado.Text = "Funcionário Contrato";
            this.rbFContratado.UseVisualStyleBackColor = true;
            this.rbFContratado.CheckedChanged += new System.EventHandler(this.rbFContratado_CheckedChanged);
            // 
            // rbFPublico
            // 
            this.rbFPublico.AutoSize = true;
            this.rbFPublico.Location = new System.Drawing.Point(157, 69);
            this.rbFPublico.Name = "rbFPublico";
            this.rbFPublico.Size = new System.Drawing.Size(118, 17);
            this.rbFPublico.TabIndex = 9;
            this.rbFPublico.TabStop = true;
            this.rbFPublico.Text = "Funcionário Público";
            this.rbFPublico.UseVisualStyleBackColor = true;
            this.rbFPublico.CheckedChanged += new System.EventHandler(this.rbFPublico_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selecione o tipo do funcionário:";
            // 
            // txPlSaude
            // 
            this.txPlSaude.Location = new System.Drawing.Point(15, 296);
            this.txPlSaude.Name = "txPlSaude";
            this.txPlSaude.Size = new System.Drawing.Size(195, 20);
            this.txPlSaude.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desconto do Plano de Saúde:";
            // 
            // txdesINSS
            // 
            this.txdesINSS.Location = new System.Drawing.Point(248, 296);
            this.txdesINSS.Name = "txdesINSS";
            this.txdesINSS.Size = new System.Drawing.Size(195, 20);
            this.txdesINSS.TabIndex = 14;
            // 
            // lbDescInss
            // 
            this.lbDescInss.AutoSize = true;
            this.lbDescInss.Location = new System.Drawing.Point(245, 280);
            this.lbDescInss.Name = "lbDescInss";
            this.lbDescInss.Size = new System.Drawing.Size(113, 13);
            this.lbDescInss.TabIndex = 13;
            this.lbDescInss.Text = "Desconto INSS (18%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Resumo da Folha de Pagamento";
            // 
            // txSlLiquido
            // 
            this.txSlLiquido.Location = new System.Drawing.Point(15, 351);
            this.txSlLiquido.Name = "txSlLiquido";
            this.txSlLiquido.Size = new System.Drawing.Size(195, 20);
            this.txSlLiquido.TabIndex = 17;
            // 
            // lblSlLiq
            // 
            this.lblSlLiq.AutoSize = true;
            this.lblSlLiq.Location = new System.Drawing.Point(12, 335);
            this.lblSlLiq.Name = "lblSlLiq";
            this.lblSlLiq.Size = new System.Drawing.Size(81, 13);
            this.lblSlLiq.TabIndex = 16;
            this.lblSlLiq.Text = "Salário Líquido:";
            // 
            // bntCalculaLiq
            // 
            this.bntCalculaLiq.Location = new System.Drawing.Point(50, 392);
            this.bntCalculaLiq.Name = "bntCalculaLiq";
            this.bntCalculaLiq.Size = new System.Drawing.Size(118, 23);
            this.bntCalculaLiq.TabIndex = 18;
            this.bntCalculaLiq.Text = "Calcular";
            this.bntCalculaLiq.UseVisualStyleBackColor = true;
            this.bntCalculaLiq.Click += new System.EventHandler(this.bntCalculaLiq_Click);
            // 
            // txVlPlSaude
            // 
            this.txVlPlSaude.Location = new System.Drawing.Point(248, 191);
            this.txVlPlSaude.Name = "txVlPlSaude";
            this.txVlPlSaude.Size = new System.Drawing.Size(195, 20);
            this.txVlPlSaude.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Valor do Plano de Saúde:";
            // 
            // bntLimpaDados
            // 
            this.bntLimpaDados.Location = new System.Drawing.Point(176, 392);
            this.bntLimpaDados.Name = "bntLimpaDados";
            this.bntLimpaDados.Size = new System.Drawing.Size(118, 23);
            this.bntLimpaDados.TabIndex = 21;
            this.bntLimpaDados.Text = "Limpar Dados";
            this.bntLimpaDados.UseVisualStyleBackColor = true;
            this.bntLimpaDados.Click += new System.EventHandler(this.bntLimpaDados_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(300, 392);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(118, 23);
            this.bntSair.TabIndex = 22;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 427);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpaDados);
            this.Controls.Add(this.txVlPlSaude);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bntCalculaLiq);
            this.Controls.Add(this.txSlLiquido);
            this.Controls.Add(this.lblSlLiq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txdesINSS);
            this.Controls.Add(this.lbDescInss);
            this.Controls.Add(this.txPlSaude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFPublico);
            this.Controls.Add(this.rbFContratado);
            this.Controls.Add(this.txBsSalario);
            this.Controls.Add(this.txNumRes);
            this.Controls.Add(this.txNmFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Cálculo de Salário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNmFunc;
        private System.Windows.Forms.TextBox txNumRes;
        private System.Windows.Forms.TextBox txBsSalario;
        private System.Windows.Forms.RadioButton rbFContratado;
        private System.Windows.Forms.RadioButton rbFPublico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPlSaude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txdesINSS;
        private System.Windows.Forms.Label lbDescInss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txSlLiquido;
        private System.Windows.Forms.Label lblSlLiq;
        private System.Windows.Forms.Button bntCalculaLiq;
        private System.Windows.Forms.TextBox txVlPlSaude;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bntLimpaDados;
        private System.Windows.Forms.Button bntSair;
    }
}

