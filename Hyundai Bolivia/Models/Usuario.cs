using Hyundai_Bolivia.Dtos;

namespace Hyundai_Bolivia.Models
{
    public class Usuario
    {
        public string? NombreCompleto { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public RolEnum Rol { get; set; }
    }
}
