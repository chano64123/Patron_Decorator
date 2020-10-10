using System;

namespace Negocios
{
    public class Auto : InterfazAuto
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public Auto(string _modelo, string _caracteristica, double _costo)
        {
            modelo = _modelo;
            caracteristicas = _caracteristica;
            costo = _costo;
        }

        public void Puertas(bool _estado)
        {
            if (_estado) Console.WriteLine("Puertas cerradas");
            else Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendiendo el motor";
        }
    }
}
