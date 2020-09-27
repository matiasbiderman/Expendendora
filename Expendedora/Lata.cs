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
        
      public Lata(string codigo, string nombre, string sabor)
        {
            Codigo = codigo;
            Nombre = nombre;
            Sabor = sabor;
        }
        public Lata()
        {
            
        }
        public string Codigo
        {
            get
            { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Sabor
        {
            get
            { return this._sabor; }
            set { this._sabor = value; }
        }
        public double Precio
        {
            get
            { return this._precio; }
            set { this._precio = value; }
        }
        public double Volumen
        {
            get
            { return this._volumen; }
            set { this._volumen = value; }
        }

        public string Nombre
        {
            get
            { return this._nombre; }
            set { this._nombre = value; }
        }

        public double GetPrecioPorLitro()
        {
            double cantLitrosLata = this._volumen / 1000;
            double precioXLitro = this._precio / cantLitrosLata;
            return precioXLitro; //precio * 1000 / volumen;
        }
        public string DevuelveLata()
        {
            
            return string.Format("Codigo {0}\nNombre {1}\n Sabor {2}\n precio {3}\n volumen {4}", this._codigo, this._nombre, this._sabor, this._precio, this._volumen);
        }
        
        public override string ToString()
        {
            
            return string.Format("Nombre {0} - Sabor {1} - $/L Precio por litro {2}\n", this._nombre, this._sabor, GetPrecioPorLitro());
        }
    }
}
