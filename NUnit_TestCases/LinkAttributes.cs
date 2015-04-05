using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Link object of the response.
     */
    [DataContract]
   public class LinkAttributes
    {
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "description")]
        public String description { get; set; }
    }
}
