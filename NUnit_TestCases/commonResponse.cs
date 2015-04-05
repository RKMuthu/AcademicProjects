using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Tests
{
    /*
     *This Class represents modelling the response data that 
     * are common for both of the services.
     *
     */
    [DataContract]
    public class commonResponse
    {
        [DataMember(Name = "error")]
        public int? errorID { get; set; }
        [DataMember(Name = "status")]
        public String errorStatus { get; set; }
        [DataMember(Name = "description")]
        public String errorDescription { get; set; }
        [DataMember(Name = "events")]
        public events eventClass { get; set; }
    }
}
