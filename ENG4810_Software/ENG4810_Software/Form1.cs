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
        private List<Route> Routes;
        private GMapOverlay RouteOverlay;
        GMapOverlay markerOverlay;
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
            uvRange.TotalMaximum = 20;
            uvRange.TotalMinimum = 0;
            uvR_Max.Text = uvRange.RangeMaximum.ToString();
            uvR_Min.Text = uvRange.RangeMinimum.ToString();

            //Initialise Route list
            Routes = new List<Route>();
            //Initialise Route Overly;
            RouteOverlay = new GMapOverlay(gmap, "Routes");
            gmap.Overlays.Add(RouteOverlay);
            //Initialise marker overlay
            markerOverlay = new GMapOverlay(gmap, "Markers");
            gmap.Overlays.Add(markerOverlay);

            List<PointLatLng> points = new List<PointLatLng>();

            //testing points
            points.Add(new PointLatLng(-28.006224, 153.428192));
            points.Add(new PointLatLng(-28.003117, 153.426647));
            points.Add(new PointLatLng(-27.996751, 153.427677));
            points.Add(new PointLatLng(-27.989627, 153.428106));
            points.Add(new PointLatLng(-27.982199, 153.423815));
            points.Add(new PointLatLng(-27.973027, 153.419952));
            points.Add(new PointLatLng(-27.960746, 153.412056));
            points.Add(new PointLatLng(-27.947327, 153.408537));
            points.Add(new PointLatLng(-27.935574, 153.401155));
            points.Add(new PointLatLng(-27.933072, 153.383904));
            points.Add(new PointLatLng(-27.928597, 153.365707));
            points.Add(new PointLatLng(-27.921848, 153.347769));
            points.Add(new PointLatLng(-27.925792, 153.329315));
            points.Add(new PointLatLng(-27.919194, 153.32262));
            points.Add(new PointLatLng(-27.906527, 153.317213));
            points.Add(new PointLatLng(-27.89386, 153.314381));
            points.Add(new PointLatLng(-27.880129, 153.315153));
            points.Add(new PointLatLng(-27.867003, 153.312922));
            points.Add(new PointLatLng(-27.85471, 153.307772));
            points.Add(new PointLatLng(-27.842871, 153.304338));
            points.Add(new PointLatLng(-27.830727, 153.300991));
            points.Add(new PointLatLng(-27.823516, 153.29464));
            points.Add(new PointLatLng(-27.819265, 153.285971));
            points.Add(new PointLatLng(-27.81471, 153.276873));
            //points.Add(new PointLatLng(-27.808941,153.268375));
            //points.Add(new PointLatLng(-27.800817,153.262367));
            //points.Add(new PointLatLng(-27.790719,153.259192));
            //points.Add(new PointLatLng(-27.780999,153.253269));
            //points.Add(new PointLatLng(-27.77014,153.251295));
            //points.Add(new PointLatLng(-27.761254,153.246059));
            //points.Add(new PointLatLng(-27.753659,153.237734));
            //points.Add(new PointLatLng(-27.744315,153.233271));
            //points.Add(new PointLatLng(-27.73406,153.227262));
            //points.Add(new PointLatLng(-27.725171,153.220053));
            //points.Add(new PointLatLng(-27.716585,153.210354));
            //points.Add(new PointLatLng(-27.708303,153.205376));
            //points.Add(new PointLatLng(-27.699868,153.196964));
            //points.Add(new PointLatLng(-27.690976,153.192329));
            //points.Add(new PointLatLng(-27.681628,153.187609));
            //points.Add(new PointLatLng(-27.672279,153.180914));
            //points.Add(new PointLatLng(-27.662777,153.171215));
            //points.Add(new PointLatLng(-27.651829,153.1604));
            //points.Add(new PointLatLng(-27.643846,153.145638));
            //points.Add(new PointLatLng(-27.633125,153.132849));
            //points.Add(new PointLatLng(-27.621414,153.127184));
            //points.Add(new PointLatLng(-27.609626,153.121347));
            //points.Add(new PointLatLng(-27.598825,153.114395));
            //points.Add(new PointLatLng(-27.587948,153.107615));
            //points.Add(new PointLatLng(-27.577145,153.100748));
            //points.Add(new PointLatLng(-27.567787,153.085728));
            //points.Add(new PointLatLng(-27.557971,153.073711));
            //points.Add(new PointLatLng(-27.54747,153.064442));
            //points.Add(new PointLatLng(-27.535978,153.058605));
            //points.Add(new PointLatLng(-27.522202,153.053713));
            //points.Add(new PointLatLng(-27.511697,153.040066));
            //points.Add(new PointLatLng(-27.499516,153.039808));
            //points.Add(new PointLatLng(-27.486725,153.032169));
            //points.Add(new PointLatLng(-27.473095,153.023672));
            //points.Add(new PointLatLng(-27.467384,153.015261));
            //points.Add(new PointLatLng(-27.472791,153.005562));
            //points.Add(new PointLatLng(-27.483375,152.995863));
            //points.Add(new PointLatLng(-27.491903,152.994146));
            //points.Add(new PointLatLng(-27.494111, 153.006077));
            Route route1 = new Route();
            route1 = create_randDS(points);
            Routes.Add(route1);
            create_Route(Routes[0].getPoints(), RouteOverlay);

            //create_Marker(markerOverlay, route1.get_Sample(0));
            gmap.ZoomAndCenterRoute(RouteOverlay.Routes.ElementAt(0));
            //create_Marker(markerOverlay, points.ElementAt(0));

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
                gmap.Zoom += 1;
            }
        }

        private void zoomMin_B_Click(object sender, EventArgs e)
        {
            if (gmap.Zoom > 1)
            {
                gmap.Zoom -= 1;
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
        public void create_Marker(GMapOverlay overlay, DataSample ds)
        {
            GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(ds.latitude, ds.longitude));
            marker.ToolTip = new GMapRoundedToolTip(marker);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = ds.ToString();
            overlay.Markers.Add(marker);
        }

        /*
         * Creates a route from the given coordinates on the given Overlay. 
         */
        private void create_Route(List<PointLatLng> poi, GMapOverlay overlay)
        {
            GMapRoute route = new GMapRoute(poi, "route");
            //route.Stroke.Width = 5;
            //route.Stroke.Color = Color.Red;
            overlay.Routes.Add(route);
        }
        private Route create_randDS(List<PointLatLng> poi)
        {
            Route r = new Route();
            Random rand = new Random();

            for (int i = 0; i < (poi.Count - 1); i++)
            {
                DataSample ds = new DataSample();
                ds.acceleration.Add(Math.Round((-98 + rand.NextDouble() * 196), 3, MidpointRounding.AwayFromZero));
                ds.acceleration.Add(Math.Round((-98 + rand.NextDouble() * 196), 3, MidpointRounding.AwayFromZero));
                ds.acceleration.Add(Math.Round((-98 + rand.NextDouble() * 196), 3, MidpointRounding.AwayFromZero));
                ds.magnetic_Field.Add(rand.Next(-1000, 1000));
                ds.magnetic_Field.Add(rand.Next(-1000, 1000));
                ds.magnetic_Field.Add(rand.Next(-1000, 1000));
                ds.latitude = poi[i].Lat;
                ds.longitude = poi[i].Lng;
                ds.humidity = rand.Next(0, 100);
                ds.luminosity = rand.Next(0, 100000);
                ds.pressure = rand.Next(3, 110);
                ds.sound = rand.Next(0, 200);
                ds.temperature = (Math.Round((rand.NextDouble() * 125 - 40), 3, MidpointRounding.AwayFromZero));
                ds.time = "time goes here";
                ds.uv = rand.Next(0, 20);

                r.add_Sample(ds);
            }
            return r;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            //remove current markers
            int numMarkers = markerOverlay.Markers.Count() - 1;
            for (int k = 0; k <= numMarkers; k++)
            {
                markerOverlay.Markers.RemoveAt(0);
            }
            for (int i = 0; i <= Routes.Count() - 1; i++)
            {
                for (int j = 0; j <= Routes[i].get_Size() - 1; j++)
                {
                    DataSample ds = Routes[i].get_Sample(j);
                    // check the magnitude of each variable in the ds against
                    //the equicalent range bar value.
                    if (dispForce.Checked)
                    {
                        if ((Convert.ToDecimal(ds.acceleration[0]) <= Convert.ToDecimal(gForceRange.RangeMaximum * 9.8)) &&
                              (Convert.ToDecimal(ds.acceleration[0]) >= Convert.ToDecimal(gForceRange.RangeMinimum * 9.8)))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                        else if ((Convert.ToDecimal(ds.acceleration[1]) <= Convert.ToDecimal(gForceRange.RangeMaximum * 9.8)) &&
                                (Convert.ToDecimal(ds.acceleration[1]) >= Convert.ToDecimal(gForceRange.RangeMinimum * 9.8)))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                        else if ((Convert.ToDecimal(ds.acceleration[2]) <= Convert.ToDecimal(gForceRange.RangeMaximum * 9.8)) &&
                                (Convert.ToDecimal(ds.acceleration[2]) >= Convert.ToDecimal(gForceRange.RangeMinimum * 9.8)))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                    }
                    if (dispTemp.Checked)
                    {
                        if (Convert.ToDecimal(ds.temperature) <= Convert.ToDecimal(tempRange.RangeMaximum) &&
                           Convert.ToDecimal(ds.temperature) >= Convert.ToDecimal(tempRange.RangeMinimum))
                        {
                            create_Marker(markerOverlay, ds);
                        }

                    }
                    if (dispPres.Checked)
                    {
                        if (Convert.ToDecimal(ds.pressure) <= Convert.ToDecimal(presRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.pressure) >= Convert.ToDecimal(presRange.RangeMinimum))
                        {
                            create_Marker(markerOverlay, ds);
                        }

                    }
                    if (dispUV.Checked)
                    {
                        if (Convert.ToDecimal(ds.uv) <= Convert.ToDecimal(uvRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.uv) >= Convert.ToDecimal(uvRange.RangeMinimum))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                    }
                    if (dispDBA.Checked)
                    {
                        if (Convert.ToDecimal(ds.sound) <= Convert.ToDecimal(dbRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.sound) >= Convert.ToDecimal(dbRange.RangeMinimum))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                    }
                    if (dispHum.Checked)
                    {
                        if (Convert.ToDecimal(ds.humidity) <= Convert.ToDecimal(humRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.humidity) >= Convert.ToDecimal(humRange.RangeMinimum))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                    }
                    if (dispMagF.Checked)
                    {
                        if ((Convert.ToDecimal(ds.magnetic_Field[0]) <= Convert.ToDecimal(magRange.RangeMaximum)) &&
                              (Convert.ToDecimal(ds.magnetic_Field[0]) >= Convert.ToDecimal(magRange.RangeMinimum)))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                        else if ((Convert.ToDecimal(ds.magnetic_Field[1]) <= Convert.ToDecimal(magRange.RangeMaximum)) &&
                                (Convert.ToDecimal(ds.magnetic_Field[1]) >= Convert.ToDecimal(magRange.RangeMinimum)))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                        else if ((Convert.ToDecimal(ds.magnetic_Field[2]) <= Convert.ToDecimal(magRange.RangeMaximum)) &&
                                (Convert.ToDecimal(ds.magnetic_Field[2]) >= Convert.ToDecimal(magRange.RangeMinimum)))
                        {
                            create_Marker(markerOverlay, ds);
                        }

                    }
                    if (dispLux.Checked)
                    {
                        if (Convert.ToDecimal(ds.luminosity) <= Convert.ToDecimal(lumRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.luminosity) >= Convert.ToDecimal(lumRange.RangeMinimum))
                        {
                            create_Marker(markerOverlay, ds);
                        }
                    }
                }

            }
        }

        private void Select_All_CheckedChanged(object sender, EventArgs e)
        {
            if (Select_All.Checked)
            {
                dispDBA.CheckState = CheckState.Checked;
                dispForce.CheckState = CheckState.Checked;
                dispHum.CheckState = CheckState.Checked;
                dispPres.CheckState = CheckState.Checked;
                dispTemp.CheckState = CheckState.Checked;
                dispUV.CheckState = CheckState.Checked;
                dispMagF.CheckState = CheckState.Checked;
                dispLux.CheckState = CheckState.Checked;
            }
            else
            {
                dispDBA.CheckState = CheckState.Unchecked;
                dispForce.CheckState = CheckState.Unchecked;
                dispHum.CheckState = CheckState.Unchecked;
                dispPres.CheckState = CheckState.Unchecked;
                dispTemp.CheckState = CheckState.Unchecked;
                dispUV.CheckState = CheckState.Unchecked;
                dispMagF.CheckState = CheckState.Unchecked;
                dispLux.CheckState = CheckState.Unchecked;
            }
        }

    }

}
// random code snppets
//for (int i = 0; i < markerOverlay.Markers.Count; i++)

//{
//    markerOverlay.Markers.RemoveAt(i);
//}


//Creates markers at all points on routes
//for (int i = 0; i < Routes[0].get_Size(); i++)
//            {
//                create_Marker(markerOverlay, Routes[0].get_Sample(i));
//            }

