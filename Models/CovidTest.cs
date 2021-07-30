using System;
using System.ComponentModel.DataAnnotations;

namespace TransactionTest.Models
{
    public class CovidTest
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public bool Result { get; set; }

        [Required]
        public string ProfessionalName { get; set; }

        public int CitizenId { get; set; }
        public Citizen Citizen { get; set; }
    }
}
