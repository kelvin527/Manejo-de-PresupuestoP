using System.ComponentModel.DataAnnotations;

namespace ManejoDePresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public int Orden { get; set; }
    }
}
