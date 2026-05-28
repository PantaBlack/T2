using System.ComponentModel.DataAnnotations;
namespace T2_Naranjo_Gianino.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del Distribuidor es obligatorio")]

        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La Razón Social es obligatoria")]

        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]

        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Año de Inicio de Operación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año debe estar entre 1900 y 3000")]

        public int AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }
    }
}