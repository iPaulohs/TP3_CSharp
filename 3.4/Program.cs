using _3._4.Modells;
using System.Globalization;

namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro SenhorDosAneis = new("Senhor Dos Aneis");
            Console.WriteLine($"Livro: {SenhorDosAneis.Titulo}");
            Console.WriteLine(SenhorDosAneis.MostraDataEntrega());
            Console.WriteLine("");
            Revista Oeste = new("Oeste");
            Console.WriteLine($"Revista: {Oeste.Titulo}");
            Console.WriteLine(Oeste.MostraDataEntrega());
            Console.WriteLine("");
            Jornal Globo = new("O Globo");
            Console.WriteLine($"Jornal: {Globo.Titulo}");
            Console.WriteLine(Globo.MostraDataEntrega());
        }
    }
}