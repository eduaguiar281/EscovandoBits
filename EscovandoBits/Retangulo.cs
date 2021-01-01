using System;

namespace EscovandoBits
{
    public struct Retangulo
    {

        public Retangulo(double baseRetangulo, double alturaRetangulo )
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }

        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            if (Base < 0)
                throw new ArgumentException("Valor do Base não pode ser menor que zero");
            if (Altura < 0)
                throw new ArgumentException("Valor do Altura não pode ser menor que zero");

            return Base * Altura;
        }
    }
}
