using _3._5.Modells;
using _3._5.Models;

namespace _3._5
{
    internal class Program
    {
        static void Main()
        {
            SistemaTarifas sistemaDeTarifas = new();

            bool FluxoControle = true;
            while (FluxoControle)
            {
                Console.WriteLine("Escolha o tipo de conta:\n1 - Corrente\n2 - Internacional\n3 - Cripto\n4 - Sair");
                int escolha = int.Parse(Console.ReadLine());

                double saldo;

                switch (escolha)
                {
                    case 1:
                        Console.Write("Informe o saldo em reais da conta corrente: ");
                        saldo = double.Parse(Console.ReadLine());
                        ContaCorrente contaCorrente = new(saldo);
                        sistemaDeTarifas.AcumularTarifa(contaCorrente);
                        break;
                    case 2:
                        Console.Write("Informe o saldo em dólar da conta internacional: ");
                        saldo = double.Parse(Console.ReadLine());
                        ContaInternacional contaInternacional = new(saldo);
                        sistemaDeTarifas.AcumularTarifa(contaInternacional);
                        break;
                    case 3:
                        Console.Write("Informe o saldo em dólar da conta cripto: ");
                        saldo = double.Parse(Console.ReadLine());
                        ContaCripto contaCripto = new(saldo);
                        sistemaDeTarifas.AcumularTarifa(contaCripto);
                        break;
                    case 4:
                        Console.WriteLine("Até breve!");
                        FluxoControle = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        continue;
                }
            }
        }
    }
}