using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData("https://www.google.com.sa/images/srpr/logo11w.png");
            this.pictureBox1.Image = Image.FromStream(new MemoryStream(imageData));
        }
    }
}
