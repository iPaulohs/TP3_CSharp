namespace _3._2.Modells
{
    internal class Caminhao : VeiculoBase
    {
        internal int QuantidadeEixos {  get; set; }

        public Caminhao(string? _modelo, string? _marca, int _ano, int _quantidadeAssentos, string _placa, int _quantidadeEixos) : base(_modelo, _marca, _ano, _quantidadeAssentos, _placa)
        {
            //Verifica a quantidade de eixos declarada no construtor
            if (_quantidadeEixos >= 2 && _quantidadeEixos <= 10)
                QuantidadeEixos = _quantidadeEixos;
            else
                throw new ArgumentException("O valor de eixos do caminhão deve estar entre 2 e 10.");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nQuantidade de eixos: {QuantidadeEixos}";
        }
    }
}
