using Estudo.Classes.Abstratas;
using Estudo.Interfaces;
using System;

namespace Estudo.Classes.Requisição
{
	public class RespostaCsv : AbstracTipoResposta
	{
		public RespostaCsv()
		{
		}

		public RespostaCsv(ITipoResposta proximo)
		{
			Proximo = proximo;
		}

		public override void Envia(Requisicao requisicao, Conta conta)
		{
			if (requisicao.Formato == Enuns.Formato.CSV)
			{
				Console.WriteLine(conta.Nome + ";" + conta.Saldo);
			}
			else
			{
				ProximoEnvio(requisicao, conta);
			}
		}
	}
}
