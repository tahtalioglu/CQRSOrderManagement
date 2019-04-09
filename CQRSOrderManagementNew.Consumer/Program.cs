
using CQRSOrderManagementNew.Business;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.FileExtensions;
using System;
using System.IO;
using CQRSOrderManagementNew.Core;

namespace CQRSOrderManagementNew.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IConnection,DapperConnection>(sericeprovider=> new DapperConnection(configuration));

            var provider = serviceCollection.BuildServiceProvider();


            Console.Title = "OrderService";


            //services.AddScoped<IConnection, DapperConnection>();
            var conn = provider.GetService<IConnection>();
            var bus = new BusConfigurator(configuration)
                .ConfigureBus((cfg, host) =>
                {
                    cfg.ReceiveEndpoint(host, configuration["OrderQueueName"], e =>
                    {
                        e.Consumer(() => new OrderConsumer(conn, configuration));
                    });
                });

            bus.Start();

            Console.WriteLine("Listening order command..");
            Console.ReadLine();
        }
        

    }
}
