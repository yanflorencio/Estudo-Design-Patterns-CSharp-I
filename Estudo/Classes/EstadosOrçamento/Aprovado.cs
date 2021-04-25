using Estudo.Interfaces;
using System;

namespace Estudo.Classes.EstadosOrçamento
{
	public class Aprovado : IEstadoDeUmOrcamento
	{
		public bool DescontoAplicado { get; private set; }

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			if (!DescontoAplicado)
			{
				orcamento.Valor -= orcamento.Valor * 0.02;
				DescontoAplicado = true;
			}
			else
			{
				throw new InvalidOperationException("Desconto já aplicado");
			}

		}

		public void Aprova(Orcamento orcamento)
		{
			// jah estou em aprovacao
			throw new InvalidOperationException("Orçamento já está em estado de aprovação");
		}

		public void Reprova(Orcamento orcamento)
		{
			// nao pode ser reprovado agora!
			throw new InvalidOperationException("Orçamento está em estado de aprovação e não pode ser reprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			// daqui posso ir para o estado de finalizado
			orcamento.EstadoAtual = new Finalizado();
		}
	}
}
