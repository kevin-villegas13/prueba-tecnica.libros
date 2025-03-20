namespace Biblioteca.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }


    // Relaciones con Author
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}

