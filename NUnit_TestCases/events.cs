using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Tests
{
    /*
     * This Class represents modelling the events object of the response.
     */
    [DataContract]
   public class events
    {
        [DataMember(Name = "event")]
        public List<eventAttributes> eventattributes { get; set; }
    }
}
