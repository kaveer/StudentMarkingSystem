using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StudentMarkingSystem.Repository
{
    class DbConfiguration
    {
        private string connectionString;

        public DbConfiguration()
        {
            ReadConfiguration();
        }

        public void ReadConfiguration()
        {
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["DB"]))
                connectionString = ConfigurationManager.AppSettings["DB"];
        }

        public string GetConnectionString()
        {
            return this.connectionString;
        }
    }
}
