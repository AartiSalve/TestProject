using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSamples.Interface;
namespace ProjectSamples.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        ILocationRepository _LocationManager;
        public LocationController(ILocationRepository LocationManagerManager)
        {
            _LocationManager = LocationManagerManager;
        }

        [HttpGet]
        [Route("api/Location/GetCountries")]
        public IEnumerable<Country> GetCountry()
        {
            return _LocationManager.GetAllCountry();
        }


        [HttpGet]
        [Route("api/Location/GetState/{countryid?}")]
        public IEnumerable<State> GetState(int countryID)
        {
            return _LocationManager.GetStateById(countryID);
        }

        [HttpGet]
        [Route("api/Location/GetCity/{stateID?}")]
        public IEnumerable<City> Get(int stateID)
        {
            return _LocationManager.GetCityById(stateID);
        }

    }
}