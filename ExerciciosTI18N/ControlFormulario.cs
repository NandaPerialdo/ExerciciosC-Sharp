using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExerciciosTI18N
{
     class ControlFormulario
    {
        ModelExercicio exercicio;
        private int opcao;
        public ControlFormulario() 
        {
            exercicio = new ModelExercicio();//conecta a classe model e a control
            ConsultarOpcao = -1;
        }//fim do metodo construtor

        //metodos modificadores toda privide precisa de get set
        //unico metodo que nao tem () no final é get set
        
        public int ConsultarOpcao
        {
            get { return opcao;}
            set { opcao = value; }  
        }// fim do metodo


        public void Menu()
        {
            Console.WriteLine("\n\n ---- menu ----\n\n" +
                               "0.Sair\n" +
                               "1.exercicio 1\n" +
                               "2 exercicio 2\n" +
                               "3.exercicio 3\n" +
                               "4.exercicio 4\n" +
                               "5.exercicio 5\n" +
                               "6.exercicio 6\n" +
                               "escolha uma das opcoes acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }// mostrar menu

        public void Operacao()
        {
            do
            {
                
                Menu();// chama metodo menu pra mostrar p ususario
                Console.Clear();//limpar dados antigos
                switch (ConsultarOpcao) // escolha
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;
                    case 1:
                        double nota1;//declarei do lado de fora, intanciou cm zero pra dps pedir p guardar a nota, assim while enxerga avaria que esta dentro
                        double nota2;
                        do
                        {
                            Console.WriteLine("Informe a primeira nota");
                            nota1 = Convert.ToDouble(Console.ReadLine()); //pegr texto, convertar p real e guardar na variavel  

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("informe um nota entre 0 e 10");
                            }// fim da validacao 
                        } while (exercicio.ValidarNotas(nota1) == true);


                        do // estrutura de repeticao q ira repetir o processo while(emquanto) validar notas retornar (true) (numero incorreto)
                        {
                            Console.WriteLine("INforme a segunda nota");
                            nota2 = Convert.ToDouble(Console.ReadLine());// converttodouble converte a varivel pra real

                            if (exercicio.ValidarNotas(nota2) == true)// se o metodo validar acusar que o numero esta incorreto (retornar true), executar a mensagem de erro abaixo
                            {
                                Console.WriteLine("informe uma nota entre 0 e 10");
                            }//fim validacao
                        } while (exercicio.ValidarNotas(nota2) == true);

                        //chamar o metodo da media que esta na classe model
                        Console.WriteLine("a media das notas digitadas é" + exercicio.MediaDuasNotas(nota1, nota2));//chamar o metodo mencionando a variavel que representa a classe modelexrcicio (dessa forma acessamos todos os metodos da model), dps passando as variaveis coletdas como parametro no metodo
                        break;
                    case 2:
                        Console.WriteLine("infome um numero");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro numero");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //comparacao
                        Console.WriteLine("O maior numero é " + exercicio.Comparar(num1, num2));
                        break;
                    default:
                        Console.WriteLine("opcao escolhida nao é valida");
                        break;
                    case 3:
                        Console.WriteLine("Informe um numero");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //mostrar resultado
                        Console.WriteLine("O antecessor é" + exercicio.Antecessor(num));
                        break;
                    case 4:
                        Console.WriteLine("informe a altura do retangulo");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a largura do retangulo");
                        double largura = Convert.ToDouble(Console.ReadLine());

                        //mostrar resultado
                        Console.WriteLine("A area do retangulo é" + exercicio.Area(altura, largura));
                        break;
                    case 5:
                        Console.WriteLine("insira o total de eleitores");
                        int total = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("insira a quantidade de votos nulos")

                }//fim do escolha
            } while (ConsultarOpcao != 0);//fim do while
        }//fim do metodo

    }//fim da classe
}//fim do projeto
