using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Tests
{
    /*
     * This Class represents modelling the Links object of the response.
     */
    [DataContract]
   public class Links
    {
        [DataMember(Name = "link")]
        public List<LinkAttributes> linkattributes { get; set; }
    }
}
