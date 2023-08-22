using System;
using System.IO;
using System.Windows.Forms;

namespace Startwindow
{
    public partial class frm_Startwindow : Form
    {
        public frm_Startwindow(Startwindow model)
        {
            InitializeComponent();
            _self = model;
        }

        Startwindow _self;

        public void LoadHistory(Base.History target)
        {
            lb_History.Items.Clear();

            foreach (var item in target._historie)
                lb_History.Items.Add(item);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            _self.History.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_self.History._historie.Count <= 0)
            {
                MessageBox.Show("History hat keine Einträge");
                return;
            }

            var path = GetPath();
            if (!path.succed)
            {
                return;
            }

            byte[] content = _self.History.ToAES();
            using (FileStream reader = File.Create(path.result))
            {
                reader.Write(content, 0, content.Length);
            }
        }

        private (bool succed, string result) GetPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return (true, openFileDialog.FileName);
                }
            }

            return (false, "");
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            var path = GetPath();
            if (!path.succed)
            {
                return;
            }

            byte[] content = File.ReadAllBytes(path.result);
            _self.History = Base.History.FromAes(content);
            LoadHistory(_self.History);
        }

        private void lb_History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
