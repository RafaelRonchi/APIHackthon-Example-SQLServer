﻿using APICodeCraft.Models;

namespace APICodeCraft.Services.Interfaces
{
    public interface IQuizService
    {
        Task<IEnumerable<Quiz>> GetAllQuizAsync();
    }
}
