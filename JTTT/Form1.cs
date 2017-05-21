using HtmlAgilityPack;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void getImage()
        {
            try
            {
                var document = new HtmlWeb().Load(urlAddress.Text);
                //HtmlNode[] nodes = document.DocumentNode.SelectNodes("//div[@class='content-info']//a")
                //    //.Where(x=>x.InnerHtml.Contains("jpg"))
                //    .Where(y => y.InnerHtml.Contains(tagToSearch.Text))
                //    .ToArray();

                var items = document.DocumentNode.SelectNodes("//div[@class='content-info']");
                var excludeItems = document.DocumentNode.SelectNodes("//div[@class='vjs-control-text']"); // exclude videos

                String imgURL = "";

                bool found = false;
                // problem jezeli pojawi sie wideo
                foreach (var item in items)
                {
                    //var link = item.Descendants("a").ToList()[0].GetAttributeValue("href", null);
                    var words = item.Descendants("a").ToList();//.InnerText.Contains(tagToSearch.Text);
                    foreach(var word in words )
                    {
                        if (word.InnerText.Contains(tagToSearch.Text))
                        {
                            Console.WriteLine(word.InnerText);
                            imgURL = item.Descendants("img").ToList()[0].GetAttributeValue("src", null);
                            found = true;
                        }
                    }
                    if (found)
                        break;
                }
                Console.WriteLine("Hej! Znalazlem: " + imgURL);
            }
            catch(Exception e)
            {
                Console.WriteLine("Blad w czytaniu adresu URL lub tagu. Blad:\n" + e.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void przycisk_Click(object sender, EventArgs e)
        {
            getImage();
        }
    }
}
