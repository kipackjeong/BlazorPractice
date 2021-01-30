using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Models;

namespace BlazorPractice.Api.Data.Concrete
{
    public class RatingsRepository : IRatingsRepository
    {
        private AppDbContext _context;

        public RatingsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async ValueTask<Rating> GetRating(int movieId, int userId)
        {
            return null;
        }
        public async ValueTask<Rating> UpdateRating()
        {
            return null;
        }
    }
}
