using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.ReverseString;

namespace RasuliEEndpointsD2.Services
{
    public class ReverseStringService : IReverseStringService
    {
        public string reverse(string s){
            string result = "";
            for(int i = s.Length-1; i >= 0; i--)
                result+=s[i];
            return $"You entered {s}. Reversed is {result}";
        }
    }
}