using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Net_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new WebClient();
            var result = client.DownloadData("http://icanhazip.com");
            var ip = Encoding.Default.GetString(result);

            textBox1.Text = ip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
