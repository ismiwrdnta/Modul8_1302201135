using System;
using Microsoft.AspNetCore.Mvc;


namespace modul8_1302201135.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovController : Controller
    {
        public static List<string> tsr = new List<string>
        {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"
        };

        public static List<string> tgf = new List<string>
        {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        };

        public static List<string> tdk = new List<string>
        {
            "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"
        };

        public static List<Movie> LMovies = new List<Movie>();

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            LMovies.Add(new Movie("The Shawshank Redemption", "Frank Darabont", tsr, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."));
            LMovies.Add(new Movie("The Godfather", "Francis Ford Coppola", tgf, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."));
            LMovies.Add(new Movie("The Dark Knight", "Christopher Nolan", tdk, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."));
            return LMovies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            LMovies.Add(movie);

        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return LMovies[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            LMovies.RemoveAt(id);
        }
    }
}

