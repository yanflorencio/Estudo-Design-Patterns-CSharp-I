using Estudo.Interfaces;
using System;

namespace Estudo.Classes
{
	public class Arrojado : IInvestimento
	{
		private readonly Random Random;

		public Arrojado()
		{
			this.Random = new Random();
		}

		public double Calcula(Conta conta)
		{
			int random = Random.Next(10);

			if (random >= 0 && random <= 1)
			{
				return conta.Saldo * 0.5;
			}
			else if (random >= 2 && random <= 4)
			{
				return conta.Saldo * 0.3;
			}
			else
			{
				return conta.Saldo * 0.006;
			}
		}
	}
}
