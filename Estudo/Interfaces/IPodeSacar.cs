using Estudo.Classes;

namespace Estudo.Interfaces
{
	public interface IPodeSacar : IEstadoDeUmaConta
	{
		double Saque(Conta conta, double valorSaque);
	}
}
