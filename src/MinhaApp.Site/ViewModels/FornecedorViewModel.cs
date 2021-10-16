using System;
using System.Collections.Generic;

namespace MinhaApp.Site.ViewModels
{
    public class FornecedorViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
