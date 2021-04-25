using Estudo.Classes.Investimento.EstadosConta;
using Estudo.Interfaces;
using System;

namespace Estudo.Classes
{
	public class Conta
	{
		public string Nome { get; private set; }
		public double Saldo { get; set; }
		public IEstadoDeUmaConta Estado { get; set; }

		public Conta()
		{
		}

		public Conta(string nome, double saldo)
		{
			Nome = nome;
			Saldo = saldo;

			if (Saldo > 0)
			{
				Estado = new Positiva();
			}
			else
			{
				Estado = new Negativa();
			}
		}

		public void Deposita(double valor)
		{
			Estado.Deposita(this, valor);
		}

		public void Saca(double valor)
		{
			if (Estado is IPodeSacar estado)
			{
				Saca(estado, valor);
			}
			else
			{
				throw new InvalidOperationException("Conta esta com saldo negativo");
			}
		}

		private void Saca(IPodeSacar podeSacar, double valor)
		{
			podeSacar.Saque(this, valor);
		}
	}
}
