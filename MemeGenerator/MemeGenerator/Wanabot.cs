using System;

namespace MemeGenerator
{
    public class WanaBot
    {
        private const string RequestMemePostUrl = "https://api.imgflip.com/caption_image";
        private static string _selectedMeme = "";

        private static void Main()
        {
            Console.WriteLine("Select meme ID you wanna caption");
            foreach (var entry in MemeDictionnaryClass.MemeDictionnary)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
            _selectedMeme = Console.ReadLine();
            //if (!MemeDictionnaryClass.MemeDictionnary.ContainsValue(_selectedMeme))
            Console.WriteLine("Enter top text");
            var topText = Console.ReadLine();

            Console.WriteLine("Enter bottom text");
            var botText = Console.ReadLine();

            const string username = "lwpowa";
            const string password = "MAXIMEH";

            Console.WriteLine("SelectMeme : " + _selectedMeme + " top text : " + topText + " bot text = " + botText);
            var url = WebClient.SendRequest(RequestMemePostUrl, _selectedMeme, username, password, topText, botText);
            Console.WriteLine("Meme generated: " + url);
            System.Diagnostics.Process.Start(url.ToString());
            Console.ReadLine();
        }
    }
}
