#define DEBUG

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


namespace ENG4810_Software
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            //Everything that needs to happen at startup. 
            InitializeComponent();
    
            
            //init Map 
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(-25.971684, 32.589759);
            
            //better performance for lots of objects. 
            gmap.ForceDoubleBuffer = true; 

            //Initialise Maximums and Minimums of the RangeBars including lables
            zoomMin_B.Text = "\u002d";
            // not following limits Max min Swapped due to orientation of the range bars. 
            //humidity bar limits
            humRange.TotalMinimum = 0;
            humRange.TotalMaximum = 100;
            humR_Max.Text = humRange.RangeMaximum.ToString();
            humR_Min.Text = humRange.RangeMinimum.ToString();
            //Temperature Bar limits
            tempRange.TotalMinimum = -40;
            tempRange.TotalMaximum = 85;
            tempR_Max.Text = tempRange.RangeMaximum.ToString();
            tempR_Min.Text = tempRange.RangeMinimum.ToString();
            // G force limits
            gForceRange.TotalMinimum = -10;
            gForceRange.TotalMaximum = 10;
            gRang_Max.Text = gForceRange.RangeMaximum.ToString();
            gRang_Min.Text = gForceRange.RangeMinimum.ToString();
            //pressure range limits
            presRange.TotalMinimum = 3;
            presRange.TotalMaximum = 110;
            presR_Max.Text = presRange.RangeMaximum.ToString();
            presR_Min.Text = presRange.RangeMinimum.ToString();
            // Magnetic Field range limits
            magRange.TotalMinimum = -1000;
            magRange.TotalMaximum = 1000;
            magR_Max.Text = magRange.RangeMaximum.ToString();
            magR_Min.Text = magRange.RangeMinimum.ToString();
            //luminosity range limits
            lumRange.TotalMinimum = 0;
            lumRange.TotalMaximum = 100000;
            lumR_Max.Text = lumRange.RangeMaximum.ToString();
            lumR_Min.Text = lumRange.RangeMinimum.ToString();
            // sound level limits
            dbRange.TotalMinimum = 0;
            dbRange.TotalMaximum = 200;
            dbaR_Max.Text = dbRange.RangeMaximum.ToString();
            dbaR_Min.Text = dbRange.RangeMinimum.ToString();
            // UV Range limits
            uvRange.TotalMaximum = 11;
            uvRange.TotalMinimum = 0;
            uvR_Max.Text = uvRange.RangeMaximum.ToString();
            uvR_Min.Text = uvRange.RangeMinimum.ToString();
            
            //Initialise marker overlay
            GMapOverlay markerOverlay = new GMapOverlay(gmap, "Markers");
            gmap.Overlays.Add(markerOverlay);
           // place_Marker(markerOverlay, -25.971684, 32.589759);

           //Console.Write(string.Join(",",ds.acceleration.ToArray()));
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

        private void lumRange_RangeChanged(object sender, EventArgs e)
        {
            lumR_Min.Text = lumRange.RangeMinimum.ToString();
            lumR_Max.Text = lumRange.RangeMaximum.ToString();
        }

        private void dbRange_RangeChanged(object sender, EventArgs e)
        {
            dbaR_Max.Text = dbRange.RangeMaximum.ToString();
            dbaR_Min.Text = dbRange.RangeMinimum.ToString();
        }

        private void magRange_RangeChanged(object sender, EventArgs e)
        {
            magR_Max.Text = magRange.RangeMaximum.ToString();
            magR_Min.Text = magRange.RangeMinimum.ToString();
        }

        private void uvRange_RangeChanged(object sender, EventArgs e)
        {
            uvR_Max.Text = uvRange.RangeMaximum.ToString();
            uvR_Min.Text = uvRange.RangeMinimum.ToString();
        }

        private void presRange_Load(object sender, EventArgs e)
        {

        }

        private void presRange_RangeChanged(object sender, EventArgs e)
        {
            presR_Max.Text = presRange.RangeMaximum.ToString();
            presR_Min.Text = presRange.RangeMinimum.ToString();
        }

        private void humRange_RangeChanged(object sender, EventArgs e)
        {
            humR_Max.Text = humRange.RangeMaximum.ToString();
            humR_Min.Text = humRange.RangeMinimum.ToString();
        }

        private void gForceRange_RangeChanged(object sender, EventArgs e)
        {
            gRang_Max.Text = gForceRange.RangeMaximum.ToString();
            gRang_Min.Text = gForceRange.RangeMinimum.ToString();
        }

        private void tempRange_RangeChanged(object sender, EventArgs e)
        {
            tempR_Max.Text = tempRange.RangeMaximum.ToString();
            tempR_Min.Text = tempRange.RangeMinimum.ToString();
        }

        /*
         * Place Green Marker on a given overlay at a given Latitude and Longitude
         */
        private void place_Marker(GMapOverlay overlay, double lat, double lng)
        {
            GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(lat, lng));
            overlay.Markers.Add(marker);
        }
     

    }
    
}
// random code snppets
//for (int i = 0; i < markerOverlay.Markers.Count; i++)
//{
//    markerOverlay.Markers.RemoveAt(i);
//}
