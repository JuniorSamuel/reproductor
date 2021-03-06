using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace reproductor
{
    public partial class Form1 : Form
    {
        Lista listCanciones;
        int play = -1;
        int pL = 0;
        int vl = 50;
        public Form1()
        {
            InitializeComponent();
            listCanciones = new Lista();
            init();
        }

        public void seleccion()
        {
            listBox1.SetSelected(listCanciones.getSelector(), true);
        }
        private void init()
        {

            cargarMult();
            panelList.Visible = false;
            macTrackBar2Volumen.Visible = false;           
           
        }

        public void cargarMult()
        {
            listCanciones.addCancion(Directory.GetFiles("C:\\Users\\Samy\\Music", "*.mp3", SearchOption.AllDirectories));
            foreach (String can in listCanciones.getList())
            {
                FileInfo info = new FileInfo(can);
                listBox1.Items.Add(info.Name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btVolumen.Tag = (macTrackBar2Volumen.Value = media.settings.volume = vl).ToString();
            this.media.uiMode = "none";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            media.URL = (String) listCanciones.getList()[index];
            listCanciones.setSelector(index);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (play == 0)
            {
                media.Ctlcontrols.pause();
                tmSlider.Stop();

                button2.BackgroundImage = Properties.Resources._008_play_button;

                itemReproducir.Enabled = true;
                itemPause.Enabled = false;
                
                play = 1;
            }
            else if (play == 1)
            {
                media.Ctlcontrols.play();
                tmSlider.Start();

                button2.BackgroundImage = Properties.Resources._007_pause_button;

                itemReproducir.Enabled = false;
                itemPause.Enabled = true;
                play = 0;
            }
            else
            {
                media.URL = listCanciones.reproduciendo();
                tmSlider.Start();
                macTrackBar1Duracion.Enabled = true;
                play = 0;
                seleccion();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCanciones.atras();
            media.URL = listCanciones.reproduciendo();
            seleccion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listCanciones.siguiente();
            media.URL = listCanciones.reproduciendo();
            seleccion();
        }

        private void macTrackBar1Duracion_ValueChanged(object sender, decimal value)
        {
            macTrackBar1Duracion.Maximum = (int)media.currentMedia.duration;

            if (macTrackBar1Duracion.Value == (int)media.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                media.Ctlcontrols.currentPosition = macTrackBar1Duracion.Value;
            }

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            macTrackBar2Volumen.Visible = true;
        }

        private void macTrackBar2Volumen_MouseLeave(object sender, EventArgs e)
        {
            macTrackBar2Volumen.Visible = false;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (pL == 0)
            {
                panelList.Visible = true;
                pL = 1;
            }
            else
            {
                panelList.Visible = false;
                pL = 0;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                macTrackBar1Duracion.Value = (int) media.Ctlcontrols.currentPosition;
                labelInicio.Text = media.Ctlcontrols.currentPositionString;
                labelFinal.Text = media.currentMedia.durationString;
            }
            catch
            {


            }
        }

        private void macTrackBar2Volumen_ValueChanged(object sender, decimal value)
        {
            media.settings.volume = macTrackBar2Volumen.Value;
            macTrackBar2Volumen.Tag = media.settings.volume.ToString();
        }

        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                macTrackBar1Duracion.Value = (int)media.Ctlcontrols.currentPosition;
                labelInicio.Text = media.Ctlcontrols.currentPositionString;
                labelFinal.Text = media.currentMedia.durationString;
            }
            catch
            {

            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REalizado por junior samuel.");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFile.InitialDirectory = "C:\\Users\\Samy\\Music";
            openFile.Filter = "Archivo de audio y video|*.mp3;*.mp4;.*;";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String file = openFile.FileName;
                    listCanciones.addCancion(file);
                    FileInfo info = new FileInfo(file);
                    listBox1.Items.Add(info.Name);
                }
                catch (Exception)
                {

                }

               
            }
       
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void media_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("REalizado por junior samuel.");
        }

        private void origenDeMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
