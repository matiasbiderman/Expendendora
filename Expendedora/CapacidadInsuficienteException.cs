using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora
{
    class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException() : base("La capacidad de la expendedora es insuficiente")
        { }
    }
}
