using Estudo.Interfaces;
using System;

namespace Estudo.Classes
{
	public class Moderado : IInvestimento
	{
		private readonly Random Random;

		public Moderado()
		{
			this.Random = new Random();
		}

		public double Calcula(Conta conta)
		{
			Random random = this.Random;

			if (random.Next(2) == 0)
			{
				return conta.Saldo * 0.025;
			}
			else
			{
				return conta.Saldo * 0.007;
			}
		}
	}
}
