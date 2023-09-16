namespace _3._1.Modells
{
    internal class FuncionarioBase
    {
        internal string Nome {  get; set; }
        internal double ValorVenda { get; set; }
        internal readonly double PorcentagemComissao = 0.05;

        internal FuncionarioBase(string _Nome, double _ValorVenda)
        {
            Nome = _Nome;
            ValorVenda = _ValorVenda;
        }

        protected internal virtual double CalculaComissao(double ValorVenda, double PorcentagemComissao) 
        {
            return ValorVenda * PorcentagemComissao;
        }

        public override string ToString()
        {
            return $"Nome do funcionário: {Nome}\nValor da venda: R${ValorVenda}\nValor da comissão: {CalculaComissao(ValorVenda, PorcentagemComissao)}\n";
        }
    }
}
