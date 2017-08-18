namespace Esgis_Paint
{
    partial class editPic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editPic));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_flipVertical = new System.Windows.Forms.Button();
            this.btn_flipHorizontal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rotateLeft = new System.Windows.Forms.Button();
            this.btn_rotateRight = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerLimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_flipVertical
            // 
            this.btn_flipVertical.Image = global::Esgis_Paint.Properties.Resources.Flip_Vertical_64px;
            this.btn_flipVertical.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_flipVertical.Location = new System.Drawing.Point(12, 198);
            this.btn_flipVertical.Name = "btn_flipVertical";
            this.btn_flipVertical.Size = new System.Drawing.Size(104, 77);
            this.btn_flipVertical.TabIndex = 7;
            this.btn_flipVertical.Text = "Ret. Vertical";
            this.btn_flipVertical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_flipVertical.UseVisualStyleBackColor = true;
            this.btn_flipVertical.Click += new System.EventHandler(this.btn_flipVertical_Click);
            // 
            // btn_flipHorizontal
            // 
            this.btn_flipHorizontal.Image = global::Esgis_Paint.Properties.Resources.Flip_Horizontal_64px;
            this.btn_flipHorizontal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_flipHorizontal.Location = new System.Drawing.Point(12, 281);
            this.btn_flipHorizontal.Name = "btn_flipHorizontal";
            this.btn_flipHorizontal.Size = new System.Drawing.Size(104, 77);
            this.btn_flipHorizontal.TabIndex = 6;
            this.btn_flipHorizontal.Text = "Ret. Horizontal";
            this.btn_flipHorizontal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_flipHorizontal.UseVisualStyleBackColor = true;
            this.btn_flipHorizontal.Click += new System.EventHandler(this.btn_flipHorizontal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(132, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_rotateLeft
            // 
            this.btn_rotateLeft.Image = global::Esgis_Paint.Properties.Resources.Rotate_Left_52px;
            this.btn_rotateLeft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rotateLeft.Location = new System.Drawing.Point(12, 32);
            this.btn_rotateLeft.Name = "btn_rotateLeft";
            this.btn_rotateLeft.Size = new System.Drawing.Size(104, 77);
            this.btn_rotateLeft.TabIndex = 2;
            this.btn_rotateLeft.Text = "Pivoter à gauche";
            this.btn_rotateLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rotateLeft.UseVisualStyleBackColor = true;
            this.btn_rotateLeft.Click += new System.EventHandler(this.btn_rotateLeft_Click);
            // 
            // btn_rotateRight
            // 
            this.btn_rotateRight.Image = global::Esgis_Paint.Properties.Resources.Rotate_Right_52px_1;
            this.btn_rotateRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rotateRight.Location = new System.Drawing.Point(12, 115);
            this.btn_rotateRight.Name = "btn_rotateRight";
            this.btn_rotateRight.Size = new System.Drawing.Size(104, 77);
            this.btn_rotateRight.TabIndex = 1;
            this.btn_rotateRight.Text = "Pivoter à droite";
            this.btn_rotateRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rotateRight.UseVisualStyleBackColor = true;
            this.btn_rotateRight.Click += new System.EventHandler(this.btn_rotateRight_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.fermerLimageToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir image";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer ";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // fermerLimageToolStripMenuItem
            // 
            this.fermerLimageToolStripMenuItem.Name = "fermerLimageToolStripMenuItem";
            this.fermerLimageToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fermerLimageToolStripMenuItem.Text = "Fermer l\'image";
            this.fermerLimageToolStripMenuItem.Click += new System.EventHandler(this.fermerLimageToolStripMenuItem_Click);
            // 
            // editPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 579);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_flipVertical);
            this.Controls.Add(this.btn_flipHorizontal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_rotateLeft);
            this.Controls.Add(this.btn_rotateRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une image";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.modifyPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rotateRight;
        private System.Windows.Forms.Button btn_rotateLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_flipHorizontal;
        private System.Windows.Forms.Button btn_flipVertical;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerLimageToolStripMenuItem;
    }
}