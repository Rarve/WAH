using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WAH.Common.Objects;

namespace WAH.Common.Utils
{
    public static class SeleniumUtils
    {
        public static object ExpectedConditions { get; private set; }

        public static void Register(IWebDriver driver, Config config)
        {
            var timeout = 60;
            driver.Url = config.URL;
            var btn1 = SeleniumUtils.FindElement(driver, By.XPath("//*[@id='table-query']/tbody/tr[2]/td[7]/input"), timeout);
            btn1.Click();

            SubmitID(driver, config, timeout);

            //var txtPaReq = SeleniumUtils.FindElement(driver, By.Name("PaReq"), timeout);
            //var urlPost = SeleniumUtils.FindElement(driver, By.Id("postUrl"), timeout);
            //var btnSubmit = SeleniumUtils.FindElement(driver, By.XPath("//input[@type='submit']"), timeout);

            //urlPost.Clear();
            //txtMD.Clear();
            //txtPaReq.Clear();

            //txtMD.SendKeys(obj.Post3DFields[0]?.Value);
            //txtPaReq.SendKeys(obj.Post3DFields[1]?.Value);

            //btnSubmit.Submit();

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until(ExpectedConditions.ElementIsVisible(By.TagName("body")));

            //var txtPwd = SeleniumUtils.FindElement(driver, By.Name("external.field.password"), timeout);
            //var btn3DSubmit = SeleniumUtils.FindElement(driver, By.Name("UsernamePasswordEntry"), timeout);

            //txtPwd.Clear();
            //txtPwd.SendKeys("111");
        }

        public static void SubmitID(IWebDriver driver, Config config, int timeout)
        {
            var Ids = config.ID.ToCharArray();
            var txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_1"), timeout);
            txtId.SendKeys(Ids[0].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_2"), timeout);
            txtId.SendKeys(Ids[1].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_3"), timeout);
            txtId.SendKeys(Ids[2].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_4"), timeout);
            txtId.SendKeys(Ids[3].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_5"), timeout);
            txtId.SendKeys(Ids[4].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_6"), timeout);
            txtId.SendKeys(Ids[5].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_7"), timeout);
            txtId.SendKeys(Ids[6].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_8"), timeout);
            txtId.SendKeys(Ids[7].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_9"), timeout);
            txtId.SendKeys(Ids[8].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_10"), timeout);
            txtId.SendKeys(Ids[9].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_11"), timeout);
            txtId.SendKeys(Ids[10].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_12"), timeout);
            txtId.SendKeys(Ids[11].ToString());
            txtId = SeleniumUtils.FindElement(driver, By.Name("person_id_card_13"), timeout);
            txtId.SendKeys(Ids[12].ToString());
        }

        internal static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }
}