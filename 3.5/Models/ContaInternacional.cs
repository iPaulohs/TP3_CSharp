using _3._5.Interfaces;
using _3._5.Modells;

namespace _3._5.Models
{
    public class ContaInternacional : ContaBase, ITarifa
    {
        private static readonly double CotacaoDolar = 4.55;
        private static readonly double TarifaInternacional = 0.025;

        public ContaInternacional(double saldoEmDolar) : base(saldoEmDolar * CotacaoDolar)
        {
        }

        public override double CalcularTarifa() => SaldoAtualEmReais * TarifaInternacional;
    }
}