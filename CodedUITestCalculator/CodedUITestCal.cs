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

                // //ALL NUMBERS
                string expectedAllNums = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15";
                UITestControl AllNumsTB = new UITestControl(Browser);
                AllNumsTB.TechnologyName = "Web";
                // AllNumsTB.SearchProperties.Add("ControlType", "");
                AllNumsTB.SearchProperties.Add("Id", "MainContent_AllNumLbl_Res");

                int count = AllNumsTB.FindMatchingControls().Count;//.InnerList).Items[0]).DisplayText;




               // ((Microsoft.VisualStudio.TestTools.UITesting.HtmlControls.HtmlSpan)new System.Collections.ArrayList.ArrayListDebugView(((System.Collections.CollectionBase)(AllNumsTB.FindMatchingControls()).List).InnerList).Items[0]).DisplayText




                    // (AllNumsTB.FindMatchingControls()).InnerList).Items[0]).DisplayText
                    // (Microsoft.VisualStudio.TestTools.UITesting.HtmlControls.HtmlSpan)new System.Collections.ArrayList.ArrayListDebugView((AllNumsTB.FindMatchingControls()).InnerList).Items[0]).DisplayText;
                int b = 1;
                //if (expectedAllNums != AllNumsTB.FindMatchingControls().Count)
                //{
                //    Assert.Fail("All Numbers fail");
                //}

                ////ALL ODD NUMBERS
                //string expectedAllOddNums = "1, 3, 5, 7, 9, 11, 13, 15";
                //UITestControl AllOddNumsTB = new UITestControl(Browser);
                //AllNumsTB.TechnologyName = "Web";
                //AllNumsTB.SearchProperties.Add("ControlType", "");
                //AllNumsTB.SearchProperties.Add("Id", "MainContent_OddLbl_res");

                ////if (expectedAllOddNums != AllOddNumsTB.?)
                ////{
                ////    Assert.Fail("Odd Numbers Fail");
                ////}

                ////ALL EVEN NUMBERS
                //string expectedAllEvenNums = "2, 4, 6, 8, 10, 12, 14";
                //UITestControl AllEveNumsTB = new UITestControl(Browser);
                //AllNumsTB.TechnologyName = "Web";
                //AllNumsTB.SearchProperties.Add("ControlType", "");
                //AllNumsTB.SearchProperties.Add("Id", "MainContent_EvenLbl_res");

                ////if (expectedAllEvenNums != AllEveNumsTB.?)
                ////{
                ////    Assert.Fail("Even Numbers Fail");
                ////}

                ////ALL LETTERS
                //string expectedLetters = "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z";
                //UITestControl AllLettersTB = new UITestControl(Browser);
                //AllNumsTB.TechnologyName = "Web";
                //AllNumsTB.SearchProperties.Add("ControlType", "");
                //AllNumsTB.SearchProperties.Add("Id", "MainContent_FibLbl_results");

                ////if (expectedLetters != AllLettersTB.?)
                ////{
                ////    Assert.Fail("Letters Fail");
                ////}

                ////ALL FIB SERIES
                //string expectedFibSeries = "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377";
                //UITestControl AllFibTB = new UITestControl(Browser);
                //AllNumsTB.TechnologyName = "Web";
                //AllNumsTB.SearchProperties.Add("ControlType", "");
                //AllNumsTB.SearchProperties.Add("Id", "MainContent_FibLbl_results");

                ////if (expectedFibSeries != AllFibTB.?)
                ////{
                ////    Assert.Fail("Letters Fail");
                ////}

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
