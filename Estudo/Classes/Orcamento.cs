using Estudo.Classes.EstadosOrçamento;
using Estudo.Interfaces;
using System.Collections.Generic;

namespace Estudo.Classes
{
	public class Orcamento
	{
		public double Valor { get; set; }
		public IList<Item> Itens { get; private set; }

		public IEstadoDeUmOrcamento EstadoAtual { get; set; }


		public Orcamento()
		{
			this.EstadoAtual = new EmAprovacao();
		}

		public Orcamento(double valor)
		{
			this.Valor = valor;
			this.Itens = new List<Item>();
			this.EstadoAtual = new EmAprovacao();
		}
		public void AdicionaItem(Item item)
		{
			this.Itens.Add(item);
		}

		public void AplicaDescontoExtra()
		{
			EstadoAtual.AplicaDescontoExtra(this);
		}

		public void Aprova()
		{
			EstadoAtual.Aprova(this);
		}

		public void Reprova()
		{
			EstadoAtual.Reprova(this);
		}

		public void Finaliza()
		{
			EstadoAtual.Finaliza(this);
		}
	}
}
