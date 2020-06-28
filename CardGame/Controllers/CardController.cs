using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CardGame.Models;
using CardGame.Domain.Services;
using System;
using log4net;

namespace CardGame.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardService _cardService;
        private readonly ILog _logger = LogManager.GetLogger(typeof(CardController));

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetCards(int? cardAmount)
        {
            try
            {
                var setAmount = (cardAmount.HasValue) ? cardAmount.Value : 5;

                var cards = await _cardService.GetCardSelection(setAmount);

                var cardViewModel = new List<CardViewModel>();

                foreach (var card in cards)
                {
                    cardViewModel.Add(new CardViewModel
                    {
                        Id = card.Id,
                        CardImage = card.CardImage
                    });
                }

                return Json(new { success = true, responseObj = cardViewModel });
            }
            catch(Exception ex)
            {
                _logger.Error(String.Format("An error occurred: {0}", ex.Message));
                return Json(new { success = false, responseText = "An error occurred" });
            }

        }
    }
}
