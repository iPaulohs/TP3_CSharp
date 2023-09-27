namespace _3._5.Modells
{
    public abstract class ContaBase
    {
        internal double SaldoAtualEmReais { get; set; }

        public ContaBase(double saldoEmReais)
        {
            if (saldoEmReais >= 0)
                SaldoAtualEmReais = saldoEmReais;
            else
                throw new ArgumentException("O saldo em reais deve ser maior ou igual a zero.");
        }

        public abstract double CalcularTarifa();
    }
}
