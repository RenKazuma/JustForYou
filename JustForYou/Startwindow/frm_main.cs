using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startwindow
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            LoadModuls();
            Open("Home");
        }

        Base.Modul CurrentModul;
        Base.Settings Settings = new Base.Settings();
        Base.History history = new Base.History();
        List<Base.Modul> Moduls = new List<Base.Modul>();

        private void LoadModuls()
        {
            //TODO: check if modul is enabled
            Moduls.Add(new Geometry.Geometry(Settings, history));
            Moduls.Add(new Basic_Calculator.Basic_Calculator(Settings, history));
            Moduls.Add(new InformationTechnology.InformationsTechnology(Settings, history));
            Moduls.Add(new Mathematics_Functions.Mathematics_Functions(Settings, history));
            Moduls.Add(new Percent.Percent(Settings, history));
            Moduls.Add(new School.School_Program(Settings, history));
            Moduls.Add(new Startwindow(Settings, history));
            Moduls.Add(new CreditCalculation.CreditCalculation(Settings, history));
        }

        private void btn_school_main_Click(object sender, EventArgs e)
        {
            //var SchoolForm = new School_Program(Settings, history);
            //Open(SchoolForm);
        }

        private void Open(Base.Modul target)
        {
            pnl_Content.Controls.Clear();
            CurrentModul = target;

            target.View.TopLevel = false;
            pnl_Content.Controls.Add(target.View);
            target.View.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            target.View.Dock = DockStyle.Fill;

            label1.Text = CurrentModul.Name;

            target.View.Show();
        }

        private bool Open(string modulname)
        {
            var modul = GetModul(modulname);
            if (modul.succed)
            {
                Open(modul.result);
                return true;
            }


            MessageBox.Show($"Modul {modulname} konnte nicht geöffnet werden");
            return false;
        }

        private (bool succed, Base.Modul result) GetModul(string name)
        {
            foreach(var modul in Moduls)
            {
                if (modul.Name == name)
                    return (true, modul);
            }

            return (false, null);
        }

        private void btn_geometry_Click(object sender, EventArgs e)
        {
            Open("Geometry");
        }

        private void btn_BasicCalculator_Click(object sender, EventArgs e)
        {

            Open("Grundrechner");
        }

        private void btn_InformationTechnology_Click(object sender, EventArgs e)
        {
            Open("Informationstechnology");
        }

        private void btn_Mathematics_Click(object sender, EventArgs e)
        {
            Open("Matherechnung");
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            Open("Prozentrechnung");
        }

        private void btn_School_Click(object sender, EventArgs e)
        {
            Open("School");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Open("Home");
        }

        private void btn_Credit_Click(object sender, EventArgs e)
        {
            Open("Kredit");
        }
    }
}