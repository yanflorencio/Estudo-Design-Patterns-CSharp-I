using Estudo.Interfaces;

namespace Estudo.Classes
{
	public class Iss : IImposto
	{
		public double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
	}
}
