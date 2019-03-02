using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGUKANYUFKA_APP
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }


       

        private void home_Load(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            anasayfaControl1.BringToFront();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height =button1 .Height;
            sidePanel.Top = button1.Top;
            anasayfaControl1.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            infoControl1.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
            maaşControl1.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            stokControl1.BringToFront();
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stokControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
