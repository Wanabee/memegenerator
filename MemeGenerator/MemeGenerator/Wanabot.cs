using System;
using System.Collections.Generic;
using System.Linq;

namespace MemeGenerator
{
    public class WanaBot
    {
        private const string RequestMemePostUrl = "https://api.imgflip.com/caption_image";
        const string Username = "lwpowa";
        const string Password = "imgflippassword";

        private static void Main()
        {
            var selectedMeme = "";

            Console.WriteLine("Select meme ID you wanna caption:\n");

            var i = 1;

            foreach (var entry in MemeDictionnaryClass.MemeDictionnary)
            {
                Console.WriteLine(entry.Key + " : " + i++);
            }

            selectedMeme = Console.ReadLine();

            i = 1;
            int result;

            int.TryParse(selectedMeme, out result);
            foreach (var entry in MemeDictionnaryClass.MemeDictionnary)
            {
                if (result == i)
                    selectedMeme = entry.Value.ToString();
                i++;
            }

            Console.WriteLine("Enter top text");
            var topText = Console.ReadLine();

            if (topText == "")
            {
                topText = MemeDictionnaryClass.MemeDictionnary
                    .First(meme => meme.Value == Convert.ToInt32(selectedMeme)).Key;

            }
            Console.WriteLine("Enter bottom text");
            var botText = Console.ReadLine();

            if (botText == "")
            {
                botText = MemeDictionnaryClass.MemeDictionnary
                    .First(meme => meme.Value == Convert.ToInt32(selectedMeme)).Key;

            }

            Console.WriteLine("SelectMeme : " + selectedMeme + " top text : " + topText + " bot text = " + botText);
            var url = WebClient.SendRequest(RequestMemePostUrl, selectedMeme, Username, Password, topText, botText);
            Console.WriteLine("Meme generated: " + url);
            System.Diagnostics.Process.Start(url.ToString());
            Console.ReadLine();
        }
    }
}
