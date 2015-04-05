using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    /*
     * This class represents the tests that are needed to test the venue details.
     */
    [TestFixture]
  public class testVenuesGet
    {
        /*
         * Generating the url and parameters,you can add any number of parameters of your choice in properties file and 
         * includde them
        */
        private static string venue_url = Properties.Settings.Default.venue_url;
        private static string urlParameters = "?app_key=" + Properties.Settings.Default.key + "&id="
            + Properties.Settings.Default.id + "&mature=" + Properties.Settings.Default.mature;
        private static venueGetResponse response;
        /*
         * This test is used as a setup for the getting the venue details where it constructs the object for the response.
         * if the url is wrong,then the whole set of tests are ignored.
         */
        [TestFixtureSetUp]
        public void testSetUp()
         {
             try
             {                 
                 string locationsRequest = UtilityFunction.CreateRequestURL(venue_url,urlParameters);
                 UtilityFunction.createWebRequest(locationsRequest);
                 UtilityFunction.createWebResponse();
                 response = UtilityFunction.objectBinding<venueGetResponse>();
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
         * This test first check user given paremeter,if wrong ignore the test and if correct then 
         * it check whether venue id generated  is equal to venue id given in the parameter and generate result.
        */
        [Test]
        public void checkVenueID()
        {
            UtilityFunction.ErrorDisplay();
            Assert.That(response.id,Is.EqualTo(Properties.Settings.Default.id));
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
         * it check whether venue address generated  null or not  and generate result.
        */
        [Test]
        public void checkVenueAddress()
        {
            UtilityFunction.ErrorDisplay(); 
            Assert.That(response.address, Is.Not.Null);
        }
        /*
         * This test first check user given paremeter,if wrong ignore the test and if correct then 
         * it check whether venue property id null or not and generate result.
        */
        [Test]
        public void checkVenueProperty()
        {
            UtilityFunction.ErrorDisplay();
            Assert.That(response.venueProperties.venueProperty.id, Is.Not.Null);
        }
    }
}
