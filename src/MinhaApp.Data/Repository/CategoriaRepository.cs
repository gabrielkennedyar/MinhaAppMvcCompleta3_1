using MinhaApp.Business.Interfaces;
using MinhaApp.Business.Models;
using MinhaApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaApp.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(MeuDbContext context) : base(context)
        {

        }
    }
}
