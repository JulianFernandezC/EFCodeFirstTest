using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionTest.Models
{
    public class Citizen
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Lastname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Passport { get; set; }

        [Required]
        [MaxLength(20)]
        public string Dni { get; set; }


        public ICollection<CovidTest> CovidTests { get; set; }
    }
}