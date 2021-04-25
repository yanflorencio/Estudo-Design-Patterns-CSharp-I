using Estudo.Classes.Abstratas;
using Estudo.Interfaces;
using System;

namespace Estudo.Classes.Requisição
{
	public class RespostaPorcento : AbstracTipoResposta
	{

		public RespostaPorcento()
		{
		}

		public RespostaPorcento(ITipoResposta proximo)
		{
			Proximo = proximo;
		}

		public override void Envia(Requisicao requisicao, Conta conta)
		{
			if (requisicao.Formato == Enuns.Formato.PORCENTO)
			{
				Console.WriteLine(conta.Nome + "%" + conta.Saldo);
			}
			else
			{
				ProximoEnvio(requisicao, conta);
			}
		}
	}
}
