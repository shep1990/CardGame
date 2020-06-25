using CardGame.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Repositories
{
    public interface ICardRepository
    {
        Task<List<CardNameEntity>> GetAsync();
    }
}
