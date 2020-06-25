using CardGame.Domain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public CardRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<string>> GetAsync()
        {
            var cards = await _unitOfWork.Context.Set<CardNameEntity>().Select(x => x.CardName).ToListAsync();

            var cardSelection = cards.OrderBy(x => Guid.NewGuid()).Take(5).ToList();

            return cardSelection;
        }
    }
}
