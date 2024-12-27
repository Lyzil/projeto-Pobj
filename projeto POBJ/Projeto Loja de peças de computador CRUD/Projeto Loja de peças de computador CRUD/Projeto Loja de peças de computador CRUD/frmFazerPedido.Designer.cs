namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    partial class frmFazerPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProdutoPedido = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.lvwExibirInfoCliente = new System.Windows.Forms.ListView();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.rbtnCPF = new System.Windows.Forms.RadioButton();
            this.rbtnNome = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbNomeProduto = new System.Windows.Forms.ComboBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome ou CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade pedida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do produto:";
            // 
            // btnAddProdutoPedido
            // 
            this.btnAddProdutoPedido.Location = new System.Drawing.Point(360, 96);
            this.btnAddProdutoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProdutoPedido.Name = "btnAddProdutoPedido";
            this.btnAddProdutoPedido.Size = new System.Drawing.Size(149, 49);
            this.btnAddProdutoPedido.TabIndex = 6;
            this.btnAddProdutoPedido.Text = "Adicionar Produto ao pedido";
            this.btnAddProdutoPedido.UseVisualStyleBackColor = true;
            this.btnAddProdutoPedido.Click += new System.EventHandler(this.btnAddProdutoPedido_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(400, 224);
            this.btnFinalizarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(90, 57);
            this.btnFinalizarPedido.TabIndex = 7;
            this.btnFinalizarPedido.Text = "Finalizar pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // lvwExibirInfoCliente
            // 
            this.lvwExibirInfoCliente.HideSelection = false;
            this.lvwExibirInfoCliente.Location = new System.Drawing.Point(27, 145);
            this.lvwExibirInfoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.lvwExibirInfoCliente.Name = "lvwExibirInfoCliente";
            this.lvwExibirInfoCliente.Size = new System.Drawing.Size(296, 195);
            this.lvwExibirInfoCliente.TabIndex = 9;
            this.lvwExibirInfoCliente.UseCompatibleStateImageBehavior = false;
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Location = new System.Drawing.Point(164, 28);
            this.txtPesquisarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(159, 22);
            this.txtPesquisarCliente.TabIndex = 10;
            // 
            // rbtnCPF
            // 
            this.rbtnCPF.AutoSize = true;
            this.rbtnCPF.Location = new System.Drawing.Point(351, 30);
            this.rbtnCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCPF.Name = "rbtnCPF";
            this.rbtnCPF.Size = new System.Drawing.Size(54, 20);
            this.rbtnCPF.TabIndex = 11;
            this.rbtnCPF.TabStop = true;
            this.rbtnCPF.Text = "CPF";
            this.rbtnCPF.UseVisualStyleBackColor = true;
            // 
            // rbtnNome
            // 
            this.rbtnNome.AutoSize = true;
            this.rbtnNome.Location = new System.Drawing.Point(439, 30);
            this.rbtnNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnNome.Name = "rbtnNome";
            this.rbtnNome.Size = new System.Drawing.Size(65, 20);
            this.rbtnNome.TabIndex = 12;
            this.rbtnNome.TabStop = true;
            this.rbtnNome.Text = "Nome";
            this.rbtnNome.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 60);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 28);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbNomeProduto
            // 
            this.cmbNomeProduto.FormattingEnabled = true;
            this.cmbNomeProduto.Location = new System.Drawing.Point(164, 57);
            this.cmbNomeProduto.Name = "cmbNomeProduto";
            this.cmbNomeProduto.Size = new System.Drawing.Size(159, 24);
            this.cmbNomeProduto.TabIndex = 15;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(164, 92);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(159, 22);
            this.txtQtd.TabIndex = 16;
            // 
            // frmFazerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(555, 385);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.cmbNomeProduto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbtnNome);
            this.Controls.Add(this.rbtnCPF);
            this.Controls.Add(this.txtPesquisarCliente);
            this.Controls.Add(this.lvwExibirInfoCliente);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnAddProdutoPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFazerPedido";
            this.Text = "frmFazerPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProdutoPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.ListView lvwExibirInfoCliente;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.RadioButton rbtnCPF;
        private System.Windows.Forms.RadioButton rbtnNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbNomeProduto;
        private System.Windows.Forms.TextBox txtQtd;
    }
}