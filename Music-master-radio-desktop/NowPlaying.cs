using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_master_radio_desktop
{
    static class NowPlaying
    {
        public static async Task<string> GetRadioPlayingAsync(string url)
        {
            Debug.WriteLine("URL: " + url);
            return await Task.Run(() =>
            {
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;

                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                options.AddArgument("--window-size=800,800");

                IWebDriver driver = new ChromeDriver(chromeDriverService, options);
                string text = "noplaying: notworking";
                try
                {
                    driver.Navigate().GoToUrl(url);
                    if (url == "http://100p.nl")
                    {
                        text = driver.FindElement(By.ClassName("artist")).Text;
                    }
                    else if (url == "https://www.skyradio.nl/")
                    {
                        string s3 = driver.FindElement(By.ClassName("ot-bnr-save-handler")).Text;
                        driver.FindElement(By.ClassName("ot-bnr-save-handler")).Click();
                        driver.FindElement(By.Id("icon-close")).Click();
                        string title = "not";
                        string subtitle = "working";
                        try
                        {
                            title = driver.FindElement(By.XPath("//div[contains(@class, 'n-title')]")).Text;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("title is the issue: " + ex.Message);
                        }
                        try
                        {
                            subtitle = driver.FindElement(By.XPath("//div[contains(@class, 'n-subTitle')]")).Text;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("subtitle is the issue: " + ex.Message);
                        }

                        text = title + " - " + subtitle;
                    }
                    else if (url == "https://www.radio10.nl/")
                    {
                        driver.FindElement(By.ClassName("ot-bnr-save-handler")).Click();
                        try
                        {
                            driver.FindElement(By.ClassName("p-paragraph-0-2-340 p-root-0-2-318 p-colorDark-0-2-397")).Click();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }
                        string title = "not";
                        string subtitle = "working";
                        try
                        {
                            title = driver.FindElement(By.XPath("//div[contains(@class, 'n-title')]")).Text;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("title is the issue: " + ex.Message);
                        }
                        try
                        {
                            subtitle = driver.FindElement(By.XPath("//div[contains(@class, 'n-subTitle')]")).Text;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("subtitle is the issue: " + ex.Message);
                        }

                        text = title + " - " + subtitle;
                    }
                    else if (url == "https://www.radio-nederland.nl/radio-rijnmond")
                    {
                        string title = "not";
                        string subtitle = "working";
                        try
                        {
                            title = driver.FindElement(By.ClassName("song-name")).Text;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("title is the issue: " + ex.Message);
                        }
                        try
                        {
                            subtitle = driver.FindElement(By.ClassName("artist-name")).Text;
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("subtitle is the issue: " + ex.Message);
                        }

                        text = title + " - " + subtitle;
                    }
                    else
                    {
                        text = "N/A";
                    }

                    System.Diagnostics.Debug.WriteLine(text);
                }
                catch (NoSuchElementException nex)
                {
                    text = "noplaying: no artist element found";
                    System.Diagnostics.Debug.WriteLine(nex);
                }
                catch (WebDriverException wex)
                {
                    text = "noplaying: web driver exception occurred";
                    System.Diagnostics.Debug.WriteLine(wex);
                }
                finally
                {
                    driver.Quit();
                }
                return text;
            });
        }
    }
}
