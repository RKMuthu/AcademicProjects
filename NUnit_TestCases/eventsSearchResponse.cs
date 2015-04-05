using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the response data that 
     * are generated during the event serach service.
     * 
     */
    [DataContract]
    public class eventsSearchResponse :commonResponse
    {
        [DataMember(Name = "total_items")]
        public String total_items { get; set; }
        [DataMember(Name = "page_size")]
        public String page_size { get; set; }
        [DataMember(Name = "page_number")]
        public String page_number { get; set; }
    }
}
