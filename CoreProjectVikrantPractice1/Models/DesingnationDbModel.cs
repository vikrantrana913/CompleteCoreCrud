using System.ComponentModel.DataAnnotations;

namespace CoreProjectVikrantPractice1.Models
{
    public class DesingnationDbModel
    {
        public int JobId { get; set; }

        [Display(Name ="Desingation")]
        public string? JobTitle { get; set; }

    }
}
