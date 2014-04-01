using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG4810_Software
{
    /*
     * A List of DataSamples required to build a route 
     */
    class Route
    {
        private List<DataSample> samples;   //List to hold all the data samples for the Route. 
        /*
         * Creates a new empty Route
         */
        public Route()
        {
            this.samples = new List<DataSample>();
        }

        /*
         * Creates a new Route with the given DataSample
         */
        public Route(DataSample ds)
        {
            this.samples = new List<DataSample>() { ds };
        }

        public void add_Sample(DataSample ds)
        {
            //might need to add check to see if sample already in List.
            samples.Add(ds);
        }

        /*
         *Returns the Sample at the  givne index
         */
        public DataSample get_Sample(int index)
        {
            
            return samples[index];
        }
    }
}
