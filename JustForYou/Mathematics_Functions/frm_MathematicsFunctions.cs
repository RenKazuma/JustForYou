using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;
using InputWindow;

namespace Mathematics_Functions
{
    public partial class frm_MathematicsFunctions : Form
    {
        public frm_MathematicsFunctions(Mathematics_Functions math)
        {
            InitializeComponent();
           _self = math;
        }

        Mathematics_Functions _self;

        private void fak_onClick(object sender, EventArgs e)
        {
            try
            {
                List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
                list.Add(new InputWindow.InputWindow.ListModel("Basis Zahl", 0));

                InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "");
                var dialog = inputWindow.ShowDialogwithReturn();
                if (dialog.result == DialogResult.OK)
                {
                    foreach (var item in dialog.param)
                    {
                        var index = dialog.param.IndexOf(item);
                        list[index].Value = item.Value;

                    }



                    if (_self.calculateFakultät(list[0].Value) == Mathematics_Functions.ErrorCodes.ERRORCODE_NEGATIVEVALUE)
                    {
                        MessageBox.Show("Die Fakultät einer Negativen Zahl ist nicht definiert.");
                        return;
                    }

                    if (_self.calculateFakultät(list[0].Value) == Mathematics_Functions.ErrorCodes.ERRORCODE_ISDECIMAL)
                    {
                        MessageBox.Show("Die Fakultät einer Dezimal Zahl ist nicht definiert.");
                        return;
                    }

                    if (_self.calculateFakultät(list[0].Value) == Mathematics_Functions.ErrorCodes.ERRORCODE_FAKTOOHIGH)
                    {
                        MessageBox.Show("Das Ergebnis der Fakultät der Zahl ist zu groß um sie korrekt auszugeben.");
                        return;
                    }


                    MessageBox.Show($"Fakultät von {list[0].Value} = {_self.calculateFakultät(list[0].Value)}");


                    _self.History.Add("Fakultät", $"{_self.FakultaetAlsRechenweg(list[0].Value)}");
                }
            } catch (System.OverflowException)
            {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }

        }

        private void pow_onClick(object sender, EventArgs e)
        {

            try
            {

                List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
                list.Add(new InputWindow.InputWindow.ListModel("Basis Zahl", 0));
                list.Add(new InputWindow.InputWindow.ListModel("Exponent", 0));

                InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "");
                var dialog = inputWindow.ShowDialogwithReturn();
                if (dialog.result == DialogResult.OK)
                {
                    foreach (var item in dialog.param)
                    {
                        var index = dialog.param.IndexOf(item);
                        list[index].Value = item.Value;

                    }
                       
                    if (list[0].Value == 0 && list[1].Value == 0)
                    {
                        MessageBox.Show($"Das Ergebnis von {list[0].Value} hoch {list[1].Value}  = {_self.calculatePotenz(list[0].Value, list[1].Value)}" +
                            $"\n\nBitte den Kontext beachten, abweichende Ergebnisse möglich.");

                        _self.History.Add("Potenz", $"{list[0].Value} ^ {list[1].Value}  = {_self.calculatePotenz(list[0].Value, list[1].Value)}" +
                            $"\n\nBitte den Kontext beachten, abweichende Ergebnisse möglich.");

                        return;
                        
                    }


                    MessageBox.Show($"Das Ergebnis von {list[0].Value} hoch {list[1].Value}  = {_self.calculatePotenz(list[0].Value, list[1].Value)}");
                    _self.History.Add("Potenz", $"{_self.PotenzAlsRechenweg(list[0].Value, list[0].Value)}");
                    return;
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }

        }



        private void prim_between_range_onClick(object sender, EventArgs e)
        {

            try
            {

                List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
                list.Add(new InputWindow.InputWindow.ListModel("Anfang", 0));
                list.Add(new InputWindow.InputWindow.ListModel("Ende", 0));

                InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "");
                var dialog = inputWindow.ShowDialogwithReturn();
                if (dialog.result == DialogResult.OK)
                {
                    foreach (var item in dialog.param)
                    {
                        var index = dialog.param.IndexOf(item);
                        list[index].Value = item.Value;

                    }

                    if (_self.calculatePrimzahlenZwischenGrenzwerten(list[0].Value, list[1].Value) == Mathematics_Functions.ErrorCodes.ERRORCODE_PRIMRANGE.ToString())
                    {
                        MessageBox.Show("Der Startgrenzwert ist kleiner oder gleich dem den Endgrenzwert.");
                        return;
                    }



                    MessageBox.Show($"Primzahlen von {list[0].Value} bis {list[1].Value} sind: {_self.calculatePrimzahlenZwischenGrenzwerten(list[0].Value, list[1].Value)}");
                    _self.History.Add("Primzahlen zwischen Grenzwerten", $"{_self.PrimzahlenZwischenGrenzwertenAlsRechenweg(list[0].Value,list[1].Value)}");
                    return;
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }

        }

        private void trans_decimal_onCLick(object sender, EventArgs e)
        {

            try
            {

                List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
                list.Add(new InputWindow.InputWindow.ListModel("Dezimalzahl", 0));


                InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "");
                var dialog = inputWindow.ShowDialogwithReturn();
                if (dialog.result == DialogResult.OK)
                {
                    foreach (var item in dialog.param)
                    {
                        var index = dialog.param.IndexOf(item);
                        list[index].Value = item.Value;

                    }



                    MessageBox.Show($"Der Bruch von der Dezimalzahl {list[0].Value} ist {_self.calculateDecimalToBruch((float)-1.5235)}");
                    _self.History.Add("Decimalzahl als Bruch", $"{_self.DecimalToBruchAlsRechenweg(list[0].Value)}");
                    return;
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }

           

        }

        private void sqrt_btn_Click(object sender, EventArgs e)
        {

            try
            {

                List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
                list.Add(new InputWindow.InputWindow.ListModel("Basis Zahl", 0));
                list.Add(new InputWindow.InputWindow.ListModel("Exponent", 0));

                InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "");
                var dialog = inputWindow.ShowDialogwithReturn();
                if (dialog.result == DialogResult.OK)
                {
                    foreach (var item in dialog.param)
                    {
                        var index = dialog.param.IndexOf(item);
                        list[index].Value = item.Value;

                    }

                    if (_self.calculateQuadratwurzel(list[0].Value) == Mathematics_Functions.ErrorCodes.ERRORCODE_NEGATIVEVALUE)
                    {
                        MessageBox.Show("Die Quadratwurzel aus einer negativen ist ist eine komplexe Zahl.");
                        return;
                    }



                    MessageBox.Show($"Das Ergebnis von {list[0].Value} hoch {list[1].Value}  = {_self.calculatePotenz(list[0].Value, list[1].Value)}");
                    _self.History.Add("Quadratwurzel", $"{_self.QuadratwurzelAlsRechenweg(list[0].Value)}");
                    return;
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }



        }
    }
}
