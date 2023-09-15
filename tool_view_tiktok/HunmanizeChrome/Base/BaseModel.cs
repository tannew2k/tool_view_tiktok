using OpenQA.Selenium;
using System;

namespace tool_view_tiktok.HunmanizeChrome.Base
{
    public abstract class BaseModel
    {
        public IWebDriver Driver;
        public Random Rnd;

        public BaseModel(ref IWebDriver driver, ref Random random)
        {
            this.Driver = driver;
            this.Rnd = random;
        }
    }
}