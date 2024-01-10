using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RasuliEEndpointsD2.Services.Madlib;
using Microsoft.AspNetCore.Mvc;

public class MadlibService : IMadlibService
{
    public string[] play (string words1, string words2, string words3, string words4, string words5, string words6, string words7, string words8, string words9, string words10){
        return new string[]{
            $"Once upon a time there was a {words1}.",
            $"The {words1} was very {words2}, so it ran into the woods.",
            $"In the woods, it found a {words3}.",
            $"And the {words3} said 'If you want to go on a quest, go to {words4} Kingdom'.",
            $"The {words1} was bored so it went.",
            $"Once there, it found a {words5} man.",
            $"He said 'Go to the {words6} Kingdom to continue.'",
            $"The {words1} was still bored, so it went.",
            $"When it finally got there, it found a {words7}.",
            $"The {words1} was happy.",
            $"And then a {words8} came and took it.",
            $"The {words1} chased it and tripped over a {words9}",
            $"And the {words8} hid inside a {words10}.",
            $"The {words1} was sad.",
            $"Sucks to be him"
        };
    }
}
