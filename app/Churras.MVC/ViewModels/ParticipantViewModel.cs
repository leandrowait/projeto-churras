using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Churras.MVC.ViewModels
{
    public class ParticipantViewModel
    {
        [Key]
        public int ParticipantId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Pago")]
        public bool Paid { get; set; } = false;

        [DataType(DataType.Currency)]
        [Display(Name = "Contribuição")]
        public decimal Contribuition { get; set; }

        [Display(Name = "Observação")]
        public string Observation { get; set; }

        [Display(Name = "Bebida")]
        public bool WithDrink { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}