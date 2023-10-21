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
                               "7.exercicio 7\n" +
                               "8.exercicio 8\n" +
                               "9.exercicio 9\n" +
                               "10.exercicio 10\n" +
                               "11.exercicio 11\n" +
                               "12.exercicio 12\n" +
                               "13.exercicio 13\n" +
                               "14.exercicio 14\n" +
                               "15.exercicio 15\n" +
                               "16.exercicio 16\n" +
                               "17.exercicio 17\n" +
                               "18.exercicio 18\n" +
                               "19.exercicio 19\n" +
                               "20.exercicio 20\n" +
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
                    case 1://exercicio 1
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
                        //exercicio 2
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
                    case 3:// exercicio 3



                        break;
                    case 4:
                        int idCor;
                        //exibindo menu e coletando numero correspondente a cor que deseja ser consultada
                        do
                        {
                            Console.WriteLine("Digite o numero da cor que deseja consultar:\n" +
                                              "1.Verde\n" +
                                              "2.Azul\n" +
                                              "3.Amarelo\n" +
                                              "4.Vermelho\n");
                            idCor = Convert.ToInt32(Console.ReadLine());
                            if (exercicio.ValidarCor(idCor) == true)
                            {
                                Console.WriteLine("Erro, insira um numero entre 1 e 4");
                            }
                        } while (exercicio.ValidarCor(idCor) == true);

                        Console.WriteLine("O preço dessa categoria é: R$ " + exercicio.PrecoCd(idCor));
                        break;
                    case 5:
                        //exercicio 5
                        Console.WriteLine("Informe um numero");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //mostrar resultado
                        Console.WriteLine("O antecessor é" + exercicio.Antecessor(num));
                        break;
                    case 6:
                        //exercicio 6
                        double altura;
                        double largura;
                        do {

                            Console.WriteLine("informe a altura do retangulo");
                            altura = Convert.ToDouble(Console.ReadLine());
                            if (altura < 0)
                            {
                                Console.WriteLine("Erro, insira um numero maior que zero");
                            }
                        } while (altura > 0);

                        do {

                            Console.WriteLine("Informe a largura do retangulo");
                            largura = Convert.ToDouble(Console.ReadLine());
                            if (largura < 0)
                            {
                                Console.WriteLine("Erro, insira um valor maior que zero");
                            }

                        } while (largura > 0);

                        //exibir resultado    
                        Console.WriteLine("A area do retangulo é" + exercicio.Area(altura, largura));
                        break;
                    case 7:
                        //exercicio 7
                        //coletando dados que serão usados no metodo e guardando em variaveis locais
                        //declarando variaveis
                        double total;
                        double qtNulos;
                        double qtBrancos;
                        double qtValidos;


                        do {//entrada e validação de total de votos
                            Console.WriteLine("insira o total de eleitores");
                            total = Convert.ToInt32(Console.ReadLine());

                            if (total <= 0)
                            {
                                Console.WriteLine("Erro, insira um total de eleitores maior que zero");
                            }
                        } while (total <= 0);

                        do {//entrada e validacao de votos nulos
                            Console.WriteLine("insira a quantidade de votos nulos: ");
                            qtNulos = Convert.ToInt32(Console.ReadLine());

                            if (qtNulos < 0)
                            {
                                Console.WriteLine("Erro, os votos nao podem ser negativos");
                            }
                        } while (qtNulos <= 0);

                        do { // entrada e validacao de votos brancos
                            Console.WriteLine("Insira a quantidade de votos brancos: ");
                            qtBrancos = Convert.ToInt32(Console.ReadLine());

                            if (qtBrancos < 0)
                            {
                                Console.WriteLine("Erro, os votos nao podem ser negativos");
                            }
                        } while (qtBrancos <= 0);

                        do
                        { // entrada e validacao de votos validos
                            Console.WriteLine("Insira a quantidade de votos válidos");
                            qtValidos = Convert.ToInt32(Console.ReadLine());

                            if (qtValidos < 0)
                            {
                                Console.WriteLine("Erro, os votos nao podem ser negativos");
                            }
                        } while (qtValidos <= 0);

                        //validando se a soma de votos nulos, validos e brancos, batem com o total de eleitores   
                        if (qtNulos + qtBrancos + qtValidos == total)
                        {
                            //mostrando resultado, calculado a partir do metodo PercentualVotos criado na aba ModelExercicio
                            Console.WriteLine("O percentual de votos nulos é: " + exercicio.PercentualVotos(total, qtNulos) + "%");
                            Console.WriteLine("O percentual de votos nulos é: " + exercicio.PercentualVotos(total, qtBrancos) + "%");
                            Console.WriteLine("O percentual de votos nulos é: " + exercicio.PercentualVotos(total, qtValidos) + "%");
                        }
                        else
                        {
                            Console.WriteLine("A soma de votos nulos, brancos e validos deve ser igual ao total de votos");
                        }
                        break;
                    case 8:
                        //exercicio 8
                        //declarando variaveis
                        double salario;
                        double reajuste;
                        //coletando dados e validando, usando um metodo de validaçao criado em model
                        do
                        {
                            Console.WriteLine("Insira o salario");
                            salario = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(salario) == true)
                            {
                                Console.WriteLine("Erro! O salario precisa ser positivo maior que zero");
                            }
                        } while (exercicio.ValidarMaiorZero(salario) == true);

                        do
                        {
                            Console.WriteLine("Insira o reajuste");
                            reajuste = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(reajuste) == true)
                            {
                                Console.WriteLine("Erro!o porcentual precisa ser positivo maior que zero");
                            }
                        } while (exercicio.ValidarMaiorZero(reajuste) == true);

                        Console.WriteLine("O salário com reajuste é igual a: " + (exercicio.Reajuste(salario, reajuste)));
                        break;
                    case 9://exercicio 9
                        //declarando as variaveis
                        double custo;
                        double pImposto;
                        double pDistribuidor;

                        do//coletando e validando o custo (validacão a partir do metodo VaidarMaiorZero, que retorna true sempre
                          //que o valor que entra em custo é menor ou igual a zero
                        {
                            Console.WriteLine("Insira o valor do custo de fábrica do carro");
                            custo = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(custo) == true)
                            {
                                Console.WriteLine("Erro, o custo de fabrica precisa ser positivo e maior que zero");
                            }
                        } while (exercicio.ValidarMaiorZero(custo) == true);

                        do//coletando e validando pimposto
                        {
                            Console.WriteLine("Insira a porcentagem de Impostos");
                            pImposto = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(pImposto) == true)
                            {
                                Console.WriteLine("Erro, a porcentagem precisa ser maior que zero");
                            }
                        } while (exercicio.ValidarMaiorZero(pImposto) == true);

                        do//coletando a validando pdistribuidor
                        {
                            Console.WriteLine("Insira a porcentagem do distribuidor");
                            pDistribuidor = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(pDistribuidor) == true)
                            {
                                Console.WriteLine("Erro, a porcentagem precisa ser maior que zero");
                            }
                        } while (exercicio.ValidarMaiorZero(pDistribuidor) == true);

                        //calculando e exibindo o valor do carro usando o metodo ValorCarro com a regra de negocio criado em modelexercicio 
                        Console.WriteLine("O valor do carro ao consumidor é: " + exercicio.ValorCarro(custo, pDistribuidor, pImposto));
                        break;
                    case 10://exercicio 10
                        //declarar variaveis que serao usadas
                        double salarioV;
                        double valorCarro;
                        double carrosVendidos;
                        double comissao;
                        double totalVendas;

                        do//coletando salario e validando, usando metodo de validacao validarmaiorzero
                        {
                            Console.WriteLine("Insira o salario do vendedor:");
                            salarioV = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(salarioV) == true)
                            {
                                Console.WriteLine("Erro, o salario precisa ser maior que zero");
                            }
                        } while (exercicio.ValidarMaiorZero(salarioV) == true);

                        do//coletando valor total de vendas em dinheiro e validando para que seja positivo, usando metodo validado ValidarPositivo, cirado na model
                        {
                            Console.WriteLine("Insira o VALOR(R$) total de vendas do funcionário");
                            totalVendas = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarPositivo(totalVendas) == true)
                            {
                                Console.WriteLine("Erro! O valor total de vendas nao pode ser negativo");
                            }
                        } while (exercicio.ValidarPositivo(totalVendas) == true);

                        do//coletando a quantidade de carros vendidos e validando para que nao sejam negativos usando o metodo validar positivo criado na model
                        {
                            Console.WriteLine("Insira a quantidade de carros vendidos");
                            carrosVendidos = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarPositivo(carrosVendidos) == true)
                            {
                                Console.WriteLine("Erro, a quantidade de carros vendidos nao pode ser negativa");
                            }
                        } while (exercicio.ValidarPositivo(carrosVendidos) == true);

                        do//coletando o valor recebido por carro vendido e validando para que seja positivo
                        {
                            Console.WriteLine("Insira o valor recebido por carro vendido");
                            valorCarro = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarPositivo(valorCarro) == true)
                            {
                                Console.WriteLine("Erro, o valor recebido por carro vendido nao pode ser negativo");
                            }
                        } while (exercicio.ValidarPositivo(valorCarro) == true);

                        do//coletando o porcentual de comissao e validando para que nao seja negativo
                        {
                            Console.WriteLine("Insira o percentual de comissao para o funcionario:");
                            comissao = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarPositivo(comissao) == true)
                            {
                                Console.WriteLine("Erro, o porcentual de comissao nao pode ser negativo");
                            }
                        } while (exercicio.ValidarPositivo(comissao) == true);

                        //realizando calculo a partir do metodo criado na model e exibindo na tela
                        Console.WriteLine("O salário final do vendedor é:" + exercicio.SalarioVendedor(salarioV, valorCarro, carrosVendidos, comissao, totalVendas));
                        break;
                    case 11:// exercicio 11
                        // declarando variaveis
                        double numero = 0;

                        //coletando numero e validando
                        do
                        {
                            Console.WriteLine("Insira um numero");
                            numero = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarPositivo(numero) == true)
                            {
                                Console.WriteLine("Insira um numero positivo");
                            }
                        } while (exercicio.ValidarPositivo(numero) == true);

                        //verificando se é impar ou nao, a partir de um metodo criado na model
                        if (exercicio.CalcularImpar(numero) == true)
                        {
                            Console.WriteLine("Este numero é impar");
                        }
                        else
                        {
                            Console.WriteLine("Esse numero é par");
                        }
                        break;
                    case 12://exercicio 12
                        //declarando variaveis
                        double idade = 0;
                        //coletando dado e validando
                        do
                        {
                            Console.WriteLine("Insira sua idade");
                            idade = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarMaiorZero(idade) == true)
                            {
                                Console.WriteLine("Erro! A idade nao pode ser negativa");
                            }
                        } while (exercicio.ValidarMaiorZero(idade) == true);

                        //verificar se é menor de idade a partir do metodo criado e exibir mensagem na tela
                        if (exercicio.CalcMenorIdade(idade) == true)
                        {
                            Console.WriteLine("Você é menor de idade");
                        }
                        else
                        {
                            Console.WriteLine("Você é maior de idade");
                        }
                        break;
                    case 13://exercicio 13



                        break;
                    case 14://exercicio 14



                        break;
                    case 15://exercicio 15
                        //declarando variaveis
                        double nt1 = 0;
                        double nt2 = 0;
                        double notaFinal = 0;

                        //coletar notas e validar
                        do
                        {
                            Console.WriteLine("Insira a primeira nota do aluno");
                            nt1 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarNotas(nt1) == true)
                            {
                                Console.WriteLine("Erro, insira um nota entre 0 e 10");
                            }
                        } while (exercicio.ValidarNotas(nt1) == true);

                        do
                        {
                            Console.WriteLine("Insira a segunda nota do aluno");
                            nt2 = Convert.ToDouble(Console.ReadLine());
                            if (exercicio.ValidarNotas(nt2) == true)
                            {
                                Console.WriteLine("Erro, insira um nota entre 0 e 10");
                            }
                        } while (exercicio.ValidarNotas(nt2) == true);

                        //calcular media e guardar em variavel
                        notaFinal = exercicio.MediaDuasNotas(nt1, nt2);

                        //exibir situaçao, verificada atraves de um metodo. passando a variavel que guarda o resultado da media
                        //calculado acima, como parametro no metodo responsavel por verificar a situacao do aluno
                        if (exercicio.SituacaoAluno(notaFinal) == true)
                        {
                            Console.WriteLine("Você foi reprovado!");
                        }
                        else
                        {
                            Console.WriteLine("Você foi aprovado!");
                        }
                        break;
                    case 16://exercicio 16


                        break;
                    case 17://exercicio 17
                        //declarando variavel
                        double n = 0;
                        //coletando numero
                        Console.WriteLine("Insira um numero");
                        n = Convert.ToDouble(Console.ReadLine());

                        if (n == 0)//verificando primeiro se o numero é igual a zero
                        {
                            Console.WriteLine("O número digitado é zero");
                        }
                        else//se nao for zero, realizar uma validaçao para descobrir se é positivo
                        {
                            if (exercicio.Validar(n) == true)//o metodo validar retorna true quando o numero é negativo
                            {
                                Console.WriteLine("O numero digitado é negativo");
                            }
                            else//o metodo validar retorna false quando é positivo
                            {
                                Console.WriteLine("O numero digitado é positivo");
                            }
                        } 
                        break;
                    case 18://exercicio 18
                      


                        break;
                    case 19:

                        break;
                }//fim do escolha
            } while (ConsultarOpcao != 0);//fim do while
        }//fim do metodo

    }//fim da classe
}//fim do projeto
