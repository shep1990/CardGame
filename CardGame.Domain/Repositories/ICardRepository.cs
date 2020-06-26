using CardGame.Domain.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardGame.Domain.Repositories
{
    public interface ICardRepository
    {
        Task<List<CardEntity>> GetAsync(int cardAmount);
    }
}
