using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Flipkart.UtilityClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flipkart.Common
{
    [Binding]
    public static class Hooks
    {

        public static string _path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\ExtentReport");


        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;
        private static IObjectContainer iob;
        public static IWebDriver driver;

        private static object _currentScenarioName;
        private static string FileName;


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            
          
            _extentHtmlReporter = new ExtentHtmlReporter(_path + @"index.html");

            _extentHtmlReporter.Config.ReportName = "Flipkart.html";
            _extentHtmlReporter.Config.DocumentTitle = "Automation Testing Report";
            _extentHtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            _extentReports = new ExtentReports();

            _extentReports.AttachReporter(_extentHtmlReporter);
            _extentReports.AddSystemInfo("Application Under Test", "Flipkart");
            _extentReports.AddSystemInfo("Application URL", "https://www.flipkart.com/");
            _extentReports.AddSystemInfo("Environment", "QA");
            _extentReports.AddSystemInfo("Tester Name", "Deepika Kumari");
            _extentReports.AddSystemInfo("System Name", Environment.MachineName);
            _extentReports.AddSystemInfo("OS", Environment.OSVersion.VersionString);


        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.flipkart.com/");

            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);


            if (null != featureContext)
            {
                {
                    _feature = _extentReports.CreateTest<Scenario>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);
                }

            }
        }



        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");

            driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            ExplicitWaiting.waitForTime(3000);

            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }

        }


        [AfterStep]
        public static void AfterEachStep()
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;
            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:

                    CreateNode<Given>();
                    break;
                case ScenarioBlock.When:

                    CreateNode<When>();
                    break;
                case ScenarioBlock.Then:

                    CreateNode<Then>();
                    break;
                default:

                    CreateNode<And>();

                    break;
            }
        }



        public static void CreateNode<T>() where T : IGherkinFormatterModel
        {
            if (_scenarioContext.TestError != null)
            {
                ///string name = @"C:\Users\Deepika\source\repos\PhpTravels01\PhpTravels01\ExtentReport" + _scenarioContext.ScenarioInfo.Title.Replace(" ", "") + ".jpeg";

                ITakesScreenshot screenshotDriver_s = Hooks.driver as ITakesScreenshot;
                Screenshot screenshot_1 = screenshotDriver_s.GetScreenshot();
                screenshot_1.SaveAsFile(_path + @"Fail_Test_Scrnsht", ScreenshotImageFormat.Jpeg);

                _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace).AddScreenCaptureFromPath("Fail_Test_Scrnsht");
            }
            else
            {

                _scenario.CreateNode<T>(_scenarioContext.StepContext.StepInfo.Text).Pass("");
            }
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            _extentReports.Flush();
        }


        //excel report

        [AfterScenario]

        public static void ExlReport()
        {



            string File_Name = " ";
            
           
            int row_count = 2 ;


            //

            //if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart logo ."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 3;

            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Search Bar."))
            //{
            //    File_Name = "Excel_REPORT";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 4;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart My profile section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 5 ;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Supercoin Zone section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 6;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Plus Zone section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 7;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart orders section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 8;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart wishlists section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 9;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart My chats section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 10;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Coupons section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 11;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Gift Cards section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 12;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Notifications section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 13;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Logout section under Login dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 14;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Become a seller section in right-top of home page."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 15;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Notifications Preferences section under More dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 16;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart 24*7 Customer Care section under More dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 17;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Advertise section under More dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 18;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Download app section under More dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 19;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Cart section in right-top of home page."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 20;
            //}

            //else if (ScenarioContext.Current.ScenarioInfo.Title.Contains("To check the Flipkart Notifications Preferences section under More dropdown."))
            //{
            //    File_Name = "Excel_Report";
            //    col_Number = 3;
            //    sheet_ = 1;
            //    row_count = 21;
            //}


            if (ScenarioContext.Current.TestError == null)
            {   
                  File_Name = "Excel_REPORT";
                string _msg = "Test passed successfully.";
                string _res = "PASS";
                string senarioname = ScenarioContext.Current.ScenarioInfo.Title;
                WriteResult.writeResultToExcel(senarioname, _res, _msg, row_count, File_Name);


            }
            else if (ScenarioContext.Current.TestError != null)
            {
                File_Name = "Excel_REPORT";
                string _msg = ScenarioContext.Current.TestError.Message;
                string _res = "FAIL";
                string senarioname = ScenarioContext.Current.ScenarioInfo.Title;
                WriteResult.writeResultToExcel(senarioname, _res, _msg, row_count, File_Name);
            }
             row_count = row_count + 1;


            //driver.Close();
            //driver.Quit();

        }


        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
            driver.Quit();


        }
    }
}
