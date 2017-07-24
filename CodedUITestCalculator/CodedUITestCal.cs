using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUITestCalculator
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITestCal
    {
        public CodedUITestCal()
        {
        }

        [TestMethod]
        public void CodedUITestValidation()
        {
            try
            {
                // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
                BrowserWindow Browser = BrowserWindow.Launch("http://localhost:37426/Calculator");

                UITestControl UiInputField = new UITestControl(Browser);
                UiInputField.TechnologyName = "Web";
                UiInputField.SearchProperties.Add("ControlType", "Edit");
                UiInputField.SearchProperties.Add("Id", "MainContent_numberTb");

                //Populate input field
                Keyboard.SendKeys(UiInputField, "15ABC");

                //Results Button
                UITestControl ResultsBtn = new UITestControl(Browser);
                ResultsBtn.TechnologyName = "Web";
                ResultsBtn.SearchProperties.Add("ControlType", "Button");
                ResultsBtn.SearchProperties.Add("Id", "MainContent_calBtn");

                Mouse.Click(ResultsBtn);

                //VALIDATION MESSAGE
                UITestControl PositiveNumValMsg = new UITestControl(Browser);
                PositiveNumValMsg.TechnologyName = "Web";
                PositiveNumValMsg.SearchProperties.Add("Id", "MainContent_regexpName");

                //var PositiveNumValMsg1 = new HtmlSpan(Browser);
                //PositiveNumValMsg1.TechnologyName = "Web";
                //PositiveNumValMsg1.SearchProperties.Add("Id", "MainContent_regexpName");

                //Point p = new Point();
                //PositiveNumValMsg1.TryGetClickablePoint(out p);

                //bool isVisible = PositiveNumValMsg1.GetProperty("style").ToString().Contains("‌​visible");
                //if (isVisible)
                //{
                //    Assert.Fail("Validation FAIL");
                //}

                Playback.Wait(10000);
            }
            catch (PlaybackFailureException x)
            {
                //throw exception
            }


        }
    

        [TestMethod]
        public void CodedUITestMethod1()
        {
            try
            {
                // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
                BrowserWindow Browser = BrowserWindow.Launch("http://localhost:37426/Calculator");

                UITestControl UiInputField = new UITestControl(Browser);
                UiInputField.TechnologyName = "Web";
                UiInputField.SearchProperties.Add("ControlType", "Edit");
                UiInputField.SearchProperties.Add("Id", "MainContent_numberTb");

                //Populate input field
                Keyboard.SendKeys(UiInputField, "15");

                //Results Button
                UITestControl ResultsBtn = new UITestControl(Browser);
                ResultsBtn.TechnologyName = "Web";
                ResultsBtn.SearchProperties.Add("ControlType", "Button");
                ResultsBtn.SearchProperties.Add("Id", "MainContent_calBtn");

                Mouse.Click(ResultsBtn);

                //ALL NUMBERS
                string expectedAllNums = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15";
                UITestControl AllNumsTB = new UITestControl(Browser);
                AllNumsTB.TechnologyName = "Web";
                AllNumsTB.SearchProperties.Add("Id", "MainContent_ShowAllNumbersResults_Lbl");

                if (expectedAllNums != AllNumsTB.GetProperty("InnerText").ToString())
                {
                    Assert.Fail("All Numbers fail");
                }

                //ALL ODD NUMBERS
                string expectedAllOddNums = "1, 3, 5, 7, 9, 11, 13, 15";
                UITestControl AllOddNumsTB = new UITestControl(Browser);
                AllOddNumsTB.TechnologyName = "Web";
                AllOddNumsTB.SearchProperties.Add("Id", "MainContent_ShowOddNumbersResults_Lbl");

                if (expectedAllOddNums != AllOddNumsTB.GetProperty("InnerText").ToString())
                {
                    Assert.Fail("Odd Numbers Fail");
                }

                //ALL EVEN NUMBERS
                string expectedAllEvenNums = "2, 4, 6, 8, 10, 12, 14";
                UITestControl AllEveNumsTB = new UITestControl(Browser);
                AllEveNumsTB.TechnologyName = "Web";
                AllEveNumsTB.SearchProperties.Add("Id", "MainContent_ShowEvenNumbersResults_Lbl");

                if (expectedAllEvenNums != AllEveNumsTB.GetProperty("InnerText").ToString())
                {
                    Assert.Fail("Even Numbers Fail");
                }

                //ALL LETTERS
                string expectedLetters = "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z";
                UITestControl AllLettersTB = new UITestControl(Browser);
                AllLettersTB.TechnologyName = "Web";
                AllLettersTB.SearchProperties.Add("Id", "MainContent_ShowLettersResults_Lbl");

                if (expectedLetters != AllLettersTB.GetProperty("InnerText").ToString())
                {
                    Assert.Fail("Letters Fail");
                }

                //ALL FIB SERIES
                string expectedFibSeries = "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377";
                UITestControl AllFibTB = new UITestControl(Browser);
                AllFibTB.TechnologyName = "Web";
                AllFibTB.SearchProperties.Add("Id", "MainContent_ShowFibNumbersResults_Lbl");

                if (expectedFibSeries != AllFibTB.GetProperty("InnerText").ToString())
                {
                    Assert.Fail("Fibonacci Numbers Fail");
                }

                Playback.Wait(10000);
            }
            catch ( PlaybackFailureException x)
            {
                //throw exception
            }

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
