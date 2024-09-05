var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//GET ALL Movies
app.MapGet("/movies", () => "returns all movies");

// create add a movie
app.MapPost("/movies", () => "add a new movie");

//delete a movie 
app.MapDelete("/movies/{id}", (int id) => $"delete movie with id: {id}");

// Update a movies
app.MapPut("/movies/{id}", (int id) => $"update movie with id: {id}");

app.MapGet("/fire", () => "Yooo! this is lit!");

app.Run();
