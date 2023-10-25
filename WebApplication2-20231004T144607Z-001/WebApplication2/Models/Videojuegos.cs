using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modelsss
{
    public class Videojuegos
    {
        [Key]
        public int id_videojuegos { get; set; }
        public string nombre { get; set; }
        public string tipo_pago { get; set; }
        public bool esgrupal { get; set; }
        public string tipo { get; set; }
        public int id_usuario { get; set; }


    }
}
