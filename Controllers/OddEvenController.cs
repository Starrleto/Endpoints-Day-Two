using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace RasuliEEndpointsD2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddEvenController
    {
        private readonly IOddEvenService _oddEvenService;

        public OddEvenController(IOddEvenService i){
            _oddEvenService = i;
        }

        [HttpGet]
        [Route("GetResult/{number}")]
        public string oddeven(string number){
            return _oddEvenService.oddeven(number);
        }
    }
}