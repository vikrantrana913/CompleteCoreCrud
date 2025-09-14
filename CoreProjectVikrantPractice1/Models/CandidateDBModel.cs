namespace CoreProjectVikrantPractice1.Models
{
    public class CandidateDBModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Gender { get; set; }

        public int Country { get; set; }

        public int State { get; set; }

        public int City { get; set; }

        public bool Python { get; set; }

        public bool Java { get; set; }

        public string? Photo { get; set; }

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
