using System;

namespace MinhaApp.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Imagem { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }

        public Fornecedor Fornecedor { get; private set; }

        public void Atualizar(string nome, string descricao, decimal valor, string imagem, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Imagem = imagem;
            Ativo = ativo;
        }
    }
}
