using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        
      public Lata(string codigo, string nombre, string sabor, double precio, double volumen)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._sabor = sabor;
            this._precio=  precio;
            this._volumen = volumen;
        }
        public Lata()
        {
            
        }
        /*public double GetPrecioPorLitro()
        {

        }*/
        public string getCodigo()
        {
            return this._codigo;
        }
        public string getNombre()
        {
            return this._nombre;
        }
        public string DevuelveLata()
        {
            return string.Format("Codigo {0}\nNombre {1}\n Sabor {2}\n precio {3}\n volumen {4}\n", this._codigo, this._nombre, this._sabor, this._precio, this._volumen);
        }
        public override string ToString()
        {
            return string.Format("Nombre {0}\nSabor {1}\n$/L Precio por litro {0}", this._nombre, this._sabor, this._precio);
        }
       

    }
}
