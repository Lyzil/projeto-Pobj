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
    public partial class frmAdicionarCliente : Form
    {
        List<Cliente> listaclientes;
        Cliente cliente;
        public frmAdicionarCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            listaclientes = clientes;
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCPF.Text)) { 
                MessageBox.Show("ERROR CPF", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtNomeCliente.Text))
            {
                MessageBox.Show("ERROR NOME", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtLagradouro.Text))
            {
                MessageBox.Show("ERROR LAGRADOURO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("ERROR ESTADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtSaldo.Text))
            {
                MessageBox.Show("ERROR SALDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cliente = new Cliente(txtCPF.Text, txtNomeCliente.Text, txtSexo.Text, txtCidade.Text, txtLagradouro.Text, txtEstado.Text, txtPais.Text, Convert.ToDouble(txtSaldo.Text));
            listaclientes = new List<Cliente>();
            listaclientes.Add(cliente);
            MessageBox.Show("Cliente Adicionado","Sucesso!", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
