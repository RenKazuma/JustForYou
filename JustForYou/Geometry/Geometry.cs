using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    public class Geometry : Base.Modul
    {
        public Geometry(Settings settings, History history) : base(settings, history)
        {

        }

        public override string Name => "Geometry";
        public override bool Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }
        private bool _enabled;

        public override Form View => _view ?? (_view = new frm_geometry(this));
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
            public const int ERRORCODE_PRALLELHoEHE = -2;
            public const int ERRORCODE_DREIECK = -3;
        }


        public float calculateCircleFromRadiusToScope(float radius)
        {

            if (radius < 0)
            {
                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (radius == 0)
            {
                return ErrorCodes.ERRORCODE_NULLVALUE;
            }



            return (float)(Math.PI * radius * 2);


        }



        public float calculateCircleFromRadiusToSquare(float radius)
        {

            if (radius < 0)
            {

                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (radius == 0)
            {
                return ErrorCodes.ERRORCODE_NULLVALUE;
            }


            return (float)(Math.PI * Math.Pow(radius, 2));


        }


        public float calculateParallScopeFromLenght(float basis, float seite, float höhe)
        {


            if (basis < 0 || seite < 0)
            {

                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (basis == 0 || seite == 0)
            {
                return ErrorCodes.ERRORCODE_NULLVALUE;
            }



            return 2 * (basis + seite);

        }


        public float calculateParallSquareFromLenght(float basis, float seite, float höhe)
        {


            if (basis < 0 || seite < 0 || höhe < 0)
            {
                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (basis == 0 || seite == 0 || höhe == 0)
            {
                return ErrorCodes.ERRORCODE_NULLVALUE;
            }

            if (höhe >= seite)
            {
                return ErrorCodes.ERRORCODE_PRALLELHoEHE;
            }


            return basis * höhe;

        }





        public float calculateTriangleScopeFromLenght(float a, float b, float c)
        {

            if (a < 0 || b < 0 || c < 0)
            {

                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (a == 0 || b == 0 || c == 0)
            {

                return ErrorCodes.ERRORCODE_NULLVALUE;
            }

            if (a + b < c || c + b < a || a + c < b)
            {

                return ErrorCodes.ERRORCODE_DREIECK;
            }




            return (float)a + b + c;
        }


        public float calculateTriangleSquareFromLenght(float a, float b, float c)
        {

            if (a < 0 || b < 0 || c < 0)
            {

                return ErrorCodes.ERRORCODE_NEGATIVEVALUE;
            }

            if (a == 0 || b == 0 || c == 0)
            {

                return ErrorCodes.ERRORCODE_NULLVALUE;
            }

            if (a + b < c || c + b < a || a + c < b)
            {

                return ErrorCodes.ERRORCODE_DREIECK;
            }

            double halbperimeter = (a + b + c) / 2;


            return (float)Math.Sqrt(halbperimeter * (halbperimeter - a) * (halbperimeter - b) * (halbperimeter - c));
        }




    }
}
