using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Libraries
{
    public class Common
    {
        public static string GetConfigurationAsJson(Configurations config)
        {
            return JsonConvert.SerializeObject(config, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }
    }
}
