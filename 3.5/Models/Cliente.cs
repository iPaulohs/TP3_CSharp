using _3._5.Modells;

namespace _3._5.Models
{

    internal class Cliente
    {

        public event Action<string, double, double> OnSomarValores;
        private string? CPF { get; set; }
        private string? Nome { get; set; }
        private double SaldoContaCorrente { get; set; }
        private double SaldoContaInternacional { get; set; }
        private double SaldoCripto { get; set; }
        private ContaInternacional? ContaInternacional { get; set; }
        private ContaCorrente? ContaCorrente { get; set; }
        private ContaCripto? ContaCripto { get; set; }

        public Cliente(string _CPF, string nome, double? saldoContaCorrente, double? saldoContaInternacional, double? saldoCripto)
        {
            CPF = _CPF;
            Nome = nome;

            if(saldoContaCorrente != null)
                SaldoContaCorrente = (double)saldoContaCorrente;
            

            if(saldoCripto != null)
                SaldoContaCorrente = (double)saldoCripto;
            

            if(saldoContaInternacional != null)
                SaldoContaInternacional = (double)saldoContaInternacional;

            if(saldoContaCorrente != null)
                ContaCorrente = new ContaCorrente((double)saldoContaCorrente);
            

            if(saldoContaInternacional != null)
                ContaInternacional = new ContaInternacional((double)saldoContaInternacional);
            

            if(saldoCripto != null)
                ContaCripto = new ContaCripto((double)saldoCripto);
            
        }

        public void SomarValoresDaConta()
        {
            double saldoTotal = SaldoContaCorrente + SaldoContaInternacional;
            double tarifaTotal = ContaCorrente?.CalcularTarifa() ?? 0 + ContaInternacional?.CalcularTarifa() ?? 0;

            
            OnSomarValores?.Invoke(CPF, saldoTotal, tarifaTotal);
        }

        public override string ToString() => $"CPF: {this.CPF}\nNome: {this.Nome}\nConta Corrente: {ContaCorrente?.CalcularTarifa():F2}\nConta Internacional: {ContaInternacional?.CalcularTarifa():F2}\nContaCripto: A conta cripto não é tarifada.";
        
    }
}
