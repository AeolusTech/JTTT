using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
//using System.Web.Security;




namespace JTTT
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
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
            try
            {
                Downloader d = new Downloader("logowanie.jpg");
                MailSender m = new MailSender("logowanie.jpg");

                string webURL = d.getImage(urlAddress.Text, tagToSearch.Text);
                d.SaveImage(webURL, ImageFormat.Jpeg);
                m.Sendmail(AdresEmail.Text, tagToSearch.Text, d.Filepath);
            }
            catch (ExternalException exception)
            {
                Console.WriteLine("Blad w formacie obrazka.\n" + exception.ToString());
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("Problem ze strumieniem\n" + exception.ToString());
            }
            
        }
    }
}
