using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class DemoModel
    {
        public string text { get; set; }

        public void Div()
        {
            if (!IsTextValid())
            {
                text = "Error";
                return;
            }

            int divSymbPos = text.IndexOf('/');
            if (divSymbPos < -1)
            { 
                text = "Error";
                return;
            }

            string sLeft = "", sRight = "";

            try
            {
                sLeft = text.Substring(0, divSymbPos);
                sRight = text.Substring(divSymbPos + 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                text = "Error";
                return;
            }

            if (sLeft.Length == 0 || sRight.Length == 0)
            {
                text = "Error";
                return;
            }

            int nLeft = 0, nRight = 0;

            try
            {
                nLeft = Int32.Parse(sLeft);
                nRight = Int32.Parse(sRight);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                text = "Error";
                return;
            }


            if (nRight == 0)
            {
                text = "You can't divide by 0!";
                return;
            }

            int nResult = nLeft / nRight;
            text = nResult.ToString();
        }


        private bool IsTextValid()
        {
            if (text.Length == 0)
                return true;

            string num = "0123456789";

            foreach (var ch in text)
            {
                if (num.IndexOf(ch) >= 0)
                    continue;

                if (ch != '/')
                    return false;
            }

            return true;
        }
    }
}
