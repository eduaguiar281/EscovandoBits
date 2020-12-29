using System;
using System.Collections.Generic;
using System.Text;

namespace EscovandoBits.Interfaces
{
    public interface IAeronave
    {
        string Nome { get; }

        void Decolar();
        void Pousar();

    }
}
