using Estudo.Interfaces;

namespace Estudo.Classes.Investimento.EstadosConta
{
	public class Positiva : IPodeSacar
	{

		public double Deposita(Conta conta, double valorDeposito)
		{
			conta.Saldo += (valorDeposito * 0.98);

			return conta.Saldo;
		}

		public double Saque(Conta conta, double valorSaque)
		{
			conta.Saldo -= valorSaque;

			if (conta.Saldo < 0)
			{
				conta.Estado = new Negativa();
			}

			return conta.Saldo;
		}

		public override string ToString()
		{
			return "Positiva";
		}

	}
}
