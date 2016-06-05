using ProjekatIST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace BioskopHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Bioskop)))
            {
                string serviceAddress = "net.tcp://127.0.0.1:5678/ProjekatIST/Bioskop/Nesto/";
                string httpAdress = "http://127.0.0.1:8080/ProjekatIST/Bioskop/BasicHttp/";
                string webhttp = "http://127.0.0.1:5666/ProjekatIST/Bioskop/";
                ServiceHost selfServiceHost = new ServiceHost(typeof(Bioskop));

              
                var bindingNetTcp = new NetTcpBinding();
                var webHttpBinding = new WebHttpBinding();
                var basichttp = new BasicHttpBinding();

                selfServiceHost.AddServiceEndpoint(typeof(IAdminBioskop), bindingNetTcp, serviceAddress);
                selfServiceHost.AddServiceEndpoint(typeof(IBioskop), basichttp, httpAdress);
                selfServiceHost.AddServiceEndpoint(typeof(IWebBioskop), webHttpBinding, webhttp);

                selfServiceHost.Open();            
                Console.WriteLine("Server je pokrenut!");
                Console.WriteLine("Unesite y za gasenje");
                Console.WriteLine();
                var s = Console.Read();
                if (s.ToString().ToLower() == "y")
                {
                    host.Close();
                }
            }
        }
    }
}
