using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Totaly.BuldingBlocks.Core.Data;

namespace Totaly.Services.Catalogo.API.Models
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);

        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
    }
}