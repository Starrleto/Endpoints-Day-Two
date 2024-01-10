using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.ReverseNum;
using Microsoft.AspNetCore.Mvc;

namespace RasuliEEndpointsD2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseNumController
    {
        private readonly IReverseNumService _reverseNumService;

        public ReverseNumController(IReverseNumService i){
            _reverseNumService = i;
        }

        [HttpGet]
        [Route("Reverse/{number}")]
        public string reverse(string number){
            return _reverseNumService.reverse(number);
        }
    }
}