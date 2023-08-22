using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public abstract class Modul
    {
        public Modul(Settings settings, History history)
        {
            Settings = settings;
            History = history;
            settings.Changed += OnSettingsChanged;
        }

        abstract public string Name { get; }
        abstract public bool Enabled { get; set; }
        abstract public Form View { get; }

        public History History;
        protected Settings Settings;

        abstract public void Close();
        abstract public void Open();
        abstract public void OnSettingsChanged(object sender, Settings new_settings);
    }
}
