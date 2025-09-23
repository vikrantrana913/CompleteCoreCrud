using System.ComponentModel.DataAnnotations;

namespace CoreProjectVikrantPractice1.Models
{
    public class CandidateDBModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The field is required.")]
        [Display(Name="Name")]
        [MaxLength(50,ErrorMessage ="Maximum 50 charactor")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public int Country { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public int State { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public int City { get; set; }

        public bool Python { get; set; }

        public bool Java { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public string? Photo { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public int Designation { get; set; }    
    }

    public class Country
    {
        public int CountryId { get; set; }

        public string? CountryName { get; set; }

    }

    public class State
    {
        public int StateId { get; set; }

        public string? StateName { get; set; }

        public int CountryId { get; set; }

    }

    public class City
    {
        public int CityId { get; set; }

        public string? CityName { get; set; }

        public int StateId { get; set; }
    }



}
