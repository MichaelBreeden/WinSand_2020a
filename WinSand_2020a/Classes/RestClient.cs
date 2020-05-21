using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WinSand_2020a.Classes
{
    public enum httpVerb
    {
        GET,
        PUT,
        POST,
        DELETE
    }

    public class RestClient
    {
        //public RestClient() { }

        public string endPoint { set; get; }
        public httpVerb httpMethod { set; get; }
        public RestClient()
        {
            endPoint = String.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = String.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString(); 

            // Get the response back
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }
                // Ppocess the response stream... could be JSON, XML, HTML, etc
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        } // End of StreamReader
                    }
                }

            } // End of using ResponseStream

            return strResponseValue;
        }

        //{ set; get; }
    }
}
