using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    static class ServValidac
    {
        public static string PedirStrNoVac(string mensaje, Expendedora exp)
        {

            string valor;
            Console.WriteLine(mensaje);
            do
            {
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine("ingrese una opcion valida");
                }
                if(valor != "" && valor != "EM" && !exp.GetEstadoMaquina)
                {
                    Console.WriteLine("no puede utilizar la maquina sin prenderla");
                }

            } while (valor == "" || (valor != "EM" && !exp.GetEstadoMaquina));
            return valor;
        }
    }
}
