using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace calculoFolhaSalarial.Entidades
{
    internal class funcPublico
    {
        //Declarando os atibutos com instruções de 'private' e 'protected' para cada atributo
        public string nmFuncionario { get; private set;}
        public string numRegistro { get; private set; }
        public double bsSalario { get; protected set; }
        public double descPlSaude { get; protected set; }
        public double liqSalario { get; protected set; }


        public funcPublico()
        {

        }

        //Criando o construtor dos atributos
        public funcPublico( double liqsalario, 
            string nmfuncionarios, string numregistro, double bssalario, double desplsaude) {
                nmFuncionario = nmfuncionarios;
                bsSalario = bssalario;
                numRegistro = numregistro;
                descPlSaude = desplsaude;
                liqSalario = liqsalario;

        
        }

        //Criando os Métodos Get e Set para todos os atributos
        public void setNmFuncionario(string nmfuncionario) { 
            this.nmFuncionario = nmfuncionario;
        
        }

        public void setNumegistro(string numregistro) { 
            this.numRegistro = numregistro;
        
        }

        public void setBsSalario(double bssalario) { 
            this.bsSalario = bssalario;
        
        }
        public void setDescPlsaude(double descplsaude)
        {
            this.descPlSaude = descplsaude;

        }

        public void setliqsalario(double liqsalario)
        {
            this.liqSalario = liqsalario;
        }

        public string getNmFuncionario()
        {
            return this.nmFuncionario;
                
        }

        public string getNumegistro() {
            return this.numRegistro;
        }

        public double getBsSalario() {
            return this.bsSalario;
        }
        public double getDescPlSaude()
        {
            return this.descPlSaude;
        }
        public double getLiqSalario()
        {
            return this.liqSalario;
        }
        
        //Criando o método para cálcular o desconto de Plano de Saúde
        public void calculodescplano(double vlDesc) {
            descPlSaude = vlDesc;
            liqSalario = bsSalario - descPlSaude;
           
        }



    }

    
}
