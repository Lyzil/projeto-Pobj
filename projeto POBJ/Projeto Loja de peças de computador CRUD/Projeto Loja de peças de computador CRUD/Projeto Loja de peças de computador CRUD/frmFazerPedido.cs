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
    public partial class frmFazerPedido : Form
    {
        List<Cliente> listClientes;
        List<Produto> listprodutos;
        List<PedidoCompra> listapedidos;


         public frmFazerPedido(List<Cliente> clientes, List<Produto> produtos)
        
        {
            InitializeComponent();
            this.listClientes = clientes;
            this.listprodutos  = produtos;
            listapedidos = new List<PedidoCompra>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnCPF.Checked)
            {
                foreach (var cliente in listClientes)
                {
                    if (cliente.CPF == txtPesquisarCliente.Text)
                    {
                    ListViewItem item = new ListViewItem(cliente.CPF);
                    lvwExibirInfoCliente.Items.Add(item);

                    }
                }
            }
            else if (rbtnNome.Checked)
            {
                foreach (var cliente in listClientes)
                {
                    if (cliente.Nome == txtPesquisarCliente.Text)
                    {
                        ListViewItem item = new ListViewItem(cliente.Nome);
                        lvwExibirInfoCliente.Items.Add(item);

                    }
                }
            }
        }
        private List<ItemCompra> itensDoPedidoAtual = new List<ItemCompra>();

        private void btnAddProdutoPedido_Click(object sender, EventArgs e)
        {
            // Obter o cliente e o produto selecionados
            Produto produtoSelecionado = (Produto)cmbNomeProduto.SelectedItem;

            // Validar a quantidade
            int quantidade;
            if (!int.TryParse(txtQtd.Text, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.");
                return;
            }

            // Verificar o estoque
            if (quantidade > produtoSelecionado.Estoque)
            {
                MessageBox.Show("Quantidade insuficiente no estoque.");
                return;
            }

            // Criar o item do pedido
            ItemCompra item = new ItemCompra();
            {
                //Produto = produtoSelecionado; // Supondo que exista essa propriedade
                //txtQtd.Text = quantidade;
                //CalcularValorTotal(); // Calcular o subtotal
            };

            // Atualizar o estoque
            //produtoSelecionado.Quantidade -= quantidade;

            // Adicionar o item à lista de itens do pedido atual
            itensDoPedidoAtual.Add(item);

            // Atualizar a interface
            // AtualizarItensDoPedido();
        }
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            
        }

    }
}
