using CardGame.Domain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<CardEntity>> GetAsync(int cardAmount)
        {
            var cards = await _unitOfWork.Context.Set<CardEntity>().ToListAsync();

            var shuffledCards = cards.OrderBy(x => Guid.NewGuid());

            var cardSelection = shuffledCards.Take(cardAmount).OrderByDescending(x => x.CardValue).ToList();

            return cardSelection;
        }
    }
}
