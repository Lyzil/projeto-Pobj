using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    internal class ItemCompra
    {
		private double _quantidade;

        public Produto produto {
			get { return produto; }
			set { produto = value; }
		}
        public double Quantidade
		{
			get { return _quantidade; }
			set { _quantidade = value; }
		}

	}
}
