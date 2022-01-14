using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    public class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabaseSources;
        private string selectedDatabaseSource;
        private string displayedDatabaseSource;
        private DbSource dbSource;
        DatabaseSources repoDatabaseSources;

        public ObservableCollection<string> DisplayedDatabaseSources
        {
            get => displayedDatabaseSources;
        }
        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set
            {
                selectedDatabaseSource = value;
                displayedDatabaseSource = DisplayedDatabaseSource;
                dbSource = DbSource;
                OnDatabaseSourceChange();
            }
        }

        public DbSource DbSource
        {
            get
            {
                // TDD fejlesztés
                // return DbSource.NONE;
                if (selectedDatabaseSource == "localhost")
                {
                    return DbSource.LOCALHOST;
                }
                else if (selectedDatabaseSource == "devops")
                {
                    return DbSource.DEVOPS;
                }
                return DbSource.NONE;
            }
        }

        public string DisplayedDatabaseSource 
        {
            get
            {
                switch(dbSource)
                {
                    case DbSource.DEVOPS:
                        return "devops adatforrás.";
                    case DbSource.LOCALHOST:
                        return "localhost adatforrás.";
                    case DbSource.NONE:
                        return "beépített teszt adatok.";
                    default:
                        return "";
                }
            }  
        }

        public event EventHandler ChangeDatabaseSource;

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
            SelectedDatabaseSource = "localhost";
        }

        protected void OnDatabaseSourceChange()
        {
            // Argumentumba belepakoljuk az üzenetet
            DatabaseSourceEventArg dsea = new DatabaseSourceEventArg(DisplayedDatabaseSource);
            // Ha van esemény akkor meghívjük a feliratkozott osztályokat;
            if (ChangeDatabaseSource != null)
                ChangeDatabaseSource.Invoke(this, dsea);
        }
    }
}
