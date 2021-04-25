using Estudo.Classes.Requisição;
using Estudo.Interfaces;
using System;

namespace Estudo.Classes.Abstratas
{
	public abstract class AbstracTipoResposta : ITipoResposta
	{
		public ITipoResposta Proximo { get; set; }

		public abstract void Envia(Requisicao requisicao, Conta conta);

		public void ProximoEnvio(Requisicao requisicao, Conta conta)
		{
			if (Proximo != null)
			{
				Proximo.Envia(requisicao, conta);
			}
			else
			{
				Console.WriteLine("Necessário definir um formato de resposta!");
			}
		}
	}
}
