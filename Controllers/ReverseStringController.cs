using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.ReverseString;
using Microsoft.AspNetCore.Mvc;

namespace RasuliEEndpointsD2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseStringController
    {
        private readonly IReverseStringService _reverseStringService;

        public ReverseStringController(IReverseStringService i){
            _reverseStringService = i;
        }

        [HttpGet]
        [Route("Reverse/{word}")]
        public string reverse(string word){
            return _reverseStringService.reverse(word);
        }
    }
}