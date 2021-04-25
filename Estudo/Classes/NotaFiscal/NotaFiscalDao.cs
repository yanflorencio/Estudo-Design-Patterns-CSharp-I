using Estudo.Interfaces;
using System;

namespace Estudo.Classes.NotaFiscal
{
	public class NotaFiscalDao : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal notaFiscal)
		{
			Console.WriteLine("salvando no banco");
		}
	}
}
