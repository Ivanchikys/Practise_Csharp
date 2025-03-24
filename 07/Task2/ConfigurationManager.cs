using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ConfigurationManager
    {
        public void SetConfiguration(string configValue, ConfigSetter setter)
        {
            setter(configValue);
        }
    }
}
