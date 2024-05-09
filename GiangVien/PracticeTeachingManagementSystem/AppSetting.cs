using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PracticeTeachingManagementSystem
{
    class AppSetting
    {
        Configuration config;

        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string GetConnectionString(string name)
        {
            return config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }

        public void SaveConnectionString(string name, string value)
        {
            config.ConnectionStrings.ConnectionStrings[name].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[name].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
