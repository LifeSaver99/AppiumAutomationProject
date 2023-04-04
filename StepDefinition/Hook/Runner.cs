using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
using AppiumAutomationForDesktopAndMobile.Framewrok.Variables;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using OpenQA.Selenium.Appium.Service;
using RazorEngine.Configuration;
using SpecFlow.Internal.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BoDi;


namespace AppiumAutomationForDesktopAndMobile.StepDefinition.Hook
{
    [Binding]
    public class Runner
    {
        IObjectContainer _objectContainer;
        DriverManager _driverManager;
        static string reportPath = System.IO.Directory.GetParent(@"../../../").FullName
             + Path.DirectorySeparatorChar + "Report"
             + Path.DirectorySeparatorChar + "Report" + DateTime.Now.ToString("ddMMyyyy HHmmss");
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest feature;
        AventStack.ExtentReports.ExtentTest scenario, steps;
        public static ConfigSettings config;
        static string configSettingsPath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "FrameWork/Configuration/appsettings.json";


        public Runner(IObjectContainer objectContainer, DriverManager driverManager)
        {
            _objectContainer = objectContainer;
            _driverManager = driverManager;

        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            config = new ConfigSettings();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configSettingsPath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);

            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(reportPath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReport);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            scenario = extent.CreateTest(context.ScenarioInfo.Title);
            _driverManager.LaunchApp();
            _driverManager.TimeOut(TimeSpan.FromSeconds(30));
        }

        [BeforeStep]
        public void BeforeTest()
        {
            steps = scenario;
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {

            if (context.TestError == null)
            {
                steps.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {
                steps.Log(Status.Fail, context.StepContext.StepInfo.Text);
                string screenShot = _driverManager.Driver_Mobile.GetScreenshot().AsBase64EncodedString;
                steps.AddScreenCaptureFromBase64String(screenShot);
                string escapedStepName = Uri.EscapeDataString(context.StepContext.StepInfo.Text);
                _driverManager.TakeScreenshot(escapedStepName);
            }

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }

        [AfterScenario]
        public void AfterScenario()
        {

            _driverManager.Quit();
        }
    }
}
