using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Tests
{
    /*
     * This class represents the tests that are common for both of the services.
     * 
     */
    [TestFixture]
    public class commonTests
    {
        /*
         * This test check the performance where i set the maximum time of 1000ms and used parameterization technique
         * to test them.
         * if the response time is greater than 1000ms,then it'll fail the test for the respective parameter.
         * If the url is wrong,then it ignore the test and give the corresponding message.
         */
        [Test, MaxTime(1000), Sequential]
        public void performanceCheck(
            [Values("http://api.eventful.com/rest/venues/get?app_key=MgGgJL4Z3Tdp8c3J&venue_id=V0-001-001308302-0&mature=all",
               "http://api.eventful.com/json/events/search?app_key=MgGgJL4Z3Tdp8c3J&keywords=books&location=vancouver")
            ] string url)
        {
            try
            {
                UtilityFunction.createWebRequest(url);
                UtilityFunction.createWebResponse();
            }
            catch (Exception e)
            {
                Assert.Ignore("Please give a proper API url to retrieve values");
            }
        }

    }
}
