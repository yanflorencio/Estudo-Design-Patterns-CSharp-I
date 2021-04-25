using Estudo.Interfaces;
using System;

namespace Estudo.Classes.NotaFiscal
{
	public class Multiplicador : IAcaoAposGerarNota
	{
		public double Fator { get; set; }

		public Multiplicador(double fator)
		{
			Fator = fator;
		}

		public void Executa(NotaFiscal notaFiscal)
		{
			Console.WriteLine("Fator: " + notaFiscal.ValorBruto * this.Fator);
		}
	}
}
