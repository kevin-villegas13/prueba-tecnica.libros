using System.ComponentModel.DataAnnotations;

namespace Biblioteca.DTO.Author;

public class CreateAuthorDto
{
    [Required(ErrorMessage = "El nombre del autor es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
    public string Name { get; set; } = string.Empty;

}
