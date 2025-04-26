using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTutorial.ConfigurationManager
{
    class ConfigurationManager<T>
    {
        public T LoadedConfiguration { get; private set; }

        public ConfigurationManager(T config)
        {
            
        }

        public static void SaveConfig(T configToSave)
        {

        }
    }
}
