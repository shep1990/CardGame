using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CardGame.Models;
using CardGame.Domain.Services;
using System.Security.Cryptography.X509Certificates;

namespace CardGame.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        public async Task<IActionResult> Index()
        {
            var cards = await _cardService.GetCardSelection();
            var cardViewModel = new List<CardViewModel>();

            foreach(var card in cards)
            {
                cardViewModel.Add(new CardViewModel
                {
                    Id = card.Id,
                    CardImage = card.CardImage
                });
            }

            return View(cardViewModel);
        }
    }
}
