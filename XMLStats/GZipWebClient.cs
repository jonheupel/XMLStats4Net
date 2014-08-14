using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    class GZipWebClient : WebClient
    {
            protected override WebRequest GetWebRequest(Uri address)
            {
                HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
                if (request == null) return null;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                return request;
            }

            public GZipWebClient(string apiKey, string userAgentName, bool useGZipCompression) : base()
            {
                string bearer = "Bearer " + apiKey;

                this.Headers.Add(Constants.authroizationLabel, bearer);
                this.Headers.Add(Constants.userAgentLabel, userAgentName);
                
                if(useGZipCompression)
                    this.Headers.Add(Constants.acceptEncodingLabel, Constants.gzipCompression);
                
                this.Encoding = Encoding.UTF8;
            }
    }
}
