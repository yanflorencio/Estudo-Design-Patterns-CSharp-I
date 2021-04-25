using Estudo.Interfaces;

namespace Estudo.Classes
{
	public class Iccc : IImposto
	{
		public double Calcula(Orcamento orcamento)
		{
			double aplicarImposto = orcamento.Valor;

			if (aplicarImposto < 1000.00)
			{
				return aplicarImposto * 0.05;
			}
			else if (aplicarImposto >= 1000.00 && aplicarImposto <= 3000.00)
			{
				return aplicarImposto * 0.07;
			}
			else
			{
				return aplicarImposto * 0.08 + 30.00;
			}
		}
	}
}
