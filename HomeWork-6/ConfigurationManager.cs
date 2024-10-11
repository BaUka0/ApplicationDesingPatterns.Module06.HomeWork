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
        public static ConfigurationManager GetInstance()
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
        public void LoadConfiguration(string path)
        {
            if (File.Exists(path))
            {
                foreach (var line in File.ReadAllLines(path))
                {
                    var parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        _configuration[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Конфигурационный файл не найден.", path);
            }
        }
        public void SaveSettings(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var kvp in _configuration)
                {
                    writer.WriteLine($"{kvp.Key}={kvp.Value}");
                }
            }
        }
        public string GetSetting(string key)
        {
            if (_configuration.ContainsKey(key))
            {
                return _configuration[key];
            }
            else
            {
                throw new KeyNotFoundException($"Настройка '{key}' не найдена.");
            }
        }
        public void UpdateSetting(string key, string value)
        {
            _configuration[key] = value;
        }

    }

}
