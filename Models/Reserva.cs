using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConlagoS_PruebaProgeso1.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Entrada")]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Salida")]
        public DateTime FechaSalida { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Ingrese un valor válido.")]
        [Display(Name = "Valor a Pagar")]
        public decimal ValorAPagar { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }
    }
}
