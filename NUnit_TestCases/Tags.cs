using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Tags object of the response.
     * 
     */
    [DataContract]
   public class Tags
    {
        [DataMember(Name = "tag")]
        public List<TagAttributes> tagattributes { get; set; }
    }
}
