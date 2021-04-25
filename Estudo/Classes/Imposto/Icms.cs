using Estudo.Interfaces;

namespace Estudo.Classes
{
	public class Icms : IImposto
	{
		public double Calcula(Orcamento orcamento)
		{
			return (orcamento.Valor * 0.5) + 50.00;
		}
	}
}
