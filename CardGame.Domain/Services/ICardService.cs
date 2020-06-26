using CardGame.Domain.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardGame.Domain.Services
{
    public interface ICardService
    {
        Task<List<CardEntity>> GetCardSelection(int cardAmount);
    }
}
