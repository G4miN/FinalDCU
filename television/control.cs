using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace television
{
    public partial class control : Form
    {

        Television tv;

        public control()
        {
            InitializeComponent();
            tv = new Television();
            tv.Show();
            
        }



       

        private void control_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz encendido la Television, espera que cargue");
            tv.media.URL = "http://bit.ly/2Oxbeyl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tv.canal.Text += "0";
        }

        private void botoncircular2_Click(object sender, EventArgs e)
        {
            switch (tv.canal.Text)
            {
                case "11":
                    tv.media.URL = "http://bit.ly/2Oxbeyl";
                    tv.canal.Text = "";
                    break;
                case "1":
                    tv.media.URL = "http://ss1.domint.net:2302/tu_str/universo/playlist.m3u";
                    tv.canal.Text = "";
                    break;
                case "7":
                    tv.media.URL = "http://d3e6ki1290i3kk.cloudfront.net/do/antena_latina.smil/playlist.m3u";
                    tv.canal.Text = "";
                    break;
                default:
                    tv.canal.Text = "Señal no valida";
                    tv.media.URL = "http://bit.ly/2Oxbeyl";
                    tv.canal.Text = "11";
                    tv.canal.Text = "";
                    break;
                    tv.canal.Text = "";
            }
        }
    }
}
