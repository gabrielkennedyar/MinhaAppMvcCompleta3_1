using Microsoft.EntityFrameworkCore;
using MinhaApp.Business.Interfaces;
using MinhaApp.Business.Models;
using MinhaApp.Data.Context;
using System;
using System.Threading.Tasks;

namespace MinhaApp.Data.Reposioty
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context)
        {

        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}
