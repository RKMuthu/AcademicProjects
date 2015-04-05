using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Property object of the response.
     * 
     */
    [DataContract]
    public class VenueProperty
    {
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "name")]
        public String name { get; set; }
        [DataMember(Name = "value")]
        public String value { get; set; }
    }
}
