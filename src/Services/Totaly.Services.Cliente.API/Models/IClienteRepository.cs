using System.Collections.Generic;
using System.Threading.Tasks;
using Totaly.BuldingBlocks.Core.Data;

namespace Totaly.Services.Clientes.API.Models
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void Adicionar(Cliente cliente);

        Task<IEnumerable<Cliente>> ObterTodos();
        Task<Cliente> ObterPorCpf(string cpf);
    }
}