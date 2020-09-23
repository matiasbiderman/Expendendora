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
            const string InsertarLata = "IL";
            const string ElegirLata = "EL";
            const string ConocerBalance = "CB";
            const string ConocerStock = "CS";
            const string Salir = "S";

            string opcion = "";

            Expendedora exp = new Expendedora();

            do
            {
                opcion = ServValidac.PedirStrNoVac("Ingrese opción:\n"
                    + EncenderMaquina + ": Encender Maquina\n"
                    + InsertarLata + ": Insertar lata\n"
                    + ListarLatas + ": Listar lata\n"
                    + ElegirLata + ": Elegir Lata\n"
                    + ConocerBalance + ": Conocer Balance\n"
                    + ConocerStock + ": Conocer Stock\n"
                    + Salir + ": Salir", exp);

                switch (opcion)
                {
                    case EncenderMaquina:
                        exp.EncenderMaquina();
                        break;
                    case ListarLatas:
                        Console.WriteLine(exp.ListarLata());
                        break;
                     /*case InsertarLata:
                        Emitir(CtrMillas.TipoVuelo);
                        break;
                    
                    case ElegirLata:
                        Emitir(CtrMillas.TipoCrucero);
                        break;
                    case ConocerBalance:
                        Emitir(CtrMillas.TipoVouSalon);
                        break;
                    case ConocerStock:
                        Emitir(CtrMillas.TipoVouSalon);
                        break;*/
                    case Salir:
                        break;
                    default:
                        Console.WriteLine("Opción no existente");
                        break;
                }

            } while (opcion != Salir);
        }
       /* public static void IngresarLata(Expendedora exp)
        {
            exp.AgregarLata();
        }
        static void ExtraerLata(Expendedora exp)
        {
            exp.ExtraerLata()
        }
        static void ObtenerBalanceLata()
        {

        }
        static void MostrarStock()
        {

        }*/
    }
}
