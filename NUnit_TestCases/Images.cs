using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Tests
{
    /*
     * This Class represents modelling the Images object of the response.
     */
    [DataContract]
   public class Images
    {
        [DataMember(Name = "image")]
        public List<ImageAttributes> imageattributes { get; set; }
    }
}
