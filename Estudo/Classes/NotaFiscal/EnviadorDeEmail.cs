using Estudo.Interfaces;
using System;

namespace Estudo.Classes.NotaFiscal
{
	public class EnviadorDeEmail : IAcaoAposGerarNota
	{
		public void Executa(NotaFiscal notaFiscal)
		{
			Console.WriteLine("enviando por e-mail");
		}
	}
}
