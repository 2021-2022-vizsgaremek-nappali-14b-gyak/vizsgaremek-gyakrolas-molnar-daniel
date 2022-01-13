using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.Repositories
{
    class DatabaseSources
    {
        private List<string> databaseSourcesItems;

        public DatabaseSources()
        {
            databaseSourcesItems = new List<string>();
            databaseSourcesItems.Add("localhost");
            databaseSourcesItems.Add("devops");
        }

        public List<string> GetAllDatabaseSources()
        {
            return databaseSourcesItems;
        }

    }
}
