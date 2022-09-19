using System;
using Totaly.BuldingBlocks.Core.DomainObjects;

namespace Totaly.BuldingBlocks.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}