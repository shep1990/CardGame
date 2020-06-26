using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Domain.Data
{
    public class CardEntity
    {
        public int Id { get; set; }

        public string CardName { get; set; }

        public string CardImage { get; set; }

        public int CardValue { get; set; }
    }
}
