using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    internal class PedidoCompra
    {
		private int _id;
		private DateTime _datahora;
		private string _status = "pendente";

        public List<ItemCompra> itens
        {
            get { return itens; }
            set { itens = value; }
        }
        public List<Cliente> cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public int ID
		{
			get { return _id; }
			set { _id = value; }
		}
        public DateTime DataHora
        {
            get { return _datahora; }
            set { _datahora = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (ItemCompra item in itens)
            {
                valorTotal += item.Quantidade * item.produto.Valor;
            }

            return valorTotal;
        }

        public bool EfetivarVenda ( )
        {
            _status = "concluido"; 
            return true;
        }

        public bool CancelarVenda ( ) 
        {
                    return true;
        }

        public string ImprimirPedido ( )
        {
            return "true";
            
        }
    }
}
