﻿using System;

namespace MinhaApp.Site.ViewModels
{
    public class EnderecoViewModel
    {
        public Guid Id { get; set; }
        public Guid FornecedorId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }
    }
}
