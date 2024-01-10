using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace RasuliEEndpointsD2.Services
{
    public class OddEvenService : IOddEvenService
    {
        public string oddeven(string number){
            double n1;

            if(double.TryParse(number, out n1)){
                return n1 % 2 == 0 ? "Even!" : "Odd!";
            }
            else
                return "Invalid input! Please enter a real number.";
        }
    }
}