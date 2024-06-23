using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T3_Apaza_Romero.Models
{
    public class Libro
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El tìtulo del libro es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El tema es obligatorio")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "La editorial es obligatoria")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El año de publicaciòn es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año debe ser entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El nùmero de pàginas es obligatorio")]
        [Range(10, 1000, ErrorMessage = "El nùmero de pàginas debe estar entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La categorìa es obligatoria")]
        public string Categoria { get; set; }

    }
}
