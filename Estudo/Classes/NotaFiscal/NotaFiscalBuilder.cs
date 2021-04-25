using Estudo.Interfaces;
using System;
using System.Collections.Generic;

namespace Estudo.Classes.NotaFiscal
{
	public class NotaFiscalBuilder
	{
		public string RazaoSocial { get; private set; }
		public string Cnpj { get; private set; }
		public double ValorTotal { get; private set; }
		public double Impostos { get; private set; }
		public IList<ItemDaNota> TodosItens { get; private set; } = new List<ItemDaNota>();
		public double ValorBruto { get; private set; }
		public DateTime? Data { get; private set; }
		public string Observacoes { get; private set; }

		private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

		public NotaFiscalBuilder ComObservacoes(String observacoes)
		{
			this.Observacoes = observacoes;
			return this;
		}

		public NotaFiscalBuilder SetData(DateTime dateTime)
		{
			this.Data = dateTime;
			return this;
		}

		public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
		{
			this.RazaoSocial = razaoSocial;
			return this;
		}

		public NotaFiscalBuilder ComCnpj(string cnpj)
		{
			this.Cnpj = cnpj;
			return this;
		}

		public NotaFiscalBuilder ComItem(ItemDaNota item)
		{
			TodosItens.Add(item);
			ValorBruto += item.Valor;
			Impostos += item.Valor * 0.05;
			return this;
		}

		public NotaFiscal Constroi()
		{
			DateTime data = Data.HasValue ? this.Data.Value : DateTime.Now;

			NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, data, ValorBruto, Impostos, TodosItens, Observacoes);

			foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
			{
				acao.Executa(notaFiscal);
			}

			return notaFiscal;
		}

		public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
		{
			this.todasAcoesASeremExecutadas.Add(novaAcao);
		}
	}
}
