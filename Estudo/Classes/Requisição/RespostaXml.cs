using Estudo.Classes.Abstratas;
using Estudo.Interfaces;
using System;

namespace Estudo.Classes.Requisição
{
	public class RespostaXml : AbstracTipoResposta
	{

		public RespostaXml()
		{
		}

		public RespostaXml(ITipoResposta proximo)
		{
			Proximo = proximo;
		}

		public override void Envia(Requisicao requisicao, Conta conta)
		{
			if (requisicao.Formato == Enuns.Formato.XML)
			{
				Console.WriteLine("<conta><titular>" + conta.Nome + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
			}
			else
			{
				ProximoEnvio(requisicao, conta);
			}
		}
	}
}
