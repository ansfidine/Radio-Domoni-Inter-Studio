using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Domoni_Inter_Studio
{

    public partial class Form1 : Form
    {
        //Switch Selector Variable 
        public int selecteurRadio = 0;

        //Radio Links
        public String rcm13Link = "https://sv1.vestaradio.com/rcm13";
        public String radioDomoniInterLink = "http://www.domoni-inter.org:8000/live";
        public String friAfriqueLink = "http://live02.rfi.fr/rfiafrique-64.mp3";
        public String dwLink = "http://dw.audiostream.io/dw/1016/mp3/64/dw-radio-8";
        public String rfiSawahiliLink = "http://rfi-swahili.scdn.arkena.com/rfienswahili.mp3";
        public String testLink = "http://domoni-inter.org:8000/test";
        public String test2Link = "http://domoni-inter.org:8000/test2";
        public String liveLyon2Link = "http://domoni-inter.org:8000/livelyon2";
        public String EtestLink = "http://domoni-inter.org:8000/Etest";
        public String domoniFootLink = "http://domoni-inter.org:8000/domonifoot";


        public Form1()
        {


            //Custoum SlapshScreen Code 

            Thread t = new Thread(new ThreadStart(StartForm));
            InitializeComponent();
            t.Start();
            Thread.Sleep(5000);
            t.Abort();

        }
     

        public void StartForm() 
        {
            Application.Run(new SplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString() + "%";
            trackBar1.Value = 50;
            groupBox1.Hide();
            Setting spec = new Setting(this);
            spec.Show();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Inter_dButton;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Quit_Button;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Minimize_Button;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Radio_France_Button;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_DW_Button;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Radio_Domoni_Inter_Studio.Properties.Resources.DW_Button;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Inter_Button;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Radio_France_Button;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Quit_Button;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Minimize_Button;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Canal_Test;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Canal_Test;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Dev_Button;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Dev_Button;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            groupBox1.Hide();
            pictureBox6.Show();
            label1.Text = ("CONNECTER SUR DW");
            selecteurRadio = 3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            groupBox1.Hide();
            pictureBox6.Show();
            selecteurRadio = 1;
            pictureBox6.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Logo_Interieu;
            label1.Text = ("CONNECTER SUR DOMONI INTER");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            groupBox1.Hide();
            pictureBox6.Show();
            selecteurRadio = 2;
            label1.Text = ("CONNECTER SUR RFI");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selecteurRadio = 4;
            groupBox1.Show();
          
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Pause_Button;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Pause_Button;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_play_Button;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Radio_Domoni_Inter_Studio.Properties.Resources.play_Button;
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Stop_Buttom;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Stop_Buttom;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            switch (selecteurRadio)
            {

                case 1:
                        axWindowsMediaPlayer2.URL = radioDomoniInterLink;
                    break;
                case 2:
                        axWindowsMediaPlayer2.URL = friAfriqueLink;
                    break;
                case 3:
                        axWindowsMediaPlayer2.URL = dwLink;
                    break;
                case 4:
                     if (radioButton1.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR RCM 13");
                        axWindowsMediaPlayer2.URL = rcm13Link; 
                    }
                     else if (radioButton2.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR RFI SAWAHILI");
                        axWindowsMediaPlayer2.URL = rfiSawahiliLink;
                    }
                     else if (radioButton3.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR test");
                        axWindowsMediaPlayer2.URL = testLink;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR test2");
                        axWindowsMediaPlayer2.URL = test2Link;
                    }
                    else if (radioButton5.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR livelyon2");
                        axWindowsMediaPlayer2.URL = liveLyon2Link;
                    }
                    else if (radioButton6.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR Etest");
                        axWindowsMediaPlayer2.URL = EtestLink;
                    }
                    else if (radioButton7.Checked == true)
                    {
                        label1.Text = ("CONNECTER SUR domonifoot");
                        axWindowsMediaPlayer2.URL = domoniFootLink;
                    }
                    else
                    {
                        messageForm messageform = new messageForm();
                        messageform.Show();
                    }
                    break;

                default :
                    messageForm messageform1 = new messageForm();
                    messageform1.Show();
                    break;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            DevInfo devinfoform = new DevInfo();
            devinfoform.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Text = ("DECONNECTER ");
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.settings.volume=trackBar1.Value;
           
            label2.Text = trackBar1.Value.ToString() +"%";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Text = ("PAUSE");
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void ouvrirLienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

