using System.Threading.Channels;

namespace Testes
{
    delegate void EventoHandler();
    internal class Evento
    {
        public event EventoHandler? Event;

        public void RealizarEvento()
        {
            Console.WriteLine("Evento invocado!");

            Event?.Invoke();
        }
    }
}
