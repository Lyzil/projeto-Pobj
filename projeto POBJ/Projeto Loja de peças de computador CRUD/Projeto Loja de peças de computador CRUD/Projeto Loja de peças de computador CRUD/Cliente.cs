using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Projeto_Loja_de_peças_de_computador_CRUD
//{
public class Cliente
    {
        private string _cpf;
        private string _nome;
        private string _sexo;
        private string _cidade;
        private string _lagrouro;
        private string _estado;
        private string _pais;
        private double _saldo = 0;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Lagrouro
        {
            get { return _lagrouro; }
            set { _lagrouro = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        public double Saldo
        {
            get { return _saldo ; }
            set { _saldo = value; }
        }

        public Cliente(string cpf, string nome,string sexo,string cidade, string logradouro, string estado, string pais, double saldo)
        {
            _cpf = cpf;
            _nome = nome;
            _sexo = sexo;
            _cidade = cidade;
            _lagrouro = logradouro;
            _estado = estado;
            _pais = pais;
            _saldo = saldo;
        }
        public bool AdicionarSaldo (double novosaldo) 
        {
        if (novosaldo < 0) 
            return false;

        _saldo += novosaldo;
        return true;
    }

        public bool DescontarSaldo (double novosaldo)
        {
        if (_saldo >= novosaldo)
        {
            _saldo -= novosaldo;
            return true;
        }
        return false;
    }
}
