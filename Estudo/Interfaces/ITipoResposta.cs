using Estudo.Classes;
using Estudo.Classes.Requisição;

namespace Estudo.Interfaces
{
	public interface ITipoResposta
	{
		ITipoResposta Proximo { get; set; }

		void Envia(Requisicao requisicao, Conta conta);
	}
}
