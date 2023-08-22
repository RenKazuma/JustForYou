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


namespace Geometry
{
    public partial class frm_geometry : Form
    {
        public frm_geometry(Geometry geometry)
        {
            InitializeComponent();
            _self = geometry;
        }

        Geometry _self;

        private void kreisberechnung_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
                list.Add(new InputWindow.InputWindow.ListModel("Radius", 0));

                InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "");
                var dialog = inputWindow.ShowDialogwithReturn();
                if (dialog.result == DialogResult.OK)
                {
                    foreach (var item in dialog.param)
                    {
                        var index = dialog.param.IndexOf(item);
                        list[index].Value = item.Value;

                    }

                    if (_self.calculateCircleFromRadiusToScope(list[0].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE ||
                        _self.calculateCircleFromRadiusToSquare(list[0].Value) == Geometry.ErrorCodes.ERRORCODE_NEGATIVEVALUE)
                    {
                        MessageBox.Show("Ein Kreis mit negativen Radius kann nicht berechnet werden.");
                        return;
                    }

                    if (_self.calculateCircleFromRadiusToScope(list[0].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE ||
                        _self.calculateCircleFromRadiusToSquare(list[0].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE)
                    {
                        MessageBox.Show("Ein Kreis mit Radius Null ist kein Kreis.");
                        return;
                    }


                    MessageBox.Show($"Umfang = {_self.calculateCircleFromRadiusToScope(list[0].Value)}" +
                            $"\nFläche = {_self.calculateCircleFromRadiusToSquare(list[0].Value)} ");

                    //Add History
                    _self.History.Add("Kreis Umfang", $"π * {list[0].Value} * 2 = {(float)(Math.PI * Math.Pow(list[0].Value, 2))}");
                    _self.History.Add("Kreis Fläche", $"π * {Math.Pow(list[0].Value, 2)} = {(float)(Math.PI * Math.Pow(list[0].Value, 2))}");

                    return;

                }
            } catch (System.OverflowException) {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }

      
        }


        private void parallelogrammberechnung_btn_Click(object sender, EventArgs e)
        {

           try { 

            List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
            list.Add(new InputWindow.InputWindow.ListModel("Länge Basis", 0));
            list.Add(new InputWindow.InputWindow.ListModel("Länge Seite ", 0));
            list.Add(new InputWindow.InputWindow.ListModel("Höhe", 0));

            InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "+");
            var dialog = inputWindow.ShowDialogwithReturn();
            if (dialog.result == DialogResult.OK)
            {
                foreach (var item in dialog.param)
                {
                    var index = dialog.param.IndexOf(item);
                    list[index].Value = item.Value;

                }

                
                if (_self.calculateParallScopeFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NEGATIVEVALUE ||
                    _self.calculateParallSquareFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NEGATIVEVALUE)
                    
                {
                    MessageBox.Show("Ein Parallelogramm mit negativen Seitenlängen oder Höhe kann nicht berechnet werden.");
                    return;
                }

                if (_self.calculateParallScopeFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE ||
                    _self.calculateParallSquareFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE)
                {
                    MessageBox.Show("Ein Parallelogramm mit Seitenlänge Null oder Höhe ist kein Parallelogramm.");
                    return;
                }

                if (_self.calculateParallScopeFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_PRALLELHoEHE ||
                    _self.calculateParallSquareFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_PRALLELHoEHE)
                {
                    MessageBox.Show("Ein Parallelogramm mit der Höhe größer oder Gleich der Seitenhöhe ist kein Paralellogramm");
                    return;
                }

                MessageBox.Show($"Umfang = {_self.calculateParallScopeFromLenght(list[0].Value, list[1].Value, list[2].Value)} " +
               $"\nFläche = {_self.calculateParallSquareFromLenght(list[0].Value, list[1].Value, list[2].Value)}");

                    _self.History.Add("Pralelogram Umfang", $"2 * {list[0].Value} + {list[0].Value} = {2 * (list[0].Value + list[1].Value)}");
                    _self.History.Add("Paralelogram Fläche", $"{list[0].Value} * {list[2].Value} = {(list[0].Value * list[2].Value)}");

                    return;
                    

                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Parameter sind zu groß um sie zu berechnen.");
            }


        }


            



          

        

        private void dreiecksberechnung_btn_Click(object sender, EventArgs e)
        {
         
            try { 

            List<InputWindow.InputWindow.ListModel> list = new List<InputWindow.InputWindow.ListModel>();
            list.Add(new InputWindow.InputWindow.ListModel("Seite A", 0));
            list.Add(new InputWindow.InputWindow.ListModel("Seite B", 0));
            list.Add(new InputWindow.InputWindow.ListModel("Seite C", 0));

            InputWindow.InputWindow inputWindow = new InputWindow.InputWindow(list, "+");
            var dialog = inputWindow.ShowDialogwithReturn();
            if (dialog.result == DialogResult.OK)
            {
                foreach (var item in dialog.param)
                {
                    var index = dialog.param.IndexOf(item);
                    list[index].Value = item.Value;
                  
                }

                if (_self.calculateTriangleScopeFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NEGATIVEVALUE ||
                    _self.calculateTriangleSquareFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NEGATIVEVALUE)

                {
                    MessageBox.Show("Ein Dreieck mit negativen Seitenlängen kann nicht berechnet werden.");
                    return;
                }

                if (_self.calculateTriangleScopeFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE ||
                    _self.calculateTriangleSquareFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_NULLVALUE)
                {
                    MessageBox.Show("Ein Dreieck mit Seitenlänge Null ist kein Dreieck.");
                    return;
                }

                if (_self.calculateTriangleScopeFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_DREIECK ||
                    _self.calculateTriangleSquareFromLenght(list[0].Value, list[1].Value, list[2].Value) == Geometry.ErrorCodes.ERRORCODE_DREIECK)
                {
                    MessageBox.Show("Ein Dreieck, wo 2 Seiten zusammen kürzer sind als die dritte Seite, ist kein Dreieck.");
                    return;
                }




                MessageBox.Show($"Umfang = {_self.calculateTriangleScopeFromLenght(list[0].Value, list[1].Value, list[2].Value)}" +
                    $"\nFläche = {_self.calculateTriangleSquareFromLenght(list[0].Value, list[1].Value, list[2].Value)}");


                    _self.History.Add("Dreick Umfang", $"{list[0].Value} + {list[1].Value} + {list[2].Value} = {(float)list[0].Value + list[1].Value + list[2].Value}");

                    
                    double halbperimeter = (list[0].Value + list[1].Value + list[2].Value) / 2;

                    _self.History.Add("Dreieck Fläche", $"{halbperimeter} * ({halbperimeter} - {list[0].Value} * ({halbperimeter} - {list[1].Value} * ({halbperimeter} - {list[2].Value}) =" +
                        $" {(float)Math.Sqrt(halbperimeter * (halbperimeter - list[0].Value) * (halbperimeter - list[1].Value) * (halbperimeter - list[2].Value))}");

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
