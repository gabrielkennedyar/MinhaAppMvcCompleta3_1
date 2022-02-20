using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MinhaApp.Business.Models
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public ICollection<CategoriaProduto> CategoriaProdutos { get; set; }
    }
}
