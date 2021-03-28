using MassTransit;
using MassTransit.RabbitMqTransport;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public class BusConfigurator
    {
        private readonly MqConstants mqConstants;

        public BusConfigurator(IConfiguration _configuration)
        {
            mqConstants = new MqConstants(_configuration);
        }

        public IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> registrationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {

                var host = cfg.Host(new Uri(MqConstants.RabbitMQUri), hst =>
                {
                    hst.Username(MqConstants.RabbitMQUserName);
                    hst.Password(MqConstants.RabbitMQPassword);
                });
                registrationAction?.Invoke(cfg, host);
            });
        }
    }
}
