using Estudo.Interfaces;

namespace Estudo.Classes.Requisição
{
	public class Enviar
	{
		public void EnviarRequisicao(Requisicao requisicao, Conta conta)
		{
			ITipoResposta envioXml = new RespostaXml();
			ITipoResposta envioCsv = new RespostaCsv();
			ITipoResposta envioPorcento = new RespostaPorcento();

			envioXml.Proximo = envioCsv;
			envioCsv.Proximo = envioPorcento;

			envioXml.Envia(requisicao, conta);
		}
	}
}
