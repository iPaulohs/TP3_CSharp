using _3._1.Modells;

namespace _3._1
{
    internal class Program
    {
        static bool controleFluxo = true;


        static void Fluxo()
        {

            Console.WriteLine("Por favor, digite o cargo do funcionário que o valor deve ser calculado:\n1 - Assistente\n2 - Analista\n3 - Especialista\n4 - Limpar o console\n5 - Sair do programa\n");
            Console.Write("Sua resposta: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nCargo: Assistente");
                    Assistente assistente = new("Paulo", 1000);
                    Console.WriteLine(assistente.ToString());
                    break;
                case 2:
                    Console.WriteLine("\nCargo: Analista");
                    Analista analista = new("Maria", 1000);
                    Console.WriteLine(analista.ToString());
                    break;
                case 3:
                    Console.WriteLine("\nCargo: Especialista");
                    Especialista especialista = new("Ana", 1000);
                    Console.WriteLine(especialista.ToString());
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("\nAté breve!");
                    controleFluxo = false;
                    break;
                default:
                    Console.WriteLine("\nDigite uma opção válida.");
                    Fluxo();
                    break;
            }
        }

        static void Main()
        {
            /*Acho mais elegante o não uso e instruções de nível superior.*/

            Console.WriteLine("Olá! Neste programa, vamos realizar o cálculo de comissão de vendas de uma loja.");


            while(controleFluxo) 
            {
                Fluxo();
            }
        }
    }
}