using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public enum EventStatus
    {
        completed,
        postponed,
        suspended,
        cancelled
    }

    public class Constants
    {


        public const string userAgentLabel = "User-agent";
        public const string authroizationLabel = "Authorization";
        public const string acceptEncodingLabel = "Accept-encoding";
        public const string gzipCompression = "gzip";

    }
}
