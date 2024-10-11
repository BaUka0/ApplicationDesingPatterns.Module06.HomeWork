using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static object _instanceLock = new object(); 
        private Dictionary<string, string> _configuration = new Dictionary<string, string> ();
        private ConfigurationManager() { }
        public ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new ConfigurationManager();
                }
            }
            return _instance;
        }

    }

}
