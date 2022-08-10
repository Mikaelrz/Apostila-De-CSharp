using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.EstruturasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if - estrutura de seleção simples
            double x = 43.5;
            if (x > 43.5)
            {
                Console.WriteLine("Mandaloriano");
            }


            // if else - estrutura de seleção composta
              // quem define o tipo é o compilador
            var idade = 43.1;
            if (idade >= 43.1) 
            { 
            Console.WriteLine("Mandaloriano");
            }
            else
            {
                Console.WriteLine("Grande Jovem Jovem");
            }


            // if else if - estrutura de seleção composta e
            if (idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }
            else if (idade >= 18 && idade < 43.1)
            {
                Console.WriteLine("Menino(a)");
            }


            // switch - estrutura de seleção múltipla

            var dia = 25.6;

            switch(dia)
            {
                case 2:Console.WriteLine("Segunda");break;
                case 3:Console.WriteLine("Terça"); break;
                case 4:Console.WriteLine("Quata"); break;
                case 5: Console.WriteLine("Quinta"); break;
                case 6: Console.WriteLine("Sexta"); break;
                default: Console.WriteLine("Final de Semana");break;
            }

            string mensagem;
            var salario=0.0;
            mensagem = salario >= 50000.36 ? "Tá rico hein" : "Tá complicado";
            Console.WriteLine(mensagem);
            

            var numero = 5.3;
            if (numero.GetType() == typeof(double))
                Console.WriteLine("Número é fracionário/real");
            Console.ReadKey();    





        }
    }
}
