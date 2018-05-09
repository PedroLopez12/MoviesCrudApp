using System.Collections.Generic;
using System.Linq;
using MoviesCRUDApp.Models.Movies;

namespace MoviesCRUDApp.Services
{
    public class MovieService : IMovieService
    {
        private readonly List<Movie> movies;

        public MovieService()
        {
            this.movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Zombieland", ReleaseYear = 2009, Summary = "American commedy produced by Columbia Pictures." },
                new Movie { Id = 2, Title = "The Shinning ", ReleaseYear = 1980, Summary = "Based on Sthepen King's novel.Tells Jack Torrance's history, a former alcoholic writer who takes a job as a winter watcher in a hotel in the mountains" },
                new Movie { Id = 3, Title = "The Revenant ", ReleaseYear = 2015, Summary = "American movie starred by Leonardo DiCaprio who won his first Oscar with his character." }
            };
        }

        public List<Movie> GetMovies()
        {
            return this.movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            return this.movies.Where(m => m.Id == id).FirstOrDefault();
        }

        public void AddMovie(Movie item)
        {
            this.movies.Add(item);
        }

        public void UpdateMovie(Movie item)
        {
            var model = this.movies.Where(m => m.Id == item.Id).FirstOrDefault();

            model.Title = item.Title;
            model.ReleaseYear = item.ReleaseYear;
            model.Summary = item.Summary;
        }

        public void DeleteMovie(int id)
        {
            var model = this.movies.Where(m => m.Id == id).FirstOrDefault();

            this.movies.Remove(model);
        }

        public bool MovieExists(int id)
        {
            return this.movies.Any(m => m.Id == id);
        }
    }
}
