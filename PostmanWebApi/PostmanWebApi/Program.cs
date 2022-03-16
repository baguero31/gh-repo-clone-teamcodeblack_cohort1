using PostmanWebApi.DAO;
using PostmanWebApi.DataModels;

var builder = WebApplication.CreateBuilder(args);
var _connString = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


/// <summary>
/// GetAuthors 
/// </summary>
/// <remarks>
/// Returns an IEnumerable list of Authors
/// </remarks>
app.MapGet("/authors", () =>
{
    IDataAccess dao = new DataAccess(_connString);
    var authors = dao.GetAuthors();
    return authors.ToList();
}).WithName("GetAuthors");

/// <summary>
/// GetAuthorsById
/// </summary>
/// <remarks>
/// Returns an IEnumerable list of authors by id
/// </remarks>
app.MapGet("/authors/{id}", (string id) =>
{   
    IDataAccess dao = new DataAccess(_connString);
    var authors = dao.GetAuthorById(id);
    return authors.ToList();
}).WithName("GetAuthorById");

/// <summary>
/// InsertNewAuthor
/// </summary>
/// <remarks>
/// Returns an IEnumerable list of authors by id
/// </remarks>
app.MapPost("/authors", (AuthorModel model) =>
{
    IDataAccess dao = new DataAccess(_connString);
    var insertAuthors = dao.CreateNewAuthor(model);
    return insertAuthors;
}).WithName("PostAuthor");

/// <summary>
/// DeleteAuthor
/// </summary>
/// <remarks>
/// Deletes an identified author
/// </remarks>
app.MapDelete("/authors/{id}", (string id) =>
{
    IDataAccess dao = new DataAccess(_connString);
    var insertAuthors = dao.DeleteAuthor(id);
    return insertAuthors;
}).WithName("DeleteAuthor");

//comment to check repo settings

app.Run();
