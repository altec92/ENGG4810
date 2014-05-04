using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG4810_Software
{
    public class DataSample
    {
        public string time;                // string representation of the time in ISO 8061 format
        public double latitude;             // latitude coordinates         units: n/a
        public double longitude;            // longitude coordinates        units: n/a
        public double temperature;          // temperature reading          units: C
        public int uv;                   // uv light intensity reading   units: mW/cm^2
        public int pressure;               // absolute pressure reading    units: kPa
        public int sound;                  // SPL A weighted sound level   units: dBA
        public int luminosity;             // Luminosity in reading in     units: Lux
        public int humidity;               // humidity reading             units: %RH
        public List<double> acceleration;   // XYZ acceleration readings    Units: m/s^2
        public List<int> magnetic_Field; // XYZ magnetic field readings  units: uT
        /*
         *Constructor initalises all variable to empty/0 
         */
        public DataSample()
        {
            //possibly need to add a unique id to avoid duplicates in a list. 
            this.time = "";
            this.latitude = Double.MaxValue;
            this.longitude = Double.MaxValue;
            this.uv = -1;
            this.pressure = -1;
            this.sound = -1;
            this.luminosity = -1;
            this.humidity = -1;
            this.acceleration = new List<double>();
            this.magnetic_Field = new List<int>();
            this.temperature = 0;
        }

        public override string ToString()
        {
            string temp = "";
            temp = "Time: " + this.time + "\n" +
                   "Latitude: " + this.latitude.ToString() + "\n" +
                   "Longitude: " + this.longitude.ToString() + "\n" +
                   "Acceleration: " + string.Join(", ", this.acceleration.ToArray()) + "\n" +
                   "Temperature: " + this.temperature.ToString() + " \u00B0" + "C" + "\n" +
                   "Pressure: " + this.pressure.ToString() + " kPa" + "\n" +
                   "Humidity: " + this.humidity.ToString() + "% " + "\n" +
                   "Magnetic Field: " + "[ " + string.Join(", ", this.magnetic_Field.ToArray()) + " ]" + "uT" + "\n" +
                   "UV Light: " + this.uv.ToString() + " mW/cm^2" + "\n" +
                   "Sound: " + this.sound.ToString() + " dbA" + "\n" +
                   "Luminosity: " + this.luminosity.ToString() + " Lux\n";
            return temp;
        }
    }
}
