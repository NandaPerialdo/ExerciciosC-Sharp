using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //exercicio 3 pegar um numero e mostrar o antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim antecessor

        //exercicio 4 - ler as dimensoes do retalgulo e escrever a area

        public double Area(double altura, double largura)
        {
            return altura * largura;
        }//fim exercicio area

        //exercicio 5 - ler o numero total de eleitores, votos brancos, nulos e validos
        //calcular e escrever o percentual que cada um representa em relacao ao total 
        //de eleitores

        public float PercentualVotos(int total,int qtVotos)
        {
            return (qtVotos / total) * 100;
        }








    }//fim da classe
}//fim do projeto

