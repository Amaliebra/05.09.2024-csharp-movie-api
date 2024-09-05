
using Microsoft.Net.Http.Headers;

class Movie
{
    private static int id = 0;
    public int id(get; set; )
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
        builder.Services.AddSingleton<List<Movie>>();
        var app = builder.Build();


        //GET ALL Movies
        app.MapGet("/movies", (List<Movie> movies) => movies);

        // create add a movie
        app.MapPost("/movies", (Movie? movie, List<Movie> movies) =>
        {
            if (movie == null)
            {
                return.Results.BadRequest();
            }

            return Results.Created();
        });

        //delete a movie 
        app.MapDelete("/movies/{id}", (int id) => $"delete movie with id: {id}");

        // Update a movies
        app.MapPut("/movies/{id}", (int id) => $"update movie with id: {id}");

        app.MapGet("/fire", () => "Yooo! this is lit!");

        app.Run();
    }
}