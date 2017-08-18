using Esgis_Paint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esgis_Paint
{
    public partial class drawPic : Form
    {
        #region Variables

        Journal log;
        List<Point> allPoints = new List<Point>();
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen pen;
        public Pen eraser;

        //Parameters that user can change
        Color pen_color;
        decimal pen_width;
        decimal eraser_width;
        SpecialForm Specialform;
        List<SpecialForm> allSpecialForms = new List<SpecialForm>();
        Image Specialform_IMG;

        //Useful to control pen state
        public Boolean pen_state;
        public Boolean eraser_state;
        public Boolean specialForm_enabled;
        public Boolean drawing;

        #endregion
        
        public drawPic()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();

            //Initialisations
            pen_state = false;
            eraser_state = false;
            specialForm_enabled = false;
            drawing = false;

            log = new Journal();
            eraser_width = 5;
            pen_width = 5;
            pen_color = Color.Black;
            pen = new Pen(Color.Black, (int) pen_width);
            eraser = new Pen(Color.White, (int) eraser_width);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            eraser.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            numericUpDown_Epaisseur.Value = pen_width;
            numericUpDown_Epaisseur.Increment = 3;


            #region COLORS OF COLOR GROUPBOX
            pictureBox_ColorActual.BackColor = pen.Color;
            pictureBox_Color1.BackColor = Color.White;
            pictureBox_Color2.BackColor = Color.Black;
            pictureBox_Color3.BackColor = Color.Blue;
            pictureBox_Color4.BackColor = Color.Green;
            pictureBox_Color5.BackColor = Color.Yellow;
            pictureBox_Color6.BackColor = Color.Red; 
            #endregion
        }

        private void drawPic_Load(object sender, EventArgs e)
        {
            // Changing the location of Left Control boxes
            groupBox_Outils.Location = new Point(groupBox_Outils.Location.X + 10, groupBox_Outils.Location.Y);
            groupBox_Formes.Location = new Point(groupBox_Formes.Location.X + 2, groupBox_Formes.Location.Y);

            // Changing the location of Right Control boxes
            int rightControlBoxes_X = groupBox_Outils.Width + panel1.Width + 70;            
           
            this.Width = this.Width - 50;

            btn_ZoomIn.Enabled = false;
            btn_ZoomOut.Enabled = false;
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
        }

        #region GROUPBOX : Outils

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            pen_state = true;
            eraser_state = false;
            specialForm_enabled = false;
            numericUpDown_Epaisseur.Value = (decimal)pen.Width;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            eraser_state = true;
            pen_state = false;
            specialForm_enabled = false;
            numericUpDown_Epaisseur.Value = (decimal)eraser.Width;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            allPoints = new List<Point>();
            allSpecialForms = new List<SpecialForm>();
            panel1.Invalidate();
        }

        #endregion

        #region GROUPBOX : Formes

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Focus
            RefreshSpecialForm_With(pictureBox1.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox6.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox3.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox5.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox4.Image);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox12.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox7.Image);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox11.Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox10.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox8.Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox9.Image);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox14.Image);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            RefreshSpecialForm_With(pictureBox13.Image);
        }
        #endregion

        #region GROUPBOX : Epaisseur

        private void numericUpDown_Epaisseur_ValueChanged(object sender, EventArgs e)
        {
            //Update pen width
            if (pen_state)
            {
                pen_width = numericUpDown_Epaisseur.Value;
                pen.Width = (int)pen_width;
            }
            else //Update eraser width
            {
                eraser_width = numericUpDown_Epaisseur.Value;
                eraser.Width = (int)eraser_width;
            }
        }

        #endregion

        #region GROUPBOX : Couleurs

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                pictureBox_ColorActual.BackColor = pen.Color;
            }

        }

        private void pictureBox_Color1_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox_Color1.BackColor;
        }

        private void pictureBox_Color2_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox_Color2.BackColor;
        }

        private void pictureBox_Color3_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox_Color3.BackColor;
        }

        private void pictureBox_Color4_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox_Color4.BackColor;
        }

        private void pictureBox_Color5_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox_Color5.BackColor;
        }

        private void pictureBox_Color6_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox_Color6.BackColor;
        }

        #endregion

        #region GROUPBOX : Fichier

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintSketch();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveSketch();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //TODO: Put the code inside a method and call it here
            if (((allPoints.Count == 0) & (allSpecialForms.Count == 0)) || (drawing = false))
            {
                log.WriteToLogFile("disconnect");
                Dispose();
            }
            else
            {
                DialogResult exitresult = MessageBox.Show("Un dessin est en cours ! Voulez-vous l'enregistrer ?", "Enregistrer ? ", MessageBoxButtons.YesNo);

                if (exitresult == DialogResult.Yes) //Saving the skecth is user is ok
                {
                    SaveSketch();
                }

                Dispose();
            }
        }

        #endregion

        #region PANEL

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pen_state) //crayon déjà cliqué
            {
                old = e.Location;
            }

            //About eraser
            if (eraser_state)
            {
                old = e.Location;
            }

            if (specialForm_enabled)
            {
                g.DrawImage(Specialform_IMG, e.Location);
                Specialform = new SpecialForm(Specialform_IMG, e.Location);
                //drawing = true;
            }
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen_state) //Pen enable
            {
                if (e.Button == MouseButtons.Left)
                {
                    Cursor.Current = Cursors.Cross;
                    current = e.Location;
                    g.DrawLine(pen, old, current);
                    old = current;

                    //Add the draw point to the list of Points
                    allPoints.Add(current);
                    drawing = true;
                }
            }
            
            //Eraser enable
            if (eraser_state)
            {
                if (e.Button == MouseButtons.Left)
                {
                    current = e.Location;
                    g.DrawLine(eraser, old, current);
                    old = current;

                    //Remove the eraser point from the list of points
                    allPoints.Remove(current);
                    //drawing = true;
                }
            }

            if (specialForm_enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawImage(Specialform_IMG, e.Location);
                    
                    //Add the draw point to the list of SpecialForm
                    Specialform = new SpecialForm(Specialform_IMG, e.Location);
                    allSpecialForms.Add(Specialform);

                    
                }
            }

            RefreshInformations();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region MENU

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSketch();
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((allPoints.Count == 0) & (allSpecialForms.Count == 0)) || (drawing = false))
            {
                log.WriteToLogFile("disconnect");
                Dispose();
            }
            else
            {
                DialogResult exitresult = MessageBox.Show("Un dessin est en cours ! Voulez-vous l'enregistrer ?", "Enregistrer ? ", MessageBoxButtons.YesNo);

                if (exitresult == DialogResult.Yes) //Saving the skecth is user is ok
                {
                    SaveSketch();
                }

                log.WriteToLogFile("disconnect");;
                Dispose();
            }
        }

        private void dessinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void effacerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allPoints = new List<Point>();
            allSpecialForms = new List<SpecialForm>();
            panel1.Invalidate();
        }

        private void nouveauDessinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region OTHERS CONTROLS

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region METHODS

        /// <summary>
        /// Refresh the label witcch provide info about user action
        /// </summary>
        private void RefreshInformations()
        {
            if (((allPoints.Count == 0) & (allSpecialForms.Count == 0)) || (drawing = false))
            {                
                label_Info.Text = "Papier vide !";
            }
            else
            {
                label_Info.Text = "Dessin en cours... ";
            }
        }

        private void RefreshSpecialForm_With(Image img)
        {
            specialForm_enabled = true;
            Specialform_IMG = img;

            //Make sure to not draw or erase when adding form to the panel
            pen_state = false;
            eraser_state = false;
        }

        private void SaveSketch()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            Bitmap bitm = new Bitmap(panel1.Width, panel1.Height);
            Graphics bitGraphics = Graphics.FromImage(bitm);

            saveDialog.Filter = "Image (*.PNG)|*.PNG";

            try
            {
                //Draw all point to Graphics
                bitGraphics.DrawLines(pen, allPoints.ToArray());

                //Drawing Images to Graphics
                foreach (var item in allSpecialForms)
                {
                    bitGraphics.DrawImage(item._Image, item._Point);
                }

                //Here we let the user enter the name for the file
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    bitm.Save(saveDialog.FileName);
                    log.WriteToLogFile("pic_save", saveDialog.FileName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossible d'enregistrer un dessin vide");
            }
            
        }

        /// <summary>
        /// Open the windows used to draw a sketch
        /// </summary>
        private void OpenDrawWindows()
        {
            drawPic draw_Windows = new drawPic();
            draw_Windows.Show();
        }

        /// <summary>
        /// Make the user choose a picture and open ModifPic Windows
        /// </summary>
        private void OpenPicture()
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
                editPic modifPage = new editPic();
                modifPage.getImage(choice_info);
                modifPage.Show();
            }
        }

        /// <summary>
        /// Open the log file
        /// </summary>
        private void OpenJournal()
        {
            log.openLogFile();
        }

        /// <summary>
        /// Close correctly the app
        /// </summary>
        private void DisconnectApp()
        {
            if (drawing)
            {
                DialogResult exitresult = MessageBox.Show("Un dessin est en cours ! Voulez-vous l'enregistrer ?", "Enregistrer ? ", MessageBoxButtons.YesNo);

                if (exitresult == DialogResult.Yes) //Saving the skecth is user is ok
                {
                    SaveSketch();                    
                }
            }

            log.WriteToLogFile("disconnect");;
            Dispose();
        }

        /// <summary>
        /// Print the sketch/drawing on the panel
        /// </summary>
        private void PrintSketch()
        {
            printPreviewDialog1 = new PrintPreviewDialog();

            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                log.WriteToLogFile("print", "Temp. unsaved Sketch");
            }
        }

        #endregion

        #region MENU

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPicture();
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintSketch();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitm = new Bitmap(panel1.Width, panel1.Height);
            try
            {
                //Draw all point to Graphics
                e.Graphics.DrawLines(pen, allPoints.ToArray());

                //Drawing Images to Graphics
                foreach (var item in allSpecialForms)
                {
                    e.Graphics.DrawImage(item._Image, item._Point);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'imprimer un dessin vide");
            }

            e.Graphics.DrawImage(bitm, 0, 0);
            bitm.Dispose();
        }

        #endregion
        
    }

    
}
