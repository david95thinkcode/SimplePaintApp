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
        Image Specialform;

        //Useful to control pen state
        public Boolean pen_state;
        public Boolean eraser_state;
        public Boolean specialForm_enabled;

        #endregion
        
        public drawPic()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();

            //Initialisations
            pen_state = false;
            eraser_state = false;
            specialForm_enabled = false;

            log = new Journal();
            eraser_width = 5;
            pen_width = 5;
            pen_color = Color.Black;
            pen = new Pen(Color.Black, (int) pen_width);
            eraser = new Pen(Color.White, (int) eraser_width);
            numericUpDown_Epaisseur.Value = pen_width;
            numericUpDown_Epaisseur.Increment = 1;


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

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            Bitmap bitm = new Bitmap(panel1.Width, panel1.Height);
            Graphics bitGraphics = Graphics.FromImage(bitm);

            saveDialog.Filter = "Image (*.PNG)|*.PNG";

            //Draw all point to Graphics
            bitGraphics.DrawLines(pen, allPoints.ToArray());

            //We name the image with words typed by the user
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                bitm.Save(saveDialog.FileName);
                log.writeSaveAction(saveDialog.FileName);
                MessageBox.Show("Image enregistrée !");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
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

            //En parlant de la gomme
            if (eraser_state)
            {
                old = e.Location;
            }

            //Add the point to the list
            allPoints.Add(current);

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
                }
            }

            if (specialForm_enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawImage(Specialform, Cursor.Position);
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //If one Special Form is selected,
            //so we draw it
            if (specialForm_enabled) 
            {
                g.DrawImage(Specialform, Cursor.Position);
            }

        }
        #endregion

        #region MENU

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dessinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void effacerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        private void RefreshSpecialForm_With(Image img)
        {
            specialForm_enabled = true;
            Specialform = img;
        } 
        #endregion
        

        hiiohjjb uikubib i
            iguuogub

    }
}
