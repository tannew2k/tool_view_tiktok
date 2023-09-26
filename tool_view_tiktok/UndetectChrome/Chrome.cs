
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

        
        public IWebDriver CreateChrome(int indexPos, string driverExecutablePath, string browserExecutablePath, string debuggerAddress)
        {
            try
            {
                Point local = Helper.GetPointFromIndexPosition(indexPos);
                Form1.Column = (int)Math.Round((decimal)(Helper.getWidthScreen / Form1.windowWidth));
                Form1.Row = (int)Math.Round((decimal)(Helper.getHeightScreen / Form1.windowHeight));
            
                var chromeOptions = new ChromeOptions();
                chromeOptions.BinaryLocation = browserExecutablePath;
                chromeOptions.DebuggerAddress = debuggerAddress;
                
                var chromeService = ChromeDriverService.CreateDefaultService(driverExecutablePath);
                chromeService.HideCommandPromptWindow = true;
            
                var chrome = new ChromeDriver(chromeService, chromeOptions, TimeSpan.FromMinutes(5));
                chrome.Manage().Window.Size = new Size(Form1.windowWidth, Form1.windowHeight);
                chrome.Manage().Window.Position = new Point(local.X, local.Y);
                chrome.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(5));
            
                return chrome;
            }
            catch (Exception e)
            {
                throw e;
            }
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