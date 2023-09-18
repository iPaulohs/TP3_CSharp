using _3._3.Modells;

namespace _3._3
{
    internal class Program
    {
        static void Main()
        {
            Imovel AvenidaBrasil578 = new(false, 150000);
            double valorAvenidaBrasil1578 = AvenidaBrasil578.CalcularValorTotal();

            Imovel AvenidaPaulista1517 = new(true, 150000);
            double valorAvenidaPaulista1517 = AvenidaPaulista1517.CalcularValorTotal();

            Console.WriteLine("Seja bem vindo ao programa de cálculo de valor de imóveis. Abaixo, temos o valor com impostos de dois imóveis: um novo e um usado.\n");
            Console.WriteLine($"Valor do imóvel usado com impostos: {valorAvenidaBrasil1578:C}");
            Console.WriteLine($"Valor do imóvel novo com impostos: {valorAvenidaPaulista1517:C}");
        }
    }
}