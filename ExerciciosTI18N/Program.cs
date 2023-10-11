using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
     class Program
    {
        static void Main(string[] args)
        {
            //conectar a control com a prigram
            ControlFormulario control = new ControlFormulario(); // instanciando a variavel p usar os metodos da classe
            control.Operacao();

            //manter aberto
            Console.ReadLine();
        }//fim do metodo main
    }//fim da classe program
}//fim do projeto

