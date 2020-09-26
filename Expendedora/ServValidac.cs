using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    static class ServValidac
    {
        public static string PedirStrNoVac(string mensaje)
        {

            string valor;
            Console.WriteLine(mensaje);
            do
            {
                valor = Console.ReadLine().ToUpper().Trim();
                if (valor == "")
                {
                    Console.WriteLine("ingrese una opcion valida");
                }
            } while (valor == "");
            return valor;
        }
        public static double PedirDouble(string mensaje)
        {

            double valor;
            Console.WriteLine(mensaje);
            do
            {
                if(!double.TryParse(Console.ReadLine(), out valor))
                {
                    valor = -1;
                }
                if (valor < 0)
                {
                    Console.WriteLine("ingrese una opcion valida");
                }
            } while (valor < 0);

            return valor;
        }
    }
}
