using Esgis_Paint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esgis_Paint
{
    public partial class Home : Form
    {
        Journal log;

        public Home()
        {
            InitializeComponent();
            log = new Journal();
            log.writeConnectionAction();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //Open the windows for drawing
            drawPic draw_Windows = new drawPic();
            draw_Windows.Show();           

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            log.writeDisconnectionAction();
            this.Dispose();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implements yet");
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
