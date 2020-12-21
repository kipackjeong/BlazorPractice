﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Services
{
    public class MovieService : IMovieService
    {
        //TODO 2: Implement MovieService
        private readonly IApiBroker apiBroker;


        public MovieService(
            IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async ValueTask<IEnumerable<Movie>> RetrieveAllMovieAsync() =>
            await apiBroker.GetAllMovieAsync();
        public async ValueTask<Movie> RegisterMovieAsync(Movie movie) => 
            await this.apiBroker.PostMovieAsync(movie);
    }
}
