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
        private const int _capacidad = 3;
        private double _dinero;
        private bool _encendida;
        private double _vuelto;
        private List<Lata> _latas;
        private List<DatoLata> _datoslatas;
        private bool llena;

        public Expendedora(string proveedor, double dinero, bool encendida)
        {
            this._proveedor = proveedor;
            this._dinero = dinero;
            this._encendida = false;
            _latas = new List<Lata>();
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
        public double Dinero
        {
            get
            { return this._dinero; }
            set
            {
                this._dinero = value;
            }
        }
        public double Vuelto
        {
            get
            { return this._vuelto; }
            set
            {
                this._vuelto = value;
            }
        }
        public int Capacidad
        {
            get
            { return _capacidad; }
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
            foreach (DatoLata datolata in _datoslatas)
            {
                lista = lista + datolata.Codigodato + "\t" + datolata.NombreDato + "\t" + datolata.SaborDato + "\n";
            }
            return lista;
        }
        public DatoLata ValidoCodigo(string codigo)
        {
            bool encuentra = false;
            for (int i = 0; i < _datoslatas.Count; i++)
            {
                if (codigo == _datoslatas[i].Codigodato)
                {
                    return _datoslatas[i];
                }
            }
            return null;
        }
        public int getStockByCodigo(string codigo)
        {
            return _latas.Where(l => l.Codigo == codigo).Count();
        }
        public void AgregarLata(Lata lata)
        {
            if (GetCapacidadRestante() != 0)
            {
                _latas.Add(lata);
                Console.WriteLine(getStockByCodigo(lata.Codigo));
            }
            else
            {
                throw new CapacidadInsuficienteException();
            }           
        }
        public bool CapacidadDisponible()
        {
            return Capacidad > _latas.Count;
        }
        public Lata getUltimaLataStockByCodigo(string codigo)
        {
            Lata ultimaLata = new Lata();
            foreach (Lata lata in _latas)
            {
                if (lata.Codigo == codigo)
                {
                    ultimaLata = lata;
                }
            }
            return ultimaLata;
        }
        public Lata ExtraerLata(string codigo, double plata)
        {
            Lata latita = getUltimaLataStockByCodigo(codigo);
            if (plata >= latita.Precio)
            {
                int pos = _latas.FindLastIndex(delegate (Lata lata)
                {
                    return lata.Codigo == codigo;
                });

                Dinero = Dinero + latita.Precio;
                Vuelto = plata - latita.Precio;
                _latas.RemoveAt(pos);
                Console.WriteLine(getStockByCodigo(codigo));
            }
            else
            {
                latita = null;
            }
            return latita;
        }
        public string GetBalance()
        {
            return "El dinero que tiene la expendedora es " + Dinero + " y tiene " + _latas.Count + " latas";
        }
        public string MuestroStock()
        {
            string lista = "";
            if (!Estavacia())
            {
                foreach (Lata lata in _latas)
                {
                    lista = lista + lata.DevuelveLata() + "\n" + lata.ToString() + "\n";
                }
            }
            else
            {
                lista = "La expendedora se encuentra vacia";
            }
            
            return lista;
        }
        public int GetCapacidadRestante()
        {
            return Capacidad - _latas.Count;
        }

        public bool Estavacia()
        {

            if (CapacidadDisponible())
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
