using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoFolhaSalarial.Entidades
{
    //Criando Classe funcionário contratado, herdando atributos da Classe Funcionário Público
    internal class funcContratado : funcPublico
    {
        //Criando o atributo de Desconto de Inss e implementando a instrução 'protected'
        public double descInss { get; protected set; }

        public funcContratado()
        {

        }
        //Construtor da Classe Atual que incluem outros argumentos herdados da classe Funcionário Publico
        public funcContratado(double liqsalario, string nmfunionario, string numregistro, 
            double bssalario, double desplsaude, double descinss)
        {
            descInss = descinss;

        }

        //Métodos Get e Set para o atributo Desconto de Inss
        public void setDescInss(double descinss)
        {
                this.descInss = descinss;
        }

        public double getDescInss() { 
            return this.descInss;
            
        }

        //Método para o Desconto de Inss do Salário Base
        public void calcDescInss() {
            descInss = (bsSalario * 18) / 100;
            liqSalario = bsSalario - descInss;
        
        }


    }
}
