using AppiumAutomationForDesktopAndMobile.Framewrok.Helpers;
//#using AppiumAutomationForDesktopAndMobile.Framewrok.Variables;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Castle.Core.Internal;
using Microsoft.Extensions.Configuration;
using TechTalk.SpecFlow;


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
        static string configSettingsPath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "FrameWork/Configuration/appsettings.json";
        static IConfigurationRoot _configuration;

        public Runner(IObjectContainer objectContainer, DriverManager driverManager)
        {
            _objectContainer = objectContainer;
            _driverManager = driverManager;

        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configSettingsPath);
            _configuration = builder.Build();
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
            _driverManager.Configuration = _configuration;
            string driverTag = context.ScenarioInfo.Tags.Find<string>(t => t.Contains("driver:"));
            _driverManager.LaunchApp(driverTag.Replace("driver:", ""));
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
