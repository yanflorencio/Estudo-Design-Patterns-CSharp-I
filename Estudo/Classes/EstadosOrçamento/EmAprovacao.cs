using Estudo.Interfaces;
using System;

namespace Estudo.Classes.EstadosOrçamento
{
	public class EmAprovacao : IEstadoDeUmOrcamento
	{
		public bool DescontoAplicado { get; private set; }

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			if (!DescontoAplicado)
			{
				orcamento.Valor -= orcamento.Valor * 0.05;
				DescontoAplicado = true;
			}
			else
			{
				throw new InvalidOperationException("Desconto já aplicado");
			}

		}

		public void Aprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Aprovado();
		}

		public void Reprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Reprovado();
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new InvalidOperationException("Orcamento em aprovação não podem ir para finalizado diretamente");
		}
	}
}
