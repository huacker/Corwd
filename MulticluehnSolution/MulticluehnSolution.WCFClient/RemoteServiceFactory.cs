using System.ServiceModel.Description;
using System.ServiceModel;
using MulticluehnSolution.Contract;
using MulticluehnSolution.Common;
using System.Xml;

namespace MulticluehnSolution.WCFClient
{
    public class RemoteServiceFactory: IServiceFactory
    {
        private const int maxReceivedMessageSize = 2147483647;
        private readonly string serviceUri = "http://192.168.1.139:52007/Service.svc";
        public IService CreateService()
        {
            return this.CreateService<IService>(serviceUri);
        }

        private T CreateService<T>(string uri)
        {
            var key = string.Format("{0} - {1}", typeof(T), uri);

            if (Caching.Get(key) == null)
            {
                var binding = new BasicHttpBinding();
                binding.MaxReceivedMessageSize = maxReceivedMessageSize;
                binding.ReaderQuotas = new XmlDictionaryReaderQuotas();
                binding.ReaderQuotas.MaxStringContentLength = maxReceivedMessageSize;
                binding.ReaderQuotas.MaxArrayLength = maxReceivedMessageSize;
                binding.ReaderQuotas.MaxBytesPerRead = maxReceivedMessageSize;

                ChannelFactory<T> chan = new ChannelFactory<T>(binding, new EndpointAddress(uri));
                chan.Endpoint.Behaviors.Add(new MulticluehnSolution.Common.WCFExtension.InspectorBehavior());
                foreach (var op in chan.Endpoint.Contract.Operations)
                {
                    var dataContractBehavior = op.Behaviors.Find<DataContractSerializerOperationBehavior>() as DataContractSerializerOperationBehavior;
                    if (dataContractBehavior != null)
                        dataContractBehavior.MaxItemsInObjectGraph = int.MaxValue;
                }

                chan.Open();

                var service = chan.CreateChannel();
                Caching.Set(key, service);

                return service;
            }
            else
            {
                return (T)Caching.Get(key);
            }
        }
    }
}
