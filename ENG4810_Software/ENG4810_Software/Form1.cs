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
    
            
            //init Map 
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(-25.971684, 32.589759);

            zoomMin_B.Text = "\u002d";
            //humidity bar limits
            humRange.TotalMaximum = 100;
            humRange.TotalMinimum = 0;
            //Temperature Bar limits
            tempRange.TotalMaximum = 85;
            tempRange.TotalMinimum = -40;
            // G force limits
            gForceRange.TotalMaximum = 10;
            gForceRange.TotalMinimum = -10; 
            
            //pressure range limits
            presRange.TotalMaximum = 110;
            presRange.TotalMinimum = 3;
            // 
            magRange.TotalMaximum = 1000;
            magRange.TotalMinimum = -1000;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar_Temp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar_G_ValueChanged(object sender, EventArgs e)
        {
            
            
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

        private void zoomPlu_B_Click(object sender, EventArgs e)
        {
            if (gmap.Zoom < 18)
            {
                gmap.Zoom += 0.5;
            }
        }

        private void zoomMin_B_Click(object sender, EventArgs e)
        {
            if (gmap.Zoom > 1)
            {
                gmap.Zoom -= 0.5;
            }
        }
    }
}
