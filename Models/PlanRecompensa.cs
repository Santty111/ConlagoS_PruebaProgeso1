using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConlagoS_PruebaProgeso1.Models
{
    public class PlanRecompensa
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage = "El nombre del plan es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no debe superar los 100 caracteres.")]
        public string Nombre { get; set; } 

        [Required(ErrorMessage = "Debe ingresar la fecha de inicio.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; } 

        [Range(0, int.MaxValue, ErrorMessage = "Los puntos acumulados deben ser positivos.")]
        [Display(Name = "Puntos Acumulados")]
        public int PuntosAcumulados { get; set; } 

        [NotMapped]
        [Display(Name = "Tipo de Recompensa")]
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados < 500 ? "SILVER" : "GOLD";
            }
        }

       
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
