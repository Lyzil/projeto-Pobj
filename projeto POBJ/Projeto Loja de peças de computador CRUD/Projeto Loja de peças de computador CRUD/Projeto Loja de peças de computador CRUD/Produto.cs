using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Loja_de_peças_de_computador_CRUD
{
    public class Produto
    {
        private int _id;
        private string _nome;
        private int _estoque = 0; 
        private double _valor;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int Estoque
        {
            get { return _estoque; }
            set { _estoque = value; }
        }
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Produto(int id, string nome, int estoque, double valor)
        {
            _id = id;
            _nome = nome;
            _estoque = estoque;
            _valor = valor;
        }
    }
}
