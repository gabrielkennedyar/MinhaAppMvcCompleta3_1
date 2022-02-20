using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaApp.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaApp.Data.Mappings
{
    public class CategoriaProdutoMapping : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder.HasKey(cp => new { cp.CategoriaId, cp.ProdutoId });

            builder.HasOne(cp => cp.Categoria)
                .WithMany(cp => cp.CategoriaProdutos)
                .HasForeignKey(cp => cp.CategoriaId);

            builder.HasOne(cp => cp.Produto)
                .WithMany(cp => cp.CategoriaProdutos)
                .HasForeignKey(cp => cp.ProdutoId);
        }
    }
}
