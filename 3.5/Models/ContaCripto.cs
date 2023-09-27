namespace _3._5.Modells
{
    public class ContaCripto : ContaBase
    {
        private static readonly double CotacaoDolar = 4.55;
        private static readonly double ValorCriptoEmDolar = 478.0;

        public ContaCripto(double saldoEmDolar) : base(saldoEmDolar) => SaldoAtualEmReais = saldoEmDolar * CotacaoDolar * ValorCriptoEmDolar;

        public override double CalcularTarifa() => 0;
    }
}
