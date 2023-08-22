using System;
using Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematics_Functions
{
    public class Mathematics_Functions : Base.Modul
    {
        public Mathematics_Functions(Settings settings, History history) : base(settings, history)
        {

        }

        public override string Name => "Matherechnung";
        public override bool Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }
        private bool _enabled;

        public override Form View => _view ?? (_view = new frm_MathematicsFunctions(this));
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


        public class ErrorCodes
        {
            public const int ERRORCODE_NULLVALUE = 0;
            public const int ERRORCODE_NEGATIVEVALUE = -1;
            public const int ERRORCODE_ISDECIMAL = -2;
            public const int ERRORCODE_FAKTOOHIGH = -3;
            public const int ERRORCODE_PRIMRANGE = -4;
            
        }



        public float calculateFakultät(float n)
        {

           

            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (n % 1 != 0)
            {
                return ErrorCodes.ERRORCODE_ISDECIMAL;
            }

            if (n > 35)
            {
                return ErrorCodes.ERRORCODE_FAKTOOHIGH;
            }


            else
            {
                return n * calculateFakultät(n - 1);
            }
        }


        public float calculatePotenz(float basis, float exponent)
        {
            if (basis == 0 && exponent == 0)
            {
                return 0;
            }


            double ergebnis = Math.Pow(basis, exponent);
            return (float)ergebnis;
        }


        public float calculateQuadratwurzel(float zahl)
        {
            if (zahl < 0)
            {
                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            double ergebnis = Math.Sqrt(zahl);
            return (float) ergebnis;
        }








        public String calculatePrimzahlenZwischenGrenzwerten(float start, float ende)
        {

            if (start >= ende)
            {
                return ErrorCodes.ERRORCODE_PRIMRANGE.ToString();
            }

            


            List<float> primzahlen = new List<float>();
            for (float zahl = start; zahl <= ende; zahl++)
            {
                bool istPrimzahl = true;
                for (int teiler = 2; teiler <= Math.Sqrt(zahl); teiler++)
                {
                    if (zahl % teiler == 0)
                    {
                        istPrimzahl = false;
                        break;
                    }
                }
                if (istPrimzahl && zahl > 1)
                {
                    primzahlen.Add(zahl);
                }
            }

            



            return string.Join(",", primzahlen);
        }




        public string calculateDecimalToBruch(float input)
        {
            //finde größten gemeinsamen teiler
            int FindGCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return Math.Abs(a);
            }

            if (input == 0) return "0/1";

            int sign = Math.Sign(input);
            float absInput = Math.Abs(input);

            // Finde den nächsten bruch mit nenner bis 1000
            int closestNumerator = 0;
            int closestDenominator = 1;
            float closestError = float.MaxValue;
            for (int denominator = 1; denominator <= 1000; denominator++)
            {
                int numerator = (int)Math.Round(absInput * denominator);
                float error = Math.Abs((float)numerator / denominator - absInput);
                if (error < closestError)
                {
                    closestNumerator = numerator;
                    closestDenominator = denominator;
                    closestError = error;
                }
            }

            // simple bruch
            int gcd = FindGCD(closestNumerator, closestDenominator);
            closestNumerator /= gcd;
            closestDenominator /= gcd;

            // bruch to string
            closestNumerator *= sign;
            return closestNumerator.ToString() + "/" + closestDenominator.ToString();
        }




        //Hilfsfunktionen für Rechenweg als String für History
        public string FakultaetAlsRechenweg(float n)
        {
            
            if (n == 0)
            {
                return "0! = 1";
            }

            string rechenweg = n.ToString() + "! = ";
            int fakultaet = 1;
            for (int i = 1; i <= n; i++)
            {
                fakultaet *= i;
                if (i != 1)
                {
                    rechenweg += " * ";
                }
                rechenweg += i.ToString();
            }
            rechenweg += " = " + fakultaet.ToString();
            return rechenweg;
        }


        public string PotenzAlsRechenweg(float basis, float exponent)
        {
            string rechenweg = basis.ToString() + "^" + exponent.ToString() + " = ";
            double ergebnis = 1;
            for (int i = 0; i < Math.Abs(exponent); i++)
            {
                ergebnis *= basis;
                if (i != 0)
                {
                    rechenweg += " * ";
                }
                rechenweg += basis.ToString();
            }
            if (exponent < 0)
            {
                ergebnis = 1 / ergebnis;
                rechenweg = "1 / (" + rechenweg + ")";
            }
            rechenweg += " = " + ergebnis.ToString();
            return rechenweg;
        }

        public string QuadratwurzelAlsRechenweg(float zahl)
        {
            
            string rechenweg = "√" + zahl.ToString() + " = ";
            double guess = zahl / 2;
            double differenz = 0;
            //Toleranzwert
            while (Math.Abs(differenz - guess) > 0.0001)
            {
                differenz = guess;
                guess = (guess + zahl / guess) / 2;
            }
            rechenweg += guess.ToString();
            return rechenweg;
        }

        public string PrimzahlenZwischenGrenzwertenAlsRechenweg(float start, float ende)
        {
           
            List<float> primzahlen = new List<float>();
            StringBuilder rechenweg = new StringBuilder();
            rechenweg.Append($"Primzahlen zwischen {start} und {ende}: \n");

            for (float zahl = start; zahl <= ende; zahl++)
            {
                bool istPrimzahl = true;
                rechenweg.Append($"Überprüfe, ob {zahl} eine Primzahl ist: \n");

                for (int teiler = 2; teiler <= Math.Sqrt(zahl); teiler++)
                {
                    rechenweg.Append($"    Teiler: {teiler}\n");
                    rechenweg.Append($"    {zahl} % {teiler} = {zahl % teiler}\n");
                    if (zahl % teiler == 0)
                    {
                        istPrimzahl = false;
                        rechenweg.Append($"    {zahl} ist durch {teiler} teilbar, also ist {zahl} keine Primzahl\n");
                        break;
                    }
                }

                if (istPrimzahl && zahl > 1)
                {
                    primzahlen.Add(zahl);
                    rechenweg.Append($"{zahl} ist eine Primzahl\n");
                }
                else
                {
                    rechenweg.Append($"{zahl} ist keine Primzahl\n");
                }
            }

            rechenweg.Append($"Primzahlen gefunden: {string.Join(",", primzahlen)}\n");
            return rechenweg.ToString();
        }

        public string DecimalToBruchAlsRechenweg(float input)
        {
            //finde größten gemeinsamen teiler
            int FindGCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return Math.Abs(a);
            }

            if (input == 0) return "0/1";

            int sign = Math.Sign(input);
            float absInput = Math.Abs(input);

            // Finde den nächsten bruch mit nenner bis 1000
            int closestNumerator = 0;
            int closestDenominator = 1;
            float closestError = float.MaxValue;
            StringBuilder rechenweg = new StringBuilder();
            rechenweg.Append($"Konvertiere {input} in einen Bruch:\n");
            rechenweg.Append($"Finde den nächsten Bruch mit Nenner bis 1000:\n");
            for (int denominator = 1; denominator <= 1000; denominator++)
            {
                int numerator = (int)Math.Round(absInput * denominator);
                float error = Math.Abs((float)numerator / denominator - absInput);
                rechenweg.Append($"    Nenner: {denominator}\n");
                rechenweg.Append($"    Zähler: {numerator}\n");
                rechenweg.Append($"    Fehler: {error}\n");
                if (error < closestError)
                {
                    closestNumerator = numerator;
                    closestDenominator = denominator;
                    closestError = error;
                }
            }

            
            int gcd = FindGCD(closestNumerator, closestDenominator);
            closestNumerator /= gcd;
            closestDenominator /= gcd;

            closestNumerator *= sign;
            rechenweg.Append($"Kürze den Bruch:\n");
            rechenweg.Append($"    Zähler: {closestNumerator}\n");
            rechenweg.Append($"    Nenner: {closestDenominator}\n");
            return $"{closestNumerator}/{closestDenominator}\nRechenweg:\n{rechenweg.ToString()}";
        }

















    }
}
