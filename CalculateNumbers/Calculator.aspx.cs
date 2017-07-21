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

        protected void CalculateResults(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(numberTb.Text);
                PerformCalculations PerformCal = new PerformCalculations();
                AllNumLbl_Res.Text = PerformCal.GetAllNumbers(number);
                OddLbl_res.Text = PerformCal.GetAllOddNumbers(number);
                EvenLbl_res.Text = PerformCal.GetAllEvenNumbers(number);
                LettersLbl_res.Text = PerformCal.GetAllLetters(number);
                FibLbl_results.Text = PerformCal.GetAllFibsNumbers(number);
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