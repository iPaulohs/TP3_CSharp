namespace _3._2.Modells
{
    internal abstract class VeiculoBase
    {
        internal string? Modelo { get; set; }
        internal string? Marca {  get; set; }
        internal int Ano { get; set; }
        internal int QuantidadeAssentos { get; set; }
        internal string Placa { get; set; }
        

        internal VeiculoBase(string? _modelo, string? _marca, int ano, int _quantidadeAssentos, string _placa)
        {
            Modelo = _modelo;
            Marca = _marca;
            Ano = ano;
            Placa = _placa;  
        }

        public override string ToString()
        {
            return $"Marca do veículo: {Marca}\nModelo do veículo: {Modelo}\nAno de fabricação: {Ano}\nQuantidade de assentos: {QuantidadeAssentos}\nPlaca do veículo: {Placa}";
        }
    }
}
