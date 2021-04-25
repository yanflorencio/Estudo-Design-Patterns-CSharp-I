using Estudo.Interfaces;
using System;

namespace Estudo.Classes
{
	public class RealizadorDeInvestimentos
	{
		public void Realiza(Conta conta, IInvestimento investimento)
		{
			double resultado = investimento.Calcula(conta);
			conta.Deposita(resultado * 0.75);
			Console.WriteLine("Saldo atual: " + conta.Saldo);
		}
	}
}
