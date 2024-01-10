using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.Madlib;
using Microsoft.AspNetCore.Mvc;

namespace RasuliEEndpointsD2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadlibController
    {
        private readonly IMadlibService _madlibService;
        public MadlibController(IMadlibService f){
            _madlibService = f;
        }

        [HttpGet]
        [Route("Play/{words1}/{words2}/{words3}/{words4}/{words5}/{words6}/{words7}/{words8}/{words9}/{words10}")] //I guess the param here has to be the same name as the param in the method
        public string[] food (string words1, string words2, string words3, string words4, string words5, string words6, string words7, string words8, string words9, string words10){
            return _madlibService.play(words1, words2, words3, words4, words5, words6, words7, words8, words9, words10);
        }
    }
}