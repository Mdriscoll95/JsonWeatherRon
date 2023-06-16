using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI 
    {
        public static void Kanye()
        {
            //connect API to Method
            HttpClient instance = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = instance.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            //Write in Console
            Console.WriteLine($"Kanye says {kanyeQuote}");

            
        }
        public static void Ron()
        {
            //connect API to Method
            HttpClient instance = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = instance.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse);

            //Write to Console
            Console.WriteLine($"ron say '{ronQuote[0]}'");
        }
        
    }
    
 

    
}
