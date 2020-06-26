using System;
using System.Threading.Tasks;

namespace CardGame.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        CardGameDbContext Context { get; }

        int Commit();

        Task<int> CommitAsync();
    }
}
