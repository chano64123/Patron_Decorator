using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Decoradores
{
    public class Nitrogeno : InterfazAuto
    {
        private InterfazAuto decoramosA;

        public Nitrogeno(InterfazAuto _componente)
        {
            decoramosA = _componente;
        }

        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 2500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrógeno funcionando";
        }        
    }
}
