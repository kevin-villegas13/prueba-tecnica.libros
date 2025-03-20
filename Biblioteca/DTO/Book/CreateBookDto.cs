using System.ComponentModel.DataAnnotations;

namespace Biblioteca.DTO.Book;
public class CreateBookDto
{
    [Required(ErrorMessage = "El título del libro es obligatorio.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debes seleccionar un autor.")]
    public int AuthorId { get; set; }
}

