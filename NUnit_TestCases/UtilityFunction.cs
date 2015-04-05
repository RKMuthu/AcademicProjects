using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;
using NUnit.Framework;
namespace Tests
{
    /*
     * This class contains a set of static functions thar are usedd by both of the services.
     * 
     */
    public class UtilityFunction
    {
        public static bool checkError;
        public static HttpWebRequest request;
        public static HttpWebResponse response;
        /*
         * This function dispaly the error message when the parameters are worng.
         */
        public static void ErrorDisplay()
        {
            if (checkError)
                Assert.Ignore("Please give a proper Parameters to retreive values");
        }
        /*
         * Thsi function responsible for creating the URL.
         */
        public static string CreateRequestURL(string url,string queryString)
        {
            string UrlRequest = url+ queryString;
            return (UrlRequest);
        }
        /*
         * This function is responsible for creating the web request.
         */
        public static void  createWebRequest(string requestUrl)
        {
                request = WebRequest.Create(requestUrl) as HttpWebRequest;
        }
        /*
         * This function is responsible for getting the response based on request.
         */
        public static void createWebResponse()
        {
            using (response)
            { response = request.GetResponse() as HttpWebResponse; }
        }
        /*
         * This generic function binds the response to the corresponding object based on the 
         * class given as generic parameter.
         */
        public static T objectBinding<T>()
        {
            using (response)
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                return (T)Convert.ChangeType(objResponse, typeof(T));
            }
            
        }
        /*
         * This function checks the response contains the error or not.
         */
        public static bool checkErrorResponse(commonResponse response)
        {
            if (response.errorID != null)
            {
                return true;
            }
            return false;
        }
        /*
         * This function reports the parameter errors.
         */
        public static void reportParameterError(commonResponse response)
        {
            if (checkError)
            {
                Assert.Fail("Please check the URL parameter \n Error code=" + response.errorID + "\n Error Status="
                    + response.errorStatus + "\n Error Description=" + response.errorDescription);
            }

        }
    }
}
