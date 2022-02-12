using MinhaApp.Business.Interfaces;
using MinhaApp.Business.Models;
using MinhaApp.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace MinhaApp.Business.Services
{
    public class ProdutoService : BaseServices, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new AdicionarProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new AtualizarProdutoValidation(), produto)) return;

            var produtoExistente = await _produtoRepository.ObterPorId(produto.Id);
            produtoExistente.Atualizar(produto.Nome, produto.Descricao, produto.Valor, produto.Imagem, produto.Ativo);

            await _produtoRepository.Atualizar(produtoExistente);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
