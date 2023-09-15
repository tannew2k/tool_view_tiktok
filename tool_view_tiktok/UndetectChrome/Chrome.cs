
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using OpenQA.Selenium;


namespace tool_view_tiktok.UndetectChrome
{
    public class Chrome 
    {
        public static List<int> listPossitionApp = new List<int>();

        
        public IWebDriver CreateChorme(int indexPos, string driverExecutablePath, string browserExecutablePath, string debuggerAddress)
        {
            Point local = Helper.GetPointFromIndexPosition(indexPos);
            Form1.Column = (int)Math.Round((decimal)(Helper.getWidthScreen / Form1.windowWidth));
            Form1.Row = (int)Math.Round((decimal)(Helper.getHeightScreen / Form1.windowHeight));
            
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            chromeOptions.AddArguments("--headless");
            chromeOptions.AddArgument("--enable-logging");
            chromeOptions.AddArgument("--window-size=" + Form1.windowWidth + "," + Form1.windowHeight);
            chromeOptions.AddArgument("--window-position=" + local.X + "," + local.Y);
            chromeOptions.BinaryLocation = browserExecutablePath;
            chromeOptions.DebuggerAddress = debuggerAddress;
            
            var chromeService = ChromeDriverService.CreateDefaultService(driverExecutablePath);
            chromeService.HideCommandPromptWindow = true;
            
            var chrome = new ChromeDriver(chromeService, chromeOptions);
            
            return chrome;
        }
        
        public int GetIndexOfPossitionApp(ref List<int> listPossitionApp)
        {
            int indexPos = 0;
            lock (listPossitionApp)
            {
                for (int i = 0; i < listPossitionApp.Count; i++)
                {
                    if (listPossitionApp[i] == 0)
                    {
                        indexPos = i;
                        listPossitionApp[i] = 1;
                        break;
                    }
                }
            }

            return indexPos;
        }

        public void FillIndexPossition(int indexPos, ref List<int> listPossitionApp)
        {
            lock (listPossitionApp)
            {
                listPossitionApp[indexPos] = 0;
            }
        }
    }
}