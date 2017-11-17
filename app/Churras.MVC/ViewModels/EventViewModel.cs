using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Churras.MVC.ViewModels
{
    public class EventViewModel
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Observação")]
        public string Observation { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Valor com Bebida")]
        public decimal ValueWithDrink { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Valor sem Bebida")]
        public decimal ValueWithoutDrink { get; set; }

        [Display(Name = "Participantes")]
        public int TotalParticipants { get; private set; }

        [Display(Name = "Total de Participantes que Bebem")]
        public int TotalWithDrinkParticipants { get; private set; }

        [Display(Name = "Total de Participantes que Não Bebem")]
        public int TotalWithoutDrinkParticipants { get; private set; }

        [Display(Name = "Total Arrecadado")]
        [DataType(DataType.Currency)]
        public decimal TotalCollection { get; private set; }

        [Display(Name = "Total a ser Arrecadado")]
        [DataType(DataType.Currency)]
        public decimal TotalTargetCollection { get; private set; }
    }
}