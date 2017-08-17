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
            saveDialog.RestoreDirectory = true;

            //Showing and saving the picture
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveDialog.FileName);
                this.Text = saveDialog.FileName + " - Modifier une image"; ;
            }

            log.WriteToLogFile("save_pic", saveDialog.FileName);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1 = new PrintPreviewDialog();

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                log.WriteToLogFile("print", img.FullName);
            }
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bitm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bitm, 0, 0);
            bitm.Dispose();
        }
    }
}
