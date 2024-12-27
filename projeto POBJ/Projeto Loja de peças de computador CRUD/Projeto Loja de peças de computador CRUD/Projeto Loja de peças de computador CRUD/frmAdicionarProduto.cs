using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    public partial class frmAdicionarProduto : Form
    {
        Produto produtos;
        List<Produto> produtados;
        public frmAdicionarProduto(List<Produto> produtos)
        {
            InitializeComponent();
            produtados = produtos;
        }

        private void AddProduto_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDProduto.Text))
            {
                MessageBox.Show("ERROR ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("ERROR VALOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("ERROR ESTOQUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtNomeProduto.Text))
            {
                MessageBox.Show("ERROR NOME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            produtos = new Produto (Convert.ToInt32(txtIDProduto.Text), txtNomeProduto.Text, Convert.ToInt32(txtEstoque.Text), Convert.ToDouble(txtValor.Text));
            produtados = new List<Produto>();
            produtados.Add(produtos);
            MessageBox.Show("Produto Adicionado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
