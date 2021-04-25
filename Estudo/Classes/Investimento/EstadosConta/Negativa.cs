using Estudo.Interfaces;

namespace Estudo.Classes.Investimento.EstadosConta
{
	public class Negativa : IEstadoDeUmaConta
	{
		public double Deposita(Conta conta, double valorDeposito)
		{
			conta.Saldo += (valorDeposito * 0.95);

			if (conta.Saldo > 0)
			{
				conta.Estado = new Positiva();
			}

			return conta.Saldo;
		}

		public override string ToString()
		{
			return "Negativa";
		}
	}
}
