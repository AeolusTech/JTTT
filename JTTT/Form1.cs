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
                HtmlNode[] nodes = document.DocumentNode.SelectNodes("//div[@class='content-info']//a")
                    //.Where(x=>x.InnerHtml.Contains("jpg"))
                    .Where(y => y.InnerHtml.Contains(tagToSearch.Text))
                    .ToArray();

                var urls = nodes.Where(x => x.InnerText.Contains(tagToSearch.Text));

                int temp = 0;
                foreach (var url in urls)
                {
                    Console.WriteLine(url.InnerHtml);
                    temp++;
                }
                Console.WriteLine(temp);
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
