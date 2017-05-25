using HtmlAgilityPack;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Web;
//using System.Web.Security;




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



        public void sendmail()
        {
            try
            {
                var message = new MailMessage();
                message.From = new MailAddress("dotnetijava2017@gmail.com", "Platformy Programistyczne");
                message.To.Add(new MailAddress(AdresEmail.Text));
                message.Subject = tagToSearch.Text;
                message.Body = "Znaleziono nowy obraz \"" +tagToSearch.Text +"\"";
                //message.Attachments.Add(new Attachment(@"sciezkapliku"));
                var smtp = new SmtpClient("smtp.gmail.com");
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("dotnetijava2017@gmail.com", "poiuytrewq1");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(message);
                Console.WriteLine("Udalo sie wyslac wiadomosc!\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("Nie udalo sie wyslac wiadomosci. Blad:\n" + e.ToString());
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
            sendmail();
            
        }
    }
}
