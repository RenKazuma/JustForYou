using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputWindow
{

    public partial class InputWindow : Form
    {
        List<ListModel> NeededValues = new List<ListModel>();
        public List<ListModel> InputWindowList = new List<ListModel>();
        public bool creditActive = false;

        public InputWindow(List<ListModel> listModels, string disabledButtons)
        {
            InitializeComponent();

            StartInputWindow(listModels, disabledButtons);
        }

        public void SetCredit(bool credit)
        {
            creditActive = credit;
        }

        public (DialogResult result, List<ListModel> param) ShowDialogwithReturn()
        {
            DialogResult dResult = this.ShowDialog();
            return (dResult, InputWindowList);
        }

        public void StartInputWindow(List<ListModel> listModels, string disabledButtons)
        {

            NeededValues = listModels;
            LabelInputInformation.Text = "Bitte " + listModels[0].Name + " angeben";

            for (int i = 0; i < disabledButtons.Length; i++)
            {
                var buttonToDisable = ButtonValueOne;

                switch (disabledButtons.Substring(i, 1))
                {
                    case "0":
                        buttonToDisable = ButtonValueZero;
                        break;
                    case "1":
                        buttonToDisable = ButtonValueOne;
                        break;
                    case "2":
                        buttonToDisable = ButtonValueTwo;
                        break;
                    case "3":
                        buttonToDisable = ButtonValueThree;
                        break;
                    case "4":
                        buttonToDisable = ButtonValueFour;
                        break;
                    case "5":
                        buttonToDisable = ButtonValueFive;
                        break;
                    case "6":
                        buttonToDisable = ButtonValueSix;
                        break;
                    case "7":
                        buttonToDisable = ButtonValueSeven;
                        break;
                    case "8":
                        buttonToDisable = ButtonValueEight;
                        break;
                    case "9":
                        buttonToDisable = ButtonValueNine;
                        break;
                    case "+":
                        buttonToDisable = ButtonValuePlusAndMinusNumber;
                        break;
                    case ".":
                        buttonToDisable = ButtonValueComma;
                        break;
                    case "E":
                        buttonToDisable = ButtonConfirm;
                        break;
                    default:
                        break;

                }

                buttonToDisable.Enabled = false;

            }
        }

        //METHODS

        /// <summary>
        /// Add number to the input value
        /// </summary>
        /// <param name="i"></param>
        private void ChangeInputValue(int i)
        {
            string[] stringh;


            if (creditActive == true)
            {

                try
                {
                    stringh = LabelDisplayInputValue.Text.Split(',');


                    if ((stringh.Length > 1) && stringh[1].Length >= 2)
                    {
                        MessageBox.Show("Only two digits after the comma!");
                        return;
                    }
                    LabelDisplayInputValue.Text += i;
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.ToString());
                }
                return;
            }




            try
            {
                stringh = LabelDisplayInputValue.Text.Split(',');

                if (stringh.Length > 1)
                {
                    switch (stringh[0].Length)
                    {
                        case 1:
                            if (stringh[1].Length >= 5) { MessageBox.Show("Only 5 Digits allowed!"); }
                            else { LabelDisplayInputValue.Text += i; }
                            break;
                        case 2:
                            if (stringh[1].Length >= 4) { MessageBox.Show("Only 4 Digits allowed!"); }
                            else { LabelDisplayInputValue.Text += i; }
                            break;
                        case 3:
                            if (stringh[1].Length >= 3) { MessageBox.Show("Only 3 Digits allowed!"); }
                            else { LabelDisplayInputValue.Text += i; }
                            break;
                        case 4:
                            if (stringh[1].Length >= 2) { MessageBox.Show("Only 2 Digits allowed!"); }
                            else { LabelDisplayInputValue.Text += i; }
                            break;
                        case 5:
                            if (stringh[1].Length >= 1) { MessageBox.Show("Only 1 Digits allowed!"); }
                            else { LabelDisplayInputValue.Text += i; }
                            break;
                        default:
                            break;
                    }
                    return;
                }

            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
            }

            LabelDisplayInputValue.Text += i;
        }



        //CLICK EVENTS
        private void ButtonValueOne_Click(object sender, EventArgs e)
        {
            ChangeInputValue(1);

        }

        private void ButtonValueTwo_Click(object sender, EventArgs e)
        {
            ChangeInputValue(2);
        }

        private void ButtonValueThree_Click(object sender, EventArgs e)
        {
            ChangeInputValue(3);
        }

        private void ButtonValueFour_Click(object sender, EventArgs e)
        {
            ChangeInputValue(4);
        }

        private void ButtonValueFive_Click(object sender, EventArgs e)
        {
            ChangeInputValue(5);
        }

        private void ButtonValueSix_Click(object sender, EventArgs e)
        {
            ChangeInputValue(6);
        }

        private void ButtonValueSeven_Click(object sender, EventArgs e)
        {
            ChangeInputValue(7);
        }

        private void ButtonValueEight_Click(object sender, EventArgs e)
        {
            ChangeInputValue(8);
        }

        private void ButtonValueNine_Click(object sender, EventArgs e)
        {
            ChangeInputValue(9);
        }

        private void ButtonValueZero_Click(object sender, EventArgs e)
        {
            ChangeInputValue(0);
        }


        /// <summary>
        /// If there is a comma as last character, don't add one. Else add a comma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValueComma_Click_1(object sender, EventArgs e)
        {
            if (!LabelDisplayInputValue.Text.EndsWith(",") && !LabelDisplayInputValue.Text.Contains(","))
            {
                string[] stringh;
                stringh = LabelDisplayInputValue.Text.Split(',');

                if (stringh[0].Length >= 6)
                {
                    MessageBox.Show("No Comma allowed!");
                }
                else
                {
                    LabelDisplayInputValue.Text += ",";
                }
            }
        }

        /// <summary>
        /// If input value is negative transform to positive and other way around.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValuePlusAndMinusNumber_Click(object sender, EventArgs e)
        {
            decimal value = Convert.ToDecimal(LabelDisplayInputValue.Text);

            if (System.Math.Abs(value) == '-')
            {
                value = +System.Math.Abs(value);
                return;
            }

            value = -System.Math.Abs(value);

            LabelDisplayInputValue.Text = value.ToString();
        }

        /// <summary>
        /// Clear Input Value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteValue_Click(object sender, EventArgs e)
        {
            LabelDisplayInputValue.Text = String.Empty;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            foreach (var item in NeededValues)
            {
                if (LabelInputInformation.Text.Contains(item.Name))
                {
                    InputWindowList.Add(new ListModel(item.Name, (float)Convert.ToDouble(LabelDisplayInputValue.Text)));

                    if (ButtonConfirm.Text == "Übergeben")
                    {
                        EndInputWindow();
                    }

                    var index = NeededValues.IndexOf(item) + 1;
                    if (index < NeededValues.Count)
                    {
                        LabelInputInformation.Text = "Bitte " + NeededValues[index].Name + " angeben:";
                        LabelDisplayInputValue.Text = String.Empty;
                    }

                    //If item is last one
                    if (index == NeededValues.Count)
                    {
                        EndInputWindow();
                    }

                    //If Item is second to last one
                    if (NeededValues.Count - 1 == index)
                    {
                        ButtonConfirm.Text = "Übergeben";
                        return;
                    }
                    return;
                }

            }
        }

        public void EndInputWindow()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;
        }

        public class ListModel
        {
            private string _name;
            private float _value;

            public string Name
            {
                get => _name;
                set { Name = value; }
            }

            public float Value
            {
                get => _value;
                set { _value = value; }
            }

            public ListModel(string name, float value)
            {
                _name = name;
                _value = value;
            }
        }

        private void ButtonRemoveLastChar_Click(object sender, EventArgs e)
        {
            try
            {
                LabelDisplayInputValue.Text = LabelDisplayInputValue.Text.Substring(0, LabelDisplayInputValue.Text.Length - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        private void ButtonDeleteWholeValue_Click(object sender, EventArgs e)
        {
            LabelDisplayInputValue.Text = String.Empty;
        }

        private void ButtonValuePlusAndMinusNumber_Click_1(object sender, EventArgs e)
        {
            decimal value = Convert.ToDecimal(LabelDisplayInputValue.Text);

            if (value.ToString().Contains("-"))
            {
                value = System.Math.Abs(value);
                LabelDisplayInputValue.Text = value.ToString();
                return;
            }

            value = -System.Math.Abs(value);

            LabelDisplayInputValue.Text = value.ToString();
        }
    }
}