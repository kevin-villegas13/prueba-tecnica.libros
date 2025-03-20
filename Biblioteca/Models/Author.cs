namespace Biblioteca.Models;

public class Author
{
    public int AuthorId { get; set; }
    public string? Name { get; set; }

    // Relación uno a muchos: Un autor puede tener varios libros
    public List<Book> Books { get; set; } = [];
}

