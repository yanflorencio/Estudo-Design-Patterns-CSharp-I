using Estudo.Interfaces;
using System;

namespace Estudo.Classes.NotaFiscal
{
	public class Impressora : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal notaFiscal)
		{
			Console.WriteLine("imprimindo notaFiscal");
		}
	}
}
