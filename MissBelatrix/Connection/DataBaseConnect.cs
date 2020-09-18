using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MissBelatrix.Connection
{
    public class DataBaseConnect
    {
        public string DataBaseConnection()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings["DataBaseName"].Value;
        }
    }
}
