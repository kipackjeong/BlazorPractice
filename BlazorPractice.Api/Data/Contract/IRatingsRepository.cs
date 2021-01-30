using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Models;

namespace BlazorPractice.Api.Data.Contract
{
    public interface IRatingsRepository
    {
        ValueTask<Rating> GetRating(int movieId, int userId);
        ValueTask<Rating> UpdateRating();
    }
}
