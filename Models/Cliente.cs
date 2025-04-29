using System.ComponentModel.DataAnnotations;


namespace ConlagoS_PruebaProgeso1.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
        public string Nombre { get; set; }

        [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100.")]
        public int Edad { get; set; }

        [Range(0, 10000, ErrorMessage = "El saldo debe ser positivo y razonable.")]
        public decimal SaldoDisponible { get; set; }

        [Display(Name = "¿Es miembro del club?")]
        public bool EsMiembro { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        [Required(ErrorMessage = "Ingrese una fecha válida.")]
        public DateTime FechaRegistro { get; set; }

        // Relación con reservas
        public ICollection<Reserva> Reserva { get; set; } = new List<Reserva>();
    }
}
