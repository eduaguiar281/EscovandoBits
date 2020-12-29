using System;
using System.Collections.Generic;
using System.Text;

namespace EscovandoBits
{
    public delegate void MostrarCalculo(Produto produto);
    public class Produto //: Object
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public decimal Total { get; private set; }

        public void CalcularTotal()
        {
            Total = Preco * Quantidade;
            MostrarCalculo?.Invoke(this);
        }

        public MostrarCalculo MostrarCalculo { get; set; }

        public override string ToString()
        {
            return $"{Codigo}- {Descricao} => {Preco:C2} x {Quantidade} = {Total:C2}";
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (obj as Produto);
            if (outroProduto == null)
                return false;
            return ((outroProduto.Codigo == Codigo) &&
                    (outroProduto.Descricao == Descricao) &&
                    (outroProduto.Preco == Preco) &&
                    (outroProduto.Quantidade == Quantidade) &&
                    (outroProduto.Total == Total));
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }
    }
}
