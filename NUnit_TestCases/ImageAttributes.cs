using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Image object of the response.
     */
    [DataContract]
   public class ImageAttributes
    {
        [DataMember(Name = "id")]
        public String id { get; set; }
        [DataMember(Name = "url")]
        public String url { get; set; }
    }
}
