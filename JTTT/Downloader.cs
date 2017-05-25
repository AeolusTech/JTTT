using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// custom usings
using HtmlAgilityPack;
using System.Drawing.Imaging;
using System.Net;
using System.IO;
using System.Drawing;

namespace JTTT
{
    class Downloader
    {
        public Downloader(string logfilepath)
        {
            logger = logfilepath;
            Filepath = Path.GetTempPath()+ RandomString(10);
            Console.WriteLine("Wybrano sciezke zapisu obrazka: " + Filepath);
        }
        
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string getImage(string urlAddress, string tagToSearch)
        {
            try
            {
                var document = new HtmlWeb().Load(urlAddress);
                var items = document.DocumentNode.SelectNodes("//div[@class='content-info']");
                var excludeItems = document.DocumentNode.SelectNodes("//div[@class='vjs-control-text']"); // exclude videos

                string imgURL = "";

                bool found = false;
                // problem jezeli pojawi sie wideo
                foreach (var item in items)
                {
                    var words = item.Descendants("a").ToList();//.InnerText.Contains(tagToSearch.Text);
                    foreach (var word in words)
                    {
                        if (word.InnerText.Contains(tagToSearch))
                        {
                            Console.WriteLine(word.InnerText);
                            imgURL = item.Descendants("img").ToList()[0].GetAttributeValue("src", null);
                            found = true;
                        }
                    }
                    if (found)
                        break;
                }
                if (imgURL.Length == 0)
                {
                    return "";
                }
                else
                {
                    Console.WriteLine("Hej! Znalazlem: " + imgURL);
                    return imgURL;
                }
               
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("Nie znalazłem żądanego obrazka.\n" + e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Nieoczekiwany błąd w czytaniu adresu URL lub tagu. Treść:\n" + e.ToString());
            }
            return ""; // uciszamy kompilator
        }

        public void SaveImage(string webURL, ImageFormat format)
        {

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(webURL);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
                bitmap.Save(Filepath, format);

            stream.Flush();
            stream.Close();
            client.Dispose();
        }


        // fields
        private static Random random = new Random();
        private string filepath, logger;

        public string Filepath { get => filepath; set => filepath = value; }
    }
}
