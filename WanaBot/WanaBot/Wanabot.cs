using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace WanaBot
{
    public class WanaBot
    {
        private const string RequestMemePostUrl = "https://api.imgflip.com/caption_image";
        public static string SelectedMeme = "";

        static void Main()
        {
            Console.WriteLine("Which meme do you wanna caption?");

            if (Console.ReadLine() == "1")
            {
                SelectedMeme = "438680";
                Console.WriteLine("Selected meme : Batman slap Robin");
            }

            Console.WriteLine("Enter top text");
            var topText = Console.ReadLine();

            Console.WriteLine("Enter bottom text");
            var botText = Console.ReadLine();

            const string username = "lwpowa";
            const string password = "MAXIMEH";

            Console.WriteLine("SelectMeme : " + SelectedMeme + " top text : " + topText + " bot text = " + botText);

            
        }

    }
}
