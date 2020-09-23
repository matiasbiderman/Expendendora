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

        public Expendedora(string proveedor, int capacidad, double dinero, bool encendida)
        {
            this._proveedor = proveedor;
            this._capacidad = capacidad;
            this._dinero = dinero;
            this._encendida = false;
            
        }
        public Expendedora()
        {
            this._encendida = false;
            this._latas = new List<Lata>();
        }
        private void CargaInicialLata()
        {
            _latas.Add(new Lata("CO1", "Coca Cola Regular"));
            _latas.Add(new Lata("CO2", "Coca Cola Zero"));
            _latas.Add(new Lata("SP1", "Sprite Regular"));
            _latas.Add(new Lata("SP2", "Sprite Zero"));
            _latas.Add(new Lata("FA1", "Fanta Regular"));
            _latas.Add(new Lata("FA2", "Fanta Zero"));
        }
        
        public bool GetEstadoMaquina
        {
            get
            {
                return this._encendida;
            }
        }
        public void EncenderMaquina()
        {
            this._encendida = true;
        }
        public string ListarLata()
        {
            string lista = "";
            CargaInicialLata();
            foreach (Lata lat in _latas)
            {
                lista = lista + lat.getCodigo() + " - " + lat.getNombre() + "\n";
            }

            return lista;
               
        }
        /* public void AgregarLata(Lata lata)
         {

         }
         public Lata ExtraerLata(string, double)
         {

         }
         public string GetBalance()
         {

         }
         public int GetCapacidadRestante()
         {

         }

         public bool Estavacia()
         {

         }*/


    }
}
