using System;
using System.Collections.Generic;
using System.Text;

namespace EscovandoBits.Interfaces
{
    public class Aviao : IAeronave
    {
        public Aviao()
        {
            Nome = nameof(Aviao);
        }
        public string Nome { get; }

        public void Decolar()
        {
            Console.WriteLine("Ligar turbinas");
            Console.WriteLine("Pagar velocidade");
            Console.WriteLine("Subir");
        }

        public void Pousar()
        {
            Console.WriteLine("Diminuir velocidade");
            Console.WriteLine("Ligar trem de pouso");
            Console.WriteLine("Parar");
        }
    }
}
