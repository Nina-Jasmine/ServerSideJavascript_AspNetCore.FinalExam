using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Models
{
    public class Teams
    {

        [Key]
        [Column(Order = 0, TypeName = "int")]
        public int TeamID { get; set; }
        [Required]
        [Column(Order = 1, TypeName = "VARCHAR(50)")]
        [Display(Name = "Team")]
        public string Name { get; set; }

        [Column(Order = 2, TypeName = "int")]
        [Display(Name = "GP")]
        public int Games { get; set; }


        [Column(Order = 3, TypeName = "int")]
        [Display(Name = "W")]
        public int Wins { get; set; }
        [Column(Order = 4, TypeName = "int")]
        [Display(Name = "L")]
        public int Losses { get; set; }
        [Column(Order = 5, TypeName = "int")]
        [Display(Name = "OT")]
        public int OvertimeLosses { get; set; }
        [Column(Order = 6, TypeName = "int")]
        [Display(Name = "PTS")]
        public int Points { get; set; }

        [Required]
        [Column(Order = 7, TypeName = "int")]
        public int DivisionID { get; set; }
        [ForeignKey("DivisionID")]
        public Divisions Divisions { get; set; }


        [Column(Order = 8, TypeName = "VARCHAR(100)")]
        public string Logo { get; set; }

    }
}