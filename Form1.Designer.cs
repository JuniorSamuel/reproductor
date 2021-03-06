namespace reproductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFinal = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btVolumen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.macTrackBar1Duracion = new XComponent.SliderBar.MACTrackBar();
            this.panelList = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.macTrackBar2Volumen = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReproducir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.labelOri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelList.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // media
            // 
            this.media.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(0, 27);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(700, 370);
            this.media.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 328);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFinal);
            this.panel1.Controls.Add(this.labelInicio);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btVolumen);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btAtras);
            this.panel1.Controls.Add(this.macTrackBar1Duracion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 54);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelFinal
            // 
            this.labelFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(565, 32);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(37, 13);
            this.labelFinal.TabIndex = 7;
            this.labelFinal.Text = "00: 00";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(207, 34);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(37, 13);
            this.labelInicio.TabIndex = 6;
            this.labelInicio.Text = "00: 00";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackgroundImage = global::reproductor.Properties.Resources._057_playlist;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(650, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // btVolumen
            // 
            this.btVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btVolumen.BackgroundImage = global::reproductor.Properties.Resources._103_volume;
            this.btVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVolumen.FlatAppearance.BorderSize = 0;
            this.btVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolumen.Location = new System.Drawing.Point(150, 14);
            this.btVolumen.Name = "btVolumen";
            this.btVolumen.Size = new System.Drawing.Size(22, 22);
            this.btVolumen.TabIndex = 4;
            this.btVolumen.UseVisualStyleBackColor = true;
            this.btVolumen.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackgroundImage = global::reproductor.Properties.Resources._068_skip_button;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(101, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImage = global::reproductor.Properties.Resources._007_pause_button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(55, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btAtras
            // 
            this.btAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAtras.BackgroundImage = global::reproductor.Properties.Resources._003_previous;
            this.btAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAtras.FlatAppearance.BorderSize = 0;
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Location = new System.Drawing.Point(17, 11);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(32, 32);
            this.btAtras.TabIndex = 1;
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // macTrackBar1Duracion
            // 
            this.macTrackBar1Duracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.macTrackBar1Duracion.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1Duracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1Duracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1Duracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1Duracion.IndentHeight = 6;
            this.macTrackBar1Duracion.Location = new System.Drawing.Point(198, 8);
            this.macTrackBar1Duracion.Maximum = 100;
            this.macTrackBar1Duracion.Minimum = 0;
            this.macTrackBar1Duracion.Name = "macTrackBar1Duracion";
            this.macTrackBar1Duracion.Size = new System.Drawing.Size(413, 28);
            this.macTrackBar1Duracion.TabIndex = 0;
            this.macTrackBar1Duracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1Duracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar1Duracion.TickHeight = 4;
            this.macTrackBar1Duracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1Duracion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar1Duracion.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1Duracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1Duracion.TrackLineHeight = 3;
            this.macTrackBar1Duracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1Duracion.Value = 0;
            this.macTrackBar1Duracion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1Duracion_ValueChanged);
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.Controls.Add(this.labelOri);
            this.panelList.Controls.Add(this.button4);
            this.panelList.Controls.Add(this.listBox1);
            this.panelList.Location = new System.Drawing.Point(428, 12);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(260, 378);
            this.panelList.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::reproductor.Properties.Resources._001_play_button;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(8, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 22);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // macTrackBar2Volumen
            // 
            this.macTrackBar2Volumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.macTrackBar2Volumen.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar2Volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar2Volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar2Volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar2Volumen.IndentHeight = 6;
            this.macTrackBar2Volumen.Location = new System.Drawing.Point(146, 284);
            this.macTrackBar2Volumen.Maximum = 100;
            this.macTrackBar2Volumen.Minimum = 0;
            this.macTrackBar2Volumen.Name = "macTrackBar2Volumen";
            this.macTrackBar2Volumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.macTrackBar2Volumen.Size = new System.Drawing.Size(28, 120);
            this.macTrackBar2Volumen.TabIndex = 6;
            this.macTrackBar2Volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2Volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar2Volumen.TickHeight = 4;
            this.macTrackBar2Volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2Volumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.macTrackBar2Volumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar2Volumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2Volumen.TrackLineHeight = 3;
            this.macTrackBar2Volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2Volumen.Value = 0;
            this.macTrackBar2Volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2Volumen_ValueChanged);
            this.macTrackBar2Volumen.MouseLeave += new System.EventHandler(this.macTrackBar2Volumen_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproducciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(700, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reproducciónToolStripMenuItem
            // 
            this.reproducciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemReproducir,
            this.itemPause,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem});
            this.reproducciónToolStripMenuItem.Name = "reproducciónToolStripMenuItem";
            this.reproducciónToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.reproducciónToolStripMenuItem.Text = "Reproducción ";
            // 
            // itemReproducir
            // 
            this.itemReproducir.Image = global::reproductor.Properties.Resources._008_play_button;
            this.itemReproducir.Name = "itemReproducir";
            this.itemReproducir.Size = new System.Drawing.Size(138, 22);
            this.itemReproducir.Text = "Reproduccir";
            this.itemReproducir.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemPause
            // 
            this.itemPause.Image = global::reproductor.Properties.Resources._007_pause_button;
            this.itemPause.Name = "itemPause";
            this.itemPause.Size = new System.Drawing.Size(138, 22);
            this.itemPause.Text = "Pausar";
            this.itemPause.Click += new System.EventHandler(this.button2_Click);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Image = global::reproductor.Properties.Resources._068_skip_button;
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.siguienteToolStripMenuItem.Text = "Siguiente";
            this.siguienteToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Image = global::reproductor.Properties.Resources._003_previous;
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // labelOri
            // 
            this.labelOri.AutoSize = true;
            this.labelOri.Location = new System.Drawing.Point(4, 4);
            this.labelOri.Name = "labelOri";
            this.labelOri.Size = new System.Drawing.Size(109, 13);
            this.labelOri.TabIndex = 7;
            this.labelOri.Text = "Lista de reproducción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.macTrackBar2Volumen);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.media);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer media;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelList;
        private XComponent.SliderBar.MACTrackBar macTrackBar1Duracion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btVolumen;
        private XComponent.SliderBar.MACTrackBar macTrackBar2Volumen;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Timer tmSlider;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemReproducir;
        private System.Windows.Forms.ToolStripMenuItem itemPause;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label labelOri;
    }
}

