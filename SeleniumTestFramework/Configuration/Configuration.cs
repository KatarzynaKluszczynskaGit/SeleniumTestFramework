using Microsoft.Extensions.Configuration;
using SeleniumTestFramework.Models;

namespace SeleniumTestFramework.Utils
{
    public class Configuration
    {
        public static WebDriverConfiguration Driver => GetConfiguration()
            .GetSection("WebDriverSection").Get<WebDriverConfiguration>();

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            return builder.Build();
        }
    }
}
