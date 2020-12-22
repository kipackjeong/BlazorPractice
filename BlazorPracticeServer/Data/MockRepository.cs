
using BlazorPracticeServer.Entity;
using System;
using System.Collections.Generic;

namespace BlazorPracticeServer.Data
{
    public class MockRepository : IRepository
    {
        public List<Movie> Movies { get; set; }
        public List<Genre> Genres { get; set; }

        public MockRepository()
        {
            Genre Action = new Genre() { Id = 1, Name = "Action" };
            Genre Comedy = new Genre() { Id = 2, Name = "Comedy" };
            Genre Horror = new Genre() { Id = 3, Name = "Horror" };
            Genre Fantasy = new Genre() { Id = 4, Name = "Fantasy" };

            ;
            Movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1, Genre = Action, Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2019, 7, 2),  Poster="https://terrigen-cdn-dev.marvel.com/content/prod/1x/spider-manfarfromhome_lob_crd_04_0.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 1,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                        MovieId = 1,
                        Genre = Comedy,
                        GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 1,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 2, Genre = Fantasy, Title = "Moana", ReleaseDate = new DateTime(2016, 11, 23), Poster = "https://lumiere-a.akamaihd.net/v1/images/r_moana_header_poststreet_mobile_bd574a31.jpeg?region=0,0,640,480",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 1,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 1,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 3, Genre = Action, Title = "Tenet", ReleaseDate = new DateTime(2016, 11, 23), Poster = "https://m.media-amazon.com/images/M/MV5BYzg0NGM2NjAtNmIxOC00MDJmLTg5ZmYtYzM0MTE4NWE2NzlhXkEyXkFqcGdeQXVyMTA4NjE0NjEy._V1_.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 3,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                            MovieId = 3,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 3,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 4, Genre = Fantasy, Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/81CgNB2mglL._SL1425_.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 4,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                            MovieId = 4,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 4,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 5, Genre = Action, Title = "IronMan", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 5,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                            MovieId = 5,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 5,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 6, Genre = Horror, Title = "Parasite", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/A1UTpJzoPBL._RI_.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 6,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                            MovieId = 6,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 6,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 7, Genre = Action ,Title = "Thor", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/91P1wWqX63L._SL1500_.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 7,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                            MovieId = 7,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 7,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                },
                new Movie()
                {
                    Id = 8,Genre = Comedy,Title = "Pikachu", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/71+PKDjuooL.jpg",
                    MovieGenres = new List<MovieGenre>
                    {
                        new MovieGenre
                        {
                            MovieId = 8,
                            Genre = Action,
                            GenreId = 1
                        },
                        new MovieGenre
                        {
                            MovieId = 8,
                            Genre = Comedy,
                            GenreId = 2
                        },
                        new MovieGenre
                        {
                            MovieId = 8,
                            Genre = Fantasy,
                            GenreId = 4
                        },
                    }
                }
            };
            Genres = new List<Genre>()
            {
                Action,
                Comedy,
                Horror,
                Fantasy
            };
        }
    }
}
