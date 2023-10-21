using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExerciciosTI18N
{
    internal class ModelExercicio
    {
        public ModelExercicio()
        {

        }//fim do construtor (metodo principal da classe)

        //exercicio 1 - a media de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }// fim do metodo media

        //metodo de validacao
        public Boolean ValidarNotas(double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//fim do metodo

        //exercicio 2 comparar 2 numero e retornar o maior

        public int Comparar(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//fim do comparar

        //exercicio 3 - Em uma escola, a média final é dada pela média aritmética de três
        //notas.E a mesma tem o seguinte esquema de avaliação:
        //Desenvolva um algoritmo que a partir da entrada das três notas mostre a
        //situação do aluno.No caso do aluno em recuperação e prova final,
        //mostre também quanto o aluno irá precisar para passar.No caso da
        //recuperação a nota necessária para passar é dada por 10 – Média + 2 e
        //na prova final é dado por 10 – Média.

        public double Media3Notas(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }//fim do metodo media3notas

        //validacao
        public Boolean ValidarZeroEDez (double nota)
        {
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
                return false;
        }//fim do metodo validar entre zero e dez

        //calculo de media
        public double MediaTresNotas(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3)/3;
        }

        //retornar situacao do aluno
        



        //exercicio 4
        //Em uma loja e CD´s existem apenas quatro tipos de preços que estão
        //associados a cores.Assim os CD´s que ficam na loja não são marcados
        //por preços e sim por cores. Desenvolva o algoritmo que a partir a entrada
        //da cor o software mostre o preço.A loja está atualmente com a seguinte
        //tabela de preços:
        //Verde R$10,00 
        // Azul R$20,00 
        //marelo R$30,00
        //Vermelho R$40,0

        public double PrecoCd(int idCor)
        {
            if (idCor == 1)//1 será o identificador da cor verde
            {
                return 10.00;
            }
            if (idCor == 2)//2 será o identificador da cor azul
            {
                return 20.00;
            }
            if (idCor == 3)//3 será o identificador da cor amarelo
            {
                return 30.00;
            }
            else
            {
                return 40;//a unica opcao restanto é o vermelho
            }
        }

        public Boolean ValidarCor(double cor)
        {
            if ((cor <= 0) || (cor > 4))
            {
                return true;
            }
                return false;
        }




        //exercicio 5 pegar um numero e mostrar o antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim antecessor

        //exercicio 6 - ler as dimensoes do retangulo e escrever a area

        public double Area(double altura, double largura)
        {
            return altura * largura;
        }//fim exercicio area

        //exercicio 7 - ler o numero total de eleitores, votos brancos, nulos e validos
        //calcular e escrever o percentual que cada um representa em relacao ao total 
        //de eleitores

        public double PercentualVotos(double total,double qtVotos)
        {
            return (qtVotos / total) * 100;
        }//fim do metodo de porcentagem


        //exercicio 8 - ler salario mensal atual de um funcionario e o percentual de reajuste
        //calcular e escrever o valor do salario ajustado

        public double Reajuste(double salario, double reajuste)
        {
            return ((reajuste / 100) * salario) + salario;
        }

        //metodo de validaçao
        public Boolean ValidarMaiorZero(double num)
        {
            if (num <= 0)
            {
                return true;
            }
                return false; 
        }

        //exercicio 9 - O custo de um carro novo ao consumidor é a soma do custo de fábrica
        //com a porcentagem do distribuidor e dos impostos(aplicados ao custo
        //de fábrica). Supondo que o percentual do distribuidor seja de 28% e os
        //impostos de 45%, escrever um algoritmo para ler o custo de fábrica de
        //um carro, calcular e escrever o custo final ao consumidor.

        public double ValorCarro(double custo, double pDistribuidor, double pImpostos)
        {
            return (((pDistribuidor / 100) * custo) + (pImpostos / 100) * custo) + custo;
        }

        // exercicio 10 - Uma revendedora de carros usados paga a seus funcionários
        // vendedores um salário fixo por mês, mais uma comissão também fixa
        //para cada carro vendido e mais 5 % do valor das vendas por ele
        // efetuadas.Escrever um algoritmo que leia o número de carros por ele
        //vendidos, o valor total de suas vendas, o salário fixo e o valor que ele
        //recebe por carro vendido. Calcule e escreva o salário final do vendedor.

        public double SalarioVendedor(double salarioV, double valorCarro, double carrosVendidos, double comissao, double totalVendas)
        {
            return salarioV + (valorCarro * carrosVendidos) + (comissao / 100) * totalVendas;
        }//fim do metodo salario vendedor

        public Boolean ValidarPositivo(double num)
        {
            if (num < 0)
            {
                return true;
            }
            return false;
        }//fim do metodo validarpositivo

        //exercicio 11 - Escreva um programa que verifica se um número é par ou ímpar e exibe a mensagem apropriada.

        public Boolean CalcularImpar (double num)
        {
            if (num%2 > 0)
            {
                return true;
            }
                return false;
        }//fim do metodo calcular impar

        //exercicio 12 - Crie um programa que recebe a idade de uma pessoa e determina se
        //ela é maior de idade(idade >= 18) ou menor de idade(idade< 18).

        public Boolean CalcMenorIdade (double idade)
        {
            if (idade < 18)
            {
                return true;
            }
                return false;
        }

        //exercicio 13 - Desenvolva um programa que pede ao usuário para digitar três números e exiba o maior deles.

        //exercicio 14 - Faça um programa que verifica se um ano é bissexto.
        //Um ano bissexto é divisível por 4, exceto os anos que são divisíveis por 100, a menos que sejam divisíveis por 400.

        //exercicio 15 - Escreva um programa que recebe as notas de um aluno em duas provas e calcula a média.
        //Se a média for maior ou igual a 7, o programa deve exibir "Aprovado"; caso contrário, deve exibir "Reprovado".

        public Boolean SituacaoAluno (double notaFinal)
        {
            if (notaFinal < 7)
            {
                return true;//se reprovado
            }
            else
            {
                return false;//se aprovado
            }
        }//fim metodo situaçaoaluno

        //exercicio 16 - Crie um programa que determine se um triângulo é equilátero (todos os lados iguais),
        //isósceles (dois lados iguais)
        //ou escaleno (todos os lados diferentes) com base nos valores dos lados informados pelo usuário.

        //exercicio 17 - Desenvolva um programa que peça ao usuário para inserir um número e, em seguida,
        //exiba se o número é positivo, negativo ou zero.

        public Boolean Validar(double n)
        {
            if (n < 0)
            {
                return true;
            }
            return false;
        }

        //exercicio 18 - Faça um programa que recebe um mês (em formato numérico) e exibe o número
        //de dias que ele tem. Lembre-se de lidar com anos bissextos.




    }//fim da classe
}//fim do projeto

