using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSOrderManagementNew.Core
{
    public class MqConstants
    {
        private readonly IConfiguration _config;

        public MqConstants(IConfiguration config)
        {
            _config = config;
            RabbitMQUri = _config["RabbitMQUri"];
            RabbitMQUserName = _config["RabbitMQUserName"];
            RabbitMQPassword = _config["RabbitMQPassword"];
        }
        public static string RabbitMQUri { get; set; }
        public static string RabbitMQUserName { get; set; }
        public static string RabbitMQPassword { get; set; }
    }
}
