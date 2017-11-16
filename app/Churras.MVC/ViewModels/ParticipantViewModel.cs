using Churras.Domain.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Churras.MVC.ViewModels
{
    public class ParticipantViewModel
    {
        [Key]
        public int ParticipantId { get; set; }

        [Required]
        public string Name { get; set; }

        public bool Paid { get; set; } = false;

        [DataType(DataType.Currency)]
        public decimal Contribuition { get; set; }

        public DrinkOption DrinkOption { get; set; }
    }
}