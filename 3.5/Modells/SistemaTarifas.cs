namespace _3._5.Modells
{
    internal class SistemaTarifas
    {
            private double ValorTotalDoSaldo { get; set; }
            private double ValorTotalDaTarifa { get; set; }

            public void AcumularTarifa(ContaBase conta)
            {
                double tarifa = conta.CalcularTarifa();
                ValorTotalDaTarifa += tarifa;
                ValorTotalDoSaldo += conta.SaldoAtualEmReais;

                Console.WriteLine($"Valor Total do Saldo: R${ValorTotalDoSaldo:F2}");
                Console.WriteLine($"Valor Total da Tarifa: R${ValorTotalDaTarifa:F2}");
            }
        }
    }
