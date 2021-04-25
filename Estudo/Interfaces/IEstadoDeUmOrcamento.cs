using Estudo.Classes;

namespace Estudo.Interfaces
{
	public interface IEstadoDeUmOrcamento
	{
		bool DescontoAplicado { get; }

		void AplicaDescontoExtra(Orcamento orcamento);
		void Aprova(Orcamento orcamento);
		void Reprova(Orcamento orcamento);
		void Finaliza(Orcamento orcamento);
	}
}
