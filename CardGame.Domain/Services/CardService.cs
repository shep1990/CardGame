using CardGame.Domain.Data;
using CardGame.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<List<CardNameEntity>> GetCardSelection()
        {
            return await _cardRepository.GetAsync();
        }
    }
}
