using Estudo.Interfaces;
using System;
using System.Linq;

namespace Estudo.Classes.Desconto
{
	public class DescontoPorVendaCasada : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public double Desconta(Orcamento orcamento)
		{
			bool caneta = this.Existe("CANETA", orcamento);
			bool lapis = this.Existe("LAPIS", orcamento);

			if (caneta && lapis)
			{
				return orcamento.Valor * 0.05;
			}
			else
			{
				return Proximo.Desconta(orcamento);
			}
		}

		private bool Existe(String nomeDoItem, Orcamento orcamento) => orcamento.Itens.Any(item => item.Nome.Equals(nomeDoItem));
	}
}
