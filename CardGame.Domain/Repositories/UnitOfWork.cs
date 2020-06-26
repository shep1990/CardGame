using System.Threading.Tasks;

namespace CardGame.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public CardGameDbContext Context { get; }

        public UnitOfWork(CardGameDbContext context)
        {
            Context = context;
        }

        public int Commit()
        {
            return Context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
