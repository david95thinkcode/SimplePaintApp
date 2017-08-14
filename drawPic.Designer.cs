namespace Esgis_Paint
{
    partial class drawPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drawPic));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDessinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown_Epaisseur = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Epaisseur = new System.Windows.Forms.GroupBox();
            this.groupBox_Couleur = new System.Windows.Forms.GroupBox();
            this.pictureBox_ColorActual = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color6 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ZoomOut = new System.Windows.Forms.Button();
            this.btn_ZoomIn = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Fichier = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Epaisseur)).BeginInit();
            this.groupBox_Epaisseur.SuspendLayout();
            this.groupBox_Couleur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Fichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crayon";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(128, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 454);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.dessinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDessinToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.annulerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // nouveauDessinToolStripMenuItem
            // 
            this.nouveauDessinToolStripMenuItem.Name = "nouveauDessinToolStripMenuItem";
            this.nouveauDessinToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nouveauDessinToolStripMenuItem.Text = "Nouveau dessin";
            this.nouveauDessinToolStripMenuItem.Click += new System.EventHandler(this.nouveauDessinToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Enabled = false;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer ";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // dessinToolStripMenuItem
            // 
            this.dessinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.effacerToutToolStripMenuItem});
            this.dessinToolStripMenuItem.Name = "dessinToolStripMenuItem";
            this.dessinToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dessinToolStripMenuItem.Text = "Dessin";
            this.dessinToolStripMenuItem.Click += new System.EventHandler(this.dessinToolStripMenuItem_Click);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // effacerToutToolStripMenuItem
            // 
            this.effacerToutToolStripMenuItem.Name = "effacerToutToolStripMenuItem";
            this.effacerToutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.effacerToutToolStripMenuItem.Text = "Effacer tout";
            this.effacerToutToolStripMenuItem.Click += new System.EventHandler(this.effacerToutToolStripMenuItem_Click);
            // 
            // numericUpDown_Epaisseur
            // 
            this.numericUpDown_Epaisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Epaisseur.Location = new System.Drawing.Point(10, 26);
            this.numericUpDown_Epaisseur.Name = "numericUpDown_Epaisseur";
            this.numericUpDown_Epaisseur.Size = new System.Drawing.Size(74, 32);
            this.numericUpDown_Epaisseur.TabIndex = 14;
            this.numericUpDown_Epaisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Epaisseur.ValueChanged += new System.EventHandler(this.numericUpDown_Epaisseur_ValueChanged);
            // 
            // groupBox_Epaisseur
            // 
            this.groupBox_Epaisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Epaisseur.Controls.Add(this.numericUpDown_Epaisseur);
            this.groupBox_Epaisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Epaisseur.Location = new System.Drawing.Point(886, 44);
            this.groupBox_Epaisseur.Name = "groupBox_Epaisseur";
            this.groupBox_Epaisseur.Size = new System.Drawing.Size(103, 70);
            this.groupBox_Epaisseur.TabIndex = 15;
            this.groupBox_Epaisseur.TabStop = false;
            this.groupBox_Epaisseur.Text = "Epaisseur";
            // 
            // groupBox_Couleur
            // 
            this.groupBox_Couleur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Couleur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Couleur.Controls.Add(this.pictureBox_ColorActual);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color2);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color5);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color3);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color6);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color1);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color4);
            this.groupBox_Couleur.Controls.Add(this.button3);
            this.groupBox_Couleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Couleur.Location = new System.Drawing.Point(886, 127);
            this.groupBox_Couleur.Name = "groupBox_Couleur";
            this.groupBox_Couleur.Size = new System.Drawing.Size(103, 170);
            this.groupBox_Couleur.TabIndex = 16;
            this.groupBox_Couleur.TabStop = false;
            this.groupBox_Couleur.Text = "Couleurs";
            // 
            // pictureBox_ColorActual
            // 
            this.pictureBox_ColorActual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_ColorActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_ColorActual.Location = new System.Drawing.Point(41, 30);
            this.pictureBox_ColorActual.Name = "pictureBox_ColorActual";
            this.pictureBox_ColorActual.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_ColorActual.TabIndex = 10;
            this.pictureBox_ColorActual.TabStop = false;
            // 
            // pictureBox_Color2
            // 
            this.pictureBox_Color2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color2.Location = new System.Drawing.Point(41, 61);
            this.pictureBox_Color2.Name = "pictureBox_Color2";
            this.pictureBox_Color2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color2.TabIndex = 9;
            this.pictureBox_Color2.TabStop = false;
            this.pictureBox_Color2.Click += new System.EventHandler(this.pictureBox_Color2_Click);
            // 
            // pictureBox_Color5
            // 
            this.pictureBox_Color5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color5.Location = new System.Drawing.Point(41, 89);
            this.pictureBox_Color5.Name = "pictureBox_Color5";
            this.pictureBox_Color5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color5.TabIndex = 8;
            this.pictureBox_Color5.TabStop = false;
            this.pictureBox_Color5.Click += new System.EventHandler(this.pictureBox_Color5_Click);
            // 
            // pictureBox_Color3
            // 
            this.pictureBox_Color3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color3.Location = new System.Drawing.Point(72, 61);
            this.pictureBox_Color3.Name = "pictureBox_Color3";
            this.pictureBox_Color3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color3.TabIndex = 7;
            this.pictureBox_Color3.TabStop = false;
            this.pictureBox_Color3.Click += new System.EventHandler(this.pictureBox_Color3_Click);
            // 
            // pictureBox_Color6
            // 
            this.pictureBox_Color6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color6.Location = new System.Drawing.Point(72, 89);
            this.pictureBox_Color6.Name = "pictureBox_Color6";
            this.pictureBox_Color6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color6.TabIndex = 6;
            this.pictureBox_Color6.TabStop = false;
            this.pictureBox_Color6.Click += new System.EventHandler(this.pictureBox_Color6_Click);
            // 
            // pictureBox_Color1
            // 
            this.pictureBox_Color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color1.Location = new System.Drawing.Point(10, 61);
            this.pictureBox_Color1.Name = "pictureBox_Color1";
            this.pictureBox_Color1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color1.TabIndex = 5;
            this.pictureBox_Color1.TabStop = false;
            this.pictureBox_Color1.Click += new System.EventHandler(this.pictureBox_Color1_Click);
            // 
            // pictureBox_Color4
            // 
            this.pictureBox_Color4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color4.Location = new System.Drawing.Point(10, 89);
            this.pictureBox_Color4.Name = "pictureBox_Color4";
            this.pictureBox_Color4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color4.TabIndex = 3;
            this.pictureBox_Color4.TabStop = false;
            this.pictureBox_Color4.Click += new System.EventHandler(this.pictureBox_Color4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Esgis_Paint.Properties.Resources.More_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(8, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Plus";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ZoomOut);
            this.groupBox3.Controls.Add(this.btn_ZoomIn);
            this.groupBox3.Controls.Add(this.btn_pencil);
            this.groupBox3.Controls.Add(this.btn_eraser);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(81, 237);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outils";
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Image = global::Esgis_Paint.Properties.Resources.Zoom_Out_32px;
            this.btn_ZoomOut.Location = new System.Drawing.Point(16, 171);
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.Size = new System.Drawing.Size(45, 37);
            this.btn_ZoomOut.TabIndex = 18;
            this.btn_ZoomOut.UseVisualStyleBackColor = true;
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Image = global::Esgis_Paint.Properties.Resources.Zoom_In_32px;
            this.btn_ZoomIn.Location = new System.Drawing.Point(16, 129);
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.Size = new System.Drawing.Size(45, 37);
            this.btn_ZoomIn.TabIndex = 17;
            this.btn_ZoomIn.UseVisualStyleBackColor = true;
            // 
            // btn_pencil
            // 
            this.btn_pencil.Image = global::Esgis_Paint.Properties.Resources.Edit_32px_4;
            this.btn_pencil.Location = new System.Drawing.Point(16, 45);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(45, 37);
            this.btn_pencil.TabIndex = 0;
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Image = global::Esgis_Paint.Properties.Resources.Erase_32px;
            this.btn_eraser.Location = new System.Drawing.Point(16, 87);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(45, 37);
            this.btn_eraser.TabIndex = 1;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox6);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(97, 159);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formes ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::Esgis_Paint.Properties.Resources.Sun_32px;
            this.pictureBox6.Location = new System.Drawing.Point(50, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Esgis_Paint.Properties.Resources.Happy_32px;
            this.pictureBox5.Location = new System.Drawing.Point(9, 108);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Esgis_Paint.Properties.Resources.Hearts_32px;
            this.pictureBox4.Location = new System.Drawing.Point(50, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Esgis_Paint.Properties.Resources.Cloud_32px;
            this.pictureBox3.Location = new System.Drawing.Point(50, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Esgis_Paint.Properties.Resources.Bright_Moon_32px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Esgis_Paint.Properties.Resources.Star_32px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox_Fichier
            // 
            this.groupBox_Fichier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Fichier.Controls.Add(this.btn_exit);
            this.groupBox_Fichier.Controls.Add(this.btn_close);
            this.groupBox_Fichier.Controls.Add(this.btn_save);
            this.groupBox_Fichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Fichier.Location = new System.Drawing.Point(886, 303);
            this.groupBox_Fichier.Name = "groupBox_Fichier";
            this.groupBox_Fichier.Size = new System.Drawing.Size(103, 176);
            this.groupBox_Fichier.TabIndex = 18;
            this.groupBox_Fichier.TabStop = false;
            this.groupBox_Fichier.Text = "Fichier";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = global::Esgis_Paint.Properties.Resources.Shutdown_32px;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_exit.Location = new System.Drawing.Point(7, 124);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 41);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Esgis_Paint.Properties.Resources.Cancel_32px_1;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_close.Location = new System.Drawing.Point(7, 77);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 41);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Esgis_Paint.Properties.Resources.Save_32px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_save.Location = new System.Drawing.Point(7, 30);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 41);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(123, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gomme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1022, 638);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox_Couleur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_Epaisseur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Fichier);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "drawPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dessiner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.drawPic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Epaisseur)).EndInit();
            this.groupBox_Epaisseur.ResumeLayout(false);
            this.groupBox_Couleur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Fichier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDessinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_Epaisseur;
        private System.Windows.Forms.GroupBox groupBox_Epaisseur;
        private System.Windows.Forms.GroupBox groupBox_Couleur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_ZoomIn;
        private System.Windows.Forms.Button btn_ZoomOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox_Fichier;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox_ColorActual;
        private System.Windows.Forms.PictureBox pictureBox_Color2;
        private System.Windows.Forms.PictureBox pictureBox_Color5;
        private System.Windows.Forms.PictureBox pictureBox_Color3;
        private System.Windows.Forms.PictureBox pictureBox_Color6;
        private System.Windows.Forms.PictureBox pictureBox_Color1;
        private System.Windows.Forms.PictureBox pictureBox_Color4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}