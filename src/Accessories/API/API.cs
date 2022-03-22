using System;
using Newtonsoft.Json;

namespace ParadimnSharp.Accessories
{
    public static class API
    {
        //scrape the given url and return the REST Api response
        public static string Get(string url)
        {
            string response = "";
            try
            {
                System.Net.WebClient client = new System.Net.WebClient();
                response = client.DownloadString(url);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return response;
        }
    }
}