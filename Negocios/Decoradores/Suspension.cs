using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Decoradores
{
    public class Suspension : InterfazAuto
    {
        private InterfazAuto decoramosA;


        public Suspension(InterfazAuto _componente)
        {
            decoramosA = _componente;
        }

        public override string ToString()
        {
            return "Suspensión de alto desempeño \r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 1000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando suspensión";

        }
    }
}
