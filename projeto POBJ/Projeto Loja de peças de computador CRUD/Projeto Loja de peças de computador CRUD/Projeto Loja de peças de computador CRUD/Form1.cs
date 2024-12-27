using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    public partial class Form1 : Form
    {
        List<Cliente> listClientes = new List<Cliente>();
        List<Produto> listprodutos = new List<Produto>();
        public Form1()
        {
            //Cliente cliente = new Cliente(); <--------- colocar dados para teste (já criar objetos para a lista por default para teste
            //listClientes.Add(cliente);
            InitializeComponent();
        }
        frmAdicionarProduto frmAdicionarProdutoobj;
        frmAdicionarCliente frmAdicionarClienteobj;
        frmFazerPedido frmFazerPedidoobj;
        private void tsmiProdutos_Click(object sender, EventArgs e)
        {

            if (frmAdicionarProdutoobj == null || frmAdicionarProdutoobj.IsDisposed)
            {
                frmAdicionarProdutoobj = new frmAdicionarProduto(listprodutos);
                frmAdicionarProdutoobj.MdiParent = this;
                frmAdicionarProdutoobj.Show();
            }
            else 
            { frmAdicionarProdutoobj.Activate(); return; }

        }

        private void tsmiCliente_Click(object sender, EventArgs e)
        {
            if (frmAdicionarClienteobj == null || frmAdicionarClienteobj.IsDisposed)
            {
                frmAdicionarClienteobj = new frmAdicionarCliente(listClientes);
                frmAdicionarClienteobj.MdiParent = this;
                frmAdicionarClienteobj.Show();
            }
            else { frmAdicionarClienteobj.Activate(); return;}
        }

        private void tsmiPedido_Click(object sender, EventArgs e)
        {
            if (frmFazerPedidoobj == null || frmFazerPedidoobj.IsDisposed)
            {
                frmFazerPedidoobj = new frmFazerPedido(listClientes, listprodutos);
                frmFazerPedidoobj.MdiParent = this;
                frmFazerPedidoobj.Show();
            }
            else {frmFazerPedidoobj.Activate(); return; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
