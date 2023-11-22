using System.ComponentModel.DataAnnotations;

namespace lista_usuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no debe ser mayor de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(1, 100, ErrorMessage = "La edad debe estar entre 1 y 100 años")]
        public int Edad { get; set; }
    }
}
