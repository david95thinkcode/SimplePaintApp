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
    public partial class editPic : Form
    {

        #region Variables
        Image pictureObj;
        FileStream picture_stream;
        FileInfo img;
        Journal log; 
        #endregion

        public editPic()
        {
            InitializeComponent();
            log = new Journal();
        }

        private void modifyPic_Load(object sender, EventArgs e)
        {
        }

        #region MENU

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPicture();
        }

        private void fermerLimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClosePicture();
        }

        #endregion

        #region TRANSFORM Buttons

        private void btn_rotateLeft_Click(object sender, EventArgs e)
        {
            RefreshPictureBoxImage();
            pictureObj.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        /// <summary>
        /// Refresh the pictureBox to apply changes
        /// </summary>
        private void RefreshPictureBoxImage()
        {
            pictureBox1.Image = pictureObj;
        }

        private void btn_rotateRight_Click(object sender, EventArgs e)
        {
            pictureObj.RotateFlip(RotateFlipType.Rotate90FlipNone);
            RefreshPictureBoxImage();
        }

        private void btn_flipVertical_Click(object sender, EventArgs e)
        {
            pictureObj.RotateFlip(RotateFlipType.RotateNoneFlipX);
            RefreshPictureBoxImage();
        }

        private void btn_flipHorizontal_Click(object sender, EventArgs e)
        {
            pictureObj.RotateFlip(RotateFlipType.RotateNoneFlipY);
            RefreshPictureBoxImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

            RefreshPictureBoxImage();

            #region Enable some components
            btn_flipHorizontal.Enabled = true;
            btn_flipVertical.Enabled = true;
            btn_rotateLeft.Enabled = true;
            btn_rotateRight.Enabled = true;

            //Menu items
            enregistrerToolStripMenuItem.Enabled = true;
            imprimerToolStripMenuItem.Enabled = true;
            fermerLimageToolStripMenuItem.Enabled = true;
            #endregion
        }

        public void Save()
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

        public void Print()
        {
            printPreviewDialog1 = new PrintPreviewDialog();

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                log.WriteToLogFile("print", img.FullName);
            }
        }

        /// <summary>
        /// Open a picture a load it in the panel
        /// </summary>
        public void OpenPicture()
        {
            OpenFileDialog OpenFile_dialog = new OpenFileDialog();

            OpenFile_dialog.Title = "Choose a picture";
            OpenFile_dialog.Multiselect = false;
            OpenFile_dialog.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";

            //Open the file dialog
            if (OpenFile_dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo choice_info = new FileInfo(OpenFile_dialog.FileName);
                getImage(choice_info);
            }

        }

        /// <summary>
        /// Remove the picture from the panel
        /// </summary>
        public void ClosePicture()
        {
            pictureObj = null;
            RefreshPictureBoxImage();

            #region Disable some components
            btn_flipHorizontal.Enabled = false;
            btn_flipVertical.Enabled = false;
            btn_rotateLeft.Enabled = false;
            btn_rotateRight.Enabled = false;

            //Menu items
            enregistrerToolStripMenuItem.Enabled = false;
            imprimerToolStripMenuItem.Enabled = false;
            fermerLimageToolStripMenuItem.Enabled = false; 
            #endregion
        }

        #endregion

        #region OTHERS
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bitm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bitm, 0, 0);
            bitm.Dispose();
        } 
        #endregion

    }
}
