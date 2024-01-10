using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.ReverseNum;

namespace RasuliEEndpointsD2.Services
{
    public class ReverseNumService : IReverseNumService
    {
        public string reverse(string s){
            if(!int.TryParse(s, out int r)){
                return "Invalid input! Please enter a real number.";
            }
            string result = "";
            for(int i = s.Length-1; i >= 0; i--)
                result+=s[i];
            return $"You entered {s}. Reversed is {result}";
        }
    }
}