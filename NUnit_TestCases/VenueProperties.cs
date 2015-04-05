using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Properties object of the response.
     */
    [DataContract]
   public  class VenueProperties
    {
        [DataMember(Name = "property")]
        public VenueProperty venueProperty { get; set; }
    }
}
