using Microsoft.AspNetCore.Components.Web;

class Movie

interface IMovieService
{
    public IEnumerable<Movie> GetAllMovies();
    public Movie GetMovieById(int id);
    public Movie CreateMovie(Movie movie);
    public Movie UpdateMovieWithId(Movie movie);
    public void DeleteMovieWithId(int id);
}

class MovieService : IMovieService
{
    private List<Movie> movies;

    public MovieService()
    {
        movies = new List<Movie>();
    }

    public IEnumerable<Movie> GetAllMovies()
    {
        return movies;
    }

    public Movie CreateMovie(Movie movie)
    {

    }
}