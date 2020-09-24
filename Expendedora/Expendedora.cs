using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    public class Expendedora
    {
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        private List<Lata> _latas;
        private List<DatoLata> _datoslatas;
        private bool llena;

        public Expendedora(string proveedor, int capacidad, double dinero, bool encendida)
        {
            this._proveedor = proveedor;
            this._capacidad = capacidad;
            this._dinero = dinero;
            this._encendida = false;
            DatosLata();
        }
        public Expendedora()
        {
            this._encendida = false;
            this._latas = new List<Lata>();
            llena = false;
            this._datoslatas = new List<DatoLata>();
            DatosLata();
        }
        
        
        public bool GetEstadoMaquina
        {
            get
            {
                return this._encendida;
            }
        }
        public string EncenderMaquina() //mio
        {
            this._encendida = true;
            return "LA MAQUINA ESTA ENCENDIDA,PUEDE EMPEZAR A OPERAR";
        }
        public string ListarLata() //mio
        {
            string lista = "";
            foreach (DatoLata dato in _datoslatas)
            {
                lista = lista + dato.Codigodato + "\t" + dato.NombreDato + "\t" + dato.SaborDato + "\n";
            }

            return lista;
        }
        public DatoLata ValidoCodigo(string codigo)
        {
            DatoLata dato;
            bool encuentra = false;
            int pos = 0;
            for (int i = 0; i < _datoslatas.Count; i++)
            {
                if (codigo == _datoslatas[i].Codigodato)
                {
                    pos = i;
                    encuentra = true;
                }
                
                
            }
            /*foreach (DatoLata dat in _datoslatas)
            {
                if (codigo == dat.Codigodato)
                {
                    encuentra = true;
                }
                pos++;
            }
            */
            if (encuentra)
            {
                dato = _datoslatas[pos];
            }
            else
            {
                dato = null;
            }
            
            return dato;
        }

         public void AgregarLata(Lata lata)
         {
            _latas.Add(lata);
            foreach (Lata la in _latas)
            {
                Console.WriteLine(la.DevuelveLata());
            }
            this._capacidad--;
         }
        /* public Lata ExtraerLata(string cc, double xx)
          {

          }
          public string GetBalance()
          {

          }
          public int GetCapacidadRestante()
          {

          }
          */
          public bool Estavacia()
          {
            
            if (this._capacidad == 0)
                llena = true;
            else
                llena = false;

            return llena;
          }
          
        private void DatosLata()
        {
            _datoslatas.Add(new DatoLata("CO1", "Coca Cola", "Regular"));
            _datoslatas.Add(new DatoLata("CO2", "Coca Cola", "Zero"));
            _datoslatas.Add(new DatoLata("SP1", "Sprite", "Regular"));
            _datoslatas.Add(new DatoLata("SP2", "Sprite", "Zero"));
            _datoslatas.Add(new DatoLata("FA1", "Fanta", "Regular"));
            _datoslatas.Add(new DatoLata("FA2", "Fanta", "Zero"));
        }

    }
}
