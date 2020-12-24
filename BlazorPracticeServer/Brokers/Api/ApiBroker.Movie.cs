﻿using BlazorPracticeServer.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPracticeServer.Entity.Dtos.MovieDto;

namespace BlazorPracticeServer.Brokers.Api
{
    public partial class ApiBroker
    {
        private const string _movieUrl = "/api/movie";

        public async ValueTask<AllMoviesDto> GetAllMovieAsync() =>
            await GetAllIndexAsync<AllMoviesDto>(_movieUrl);

        public async ValueTask<Movie> GetMovieByIdAsync(int id) =>
            await GetAsync<Movie>(_movieUrl+$"/{id}");

        public async ValueTask<IEnumerable<Movie>> GetAllMovieByName(string searchText) =>
            await GetAllFilteredAsync<Movie>(_movieUrl + $"/search/{searchText}");

        public async ValueTask<Movie> PostMovieAsync(Movie movie) =>
            await PostAsync(_movieUrl, movie);

        public async ValueTask<Movie> PutMovieAsync(Movie movie, int id) =>
            await PutAsync(_movieUrl + $"/{id}", movie);

        public async ValueTask<Movie> DeleteMovieAsync(int id) =>
            await DeleteAsync<Movie>(_movieUrl + $"/{id}");
    }
}