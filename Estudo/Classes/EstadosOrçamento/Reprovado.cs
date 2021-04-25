using Estudo.Interfaces;
using System;

namespace Estudo.Classes.EstadosOrçamento
{
	public class Reprovado : IEstadoDeUmOrcamento
	{
		public bool DescontoAplicado { get; private set; }

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new InvalidOperationException("Orçamentos reprovados não recebem desconto extra!");
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new InvalidOperationException();
		}

		public void Finaliza(Orcamento orcamento)
		{
			// daqui posso ir para o estado de finalizado
			orcamento.EstadoAtual = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new InvalidOperationException();
		}
	}
}
