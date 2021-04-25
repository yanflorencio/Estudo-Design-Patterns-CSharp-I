namespace Estudo.Classes.NotaFiscal
{
	public class ItemDaNotaBuilder
	{
		public string Nome { get; private set; }

		public double Valor { get; private set; }

		public ItemDaNotaBuilder SetNome(string nome)
		{
			Nome = nome;
			return this;
		}

		public ItemDaNotaBuilder SetValor(double valor)
		{
			Valor = valor;
			return this;
		}

		public ItemDaNota Build()
		{
			return new ItemDaNota(Nome, Valor);
		}
	}
}
