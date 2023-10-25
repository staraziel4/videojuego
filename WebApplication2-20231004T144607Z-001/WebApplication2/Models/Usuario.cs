using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public bool genero { get; set; }
        public int edad { get; set; }
        
    }
}