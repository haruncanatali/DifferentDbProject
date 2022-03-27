using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDbProject
{
    public class ConnnectionStringReader
    {
        public static string GetConnectionString(string cName)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[cName].ConnectionString;
        }
    }
}
