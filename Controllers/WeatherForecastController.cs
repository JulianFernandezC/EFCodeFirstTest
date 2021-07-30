using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransactionTest.Context;
using TransactionTest.Models;

namespace TransactionTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly CovidDBContext _dbContext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, CovidDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public bool Get()
        {            
            var citizen = new Citizen()
            {
                Name = "Maria",
                Lastname = "Perez",
                Birthdate = DateTime.Now,
                Dni = "68572555",
                Passport = "Y282BSAW"
            };
            var covidTestList = new List<CovidTest>()
            {
                new CovidTest()
                {
                    Date = DateTime.Now.AddMonths(-1),
                    ProfessionalName="Doc. 2",
                    Result = false
                },
                new CovidTest()
                {
                    Date = DateTime.Now,
                    ProfessionalName="Doc. 3",
                    Result = true
                }
            };
            citizen.CovidTests = covidTestList;

            _dbContext.Citizen.Add(citizen);
            _dbContext.SaveChanges();             

            return true;
        }
    }
}
