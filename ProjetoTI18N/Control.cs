using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Control
    {
        
        public Control()
        {
            calc = new Calculadora();//Instanciando, calc é um objeto de calculadora
        }//fim de construtor
        public int ConsultarOpcao
        {
            get { retun opcao }
            set { opcao = value}
        }//Fim método
    
        //Coletar
        public void coletarnum1()
        {
            Console.WriteLine("informe um número");
            calc.ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
        }//Fim de método coletarNum1

        public void coletarnum2()
        {
            Console.WriteLine("informe um número");
            calc.ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//Fim de método coletarNum2

        public void menu()
        {
            Console.WriteLine("------- Menu -------" +
                             "/n0. Sair" +
                             "/n1. Somar" +
                             "/n2. Subtrair" +
                             "/n3 multiplicar" +
                             "/n4 Dividir" +
                             "/n/n Escolha uma das opções acima:  ");
            Consultaropcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do método Menu

        //Método que faça a operação
        public world Operacao()
        {
            do 
            menu();
            switch (ConsultarOpcao)
            {
                case 0
                    Console.WriteLine("Obrigado")
                        break;
                case 1:
                    coletarnum1();//Pegando o 1° Número
                    coletarnum2();//Pegando o 1° número
                    Console.WriteLine("A soma dos números digitados é: " + calc.Somar());
                    break;
                case 2
                    coletarnum1();//Pegando o 1° Número
                    coletarnum2();//Pegando o 1° número
                    Console.WriteLine("A subtração dos números digitados é: " + calc.subtrair());
                    break;
                case 3
                    coletarnum1();//Pegando o 1° Número
                    coletarnum2();//Pegando o 1° número
                    if (calc.Dividir() == -1)
                    {
                        Console.WriteLine("Impossível dividir!");
                    }
                    else
                    {
                        Console.WriteLine("A divisão dos números digitados é:" + calc.Dividir());
                        break;
                    }
                    Console.WriteLine("A divisão dos números digitados é: " + calc.Dividir());
                    break;
                case 4
                    coletarnum1();//Pegando o 1° Número
                    coletarnum2();//Pegando o 1° número
                    Console.WriteLine("A multiplicação dos números digitados é: " + calc.multiplicar());
                    break;
                default:
                    Console.WriteLine("Opção escolhida não é válida")
                        break;
            }//Fim do Switch
        } while (consultarOpcao != 0);
        }//Fim operação


    }
}
