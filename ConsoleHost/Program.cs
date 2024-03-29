﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using EmailService;

namespace ConsoleHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Type serviceType = typeof (EmailValidator);
            Uri serviceUri = new Uri("http://localhost:10000/");

            ServiceHost host = new ServiceHost(serviceType, serviceUri);
            host.Open();


            #region Output dispatchers listening

            foreach (Uri uri in host.BaseAddresses)
            {
                Console.WriteLine("\t{0}", uri.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Number of dispatchers listening : {0}", host.ChannelDispatchers.Count);
            foreach (System.ServiceModel.Dispatcher.ChannelDispatcher dispatcher in host.ChannelDispatchers)
            {
                Console.WriteLine("\t{0}, {1}", dispatcher.Listener.Uri.ToString(), dispatcher.BindingName);
            }

            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate Host");
            Console.ReadLine();

            #endregion
        }
    }
}
