using System;
using Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percent
{
    public class Percent : Base.Modul
    {
        public Percent(Settings settings, History history) : base(settings, history)
        {

        }

        public override string Name => "Prozentrechnung";
        public override bool Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }
        private bool _enabled;

        public override Form View => _view ?? (_view = new frm_Percent(this));
        private Form _view;

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        public override void OnSettingsChanged(object sender, Settings new_settings)
        {
            throw new NotImplementedException();
        }
    }
}
