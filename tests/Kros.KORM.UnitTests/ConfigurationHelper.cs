﻿using Microsoft.Extensions.Configuration;

namespace Kros.KORM.UnitTests
{
    internal class ConfigurationHelper
    {
        private static IConfigurationRoot _config;

        public static IConfigurationRoot GetConfiguration()
        {
            if (_config == null)
            {
                _config = new ConfigurationBuilder()
                    .AddJsonFile($"appsettings.json")
                    .AddJsonFile($"appsettings.local.json", true)
                    .Build();
            }

            return _config;
        }
    }
}
