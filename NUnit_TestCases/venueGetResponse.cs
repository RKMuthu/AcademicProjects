using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections;
namespace Tests
{
    /*
     * This Class represents modelling the response data that 
     * are generated during the venueGet service.
     * 
     */
    [DataContract]
    public class venueGetResponse : commonResponse
    {
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "postal_code")]
        public String postal_code { get; set; }
        [DataMember(Name = "region_abbr")]
        public String region_abbr { get; set; }
        [DataMember(Name = "name")]
        public String name { get; set; }
        [DataMember(Name = "address")]
        public String address { get; set; }
        [DataMember(Name = "links")]
        public Links links { get; set; }
        [DataMember(Name = "images")]
        public Images images { get; set; }
        [DataMember(Name = "tags")]
        public Tags tags { get; set; }
        [DataMember(Name = "properties")]
        public VenueProperties venueProperties { get; set; }
    }
}
