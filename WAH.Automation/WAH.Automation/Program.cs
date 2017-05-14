using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using System.IO;
using WAH.Common.Objects;
using WAH.Common.Utils;

namespace WAH.Automation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var filePath = "Config.json";
            var jsonStr = File.ReadAllText(filePath);
            var config = JsonConvert.DeserializeObject<Config>(jsonStr);
            var driver = new ChromeDriver();

            SeleniumUtils.Register(driver, config);
        }
    }
}