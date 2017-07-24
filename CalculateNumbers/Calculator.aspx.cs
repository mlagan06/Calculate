using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculateNumbers
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //CALCULATE OUTPUTS AFTER INPUT ENTERED
        protected void CalculateResults(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(numberTb.Text);
                PerformCalculations PerformCal = new PerformCalculations();
                ShowAllNumbersResults_Lbl.Text = PerformCal.GetAllNumbers(number);
                ShowOddNumbersResults_Lbl.Text = PerformCal.GetAllOddNumbers(number);

                if (number == 1)
                {
                    ShowEvenNumbersResults_Lbl.Text = "No numbers to show";
                }
                else
                {
                    ShowEvenNumbersResults_Lbl.Text = PerformCal.GetAllEvenNumbers(number);
                }
                ShowLettersResults_Lbl.Text = PerformCal.GetAllLetters(number);
                ShowFibNumbersResults_Lbl.Text = PerformCal.GetAllFibsNumbers(number);
                ResultsDiv.Style["display"] = "block";
                CalculateUP.Update();
            }
            catch ( Exception ex)
            {
                //throw new exception;
            }
        }
    }
}