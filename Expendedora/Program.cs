using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    class Program
    {
        static void Main(string[] args)
        {

            const string EncenderMaquina = "EM";
            const string ListarLatas = "LL";
            const string insertarLata = "IL";
            const string elegirLata = "EL";
            const string conocerBalance = "CB";
            const string conocerStock = "CS";
            const string Salir = "S";

            string opcion = "";

            Expendedora exp = new Expendedora();

            do
            {
                opcion = ServValidac.PedirStrNoVac("Ingrese opción:\n"
                    + EncenderMaquina + ": Encender Maquina\n"
                    + insertarLata + ": Insertar lata\n"
                    + ListarLatas + ": Listar lata\n"
                    + elegirLata + ": Elegir Lata\n"
                    + conocerBalance + ": Conocer Balance\n"
                    + conocerStock + ": Conocer Stock\n"
                    + Salir + ": Salir");

                    switch (opcion)
                    {
                        case EncenderMaquina:
                        if (exp.GetEstadoMaquina == true)
                        {
                            Console.WriteLine("LA MAQUINA YA SE ENCUENTRA ENCENDIDA, REALICE UNA ACCION");
                        }
                        else
                        {
                            Console.WriteLine(exp.EncenderMaquina());
                        }
                        break;
                        case ListarLatas:
                        if (opcion != EncenderMaquina && !exp.GetEstadoMaquina)
                        {
                            Console.WriteLine("no puede utilizar la maquina sin prenderla");
                        }
                        else
                        {
                            Console.WriteLine(exp.ListarLata());
                        }
                            break;
                        case insertarLata:
                        if (opcion != EncenderMaquina && !exp.GetEstadoMaquina)
                        {
                            Console.WriteLine("no puede utilizar la maquina sin prenderla");
                        }
                        else
                        {
                            InsertarLata(exp);
                        }
                            break;

                        case elegirLata:
                        if (opcion != EncenderMaquina && !exp.GetEstadoMaquina)
                        {
                            Console.WriteLine("no puede utilizar la maquina sin prenderla");
                        }
                        else
                        {
                           // Elegir(exp);
                        }
                        break;
                        case conocerBalance:
                        if (opcion != EncenderMaquina && !exp.GetEstadoMaquina)
                        {
                            Console.WriteLine("no puede utilizar la maquina sin prenderla");
                        }
                        else
                        {
                            ObtenerBalance(exp);
                        }
                        break;
                        case conocerStock:
                        if (opcion != EncenderMaquina && !exp.GetEstadoMaquina)
                        {
                            Console.WriteLine("no puede utilizar la maquina sin prenderla");
                        }
                        else
                        {
                            MostrarStock(exp);
                        }
                        break;
                        case Salir:
                            break;
                        default:
                            Console.WriteLine("Opción no existente");
                            
                            break;
                    }

            } while (opcion != Salir);
        }
       private static void InsertarLata(Expendedora exp)
        {
            DatoLata datolata = new DatoLata();
            Console.WriteLine(exp.ListarLata());
            bool encuentracodigo = false;


           do
            {
                encuentracodigo = false;
                string codigo = ServValidac.PedirStrNoVac("Ingrese el codigo de la lata disponible");
                datolata = exp.ValidoCodigo(codigo);
             if (datolata == null)
             {
                 Console.WriteLine("No se encuentra el codigo de lata solicitado, ingrese nuevamente");

             }
             else
             {
                double precio = ServValidac.PedirDouble("Ingrese el precio de la lata");
                    double volumen = ServValidac.PedirDouble("Ingrese el volumen de la lata");
                    Lata lata = new Lata(codigo, datolata.NombreDato, datolata.SaborDato, precio, volumen);
                    exp.AgregarLata(lata);
              } 
            } while (datolata == null);









            //}


            //exp.AgregarLata();
        }
        private static void ExtraerLata(Expendedora exp)
        {
           // exp.ExtraerLata()
        }
        private static void ObtenerBalance(Expendedora exp)
        {

        }
        private static void MostrarStock(Expendedora exp)
        {

        }
        
    }
}
