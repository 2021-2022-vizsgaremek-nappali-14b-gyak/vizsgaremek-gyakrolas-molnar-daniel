using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;

namespace Vizsgaremek.ViewModels
{
    class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabaseSources;
        private string selectedDatabaseSource;
        DatabaseSources repoDatabaseSources;

        public ObservableCollection<string> DisplayedDatabaseSources
        {
            get => displayedDatabaseSources;
        }
        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set => selectedDatabaseSource = value;
        }

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
        }
    }
}
