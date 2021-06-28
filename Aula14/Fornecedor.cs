using System;
using System.Collections.Generic;

namespace ATT_Antonio
{
	public class Fornecedor:IImprimivel
	{
		private string _Fornome;
		private string _Forcontato;
		private string _Forcnpj;
		private string _Forendereco;


		public string Nome
        {
			get { return this._Fornome; }
        }
    public string Contato
		{
			get { return this._Forcontato; }
		}
  	public string Cnpj
		{
			get { return this._Forcnpj; }
		}
		public string Endereco
		{
			get { return this._Forendereco; }
		}
		

		public Fornecedor (string Fornome, string Forconato, string Forcnpj, string Forendereco)

        {
			this._Fornome = Fornome;
			this._Forconato = Forendereco;
			this._Forcnpj = Forcnpj;
			this._Forendereco = Forcontato;
        }


		public void Imprimir()
        {
			Console.WriteLine("FORNECEDOR:\t{0}", this.Nome);
      Console.WriteLine("CONTATO:\t{0}", this.Contato);
      Console.WriteLine("CNPJ:\t{0}", this.Cnpj);
			Console.WriteLine("ENDERÇO:\t{0}", this.Endereco);
		}
	}
}