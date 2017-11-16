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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Required]
        public string Description { get; set; }

        public string Observation { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValueWithDrink { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValueWithoutDrink { get; set; }

        public int TotalParticipants { get; private set; }

        public int TotalWithDrinkParticipants { get; private set; }

        public int TotalWithoutDrinkParticipants { get; private set; }

        [DataType(DataType.Currency)]
        public decimal TotalCollection { get; private set; }

        [DataType(DataType.Currency)]
        public decimal TotalTargetCollection { get; private set; }
    }
}