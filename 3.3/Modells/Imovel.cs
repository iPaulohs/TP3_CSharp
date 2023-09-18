using _3._3.Interfaces;

namespace _3._3.Modells
{
    internal class Imovel : ITributavel
    {
        internal double TaxaImposto { private get; set; }
        internal double ValorDoImovel { private get; set; }

        public Imovel(bool _imovelNovo, double _valorDoImovel)
        {
            if (_imovelNovo)
                TaxaImposto = 0.05;
            else
                TaxaImposto = 0.15;

            ValorDoImovel = _valorDoImovel;
        }

        public double CalcularValorTotal()
        {
            return ValorDoImovel + (ValorDoImovel * TaxaImposto);
        }
    }
}
