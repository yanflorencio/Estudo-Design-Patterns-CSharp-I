using static Estudo.Classes.Enuns;

namespace Estudo.Classes.Requisição
{
	public class Requisicao
	{

		public Formato Formato { get; private set; }

		public Requisicao(Formato formato)
		{
			this.Formato = formato;
		}
	}
}
