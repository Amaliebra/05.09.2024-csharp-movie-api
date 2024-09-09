using Microsoft.AspNetCore.Components.Web;

class Movie

interface IMovieService
{
    public IEnumerable<Movie> GetAllMovies();
    public Movie GetMovieById(int id);
    public Movie CreateMovie(Movie movie);
    public Movie? UpdateMovieWithId(Movie movie, Movie updateMovieInfo);
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
        movies.Add(movie);

        return movie;
    }

    public Movie UpdateMovieWithId(Movie movie)
    {
        //Find the correct movie
        var movie = movies.Find{ (movie) => movie.Id == id};

        if (movie == null)
        {
            return null;
        }

        movie.Title = updateMovieInfo.Title;
        //Update
        return movie;

    }

    public void DeleteMovieWithId(int id)
    {
        var movie = MovieService.Find{ (movie) => movie.Id == id};
        if ()
    }
}