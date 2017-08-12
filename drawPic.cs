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
        List<Point> allPoints = new List<Point>();
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen pen = new Pen(Color.Black, 5);
        public Pen eraser = new Pen(Color.White, 5);
        Journal log;

        //Booléen pour controler l'état du crayon
        public Boolean pen_state;
        public Boolean eraser_state;

        public drawPic()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            log = new Journal();        }

        private void drawPic_Load(object sender, EventArgs e)
        {
            pen_state = false;
            eraser_state = false;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
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
            if (pen_state) //crayon déjà cliqué
            {
                if (e.Button == MouseButtons.Left)
                {
                    current = e.Location;
                    g.DrawLine(pen, old, current);
                    old = current;
                    
                    //Add the draw point to the list
                    allPoints.Add(current);
                }
            }

            //GOmme
            if (eraser_state)
            {
                if (e.Button == MouseButtons.Left)
                {
                    current = e.Location;
                    g.DrawLine(eraser, old, current);
                    old = current;

                    //Remove the eraser point from the list
                    allPoints.Remove(current);
                }
            }
            
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
             pen_state = true;
             eraser_state = false;
        }
        
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            eraser_state = true;
            pen_state = false;
        }

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
    }
}
