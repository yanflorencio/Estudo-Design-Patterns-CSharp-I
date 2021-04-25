using Estudo.Interfaces;
using System;

namespace Estudo.Classes.Desconto
{
	public class SemDesconto : IDesconto
	{
		public IDesconto Proximo { get; set; }

		public Double Desconta(Orcamento orcamento)
		{
			return 0;
		}
	}
}
