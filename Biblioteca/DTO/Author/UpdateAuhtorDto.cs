
using Biblioteca.DTO.Book;

namespace Biblioteca.DTO.Author;

public class UpdateAuthorDto : CreateAuthorDto
{
    public List<BookDto> Books { get; set; } = [];
}

