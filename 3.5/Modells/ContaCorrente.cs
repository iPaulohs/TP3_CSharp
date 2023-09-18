using _3._5.Interfaces;

namespace _3._5.Modells
{
    public class ContaCorrente : ContaBase, ITarifa
    {
        private static readonly double TarifaCorrente = 0.015; // 1.5%

        public ContaCorrente(double saldoEmReais) : base(saldoEmReais)
        {
        }

        public override double CalcularTarifa()
        {
            return SaldoAtualEmReais * TarifaCorrente;
        }
    }
}
