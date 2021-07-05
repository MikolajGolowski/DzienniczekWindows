using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzienniczekLibrary
{
    public static class GlobalConnector
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static string ConnectionDetails(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void Initialize(bool ifSQL, bool ifCSV)
        {

            if (ifSQL)
            {
                SQLConnector SQL = new SQLConnector();
                Connections.Add(SQL);
            }
            if (ifCSV)
            {
                CSVConnector CSV = new CSVConnector();
                Connections.Add(CSV);
            }

        } 

    }
}
