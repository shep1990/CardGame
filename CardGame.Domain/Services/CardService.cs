using CardGame.Domain.Data;
using CardGame.Domain.Repositories;
using log4net;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardGame.Domain.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly ILog _logger = LogManager.GetLogger(typeof(CardService));

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<List<CardEntity>> GetCardSelection(int cardAmount)
        {
            try
            {
                return await _cardRepository.GetAsync(cardAmount);
            }
            catch(Exception ex)
            {
                _logger.Error(String.Format("An error occurred in the card service: {0}", ex.Message));
                throw ex;
            }
        }
    }
}
