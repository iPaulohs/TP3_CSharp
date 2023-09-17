using _3._2.Modells;

namespace _3._2
{
    internal class Program
    {
        static bool controleFluxo = true;

        static void Fluxo()
        {

            Carro carro = new("Gol", "Volkswagen", 2022, 4, "GOL-1234");
            Onibus onibus = new("PARADISO G8 1800 DD", "Marcopolo", 2023, 44, "PAR-5678");
            Caminhao caminhao = new("FH 500", "Volvo", 2023, 3, "VFH-5001", 6);

            Console.WriteLine("Digite a opção desejada:\n1 - Exibir a lista de veículos\n2 - Sair do programa\n3 - Limpar o console");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Console.WriteLine($"{carro}\n");
                    Console.WriteLine($"{onibus}\n");
                    Console.WriteLine($"{caminhao}\n");
                    break;
                case 2:
                    Console.WriteLine("Até breve!");
                    controleFluxo = true;
                    break;
                case 3:
                    Console.Clear();
                    break;
                default: 
                    Console.WriteLine("Digite uma opção válida!");
                    Fluxo();
                    break;
            }
        }

        static void Main()
        {
            Console.WriteLine("Seja bem vindo ao sistema para cadastro de veículos.");

            while (controleFluxo)
            {
                Fluxo();
            }
        }
    }
}