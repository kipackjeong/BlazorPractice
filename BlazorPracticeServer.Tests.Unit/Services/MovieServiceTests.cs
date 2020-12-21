using BlazorPracticeServer.Brokers.Api;
using BlazorPracticeServer.Entity;
using BlazorPracticeServer.Services;
using Moq;
using System;
using Tynamix.ObjectFiller;

namespace BlazorPracticeServer.Tests.Unit.Services
{
    public class MovieServiceTests
    {
        private readonly Mock<IApiBroker> _apiBrokerMock;
        private readonly IMovieService _movieService;

        public MovieServiceTests()
        {
            _apiBrokerMock = new Mock<IApiBroker>();
            _movieService = new MovieService(
                apiBroker: this._apiBrokerMock.Object
                );
        }

        private static Movie CreateRandomMovie() =>
            CreateMovieFiller().Create();

        private static Filler<Movie> CreateMovieFiller()
        {
            var filler = new Filler<Movie>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(DateTimeOffset.UtcNow);

            return filler;
        }
    }
}