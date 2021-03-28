using Autofac;
using Autofac.Extensions.DependencyInjection;
using CQRSOrderManagementNew.Core;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSOrderManagementNewWeb
{
    public static class AutofacContainerBuilderExtensions
    {
        public static IServiceProvider AutofacContainerBuilder(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var builder = new ContainerBuilder();

            builder.Properties.Add("ConnectionString", configuration.GetConnectionString("DefaultConnection"));
            builder.Properties.Add("StoreId", configuration.GetSection("AppConfig:StoreId").Value);
            builder.Properties.Add("Application", configuration.GetSection("AppConfig:ApplicationName").Value);

            builder.Register(c =>
            {
          
                return Bus.Factory.CreateUsingRabbitMq(cfg =>
                {
                    cfg.Host(new Uri(MqConstants.RabbitMQUri), hostConfigurator =>
                    {
                        hostConfigurator.Username(MqConstants.RabbitMQUserName);
                        hostConfigurator.Password(MqConstants.RabbitMQUserName);
                    });
                });
            }).As<IBusControl>().SingleInstance();

            builder.Register(c =>
            {
                var busControl = c.Resolve<IBusControl>();
                return busControl.GetSendEndpoint(new Uri($"{MqConstants.RabbitMQUri}")).Result;
            }).As<ISendEndpoint>().SingleInstance();

            builder.Populate(services);

            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
