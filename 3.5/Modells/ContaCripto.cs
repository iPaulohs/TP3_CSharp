namespace _3._5.Modells
{
    public class ContaCripto : ContaBase
    {
        private static readonly double CotacaoDolar = 4.55;
        private static readonly double ValorCriptoEmDolar = 478.0;

        public ContaCripto(double saldoEmDolar) : base(saldoEmDolar)
        {
            if (saldoEmDolar > 0)
                SaldoAtualEmReais = saldoEmDolar * CotacaoDolar * ValorCriptoEmDolar;
            else
                throw new ArgumentException("O valor do saldo em dolar deve ser maior do que 0");
        }

        public override double CalcularTarifa()
        {
            return 0;
        }
    }
}
