using MinhaApp.Business.Models;
using System;
using System.Threading.Tasks;

namespace MinhaApp.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
