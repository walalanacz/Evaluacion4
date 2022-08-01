using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluacion4.Models
{
    [Table("Auto")]
    public class Auto
    {
        public int Id { get; set; }
        public int AutomotoraId { get; set; }
        public string Modelo { get; set; }
        public int Cantidad { get; set; }

        // Relaciones
        public virtual Automotora Automotora { get; set; }
    }
}
