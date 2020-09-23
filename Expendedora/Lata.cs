using System;
using System.Collections.Generic;
using System.Linq;
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

        public Lata(string codigo, string nombre)
        {
            this._codigo = codigo;
            this._nombre=  nombre;
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
        public override string ToString()
        {
            return string.Format("Nombre {0}\nSabor {1}\n$/L Precio por litro {0}", this._nombre, this._sabor, this._precio);
        }
    }
}
