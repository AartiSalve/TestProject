using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static System.Data.CommandType;
using ProjectSamples.Interface;
using System.Data;
namespace ProjectSamples.Repository
{
    public class LocationRepository:BaseRepository, ILocationRepository
    {
        public IList<Country> GetAllCountry()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Flag", 0);
            IList<Country> customerList = SqlMapper.Query<Country>(con, "Registration", parameters, commandType: StoredProcedure).ToList();
            return customerList;
        }
        public IList<State> GetStateById(int CountryID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Flag", 1);
                parameters.Add("@CountryID", CountryID);
                return SqlMapper.Query<State>((SqlConnection)con, "Registration", parameters, commandType: StoredProcedure).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IList<City> GetCityById(int StateID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Flag", 2);
                parameters.Add("@StateID", StateID);
                return SqlMapper.Query<City>((SqlConnection)con, "Registration", parameters, commandType: StoredProcedure).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
