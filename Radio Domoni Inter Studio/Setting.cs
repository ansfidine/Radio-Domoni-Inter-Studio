using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Domoni_Inter_Studio
{
    public partial class Setting : Form
    {
        private Form1 mainForm = null;
        public Setting(Form1 form1)
        {
            mainForm = form1 as Form1;
            InitializeComponent();
            analyzer = new Analyzer(progressBar1, progressBar2, spectrum1, comboBox1, chart1);
            //timer1.Enabled = true;
            timer1.Enabled = true;
        }
        Analyzer analyzer;
        private void SpectrumAnalyzer_Load(object sender, EventArgs e)
        {
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
            Btn_Enable.Text = "Disable";
        }

        private void Btn_Enable_Click(object sender, EventArgs e)
        {
            if (Btn_Enable.Text == "Enable")
            {
                analyzer.Enable = true;
                analyzer.DisplayEnable = true;
                Btn_Enable.Text = "Disable";
            }
            else
            {
                analyzer.Enable = false;
                analyzer.DisplayEnable = false;
                Btn_Enable.Text = "Enable";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Image = Radio_Domoni_Inter_Studio.Properties.Resources.selected_Minimize_Button;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Radio_Domoni_Inter_Studio.Properties.Resources.Minimize_Button;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
