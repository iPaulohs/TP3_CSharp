namespace _3._2.Modells
{
    internal class Carro : VeiculoBase
    {
        public Carro(string? _modelo, string? _marca, int _ano, int _quantidadeAssentos, string _placa) : base(_modelo, _marca, _ano, _quantidadeAssentos, _placa)
        {
            if (_quantidadeAssentos >= 2 && _quantidadeAssentos <= 5)
                QuantidadeAssentos = _quantidadeAssentos;
            else
                throw new ArgumentException("O valor de assentos do caminhão deve estar entre 2 e 5.");
        }
    }
}
