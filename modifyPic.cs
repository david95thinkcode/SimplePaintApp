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

        #region Variables
        Image pictureObj;
        FileStream picture_stream;
        FileInfo img;
        Journal log; 
        #endregion

        public modifyPic()
        {
            InitializeComponent();
            log = new Journal();
        }

        private void modifyPic_Load(object sender, EventArgs e)
        {
        }

        #region TRANSFORM Button

        private void btn_rotateLeft_Click(object sender, EventArgs e)
        {
            refreshPictureBoxImage();
            pictureObj.RotateFlip(RotateFlipType.Rotate270FlipNone);
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

        private void btn_flipVertical_Click(object sender, EventArgs e)
        {
            pictureObj.RotateFlip(RotateFlipType.RotateNoneFlipX);
            refreshPictureBoxImage();
        }

        private void btn_flipHorizontal_Click(object sender, EventArgs e)
        {
            pictureObj.RotateFlip(RotateFlipType.RotateNoneFlipY);
            refreshPictureBoxImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region OPTIONS Button

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Filter = "Image (*.PNG)|*.PNG";
            //saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;

            //Showing and saving the picture
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveDialog.FileName);
                this.Text = saveDialog.FileName + " - Modifier une image"; ;
            }

            log.writeSaveAction(saveDialog.FileName);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //printDocument1.PrinterSettings.PrintToFile);
            ///printDocument1.Container = 
            printPreviewDialog1.Document = printDocument1;
            printDocument1.Print();
            log.writePrintAction(img.FullName);
            //printDocument1.
        }
        
        #endregion
        
        #region METHODS

        public void getImage(FileInfo imgInfo)
        {
            //Getting the picture stream
            img = imgInfo;
            picture_stream = img.OpenRead();
            pictureObj = Image.FromStream(picture_stream);

            this.Text = img.FullName + " - Modifier une image";

            refreshPictureBoxImage();
        }

        #endregion
        
    }
}
