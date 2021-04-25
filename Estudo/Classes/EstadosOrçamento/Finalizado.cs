using Estudo.Interfaces;
using System;

namespace Estudo.Classes.EstadosOrçamento
{
	public class Finalizado : IEstadoDeUmOrcamento
	{
		public bool DescontoAplicado { get; private set; }

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new InvalidOperationException("Orçamentos finalizados não recebem desconto extra!");
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new InvalidOperationException();
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new InvalidOperationException();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new InvalidOperationException();
		}
	}
}
