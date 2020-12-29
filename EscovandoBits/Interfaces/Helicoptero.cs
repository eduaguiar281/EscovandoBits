using System;
using System.Collections.Generic;
using System.Text;

namespace EscovandoBits.Interfaces
{
    public class Helicoptero : IAeronave
    {
        public Helicoptero()
        {
            Nome = nameof(Helicoptero);
        }
        public string Nome { get; }

        public void Decolar()
        {
            Console.WriteLine("Ligar rotores");
            Console.WriteLine("Aguardar rotação necessária");
            Console.WriteLine("Subir");
        }

        public void Pousar()
        {
            Console.WriteLine("Diminur velocidade dos rotores");
            Console.WriteLine("Abaixar");
            Console.WriteLine("Pousar");
            Console.WriteLine("Desligar rotores");
        }
    }
}
