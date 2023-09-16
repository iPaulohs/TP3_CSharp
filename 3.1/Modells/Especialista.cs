namespace _3._1.Modells
{
    internal class Especialista : FuncionarioBase
    {
        internal Especialista(string _Nome, double _ValorVenda) : base(_Nome, _ValorVenda)
        {
        }

        protected internal override double CalculaComissao(double ValorVenda, double PorcentagemComissao)
        {
            return ValorVenda * 0.3;
        }
    }
}
