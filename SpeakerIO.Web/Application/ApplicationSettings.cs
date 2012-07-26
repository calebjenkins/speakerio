using System.Configuration;

namespace SpeakerIO.Web.Application
{
    public class ApplicationSettings : IApplicationSettings
    {
        public string JanrainApiKey()
        {
            return ConfigurationManager.AppSettings["janrainApiKey"];
        }

        public string JanrainAppName()
        {
            return ConfigurationManager.AppSettings["janrainName"];
        }

        public bool ShouldProxyOutboundHttpRequests()
        {
            string outboundHttpProxy = OutboundHttpProxy();
            return !string.IsNullOrWhiteSpace(outboundHttpProxy);
        }

        public string OutboundHttpProxy()
        {
            return ConfigurationManager.AppSettings["outboundHttpProxy"];
        }
    }
}