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
            const string extraerLata = "EL";
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
                    + extraerLata + ": Extraer Lata\n"
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
                    case extraerLata:
                        if (opcion != EncenderMaquina && !exp.GetEstadoMaquina)
                        {
                            Console.WriteLine("no puede utilizar la maquina sin prenderla");
                        }
                        else
                        {
                            ExtraerLata(exp);
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
            Lata lata = new Lata();
            Console.WriteLine(exp.ListarLata());
            bool encuentracodigo = false;

            do
            {
                //ACA TIENEN QUE HABER EXCEPCION DEL CODIGO
                encuentracodigo = false;
                if (exp.CapacidadDisponible())
                {
                    string codigo = ServValidac.PedirStrNoVac("Ingrese el codigo de la lata disponible");
                    datolata = exp.ValidoCodigo(codigo);

                    if (datolata != null)
                    {
                        lata.Precio = ServValidac.PedirDouble("Ingrese el precio de la lata");
                        lata.Volumen = ServValidac.PedirDouble("Ingrese el volumen de la lata");
                        lata.Codigo = datolata.Codigodato;
                        lata.Nombre = datolata.NombreDato;
                        lata.Sabor = datolata.SaborDato;
                        exp.AgregarLata(lata);
                    }
                    else
                    {
                        Console.WriteLine("No se encuentra el codigo de lata solicitado, ingrese nuevamente");
                    }
                }
                else
                {
                    Console.WriteLine("No hay capacidad para mas latas");
                }

            } while (datolata == null);
        }
        private static void ExtraerLata(Expendedora exp)
        {
            DatoLata datolata = new DatoLata();
            Lata lata = new Lata();
            Console.WriteLine(exp.ListarLata());
            string codigo = ServValidac.PedirStrNoVac("Ingrese el codigo de la lata disponible");
            datolata = exp.ValidoCodigo(codigo);

            if (datolata != null)
            {
                if (exp.getStockByCodigo(codigo) > 0)
                {
                    double dinero = ServValidac.PedirDouble("Ingrese el dinero que tiene para pagar la lata");
                    lata = exp.ExtraerLata(datolata.Codigodato, dinero);

                    if (lata == null)
                    {
                        Console.WriteLine("No le alcanza el dinero, intente extraer nuevamente colocando el dinero correcto");
                        //throw new Exception("No le alcanza el dinero");
                    }
                    else
                    {
                        
                       Console.WriteLine("la lata que esta agarrand es " + lata.Codigo + " con un precio de " + lata.Precio);
                        Console.WriteLine("Su vuelto es " + exp.Vuelto);
                        Console.WriteLine("el dinero acumulado por la expendedora es " + exp.Dinero);
                    }
                }
                else
                {
                    Console.WriteLine("Sin stock para " + codigo);
                }
            }
            else
            {
                Console.WriteLine("No se encuentra el codigo de lata solicitado, ingrese nuevamente");
            }
        }
        private static void ObtenerBalance(Expendedora exp)
        {
            Console.WriteLine(exp.GetBalance());
        }
        private static void MostrarStock(Expendedora exp)
        {
            Console.WriteLine(exp.MuestroStock());
        }
    }
}