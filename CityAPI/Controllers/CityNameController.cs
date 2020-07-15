using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CityAPI.Models;
using CityAPI.Services;

namespace CityAPI.Controllers
{
    [Route("[controller]")]
    public class CityNameController : Controller
    {
        private readonly CityNameService _cityNameService;

         public CityNameController(CityNameService cityNameService)
        {
            _cityNameService = cityNameService;           
        }

        [HttpGet("GetAll")]
        public CityNameModel GetCityName(string slat, string slong)
        {
            CityNameModel lstmdlApplication = _cityNameService.GetAll(slat, slong);

            return lstmdlApplication;
        }

    }
}