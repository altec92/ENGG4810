using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG4810_Software
{
    class DataSample
    {
        public string time;                // string representation of the time in ISO 8061 format
        public float latitude;             // latitude coordinates         units: n/a
        public float longitude;            // longitude coordinates        units: n/a
        public float temperature;          // temperature reading          units: C
        public float uv;                   // uv light intensity reading   units: mW/cm^2
        public int pressure;               // absolute pressure reading    units: kPa
        public int sound;                  // SPL A weighted sound level   units: dBA
        public int luminosity;             // Luminosity in reading in     units: Lux
        public int humidity;               // humidity reading             units: %RH
        public List<float> acceleration;   // XYZ acceleration readings    Units: m/s^2
        public List<float> magnetic_Field; // XYZ magnetic field readings  units: uT
        /*
         *Constructor initalises all variable to empty/0 
         */
        public DataSample()
        {
            //possibly need to add a unique id to avoid duplicates in a list. 
            this.time = "";
            this.latitude = 0;
            this.longitude = 0;
            this.uv = 0;
            this.pressure = 0;
            this.pressure = 0;
            this.sound = 0;
            this.luminosity = 0;
            this.humidity = 0;
            this.acceleration = new List<float>();
            this.magnetic_Field = new List<float>();
            this.temperature = 0;
        }
    }
}
