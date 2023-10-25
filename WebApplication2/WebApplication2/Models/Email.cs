using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modelss
{
    public class Email
    {
        [Key]
        public int id_email { get; set; }
        public string email { get; set; }
        public int id_usuario { get; set; }
       
    }
}