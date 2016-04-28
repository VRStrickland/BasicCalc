using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalc
{
    class CalcDisplay
    {
        public string UpdateDisplay(string InputString, string NewAddition)
        {
            string NewString = "";
            if (!IsValidInput(InputString, NewAddition))
            {
                return InputString;
            }
            NewString = InputString + NewAddition;
            return NewString;
        }

        private bool IsValidInput(string InputString, string NewAddition)
        {
            bool RetBool = true;

            switch (NewAddition)
            {
                case ".":
                    int res1 = InputString.IndexOf(".");
                    if (res1 != -1)
                        {
                            RetBool = false;
                        }
                    break;
                case "1":
                default:
                    RetBool = true;
                    break;
            }
            return RetBool;




        }

    }
}
