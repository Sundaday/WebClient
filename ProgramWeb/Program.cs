using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace ProgramWeb
{
    internal class Program
    {
        class Pizza
        {
        public Pizza()
        {
        }

        }

        static void Main(string[] args)
        {
            string url = "https://codeavecjonathan.com/res/papillon.jpg";
            Console.WriteLine("Connexion ...");
            try
            {
                var webClient = new WebClient();
                webClient.DownloadFile(url,"papillon.jpg");
                Console.WriteLine("Download 100%");
            }
            catch (WebException ex)
            {
                if(ex.Response != null)
                {
                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;

                    if(statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("NETWORK ERROR : Non trouvé");
                    }
                    else
                    {
                        Console.WriteLine("NETWORK ERROR : " + statusCode);
                    }
                }
                else
                {
                    Console.WriteLine("NETWORK ERROR : " + ex.Message);
                }
            }

            
           
        }
    }
}
