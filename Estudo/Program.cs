using Estudo.Classes;
using Estudo.Classes.Desconto;
using Estudo.Classes.NotaFiscal;
using Estudo.Classes.Requisição;
using Estudo.Interfaces;
using System;

namespace Estudo
{
	public class Program
	{
		static void Main(string[] args)
		{
			TesteAcaoPosGerarNota();

			Console.ReadKey();
		}

		public static void TesteAcaoPosGerarNota()
		{
			NotaFiscalBuilder builder = new NotaFiscalBuilder();
			builder.AdicionaAcao(new EnviadorDeEmail());
			builder.AdicionaAcao(new NotaFiscalDao());
			builder.AdicionaAcao(new EnviadorDeSms());
			builder.AdicionaAcao(new Impressora());
			builder.AdicionaAcao(new Multiplicador(2));

			NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
								.ComCnpj("123.456.789/0001-10")
								.ComItem(new ItemDaNota("item 1", 100.0))
								.ComItem(new ItemDaNota("item 2", 200.0))
								.ComItem(new ItemDaNota("item 3", 300.0))
								.ComObservacoes("entregar notaFiscal pessoalmente")
								.Constroi();
		}



		public static void TesteNotaFiscalBuilder()
		{
			NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Caelum")
				  .ComCnpj("123.456.789/0001-10")
				  .ComItem(new ItemDaNota("item 1", 100.0))
				  .ComItem(new ItemDaNota("item 2", 200.0))
				  .ComItem(new ItemDaNota("item 3", 300.0))
				  .ComObservacoes("entregar nf pessoalmente")
				  .Constroi();

			Console.WriteLine(nf.ToString());
		}

		public static void TesteEstadosDaConta()
		{
			Conta conta = new Conta("NomeDeAlguém", 100);

			conta.Deposita(50);

			Console.WriteLine("Saldo: " + conta.Saldo + " Estado: " + conta.Estado.ToString());

			conta.Saca(151);

			Console.WriteLine("Saldo: " + conta.Saldo + " Estado: " + conta.Estado.ToString());

			conta.Deposita(200);

			Console.WriteLine("Saldo: " + conta.Saldo + " Estado: " + conta.Estado.ToString());

			//conta.Saca(1);
		}

		public static void TesteEstadosDoOrcamento()
		{
			Orcamento reforma = new Orcamento(500.0);

			/*reforma.AplicaDescontoExtra();
			Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
			reforma.Aprova(); // aprova nota!

			reforma.AplicaDescontoExtra();
			Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

			reforma.Finaliza();*/

			reforma.AplicaDescontoExtra();

			Console.WriteLine(reforma.Valor);

			reforma.AplicaDescontoExtra();
		}

		public static void TesteRequisicao()
		{
			Enviar enviar = new Enviar();
			Conta conta = new Conta("ABC", 100);
			Requisicao requisicao = new Requisicao(Enuns.Formato.NONE);

			enviar.EnviarRequisicao(requisicao, conta);
		}

		public static void TesteDesconto()
		{
			CalculadorDeDescontos calculador = new CalculadorDeDescontos();

			Orcamento orcamento = new Orcamento(1.0);


			orcamento.AdicionaItem(new Item("CANETA", 250.0));
			orcamento.AdicionaItem(new Item("LAPIS", 250.0));

			double desconto = calculador.Calcula(orcamento);

			Console.WriteLine(desconto);
		}

		public static void TesteImposto()
		{
			IImposto iss = new Iss();
			IImposto icms = new Icms();
			Orcamento orcamento = new Orcamento(500.0);
			CalculadorDeImposto calculador = new CalculadorDeImposto();

			// Calculando o ISS
			calculador.RealizaCalculo(orcamento, iss);

			// Calculando o ICMS
			calculador.RealizaCalculo(orcamento, icms);
		}
	}
}
