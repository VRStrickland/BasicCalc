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
            //This method will be used to add char to the calc display
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
            //This method has the job of ensuring only valid additions are added to the calc screen
            //as of right now the only invalid one I can think of is two decimal places.  It checks
            //for that now.
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