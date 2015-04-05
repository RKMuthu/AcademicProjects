using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the event object of the response.          
    */
    [DataContract]
   public class eventAttributes
    {
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "description")]
        public String description { get; set; }
        [DataMember(Name = "venue_url")]
        public String venue_url { get; set; }
        [DataMember(Name = "venue_address")]
        public String venue_address { get; set; }
        [DataMember(Name = "country_name")]
        public String country_name { get; set; }
        [DataMember(Name = "image")]
        public ImageAttributes imageAttributes { get; set; }

    }
}
