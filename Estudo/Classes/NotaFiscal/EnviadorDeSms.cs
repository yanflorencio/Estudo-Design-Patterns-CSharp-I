using Estudo.Interfaces;
using System;

namespace Estudo.Classes.NotaFiscal
{
	public class EnviadorDeSms : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal notaFiscal)
		{
			Console.WriteLine("enviando por sms");
		}
	}
}
