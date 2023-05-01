using calculoFolhaSalarial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoFolhaSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalculaLiq_Click(object sender, EventArgs e)
        {
            //Estrutura IF...ELSE para checar qual botão (Funcionário Público/Contratado) está selecionado
            if (rbFPublico.Checked == true) {

                funcPublico func1 = new funcPublico();

                //Intrução TRY...CATCH para lidar com erros de inserção de dados do usuário
                try {

                    //Recebendo valores inseridos pelo usuário para o nosso objeto Funcionário Público
                    func1.setNmFuncionario(txNmFunc.Text);
                    func1.setBsSalario(double.Parse(txBsSalario.Text));
                    func1.setNumegistro(txNumRes.Text);
                    func1.calculodescplano(double.Parse(txVlPlSaude.Text));

                }
                catch(Exception ex)
                {
                    //Erro de inserção de dados
                    MessageBox.Show($"Verifique se os dados estão inseridos corretamente e tente novamente.", "Erro de inserção");


                }

                //Mostrando resultados do cálculo do salário líquido

                txPlSaude.Text = (func1.getDescPlSaude()).ToString();

                lblSlLiq.Visible = true;
                txSlLiquido.Visible = true;

                txSlLiquido.Text = (func1.getLiqSalario()).ToString();
                


            } else if(rbFContratado.Checked == true)
            { 
                //Criando objeto Funcionário Contratado
                funcContratado func2 = new funcContratado();


                try
                {
                    func2.setNmFuncionario(txNmFunc.Text);
                    func2.setBsSalario(double.Parse(txBsSalario.Text));
                    func2.setNumegistro(txNumRes.Text);

                    func2.calcDescInss();
                    func2.setBsSalario(func2.liqSalario);
                    func2.calculodescplano(double.Parse(txVlPlSaude.Text));

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Verifique se os dados estão inseridos corretamente e tente novamente.", "Erro de inserção");
                }
                

                //Mostrando os resultados
                txdesINSS.Text = (func2.getDescInss()).ToString();
                txPlSaude.Text = (func2.getDescPlSaude()).ToString();

                lblSlLiq.Visible = true;
                txSlLiquido.Visible = true;

                txSlLiquido.Text = (func2.getLiqSalario()).ToString();

            }

        }
        //Iniciando o formulário com o Botão 'Funcionário Público' clicado e o Salário Líquido sem visibilidade 
        private void Form1_Load(object sender, EventArgs e)
        {
            rbFPublico.Checked = true;
            lblSlLiq.Visible = false;
            txSlLiquido.Visible = false;
        }

        private void rbFPublico_CheckedChanged(object sender, EventArgs e)
        {
            lbDescInss.Visible = false;
            txdesINSS.Visible = false;
            
        }

        private void rbFContratado_CheckedChanged(object sender, EventArgs e)
        {
            lbDescInss.Visible = true;
            txdesINSS.Visible = true;
        }

        //Criando um botão para Limpar os Dados inseridos pelo usuário
        private void bntLimpaDados_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Você deseja limpar todos os dados inseridos?", "Limpar Dados", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                txNmFunc.Clear();
                txNumRes.Clear();
                txBsSalario.Clear();    
                txPlSaude.Clear();
                txVlPlSaude.Clear();
                txdesINSS.Clear();
                txSlLiquido.Clear();

                lblSlLiq.Visible = false;
                txSlLiquido.Visible = false;
            }
        }

        //Criando um botão para encerrar o programa
        private void bntSair_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Você deseja sair do sistema?", "Encerrar Sistema", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();


            }
        }
    }
}
