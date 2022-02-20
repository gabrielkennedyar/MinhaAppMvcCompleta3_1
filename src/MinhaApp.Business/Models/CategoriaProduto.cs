using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaApp.Business.Models
{
    public class CategoriaProduto : Entity
    {
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
