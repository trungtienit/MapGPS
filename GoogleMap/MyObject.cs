using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Parsing
{
    public class MyObject
    {
        public List<Result> results { get; set; }
        public string status { get; set; }
    }
    public class AddressComponent
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<string> types { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }

    }

    public class Geometry
    {
        public Location location { get; set; }
        public string location_type { get; set; }
    }

    public class Result
    {
        public string formatted_address { get; set; }
        public Geometry geometry { get; set; }
    }
    public class IP
    {
        public string ip { get; set; }
    }
    public class Geolocation
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
