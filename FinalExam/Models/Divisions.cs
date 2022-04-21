using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Models
{

    public class Divisions
    {
        [Key]
        [Column(Order = 0, TypeName = "int")]
        public int DivisionID { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "VARCHAR(50)")]
        [Display(Name = "Division")]
        public string Name { get; set; }

        public ICollection<Teams> Teams { get; set; }
    }
}
