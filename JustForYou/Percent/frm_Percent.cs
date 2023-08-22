using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percent
{
    public partial class frm_Percent : Form
    {
		Percent programm;
		List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
		DialogResult dialogResult;
		

		public frm_Percent(Percent percent)
        {
            InitializeComponent();
			programm = percent;
        }

		private void FillList(string text1)
		{
			list.Add(new InputWindow.InputWindow.ListModel(text1, 0));
		}

		private void StartInput(string notWantedKeys)
		{
			dialogResult = DialogResult.None;
			InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, notWantedKeys);
			var dialog = inputWindow.ShowDialogwithReturn();
			dialogResult = dialog.result;

			if (dialogResult == DialogResult.OK)
			{
				foreach (var item in dialog.param)
				{
					var index = dialog.param.IndexOf(item);
					list[index].Value = item.Value;
				}
			}

           
		}

		private void btn_davon_Click(object sender, EventArgs e)
        {
			list.Clear();
			FillList("Prozentsatz");
			FillList("Prozenwert");
			StartInput("");
			
			string stringResult;

			var percentage = list.Find(x => x.Name == "Prozentsatz").Value;
			var percentValue = list.Find(x => x.Name == "Prozenwert").Value;

			if (percentage != 0 && percentValue != 0)
			{
				var mathResult = ( percentage * percentValue) / 100;
					
				stringResult = $"({percentage} * {percentValue}) / 100 = {mathResult}";
				programm.History.Add("Prozent Davon", stringResult);
				MessageBox.Show(stringResult);
				return;
			}
			
        }
		
		private void btn_weg_Click(object sender, EventArgs e)
		{
			list.Clear();
			FillList("Prozentsatz");
			FillList("Prozenwert");
			StartInput("");
			
			string stringResult;
			var percentage = list.Find(x => x.Name == "Prozentsatz").Value;
			var percentValue = list.Find(x => x.Name == "Prozenwert").Value;

			if (percentage != 0 && percentValue != 0)
			{
				var mathResult =  percentValue - ( percentage * percentValue) / 100;
					
				stringResult = $"({percentValue} - (({percentage} * {percentValue}) / 100)) = {mathResult}";
				programm.History.Add("Prozent Weg", stringResult);
				MessageBox.Show(stringResult);
				return;
			}
		}
		
		private void btn_dazu_Click(object sender, EventArgs e)
		{
			list.Clear();
			FillList("Prozenwert");
			FillList("Prozentsatz");
			StartInput("");

			string stringResult;
			var percentage = list.Find(x => x.Name == "Prozentsatz").Value;
			var percentValue = list.Find(x => x.Name == "Prozenwert").Value;
		

			if(percentage != 0 && percentValue != 0)
			{
				var mathResult = percentValue + ( percentage * percentValue) / 100;
					
				stringResult = $"({percentValue} + (({percentage} * {percentValue}) / 100)) = {mathResult}";
				programm.History.Add("Prozent Dazu", stringResult);
				MessageBox.Show(stringResult);
				return;

				
			}
		}

        private void btn_Satz_Click(object sender, EventArgs e)
        {
			list.Clear();
			FillList("Prozentwert");
			FillList("Grundwert");
			StartInput("");

			string stringResult;
			var prozentwert = list.Find(x => x.Name == "Prozentwert").Value;
			var grundwert = list.Find(x => x.Name == "Grundwert").Value;

			float result = (float)Math.Round((grundwert * 100) / prozentwert, 2);

			stringResult = $"({grundwert} * 100) / {prozentwert} = {result}";
			programm.History.Add("Prozentsatz", stringResult);
			MessageBox.Show(stringResult);
		}

        private void btn_NettoAusBrutto_Click(object sender, EventArgs e)
        {
			list.Clear();
			FillList("Nettopreis");
			StartInput("");

			string stringResult;
			var nettopreis = list.Find(x => x.Name == "Nettopreis").Value;
			var prozentsatz = 19;

			float result = (float)Math.Round((nettopreis * 100) / (prozentsatz + 100), 2);

			stringResult = $"({nettopreis} * 100) / ({prozentsatz} + 100) = {result}";
			programm.History.Add("Netto aus Brutto", stringResult);
			MessageBox.Show(stringResult);
		}

        private void btn_BruttoAusNetto_Click(object sender, EventArgs e)
        {
			list.Clear();
			FillList("Nettopreis");
			StartInput("");

			string stringResult;

			var nettopreis = list.Find(x => x.Name == "Nettopreis").Value;
			var prozentsatz = 19;

			float result = (nettopreis * (prozentsatz + 100)) / 100;

			stringResult = $"({nettopreis} * ({prozentsatz} + 100)) / {100} = {result}";
			programm.History.Add("Brutto aus Netto", stringResult);
			MessageBox.Show(stringResult);
		}

    }
}
