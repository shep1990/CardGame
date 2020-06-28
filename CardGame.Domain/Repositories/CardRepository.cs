using CardGame.Domain.Data;
using log4net;
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
        private readonly ILog _logger = LogManager.GetLogger(typeof(CardRepository));

        public CardRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<CardEntity>> GetAsync(int cardAmount)
        {
            try
            {
                var cards = await _unitOfWork.Context.Set<CardEntity>().ToListAsync();

                var shuffledCards = cards.OrderBy(x => Guid.NewGuid());

                var cardSelection = shuffledCards.Take(cardAmount).OrderByDescending(x => x.CardValue).ToList();

                return cardSelection;
            }
            catch(Exception ex)
            {
                _logger.Error(String.Format("An error occurred in the card repository: {0}", ex.Message));
                throw ex;
            }
        }
    }
}
