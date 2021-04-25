using Estudo.Interfaces;
using System;

namespace Estudo.Classes
{
	public class CalculadorDeImposto
	{
		public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
		{
			double valor = imposto.Calcula(orcamento);

			string type = imposto.GetType().Name;
			string mensagem = $"Imposto {type} Valor {valor}";

			Console.WriteLine(mensagem);
		}
	}
}
