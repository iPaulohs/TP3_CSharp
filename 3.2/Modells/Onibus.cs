namespace _3._2.Modells
{
    internal class Onibus : VeiculoBase
    {
        public Onibus(string? _modelo, string? _marca, int _ano, int _quantidadeAssentos, string _placa) : base(_modelo, _marca, _ano, _quantidadeAssentos, _placa)
        {
            if (_quantidadeAssentos >= 10 && _quantidadeAssentos <= 44)
                QuantidadeAssentos = _quantidadeAssentos;
            else
                throw new ArgumentException("O valor de assentos do caminhão deve estar entre 10 e 44.");
        }
    }
}
