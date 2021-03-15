using nguyenconghau_5951071025.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace nguyenconghau_5951071025.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInflist = new List<WeatherInfo>();
            for ( int i = 0 ; i < 10 ; i++ )
            {
                var weartherInfo = new WeatherInfo
                {
                    Location = $"Location { i }" ,
                    Degree = i * 23 / 17 ,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherInflist.Add(weartherInfo);
            }
            return weatherInflist;
        }

        // GET: api/Weather/5
        public WeatherInfo Get( int id )
        {
            return new WeatherInfo
            {
                Location = $"Location { id }" ,
                Degree = id * 23 / 17 ,
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }

        // POST: api/Weather
        public void Post( [FromBody] string value )
        {
        }

        // PUT: api/Weather/5
        public void Put( int id , [FromBody] string value )
        {
        }

        // DELETE: api/Weather/5
        public void Delete( int id )
        {
        }
    }
}
