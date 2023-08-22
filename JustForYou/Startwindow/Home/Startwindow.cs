using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startwindow
{
    public class Startwindow : Base.Modul
    {
        public Startwindow(Settings settings, History history) : base(settings, history)
        {
            history.Changed += History_Changed;
        }

        public override string Name => "Home";

        public override bool Enabled 
        {
            get => _enabled;
            set => _enabled = value;
        }
        private bool _enabled;

        public override Form View => _view ?? (_view = new frm_Startwindow(this));
        private frm_Startwindow _view;
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void OnSettingsChanged(object sender, Settings new_settings)
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        private void History_Added(object sender, EventArgs e)
        {
            ((frm_Startwindow)View).LoadHistory(History);
            View.Refresh();
        }

        private void History_Changed(object sender, EventArgs e)
        {
            ((frm_Startwindow)View).LoadHistory(History);
        }


    }
}
