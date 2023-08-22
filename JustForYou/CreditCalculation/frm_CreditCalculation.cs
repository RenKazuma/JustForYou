using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalculation
{
    public partial class frm_CreditCalculation : Form
    {
        CreditCalculation creditCalculation;
        public frm_CreditCalculation(CreditCalculation credit)
        {
            InitializeComponent();
            creditCalculation = credit;
        }

        private void Btn_CreditOnePayment_Click(object sender, EventArgs e)
        {
            List<InputWindow.InputWindow.ListModel> listModels = new List<InputWindow.InputWindow.ListModel>();
            listModels.Add(new InputWindow.InputWindow.ListModel("Kreditsumme", 0));
            listModels.Add(new InputWindow.InputWindow.ListModel("Zinssatz", 0));

            InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(listModels, "");

            inputWindow.SetCredit(true);
            
            var dialog = inputWindow.ShowDialogwithReturn();
            string returnString;

            if (dialog.result == DialogResult.OK || dialog.result == DialogResult.Yes)
            {
                foreach (var item in dialog.param)
                {
                    var index = dialog.param.IndexOf(item);
                    listModels[index].Value = item.Value;

                }
            }

            var kreditsumme = listModels.Find(x => x.Name == "Kreditsumme").Value;
            var zinssatz = listModels.Find(x => x.Name == "Zinssatz").Value;

            var zuZahlen = ((zinssatz * kreditsumme) / 100) + kreditsumme;
            returnString = $"(( {zinssatz} * {kreditsumme}) / {100}) + {kreditsumme} = {zuZahlen}";
            MessageBox.Show(returnString);
            creditCalculation.History.Add("Einmaliger Rückzahlung", returnString);
        }

        private void Btn_CreditWithRunTime_Click(object sender, EventArgs e)
        {
            //Die Formel für die Berechnung der Monatsrate lautet: [Kreditsumme +(Kreditsumme x Zinssatz ÷ 100)] ÷ Laufzeit in Monaten
            List<InputWindow.InputWindow.ListModel> listModels = new List<InputWindow.InputWindow.ListModel>();
            listModels.Add(new InputWindow.InputWindow.ListModel("Kreditsumme", 0));
            listModels.Add(new InputWindow.InputWindow.ListModel("Zinssatz", 0));
            listModels.Add(new InputWindow.InputWindow.ListModel("Laufzeit in j", 0));

            InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(listModels, "");
            inputWindow.SetCredit(true);
            var dialog = inputWindow.ShowDialogwithReturn();
            string returnString;

            if (dialog.result == DialogResult.OK || dialog.result == DialogResult.Yes)
            {
                foreach (var item in dialog.param)
                {
                    var index = dialog.param.IndexOf(item);
                    listModels[index].Value = item.Value;

                }
            }

            var kreditsumme = listModels.Find(x => x.Name == "Kreditsumme").Value;
            var zinssatz = listModels.Find(x => x.Name == "Zinssatz").Value;
            var laufzeit = listModels.Find(x => x.Name == "Laufzeit in j").Value;


            for(int i = 1; i <= laufzeit; i++)
            {
                var tilgungsrate = kreditsumme / laufzeit;
                var restschuld = kreditsumme * (1 - (i - 1) / laufzeit);
                var zinsbetrag = kreditsumme * (1 - (i - 1) / laufzeit) * (zinssatz / 100);
                var annuität = tilgungsrate + zinsbetrag;

                var restSchuldEndeJahr = (float)Math.Round(restschuld + zinsbetrag - annuität, 2);


                if(restSchuldEndeJahr < 0)
                {
                    restSchuldEndeJahr = (float)Math.Round(restschuld - tilgungsrate, 2);
                }
                if(i == 1)
                { 
                    returnString = $"({kreditsumme} * (1 - {i} / {laufzeit})) + ({kreditsumme} * (1 - ({i} - 1) / {laufzeit}) * ({zinssatz} / 100)) - (({kreditsumme} / {laufzeit}) +  ((1 - ({i} - 1) / {laufzeit}) * ({zinssatz} / 100)) = {restSchuldEndeJahr}";
                    creditCalculation.History.Add("Legende", "restschuld | zinsbetrag | tilgungsrate  | annuität | restSchuldEndeJahr");
                    creditCalculation.History.Add("Formel Monatsrate Jahr 1", returnString);
                    MessageBox.Show("Jahr 1: " + returnString);
                }
                returnString = $"{Math.Round(restschuld, 2)} | {Math.Round(zinsbetrag, 2)} | {Math.Round(tilgungsrate, 2)}  | {Math.Round(annuität, 2)} | {restSchuldEndeJahr}";
                creditCalculation.History.Add($"Jahr {i}", returnString);
            }
           
        }

        private void Btn_CreditWithRateAmount_Click(object sender, EventArgs e)
        {
            //Die Formel für die Berechnung der Monatsrate lautet: [Kreditsumme +(Kreditsumme x Zinssatz ÷ 100)] ÷ Laufzeit in Monaten
            List<InputWindow.InputWindow.ListModel> listModels = new List<InputWindow.InputWindow.ListModel>();
            listModels.Add(new InputWindow.InputWindow.ListModel("Kreditsumme", 0));
            listModels.Add(new InputWindow.InputWindow.ListModel("Zinssatz", 0));
            listModels.Add(new InputWindow.InputWindow.ListModel("Laufzeit in m", 0));

            InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(listModels, "");
            inputWindow.SetCredit(true);
            var dialog = inputWindow.ShowDialogwithReturn();
            string returnString;

            if (dialog.result == DialogResult.OK || dialog.result == DialogResult.Yes)
            {
                foreach (var item in dialog.param)
                {
                    var index = dialog.param.IndexOf(item);
                    listModels[index].Value = item.Value;

                }
            }

            var kreditsumme = listModels.Find(x => x.Name == "Kreditsumme").Value;
            var zinssatz = listModels.Find(x => x.Name == "Zinssatz").Value;
            var laufzeit = listModels.Find(x => x.Name == "Laufzeit in m").Value;

            var monatsrate = (kreditsumme + (kreditsumme * zinssatz / 100)) / laufzeit;

            returnString = $"({kreditsumme} + ({kreditsumme} * {zinssatz} / 100)) / {laufzeit} = {monatsrate}";
            MessageBox.Show(returnString);
            creditCalculation.History.Add("Ratenkredit, Vorgabe der Laufzeit", returnString);
        }
    }
}
