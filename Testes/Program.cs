namespace Testes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Evento evento = new();
            EventoLab el = new();

            evento.Event += el.EnviarEmail;

            evento.RealizarEvento();
        }
    }
}