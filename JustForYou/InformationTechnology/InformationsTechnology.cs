using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationTechnology
{
    public class InformationsTechnology : Base.Modul
    {
        public InformationsTechnology(Settings settings, History history) : base(settings, history)
        {

        }

        public override string Name => "Informationstechnology";
        public override bool Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }
        private bool _enabled;

        public override Form View => _view ?? (_view = new frm_InformationsTechnology());
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
