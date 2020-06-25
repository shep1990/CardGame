﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Domain.Services
{
    public interface ICardService
    {
        Task<List<string>> GetCardSelection();
    }
}
