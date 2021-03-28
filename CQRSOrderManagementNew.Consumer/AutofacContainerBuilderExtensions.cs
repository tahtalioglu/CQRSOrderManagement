using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
 
using GreenPipes;
using MassTransit;
using MassTransit.AutofacIntegration;
using MassTransit.RabbitMqTransport;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace CQRSOrderManagementNew.Consumer
{
    public static class AutofacContainerBuilderExtensions
    {
        public static IServiceProvider AutofacContainerBuilder(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var builder = new ContainerBuilder();

            builder.Properties.Add("ConnectionString", configuration.GetConnectionString("DefaultConnection"));
            builder.Properties.Add("StoreId", configuration.GetSection("AppConfig:StoreId").Value);
            builder.Properties.Add("Application", configuration.GetSection("AppConfig:ApplicationName").Value);

            builder.RegisterGeneric(typeof(AutofacConsumerFactory<>))
                .WithParameter(new NamedParameter("name", "message"))
                .As(typeof(IConsumerFactory<>));

            builder.AddMassTransit(x =>
            {
                x.AddConsumer<UpdateOrderConsumer>();

                x.AddBus(context => Bus.Factory.CreateUsingRabbitMq(cfg =>
                {


                    var host = cfg.Host(new Uri(""), hostConfigurator =>
                    {
                        hostConfigurator.Username("admin");
                        hostConfigurator.Password("1234");
                    });

                    cfg.ReceiveEndpoint(host, "aymarka.marketplace.create.order", re =>
                    {
                        re.PrefetchCount = 1;

                        re.UseMessageRetry(r => r.Interval(5, 100));

                        re.ConfigureConsumer<UpdateOrderConsumer>(context);
                    });

                    cfg.ConfigureEndpoints(context);
                }));
            });

            builder.RegisterModule<HostModule>();

            builder.Populate(services);

            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
