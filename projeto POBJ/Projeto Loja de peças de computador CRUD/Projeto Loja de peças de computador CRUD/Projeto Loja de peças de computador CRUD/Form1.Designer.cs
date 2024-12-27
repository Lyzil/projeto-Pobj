namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdicionar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAdicionar
            // 
            this.tsmiAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProdutos,
            this.tsmiCliente,
            this.tsmiPedido});
            this.tsmiAdicionar.Name = "tsmiAdicionar";
            this.tsmiAdicionar.Size = new System.Drawing.Size(70, 20);
            this.tsmiAdicionar.Text = "Adicionar";
            // 
            // tsmiProdutos
            // 
            this.tsmiProdutos.Name = "tsmiProdutos";
            this.tsmiProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmiProdutos.Text = "Produto";
            this.tsmiProdutos.Click += new System.EventHandler(this.tsmiProdutos_Click);
            // 
            // tsmiCliente
            // 
            this.tsmiCliente.Name = "tsmiCliente";
            this.tsmiCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmiCliente.Text = "Cliente";
            this.tsmiCliente.Click += new System.EventHandler(this.tsmiCliente_Click);
            // 
            // tsmiPedido
            // 
            this.tsmiPedido.Name = "tsmiPedido";
            this.tsmiPedido.Size = new System.Drawing.Size(180, 22);
            this.tsmiPedido.Text = "Pedido";
            this.tsmiPedido.Click += new System.EventHandler(this.tsmiPedido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 357);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdicionar;
        private System.Windows.Forms.ToolStripMenuItem tsmiProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiPedido;
    }
}

