using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class DatoLata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
       /* private string[] codigos = { "CO1", "CO2", "SP1", "SP2", "FA1", "FA2" };
        private string[] nombres = { "CO1", "CO2", "SP1", "SP2", "FA1", "FA2" };
        private string[] sabores = new string[6];*/
        public DatoLata(string codigo, string nombre, string sabor)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._sabor = sabor;
        }

        public DatoLata()
        {
        }
        
        public string Codigodato
        {
            get { return this._codigo; }
            set
            {
                this._codigo = value;
            }
        }
        public string NombreDato
        {
            get { return this._nombre; }
            set
            {
                this._nombre = value;
            }
        }
        public string SaborDato
        {
            get { return this._sabor; }
            set
            {
                this._sabor = value;
            }
        }
    }
}
