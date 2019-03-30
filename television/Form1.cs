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
    public partial class Form1 : Form
    {
        int count = 1;
        int counta; 
        public Form1()
        {
            InitializeComponent();
            
        }
       
            
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {   //no funciona
            //boton verde
            

            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {   //FUNCIONA
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //alante boton

       
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //atras boton
           
        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void botoncircular1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz encendido la Television, espera que cargue");
            Media.URL = "http://bit.ly/2Oxbeyl";

          
        }

        private void botoncircular2_Click(object sender, EventArgs e)
        {
            //atras
            counta = count--;

            lblCountry.Text = counta.ToString();

            Media.Ctlcontrols.previous();

            if (count == 11)
            {
                /*Media.URL = "http://bit.ly/2SYaBuX ";*/
                Media.URL = "http://ss2.domint.net:2138/cvh_str/colorvisionhd/playlist.m3u";
            }

            if (count == 12)
            {
                /*Media.URL = "http://bit.ly/2SYaBuX ";*/
                Media.URL = "http://d3e6ki1290i3kk.cloudfront.net/do/antena_latina.smil/playlist.m3u";
            }

        }

        private void botoncircular3_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.next();
            count++;
            lblCountry.Text = count.ToString();

            if (count == 11)
            {
                /*Media.URL = "http://bit.ly/2SYaBuX ";*/
                Media.URL = "http://ss2.domint.net:2138/cvh_str/colorvisionhd/playlist.m3u";
                count++;
            }

            else if (count == 12)
            {
                /*Media.URL = "http://bit.ly/2SYaBuX ";*/
                Media.URL = "http://d3e6ki1290i3kk.cloudfront.net/do/antena_latina.smil/playlist.m3u";
                count++;
            }
            else if (count == 13)
            {
                /*Media.URL = "http://bit.ly/2SYaBuX ";*/
                Media.URL = "http://api.new.livestream.com/accounts/27035275/events/8371710/broadcasts/189186649.m3u?dw=80&hdnea=st=1553629038~exp=1553630838~acl=/i/27035275_8371710_lsisd6p8zrz5i0kij33_1@688299/*~hmac=56a4077b7682ffa08999625f0ab2311c2b176c0244a8898ea03c8567f6d07603";
                count++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Media_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botoncircular7_Click(object sender, EventArgs e)
        {
           
            lblCountry.Text += "1";
            Media.URL = "http://ss2.domint.net:2138/cvh_str/colorvisionhd/playlist.m3u";
        }

        private void dos_Click(object sender, EventArgs e)
        {
           
            lblCountry.Text += "2";
            Media.URL = "http://api.new.livestream.com/accounts/27035275/events/8371710/broadcasts/189186649.m3u?dw=80&hdnea=st=1553629038~exp=1553630838~acl=/i/27035275_8371710_lsisd6p8zrz5i0kij33_1@688299/*~hmac=56a4077b7682ffa08999625f0ab2311c2b176c0244a8898ea03c8567f6d07603";

        }

        private void tres_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "8";

        }

        private void nueve_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            lblCountry.Text += "0";
        }

        private void botoncircular10_Click(object sender, EventArgs e)
        {
                Media.URL = "http://ss8.domint.net:2118/tf_str/futu/playlist.m3u";
 
        }
    }
}
