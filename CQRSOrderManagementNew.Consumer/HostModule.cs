using System;
using Autofac;
using Microsoft.Extensions.Hosting;
namespace CQRSOrderManagementNew.Consumer
{
    public class HostModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var connectionString = builder.Properties["ConnectionString"];

            int storeId = 1;
            if (builder.Properties["StoreId"] != null)
            {
                int.TryParse(builder.Properties["StoreId"].ToString(), out storeId);
            }

            string application = null;
            if (builder.Properties["Application"] != null)
            {
                application = builder.Properties["Application"].ToString();
            }



            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();




            builder.RegisterType<BusService>().As<IHostedService>().SingleInstance();
        }
    }
}