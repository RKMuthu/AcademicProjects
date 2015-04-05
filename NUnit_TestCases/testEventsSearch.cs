using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Tests
{
    /*
     * This class represents the tests that are needed to test  the serach event.
     */
    [TestFixture]
  public  class testEventsSearch
    {
        /*
         * Generating the url and parameters,you can add any number of parameters of your choice in properties file and 
         * includde them
        */
        private static string eventSearch_url = Properties.Settings.Default.eventSearch_url;
        private static string urlParameters = "?app_key=" + Properties.Settings.Default.key + "&keywords="
            + Properties.Settings.Default.keywords + "&location=" + Properties.Settings.Default.location;
        private static eventsSearchResponse response;
        /*
         * This test is used as a setup for getting the  event serach details where it constructs the object for the response.
         * if the url is wrong,then the whole set of tests are ignored.
         */
        [TestFixtureSetUp]
        public void testSetUp()
        {
            try
            {               
                string locationsRequest = UtilityFunction.CreateRequestURL(eventSearch_url, urlParameters);
                 UtilityFunction.createWebRequest(locationsRequest);
                 UtilityFunction.createWebResponse();
                 response = UtilityFunction.objectBinding<eventsSearchResponse>();
                UtilityFunction.checkError = UtilityFunction.checkErrorResponse(response);
            }
            catch (Exception e)
            {
                Assert.Ignore("Please give a proper API url to retrieve values");
            }
        }
        /*
         * This test is responsible for deleting the object after all the tests.
         */
        [TestFixtureTearDown]
        public void testTearDown()
        {
            response = null;
        }
        /*
         * This test is used to check the user given parameter url.
         */
        [Test]
        public void checkParameterURL()
        {
            UtilityFunction.reportParameterError(response);
        }        
        /*
         * This test first check user given paremeter,if wrong ignore the test and if correct then 
         * it check whether total_items is null or not and generste the result.
        */
        [Test]
        public void checkTotalItems()
        {
            UtilityFunction.ErrorDisplay();
            Assert.That(response.total_items, Is.Not.Null);
        }
    }
}