#define DEBUG
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ENG4810_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Everything that needs to happen at startup. 
            InitializeComponent();
            //track bar ranges;
            trackBar_Temp.Minimum = -40;
            trackBar_Temp.Maximum = 85;
            trackBar_G.Minimum = -10;
            trackBar_G.Maximum = +10;

            // Initialise labels and textboxes.
            tempBar_text.Text = trackBar_Temp.Value.ToString();
            tempBar_Max.Text = trackBar_Temp.Maximum.ToString()+"C";
            tempBar_Min.Text = trackBar_Temp.Minimum.ToString()+"C";
            gBar_text.Text = trackBar_G.Value.ToString();
            gBar_Max.Text = trackBar_G.Maximum.ToString()+"g";
            gBar_Min.Text = trackBar_G.Minimum.ToString() + "g";

            //init Map 
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(-25.971684, 32.589759);
            //gmap.SetCurrentPositionByKeywords("Brisbane,Autralia");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar_Temp_ValueChanged(object sender, EventArgs e)
        {
            tempBar_text.Text = trackBar_Temp.Value.ToString();
        }

        private void trackBar_G_ValueChanged(object sender, EventArgs e)
        {
            gBar_text.Text = trackBar_G.Value.ToString();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1; 

            //DialogResult userClickedOK = fileDialog.ShowDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                  
                // insert file handing stuff here 
             }
 
        }
    }
}
