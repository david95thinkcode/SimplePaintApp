﻿using Esgis_Paint.Models;
using System;
using System.IO;
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
            OpenFileDialog OpenFile_dialog = new OpenFileDialog();
            OpenFile_dialog.Title = "Choose a picture";
            OpenFile_dialog.Multiselect = false;

            // Set filter options and filter index.
            OpenFile_dialog.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            //Open the file dialog
            if (OpenFile_dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo choice_info = new FileInfo(OpenFile_dialog.FileName);
                
                //Calling modifyPic and sending to it the picture info
                modifyPic modifPage = new modifyPic();
                modifPage.getImage(choice_info);
                modifPage.Show();                
            }
            
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            log.openLogFile();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
