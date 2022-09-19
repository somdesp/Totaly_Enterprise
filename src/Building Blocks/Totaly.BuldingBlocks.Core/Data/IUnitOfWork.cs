using System.Threading.Tasks;

namespace Totaly.BuldingBlocks.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}