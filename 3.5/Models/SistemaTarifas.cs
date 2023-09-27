
namespace _3._5.Models
{
    internal class SistemaTarifas
    {
        private readonly string caminhoArquivo = @"C:\Users\Paulo\Desktop\TP3\3.5\Clientes.csv";
        private delegate void SomaValores();

        internal void ObtemCliente()
        {
            int controleDeIteracoes = 0;

            foreach (string linha in File.ReadLines(caminhoArquivo))
            {
                if (controleDeIteracoes >= 1)
                {
                    string[] infoCliente = linha.Split("|");

                    if (infoCliente.Length == 5)
                    {
                        string cpf = infoCliente[0];
                        string nome = infoCliente[1];

                        double saldoContaCorrente;
                        double saldoContaInternacional;
                        double saldoCripto;

                        double[] valores = new double[3];

                        if (double.TryParse(infoCliente[2], out saldoContaCorrente))
                            valores[0] = saldoContaCorrente;
                        else if (string.IsNullOrEmpty(infoCliente[2]))
                            Console.WriteLine("O cliente não possui conta Corrente.");

                        if (double.TryParse(infoCliente[3], out saldoContaInternacional))
                            valores[1] = saldoContaInternacional;
                        else if (string.IsNullOrEmpty(infoCliente[3]))
                            Console.WriteLine("O cliente não possui conta Internacional.");


                        if (double.TryParse(infoCliente[4], out saldoCripto))
                            valores[2] = saldoCripto;
                        else if (string.IsNullOrEmpty(infoCliente[4]))
                            Console.WriteLine("O cliente não possui conta Cripto.");

                        Cliente cliente = new(cpf, nome, saldoContaCorrente, saldoContaInternacional, saldoCripto);
                        cliente.OnSomarValores += (cpf, saldo, tarifa) => Console.WriteLine($"CPF: {cpf}\nSaldo Total: {saldo:F2}\nTarifa Total: {tarifa:F2}\n\n");
                        cliente.SomarValoresDaConta();
                    }
                }
                else
                {
                    controleDeIteracoes += 1;
                }
            }
        }
    }
}
