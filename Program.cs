
using System.Reflection.Metadata.Ecma335;
using Microsoft.Net.Http.Headers;

class Movie
{
    private static int id = 0;
    public int Id { get; set; }
    public string Title { get; set; }

    public Movie(string title)
    {
        Title = title;
        Id = _id++;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //Register the list with the dependency container
        builder.Services.AddSingleton<IMovieService, MovieService>();
        var app = builder.Build();


        //GET ALL Movies
        app.MapGet("/movies", (IMovieService movieService) =>
        {
            if (MovieService)
        });

        // create add a movie
        app.MapPost("/movies", (Movie? movie, List<Movie> movies) =>
        {
            if (movie == null)
            {
                return.Results.NotFound();
            }

            movies.Remove(movie);
            return Results.Ok();
        });

        //delete a movie 
        app.MapDelete("/movies/{id}", (int id, List<>) =>
        {
        movies.Find (movie) => (
            Return movie.id == id()
            )
        });

        // Update a movies
        app.MapPut("/movies/{id}", (int id) => $"update movie with id: {id}");

        app.MapGet("/fire", () => "Yooo! this is lit!");

        app.Run();
    }
}