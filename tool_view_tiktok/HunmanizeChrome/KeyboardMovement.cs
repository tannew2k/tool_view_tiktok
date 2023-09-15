using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using tool_view_tiktok.HunmanizeChrome.Base;


namespace tool_view_tiktok.HunmanizeChrome
{
    public class KeyboardMovement : BaseModel
    {
        public KeyboardMovement(ref IWebDriver driver, ref Random random) : base(ref driver, ref random) { }

        /// <summary>
        /// Types like a human (with errors)
        /// </summary>
        /// <param name="text">The text we want to write</param>
        /// <param name="from">The speed from</param>
        /// <param name="to">The speed to</param>
        public void Type(string text, int from = 150, int to = 230)
        {
            foreach (var c in text)
            {
                Thread.Sleep(Rnd.Next(from, to));

                Actions action = new Actions(Driver);
                action.SendKeys(c.ToString()).Perform();
            }
        }
    }
}