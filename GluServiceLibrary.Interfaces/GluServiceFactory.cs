using GluServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace GluWebsite
{
    public class GluServiceFactory
    {
        public static IGluService GetGluService()
        {
            string gluServiceUrl = ConfigurationManager.AppSettings["GluServiceUrl"];
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.MaxReceivedMessageSize = 1000000;
            binding.ReaderQuotas.MaxDepth = 200;
            ChannelFactory<IGluService> channelFactory = new ChannelFactory<IGluService>(binding, new EndpointAddress(new Uri(gluServiceUrl)));
            IGluService gluSrvc = channelFactory.CreateChannel();
            // TODO webhttpbinding po stronie WCF
            return gluSrvc;
        }
    }
}