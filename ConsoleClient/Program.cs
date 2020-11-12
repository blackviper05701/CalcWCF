using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcWCF;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri tcpBaseAddress = new Uri("net.tcp://localhost:4430/");
            Uri httpBaseAddress = new Uri("http://localhost:4431/");

            ServiceHost host = new ServiceHost(typeof(CalculatorService), new Uri[] { tcpBaseAddress, httpBaseAddress });

            ServiceEndpoint tcpEndpoint = host.AddServiceEndpoint(typeof(ICalcutorService), new NetTcpBinding(), tcpBaseAddress);
            ServiceEndpoint httpEndpoint = host.AddServiceEndpoint(typeof(ICalcutorService), new WSHttpBinding(), httpBaseAddress);
           
            ServiceMetadataBehavior metadata = new ServiceMetadataBehavior();
            metadata.HttpGetEnabled = false;
            host.Description.Behaviors.Add(metadata);

            ServiceEndpoint httpEpMex = host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), httpBaseAddress + "mex");
            ServiceEndpoint tcpEpMex = host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), tcpBaseAddress + "mex");


            host.Open();
            Console.WriteLine("Open....");
            foreach(var item in host.Description.Endpoints)
            {
                Console.WriteLine(item.Address.ToString());
                Console.WriteLine(item.Binding.Name);
                Console.WriteLine(item.Contract.Name);
            }
            Console.ReadLine();
            host.Close();
        }
    }
}

