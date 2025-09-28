using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace CoreProjectVikrantPractice1.Models
{
    public class CandidateDBContext
    {
        private readonly string Mycon;
        public CandidateDBContext(IConfiguration configuration)
        {
            Mycon = configuration.GetConnectionString("MyConnection");
        }

        public List<DesingnationDbModel> listOfDesingnation()
        {
            List<DesingnationDbModel> desingnationlist=new List<DesingnationDbModel>();
            SqlConnection con = new SqlConnection(Mycon);
            SqlCommand cmd = new SqlCommand("GetDesingnationList",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                DesingnationDbModel desingnationDbModel = new DesingnationDbModel();
                desingnationDbModel.JobId = Convert.ToInt32(sdr["JobId"].ToString());
                desingnationDbModel.JobTitle = sdr["JobTitle"].ToString();
                desingnationlist.Add(desingnationDbModel);  
            }
            return desingnationlist;
        }
        public void CreateCandidateData(CandidateDBModel candidateDBModel)
        {

            SqlConnection con = new SqlConnection(Mycon);
            SqlCommand cmd = new SqlCommand("AddCandidateData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", candidateDBModel.Name);
            cmd.Parameters.AddWithValue("@Gender", candidateDBModel.Gender);
            cmd.Parameters.AddWithValue("@Country", candidateDBModel.Country);
            cmd.Parameters.AddWithValue("@State", candidateDBModel.State);
            cmd.Parameters.AddWithValue("@City", candidateDBModel.City);
            cmd.Parameters.AddWithValue("@Python", candidateDBModel.Python);
            cmd.Parameters.AddWithValue("@Java", candidateDBModel.Java);
            cmd.Parameters.AddWithValue("@Photo", candidateDBModel.Photo);
            cmd.Parameters.AddWithValue("@Desingnation", candidateDBModel.Designation);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

            public List<Country> GetCountry()
            {
            List<Country> countries = new List<Country>();

            SqlConnection con = new SqlConnection(Mycon);
            SqlCommand cmd = new SqlCommand("GetCountryList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                Country country1 = new Country();
                country1.CountryId = Convert.ToInt32(sdr["CountryId"].ToString());
                country1.CountryName = sdr["CountryName"].ToString();
                countries.Add(country1);
            }

            return countries; 
            }

            public List<State> GetStates(int CountId)
            {
            List<State> states = new List<State>();

            SqlConnection con = new SqlConnection(Mycon);
            SqlCommand cmd = new SqlCommand("GetStateList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CountId",CountId);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                State state= new State();
                state.StateId = Convert.ToInt32(sdr["StateId"].ToString());
                state.StateName = sdr["StateName"].ToString();
                states.Add(state);
            }
            return states;
            }
            
            public List<City> GetCity(int statId)
            {
            List<City> city = new List<City>();
            SqlConnection con = new SqlConnection(Mycon);
            SqlCommand cmd = new SqlCommand("GetCityList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatId",statId);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                City city1 = new City();
                city1.CityId = Convert.ToInt32(sdr["CityId"].ToString());
                city1.CityName = sdr["CityName"].ToString();
                city.Add(city1);
            }
            return city;
            }

    }
}
