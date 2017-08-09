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
using Esgis_Paint.Models;

namespace Esgis_Paint
{
    public partial class modifyPic : Form
    {
        Image pictureObj;
        FileStream picture_stream;
        FileInfo img;
        Journal log;

        public modifyPic()
        {
            InitializeComponent();
            log = new Journal();
        }

        //TODO : Finish it
        private void btn_save_Click(object sender, EventArgs e)
        {
            Stream mystream;
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Image (*.PNG)|*.PNG";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;

            //Showing and saving the picture
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                mystream = saveDialog.OpenFile();

                if (mystream != null)
                {
                    /* //TODO: 
                     * We should get the path of the file wich is saved
                     * So we can send the path as string to writeSaveAction()
                     */

                    // Code to write the stream goes here.
                    mystream.Close();
                    MessageBox.Show(mystream.ToString());
                    //log.writeSaveAction();
                }
            }
           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void modifyPic_Load(object sender, EventArgs e)
        {

        }

        public void getImage(FileInfo imgInfo)
        {            
            //Getting the picture stream
            img = imgInfo;
            picture_stream = img.OpenRead();
            pictureObj = Image.FromStream(picture_stream); 

            this.Text = "Modifier une image - " + img.FullName;

            refreshPictureBoxImage();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Setting Size mode

        }

       
        //TODO: Code this method
        private void btn_rotateLeft_Click(object sender, EventArgs e)
        {

            //pictureObj.RotateFlip(RotateFlipType.);
            //pictureObj.RotateFlip
            refreshPictureBoxImage();
        }

        /// <summary>
        /// Refresh the pictureBox to apply changes
        /// </summary>
        private void refreshPictureBoxImage()
        {
            pictureBox1.Image = pictureObj;
        }

        private void btn_rotateRight_Click(object sender, EventArgs e)
        {
            pictureObj.RotateFlip(RotateFlipType.Rotate90FlipNone);
            refreshPictureBoxImage();
        }
    }
}
