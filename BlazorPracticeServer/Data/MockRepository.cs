
using System;
using System.Collections.Generic;
using BlazorPracticeServer.Entity;

namespace BlazorPracticeServer.Data
{
    public class MockRepository : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() {Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2019, 7, 2), Poster="https://terrigen-cdn-dev.marvel.com/content/prod/1x/spider-manfarfromhome_lob_crd_04_0.jpg"},
                new Movie() {Title = "Moana", ReleaseDate = new DateTime(2016, 11, 23), Poster = "https://lumiere-a.akamaihd.net/v1/images/r_moana_header_poststreet_mobile_bd574a31.jpeg?region=0,0,640,480"},
                new Movie() {Title = "Tenet", ReleaseDate = new DateTime(2016, 11, 23), Poster = "https://m.media-amazon.com/images/M/MV5BYzg0NGM2NjAtNmIxOC00MDJmLTg5ZmYtYzM0MTE4NWE2NzlhXkEyXkFqcGdeQXVyMTA4NjE0NjEy._V1_.jpg"},
                new Movie() {Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/81CgNB2mglL._SL1425_.jpg"},
                new Movie() {Title = "IronMan", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_.jpg"},
                new Movie() {Title = "Parasite", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/A1UTpJzoPBL._RI_.jpg"},
                new Movie() {Title = "Thor", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/91P1wWqX63L._SL1500_.jpg"},
                new Movie() {Title = "Pikachu", ReleaseDate = new DateTime(2010, 7, 16), Poster = "https://images-na.ssl-images-amazon.com/images/I/71+PKDjuooL.jpg"}
            };
        }
    }
}
