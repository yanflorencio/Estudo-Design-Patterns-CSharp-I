using Estudo.Classes;

namespace Estudo.Interfaces
{
	public interface IDesconto
	{
		IDesconto Proximo { get; set; }

		double Desconta(Orcamento orcamento);

	}
}
