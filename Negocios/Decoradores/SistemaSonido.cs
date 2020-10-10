using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Decoradores
{
    public class SistemaSonido : InterfazAuto
    {
        private InterfazAuto decoramosA;

        public SistemaSonido(InterfazAuto _componente)
        {
            decoramosA = _componente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 2000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", enciendiendo sistema sonido";
        }
    }
}
