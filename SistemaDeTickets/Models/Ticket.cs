using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTickets.Models
{
    public class Ticket
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(600)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }


        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hour")]
        public DateTime Hour { get; set; }
    }
}

