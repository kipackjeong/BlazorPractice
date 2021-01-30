using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPractice.Api.Data.Contract;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Entity.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private UserManager<IdentityUser> _userManager;
        private IRatingsRepository _repo;
        public RatingsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async ValueTask<Rating> GetRating(Movie movie)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(HttpContext.User.Identity.Name);
            string userId = user.Id;

            return null;
        }
    }
}
