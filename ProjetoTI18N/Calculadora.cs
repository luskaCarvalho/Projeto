using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Calculadora
    {
        //Variáveis globais 
        private double num1;
        private double num2;
        //Método contstrutor -> IntÂncia as variáveis na memória do computador 

        public Calculadora(double num1)
        {
            ConsultarNum1 = 0;
            Consultarnum2 = 0;

        }//Fim do método construtor

        //Métodos de modificadores = GET e SET 
        public double ConsultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }//Fim do método consultarNum1

        public double consultarnum2
        {
            get { return num2; }
            set { num2 = value; }
        }//Fim consultar num2

        //Métodos 
        public double Somar()
        {
            return ConsultarNum1 + consultarnum2;
        }// Fim somar 

        public double subtrair()
        {
            return ConsultarNum1 - consultarnum2;
        }

        public double Multiplicar()
        {
            return ConsultarNum1 * consultarnum2;
                
        }
        public double Dividir()
        {
            if (consultarnum2 <= 0)
            {
                retturn -1
            }




    }//Fim da classe
}//Fim do projeto
