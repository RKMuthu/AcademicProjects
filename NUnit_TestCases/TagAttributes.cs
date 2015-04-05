using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Tag object of the response.
     */
    [DataContract]
   public class TagAttributes
    {
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "title")]
        public String title { get; set; }
        [DataMember(Name = "owner")]
        public String owner { get; set; }
    }
}
