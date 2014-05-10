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
            //gmap.Position = new GMap.NET.PointLatLng(-25.971684, 32.589759);
            
      

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

            //testing points
            List<PointLatLng> points = new List<PointLatLng>();

            List<PointLatLng> points2 = new List<PointLatLng>();
            //Rouets
            //Routes1
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
            points.Add(new PointLatLng(-27.808941,153.268375));
            points.Add(new PointLatLng(-27.800817,153.262367));
            points.Add(new PointLatLng(-27.790719,153.259192));
            points.Add(new PointLatLng(-27.780999,153.253269));
            points.Add(new PointLatLng(-27.77014,153.251295));
            points.Add(new PointLatLng(-27.761254,153.246059));
            //points.Add(new PointLatLng(-27.753659,153.237734));
            //Route2
            points2.Add(new PointLatLng(-27.744315,153.233271));
            points2.Add(new PointLatLng(-27.73406,153.227262));
            points2.Add(new PointLatLng(-27.725171,153.220053));
            points2.Add(new PointLatLng(-27.716585,153.210354));
            points2.Add(new PointLatLng(-27.708303,153.205376));
            points2.Add(new PointLatLng(-27.699868,153.196964));
            points2.Add(new PointLatLng(-27.690976,153.192329));
            points2.Add(new PointLatLng(-27.681628,153.187609));
            points2.Add(new PointLatLng(-27.672279,153.180914));
            points2.Add(new PointLatLng(-27.662777,153.171215));
            points2.Add(new PointLatLng(-27.651829,153.1604));
            points2.Add(new PointLatLng(-27.643846,153.145638));
            points2.Add(new PointLatLng(-27.633125,153.132849));
            points2.Add(new PointLatLng(-27.621414,153.127184));
            points2.Add(new PointLatLng(-27.609626,153.121347));
            points2.Add(new PointLatLng(-27.598825,153.114395));
            points2.Add(new PointLatLng(-27.587948,153.107615));
            points2.Add(new PointLatLng(-27.577145,153.100748));
            points2.Add(new PointLatLng(-27.567787,153.085728));
            points2.Add(new PointLatLng(-27.557971,153.073711));
            points2.Add(new PointLatLng(-27.54747,153.064442));
            points2.Add(new PointLatLng(-27.535978,153.058605));
            points2.Add(new PointLatLng(-27.522202,153.053713));
            points2.Add(new PointLatLng(-27.511697,153.040066));
            points2.Add(new PointLatLng(-27.499516,153.039808));
            points2.Add(new PointLatLng(-27.486725,153.032169));
            points2.Add(new PointLatLng(-27.473095,153.023672));
            points2.Add(new PointLatLng(-27.467384,153.015261));
            points2.Add(new PointLatLng(-27.472791,153.005562));
            points2.Add(new PointLatLng(-27.483375,152.995863));
            points2.Add(new PointLatLng(-27.491903,152.994146));
            points2.Add(new PointLatLng(-27.494111, 153.006077));
            Route route1 = new Route();
            Route route2 = new Route();
            route1 = create_randDS(points);
            route2 = create_randDS(points2);
            Routes.Add(route1);
            create_Route_Label("Log_1");
            Routes.Add(route2);
            create_Route_Label("Log_2");
            create_Route(Routes[0], RouteOverlay);
            create_Route(Routes[1], RouteOverlay);

            gmap.ZoomAndCenterRoute(RouteOverlay.Routes.ElementAt(0));

            
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
        
        //Updates corresponding text box with current max and min of corresponding range bar

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
         * Creates a route from the given Route on the given Overlay. 
         */
        private void create_Route(Route r, GMapOverlay overlay)
        {
            for (int i = 0; i < r.get_Size() - 1; i++)
            {
                List<PointLatLng> twoPoints = new List<PointLatLng>();
                DataSample ds1 = r.get_Sample(i);
                DataSample ds2 = r.get_Sample(i + 1);
                double tempAvg = (ds1.temperature + ds2.temperature) / 2;
                twoPoints.Add(new PointLatLng(ds1.latitude, ds1.longitude));
                twoPoints.Add(new PointLatLng(ds2.latitude, ds2.longitude));
                GMapRoute route = new GMapRoute(twoPoints, "route " + i.ToString());
                if (tempAvg <= -35)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0 , 53, 204);
                }
                else if (tempAvg <= -30)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 85, 205);
                }
                else if (tempAvg <= -25)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 119, 207);
                }
                else if (tempAvg <= -20)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 153, 209);
                }
                else if (tempAvg <= -15)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 188, 210);
                }
                else if (tempAvg <= -10)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 212, 201);
                }
                else if (tempAvg <= -5)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 214, 169);
                }
                else if (tempAvg <= 0)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 215, 136);
                }
                else if (tempAvg <= 5)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 217, 103);
                }
                else if (tempAvg <= 10)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 219, 69);
                }
                else if (tempAvg <= 15)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(0, 221, 34);
                }
                else if (tempAvg <= 20)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(35, 224, 0);
                }
                else if (tempAvg <= 25)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(71, 226, 0);
                }
                else if (tempAvg <= 30)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(108, 227, 0);
                }
                else if (tempAvg <= 35)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(145, 229, 0);
                }
                else if (tempAvg <= 40)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(183, 231, 0);
                }
                else if (tempAvg <= 45)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(221, 233, 0);
                }
                else if (tempAvg <= 50)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(234, 209, 0);
                }
                else if (tempAvg <= 55)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(236, 173, 0);
                }
                else if (tempAvg <= 60)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(238, 137, 0);
                }
                else if (tempAvg <= 65)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(239, 100, 0);
                }
                else if (tempAvg <= 70)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(241, 62, 0);
                }
                else if (tempAvg <= 75)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(243, 24, 0);
                }
                else if (tempAvg <= 80)
                {
                    route.Stroke.Width = 5;
                    route.Stroke.Color = Color.FromArgb(245, 0, 14);
                }
                
                overlay.Routes.Add(route);
            }
        }

        /*
         * TESTING PURPOSES: CREATES RANDOM DATA SAMPLES AND ADDS THEM TO A ROUTE
         */
        private Route create_randDS(List<PointLatLng> poi)
        {
            Route r = new Route();
            Random rand = new Random();

            for (int i = 0; i < poi.Count; i++)
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
                ds.time = new DateTime(2014, 4, 8, 12, 15, 0).ToString();
                ds.uv = rand.Next(0, 20);

                r.add_Sample(ds);
            }
            return r;

        }

        /*
         * Creates a Label for each route in the Routes List 
         */
        private void create_Route_Label(string name)
        {
            this.splitContainer1.Panel1.Controls.Add(new Label
            {
                Location = new Point(444, 44 + (Routes.Count - 1) * 26),
                Name = "ThreshCheckR" + Routes.Count.ToString(),
                Text = name,
                BorderStyle = BorderStyle.None,
                BackColor = Color.Transparent,
                AutoSize = true,
                Size = new Size(35, 13) 
            });
        }

        /*
         * Updates the Map depending on the Thresholds Selected
         */
        private void Update_Click(object sender, EventArgs e)
        {
            

            List<DataSample> out_of_threshold = new List<DataSample>(); //List for all datasamples that are out of the threshold

            //Remove current MArkers
            for (int k = 0; k <= markerOverlay.Markers.Count() - 1; k++)
            {
                markerOverlay.Markers.RemoveAt(0);
            }

            //Check Each Route in Routes List
            for (int i = 0; i <= Routes.Count() - 1; i++)
            {
                //Threshold checks
                for (int j = 0; j <= Routes[i].get_Size() - 1; j++)
                {
                    DataSample ds = Routes[i].get_Sample(j);
                    // check the magnitude of each variable in the ds against
                    //the equicalent range bar value.
                    
                    //acceleration
                    if (dispForce.Checked & !out_of_threshold.Contains(ds) & (ds.acceleration.Count != 0))
                    {
                        if ((Convert.ToDecimal(ds.acceleration[0]) <= Convert.ToDecimal(gForceRange.RangeMaximum * 9.8)) &&
                                (Convert.ToDecimal(ds.acceleration[0]) >= Convert.ToDecimal(gForceRange.RangeMinimum * 9.8)))
                        {
                            //continue checks
                        }
                        else if ((Convert.ToDecimal(ds.acceleration[1]) <= Convert.ToDecimal(gForceRange.RangeMaximum * 9.8)) &&
                                (Convert.ToDecimal(ds.acceleration[1]) >= Convert.ToDecimal(gForceRange.RangeMinimum * 9.8)))
                        {
                            //continue checks
                        }
                        else if ((Convert.ToDecimal(ds.acceleration[2]) <= Convert.ToDecimal(gForceRange.RangeMaximum * 9.8)) &&
                                (Convert.ToDecimal(ds.acceleration[2]) >= Convert.ToDecimal(gForceRange.RangeMinimum * 9.8)))
                        {
                            //continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }
                    }
                    //Temperature
                    if (dispTemp.Checked & !out_of_threshold.Contains(ds))
                    {
                        if (Convert.ToDecimal(ds.temperature) <= Convert.ToDecimal(tempRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.temperature) >= Convert.ToDecimal(tempRange.RangeMinimum))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }

                    }
                    //Pressure
                    if (dispPres.Checked & !out_of_threshold.Contains(ds) & (ds.pressure != -1))
                    {
                        if (Convert.ToDecimal(ds.pressure) <= Convert.ToDecimal(presRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.pressure) >= Convert.ToDecimal(presRange.RangeMinimum))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }

                    }
                    //UV Light
                    if (dispUV.Checked & !out_of_threshold.Contains(ds) & (ds.uv != -1))
                    {
                        if (Convert.ToDecimal(ds.uv) <= Convert.ToDecimal(uvRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.uv) >= Convert.ToDecimal(uvRange.RangeMinimum))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }
                    }
                    //Sound Level
                    if (dispDBA.Checked & !out_of_threshold.Contains(ds) & (ds.sound != -1))
                    {
                        if (Convert.ToDecimal(ds.sound) <= Convert.ToDecimal(dbRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.sound) >= Convert.ToDecimal(dbRange.RangeMinimum))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }
                    }
                    //Humidity
                    if (dispHum.Checked & !out_of_threshold.Contains(ds) & (ds.humidity != -1))
                    {
                        if (Convert.ToDecimal(ds.humidity) <= Convert.ToDecimal(humRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.humidity) >= Convert.ToDecimal(humRange.RangeMinimum))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }
                    }
                    //Magnetic Field
                    if (dispMagF.Checked & !out_of_threshold.Contains(ds) & (ds.magnetic_Field.Count != 0))
                    {
                        if ((Convert.ToDecimal(ds.magnetic_Field[0]) <= Convert.ToDecimal(magRange.RangeMaximum)) &&
                                (Convert.ToDecimal(ds.magnetic_Field[0]) >= Convert.ToDecimal(magRange.RangeMinimum)))
                        {
                            // continue checks
                        }
                        else if ((Convert.ToDecimal(ds.magnetic_Field[1]) <= Convert.ToDecimal(magRange.RangeMaximum)) &&
                                (Convert.ToDecimal(ds.magnetic_Field[1]) >= Convert.ToDecimal(magRange.RangeMinimum)))
                        {
                            // continue checks
                        }
                        else if ((Convert.ToDecimal(ds.magnetic_Field[2]) <= Convert.ToDecimal(magRange.RangeMaximum)) &&
                                (Convert.ToDecimal(ds.magnetic_Field[2]) >= Convert.ToDecimal(magRange.RangeMinimum)))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }

                    }
                    //Luminosity
                    if (dispLux.Checked & !out_of_threshold.Contains(ds) & (ds.luminosity != -1) )
                    {
                        if (Convert.ToDecimal(ds.luminosity) <= Convert.ToDecimal(lumRange.RangeMaximum) &&
                            Convert.ToDecimal(ds.luminosity) >= Convert.ToDecimal(lumRange.RangeMinimum))
                        {
                            // continue checks
                        }
                        else
                        {
                            out_of_threshold.Add(ds);
                        }
                    }
                    //Create Marker if out of threshold 
                    if (out_of_threshold.Contains(ds) && out_of_threshold.Count > 0)
                    {
                        create_Marker(markerOverlay, ds);
                       
                    }
                    
                }
                 //update Route Label colour
                if (out_of_threshold.Count > 0) 
                {
                    Controls.Find("ThreshCheckR" + (i + 1).ToString(), true).ElementAt(0).BackColor = Color.Red;
                    this.splitContainer1.Update();
                }
                else
                {
                    Controls.Find("ThreshCheckR" + (i + 1).ToString(), true).ElementAt(0).BackColor = Color.Green;
                    this.splitContainer1.Update();
                }
            }
        }

        /*
         * Sets all check boxes to the state of the select all check box when the state changes. 
         */
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


