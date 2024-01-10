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
        [Route("Play/{LivingThing}/{Emotion}/{Noun}/{Name}/{Adjective}/{AnotherName}/{AnotherObject}/{NewLivingThing}/{NewNoun}/{PlaceToHide}")] //I guess the param here has to be the same name as the param in the method
        public string[] food (string LivingThing, string Emotion, string Noun, string Name, string Adjective, string AnotherName, string AnotherObject, string NewLivingThing, string NewNoun, string PlaceToHide){
            return _madlibService.play(LivingThing, Emotion, Noun, Name, Adjective, AnotherName, AnotherObject, NewLivingThing, NewNoun, PlaceToHide);
        }
    }
}