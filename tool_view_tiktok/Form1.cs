using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterDevs.ChromeDevTools;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PagedList;
using SeleniumExtras.WaitHelpers;
using tool_view_tiktok.UndetectChrome;
using Helper = tool_view_tiktok.UndetectChrome.Helper;
using Keys = OpenQA.Selenium.Keys;

namespace tool_view_tiktok
{
    public partial class Form1 : Form
    {
        private IPagedList<JToken> _listProfile;
        private int _numberThread;
        private bool _isHeaderCheckBoxClicked;
        private static int _pageNumber = 1;
        private static int _timeStart;
        private static int _timeEnd;
        private static bool _start = true;
        private static string _pathFileSearchKeywords = string.Empty;
        private static string _pathFileCommentKeywords = string.Empty;
        private static readonly List<string> ListCommentKeywords = new List<string>();
        private static readonly List<string> ListSearchKeywords = new List<string>();

        public static int delayAction;
        public static int windowWidth;
        public static int windowHeight;
        public static int column;
        public static int row;

        internal CheckBox headerCheckBoxAction;
        internal Button openProfile = null;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            // Screen[] screens = Screen.AllScreens;
            // if (screens.Length == 2)
            // {
            //     Screen primaryScreen = screens[0];
            //     Screen secondScreen = screens[1];
            //     Helper.getWidthScreen = Screen.PrimaryScreen.Bounds.Height;
            //     Helper.getWidthScreen = primaryScreen.Bounds.Width + secondScreen.Bounds.Width;   
            // }
            // else
            // {
                Helper.getWidthScreen = Screen.PrimaryScreen.Bounds.Height;
                Helper.getWidthScreen = Screen.PrimaryScreen.Bounds.Width;   
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBoxAction();
            headerCheckBoxAction.MouseClick += HeaderCheckBoxAction_MouseClick;
            LoadProfiles();
        }

        public void AddHeaderCheckBoxAction()
        {
            headerCheckBoxAction = new CheckBox();
            var rect = dataGridViewProfie.GetCellDisplayRectangle(0, -1, true);
            rect.Y = 8;
            rect.X = 20;
            headerCheckBoxAction.Name = "HeaderCheckBoxAction";
            headerCheckBoxAction.Size = new Size(15, 15);
            headerCheckBoxAction.Location = rect.Location;
            dataGridViewProfie.Columns[0].Frozen = true;
            dataGridViewProfie.Controls.Add(headerCheckBoxAction);
        }

        private void HeaderCheckBoxAction_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxActionClick((CheckBox)sender);
        }

        public void HeaderCheckBoxActionClick(CheckBox checkBox)
        {
            _isHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow row in dataGridViewProfie.Rows)
                ((DataGridViewCheckBoxCell)row.Cells[0]).Value = checkBox.Checked;
            dataGridViewProfie.RefreshEdit();
            _isHeaderCheckBoxClicked = false;
        }

        public bool CheckSetting()
        {
            if ((int)numericUpDownWindowWidth.Value > 0 &&
                (int)numericUpDownWindowHeight.Value > 0 &&
                (int)numericUpDownNumberThersas.Value > 0 &&
                (int)numericUpDownDelayAction.Value > 0 &&
                (int)numericUpDownStartTime.Value > 0 &&
                (int)numericUpDownStartTime.Value <= (int)numericUpDownEndTime.Value &&
                dataGridViewProfie.Rows != null &&
                dataGridViewProfie.Rows.Count > 0 &&
                ListSearchKeywords.Count > 0 &&
                ListCommentKeywords.Count > 0)
            {
                delayAction = (int)numericUpDownDelayAction.Value;
                windowWidth = (int)numericUpDownWindowWidth.Value;
                windowHeight = (int)numericUpDownWindowHeight.Value;
                _numberThread = (int)numericUpDownNumberThersas.Value;
                _timeStart = (int)numericUpDownStartTime.Value;
                _timeEnd = (int)numericUpDownEndTime.Value;
                return true;
            }

            return false;
        }

        public async void LoadProfiles()
        {
            _listProfile = await GetPageLisAsync();
            if (_listProfile != null && _listProfile.Count > 0)
            {
                buttonPrevious.Enabled = _listProfile.HasPreviousPage;
                buttonNext.Enabled = _listProfile.HasNextPage;
                LoadProfileToGrid(_listProfile.ToList());
                IblPageNumber.Text = string.Format("Page {0}/{1}", _pageNumber, _listProfile.PageCount);
            }
            else
            {
                MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public async Task<IPagedList<JToken>> GetPageLisAsync(int page = 1, int pageSize = 50)
        {
            return await Task.Factory.StartNew(() =>
            {
                try
                {
                    var listProfile = ApiOmniLogin.ApiOmniLogin.GetProfileOmniLogin("asc").Result;
                    if (listProfile != null && listProfile.Type != JTokenType.Null)
                        return listProfile.ToPagedList(page, pageSize);
                    return null;
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }

        public void ActionViewTiktok(string id, string driverExecutablePath, string browserExecutablePath,
            string debuggerAddress)
        {
            var randomTime = new Random();
            var chrome = new Chrome();

            int runTime = 0;
            int indexPos = chrome.GetIndexOfPossitionApp(ref Chrome.listPossitionApp);
            IWebDriver webDriver =
                chrome.CreateChrome(indexPos, driverExecutablePath, browserExecutablePath, debuggerAddress);

            try
            {
                runTime = randomTime.Next(_timeStart, _timeEnd);
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)webDriver;


                dataGridViewProfie.Invoke(new Action(() =>
                {
                    var row = dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                        .Where(x => x.Cells["ID"].Value.ToString() == id).First();
                    row.Cells[5].Value = "Start";
                }));

                var actions = new Actions(webDriver);
                var wait = new WebDriverWait(webDriver, TimeSpan.FromMinutes(delayAction));

                webDriver.Navigate().GoToUrl("https://www.tiktok.com/");
                chrome.FillIndexPossition(indexPos, ref Chrome.listPossitionApp);
                webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
                webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);

                var end = DateTime.Now.AddMinutes(runTime);

                if (wait.Until(e =>
                            e.FindElements(
                                By.XPath(
                                    "//div[@data-e2e=\"recommend-list-item-container\"]")))
                        .Count > 0)
                {
                    if (wait.Until(e =>
                                e.FindElements(
                                    By.XPath(
                                        "//div[@id=\"app\"]//div[div[contains(text(),'Introducing keyboard shortcuts!')]]/div")))
                            .Count > 0)
                    {
                        var closeIntroducingKeyboard = wait.Until(ExpectedConditions.ElementIsVisible(
                            By.XPath(
                                "//div[@id=\"app\"]//div[div[contains(text(),'Introducing keyboard shortcuts!')]]/div")));
                        actions.Click(closeIntroducingKeyboard).Perform();
                    }

                    var count = 0;
                    var countView = 0;
                    var countLike = 0;
                    var countComment = 0;
                    var countFollow = 0;
                    //var countShare = 0;

                    while (end.Subtract(DateTime.Now).Seconds > 0)
                    {
                        var randomViewVideo = new Random();
                        var randomVideo = randomViewVideo.Next(0, 100);
                        if (count > 0)
                        {
                            if (wait.Until(e =>
                                        e.FindElements(
                                            By.XPath($"//div[@data-e2e=\"recommend-list-item-container\"][{count}]")))
                                    .Count > 0)
                            {
                                if (wait.Until(e =>
                                            e.FindElements(
                                                By.XPath(
                                                    $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//div[div[div[@role=\"slider\"]]]")))
                                        .Count > 0 && randomVideo <= 30)
                                {
                                    string result = ActionViewVideoLong(webDriver, actions, jsExecutor, wait, countView,
                                        countLike, countComment, countFollow, count, id, chrome, indexPos);
                                    if (result != "")
                                    {
                                        countView = int.Parse(result.Split('|')[0]);
                                        countLike = int.Parse(result.Split('|')[1]);
                                        countComment = int.Parse(result.Split('|')[2]);
                                        countFollow = int.Parse(result.Split('|')[3]);
                                    }
                                }
                                else if (randomVideo <= 30)
                                {
                                    string result = ActionViewVideoShort(webDriver, actions, jsExecutor, wait,
                                        countView, countLike, countComment, countFollow, count, id, chrome, indexPos);
                                    if (result != "")
                                    {
                                        countView = int.Parse(result.Split('|')[0]);
                                        countLike = int.Parse(result.Split('|')[1]);
                                        countComment = int.Parse(result.Split('|')[2]);
                                        countFollow = int.Parse(result.Split('|')[3]);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (wait.Until(e =>
                                        e.FindElements(By.XPath("//div[@data-e2e=\"recommend-list-item-container\"]")))
                                    .Count() > 0)
                            {
                                if (wait.Until(e =>
                                            e.FindElements(By.XPath(
                                                "//div[@data-e2e=\"recommend-list-item-container\"]//div[div[div[@role=\"slider\"]]]")))
                                        .Count > 0 && randomVideo <= 30)
                                {
                                    string result = ActionViewVideoLong(webDriver, actions, jsExecutor, wait, countView,
                                        countLike, countComment, countFollow, count, id, chrome, indexPos);
                                    if (result != "")
                                    {
                                        countView = int.Parse(result.Split('|')[0]);
                                        countLike = int.Parse(result.Split('|')[1]);
                                        countComment = int.Parse(result.Split('|')[2]);
                                        countFollow = int.Parse(result.Split('|')[3]);
                                    }
                                }
                                else if (randomVideo <= 30)
                                {
                                    string result = ActionViewVideoShort(webDriver, actions, jsExecutor, wait,
                                        countView, countLike, countComment, countFollow, count, id, chrome, indexPos);
                                    if (result != "")
                                    {
                                        countView = int.Parse(result.Split('|')[0]);
                                        countLike = int.Parse(result.Split('|')[1]);
                                        countComment = int.Parse(result.Split('|')[2]);
                                        countFollow = int.Parse(result.Split('|')[3]);
                                    }
                                }
                            }
                        }

                        Thread.Sleep(3000);
                        actions.KeyDown(Keys.ArrowDown).Perform();
                        webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                        count++;
                        Thread.Sleep(2000);
                    }
                }

                Thread.Sleep(3000);

                dataGridViewProfie.Invoke(new Action(() =>
                {
                    var row = dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                        .Where(x => x.Cells["ID"].Value.ToString() == id).First();
                    row.Cells[0].Value = false;
                    row.Cells[5].Value = "Done";
                }));

                webDriver.Manage().Network.ClearRequestHandlers();
                webDriver.Manage().Network.ClearResponseHandlers();
                Chrome.listPossitionApp.Remove(indexPos);
                webDriver.Close();
                webDriver.Quit();
            }
            catch (Exception exception)
            {
                webDriver.Manage().Network.ClearRequestHandlers();
                webDriver.Manage().Network.ClearResponseHandlers();
                dataGridViewProfie.Invoke(new Action(() =>
                {
                    var row = dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                        .Where(x => x.Cells["ID"].Value.ToString() == id).First();
                    row.Cells[0].Value = false;
                    row.Cells[5].Value = "Error";
                }));
                Console.WriteLine(exception.ToString());
                Chrome.listPossitionApp.Remove(indexPos);
                webDriver.Close();
                webDriver.Quit();
            }
        }

        public string ActionViewVideoShort(IWebDriver webDriver, Actions actions, IJavaScriptExecutor jsExecutor,
            WebDriverWait wait, int countView, int countLike, int countComment, int countFollow, int count, string id,
            Chrome chrome, int indexPos)
        {
            try
            {
                var randomLikeVideo = new Random();
                var randomLike = randomLikeVideo.Next(0, 100);
                var randomCommentVideo = new Random();
                var randomComment = randomLikeVideo.Next(0, 100);
                var randomFollowVideo = new Random();
                var randomFollow = randomFollowVideo.Next(0, 100);

                Thread.Sleep(TimeSpan.FromSeconds(30));
                countView++;

                if (randomLike <= 80)
                {
                    actions.SendKeys("l").Perform();
                    countLike++;
                }

                webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                Thread.Sleep(5000);

                if (randomLike <= 80 && randomComment <= 60 && randomFollow <= 20)
                {
                    IWebElement buttonFollow = null;
                    if (count > 0)
                    {
                        buttonFollow = wait.Until(ExpectedConditions.ElementToBeClickable(
                            By.XPath(
                                $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//button[@data-e2e=\"feed-follow\"]"))
                        );
                    }
                    else
                    {
                        buttonFollow = wait.Until(ExpectedConditions.ElementToBeClickable(
                            By.XPath(
                                "//div[@data-e2e=\"recommend-list-item-container\"]//button[@data-e2e=\"feed-follow\"]"))
                        );
                    }

                    actions.MoveToElement(buttonFollow)
                        .Click()
                        .Pause(TimeSpan.FromMilliseconds(3000))
                        .Perform();

                    countFollow++;
                }

                webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                Thread.Sleep(5000);

                if (randomLike <= 80 && randomComment <= 60)
                {
                    IWebElement comment = null;
                    var randomCommentLine = new Random();
                    var index = randomCommentLine.Next(ListCommentKeywords.Count);
                    string commentLine = ListCommentKeywords[index];

                    if (count > 0)
                    {
                        comment = wait.Until(ExpectedConditions.ElementIsVisible(
                            By.XPath(
                                $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//button[span[@data-e2e=\"comment-icon\"]]"))
                        );
                    }
                    else
                    {
                        comment = wait.Until(ExpectedConditions.ElementIsVisible(
                            By.XPath(
                                "//div[@data-e2e=\"recommend-list-item-container\"]//button[span[@data-e2e=\"comment-icon\"]]"))
                        );
                    }

                    jsExecutor.ExecuteScript("arguments[0].click();", comment);

                    Thread.Sleep(3000);

                    webDriver.Manage().Window.Size = new Size(1000, Form1.windowHeight);

                    var commentInput = wait.Until(ExpectedConditions.ElementIsVisible(
                        By.XPath("//div[@data-e2e=\"comment-text\"]"))
                    );
                    
                    actions.MoveToElement(commentInput)
                        .ClickAndHold()
                        .Pause(TimeSpan.FromMilliseconds(1000))
                        .Release()
                        .Pause(TimeSpan.FromMilliseconds(4000))
                        .SendKeys(commentLine)
                        .Pause(TimeSpan.FromMilliseconds(3000))
                        .SendKeys(Keys.Enter)
                        .Perform();

                    Thread.Sleep(3000);
                    var buttonClose = wait.Until(ExpectedConditions.ElementIsVisible(
                        By.XPath("//button[@aria-label=\"Close\"]"))
                    );

                    actions.MoveToElement(buttonClose)
                        .Click()
                        .Pause(TimeSpan.FromMilliseconds(3000))
                        .Perform();

                    countComment++;

                    Thread.Sleep(4000);
                    webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                    webDriver.Manage().Window.Size = new Size(Form1.windowWidth, Form1.windowHeight);
                    webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                }

                dataGridViewProfie.Invoke(new Action(() =>
                {
                    var row = dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                        .Where(x => x.Cells["ID"].Value.ToString() == id).First();
                    row.Cells[6].Value = countView.ToString();
                    row.Cells[7].Value = countLike.ToString();
                    row.Cells[8].Value = countFollow.ToString();
                    row.Cells[9].Value = countComment.ToString();
                }));

                return countView + "|" + countLike + "|" + countComment + "|" + countFollow;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return "";
        }

        public string ActionViewVideoLong(IWebDriver webDriver, Actions actions, IJavaScriptExecutor jsExecutor,
            WebDriverWait wait, int countView, int countLike, int countComment, int countFollow, int count, string id,
            Chrome chrome, int indexPos)
        {
            try
            {
                var randomLikeVideo = new Random();
                var randomLike = randomLikeVideo.Next(0, 100);
                var randomCommentVideo = new Random();
                var randomComment = randomLikeVideo.Next(0, 100);
                var randomFollowVideo = new Random();
                var randomFollow = randomFollowVideo.Next(0, 100);

                string sliderTimeVideo = null;
                IWebElement mouseSliderTimeVideo = null;

                if (count > 0)
                {
                    mouseSliderTimeVideo = wait.Until(ExpectedConditions.ElementIsVisible(
                        (By.XPath(
                                $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//div[div[div[@role=\"slider\"]]]"
                            )
                        )));
                    sliderTimeVideo = wait.Until(ExpectedConditions.ElementExists(
                        By.XPath(
                            $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//div[div[div[@role=\"slider\"]]]"
                        )
                    )).Text;
                }
                else
                {
                    mouseSliderTimeVideo = wait.Until(ExpectedConditions.ElementIsVisible(
                        (By.XPath(
                                "//div[@data-e2e=\"recommend-list-item-container\"]//div[div[div[@role=\"slider\"]]]"
                            )
                        )));
                    sliderTimeVideo = wait.Until(ExpectedConditions.ElementExists(
                        By.XPath(
                            "//div[@data-e2e=\"recommend-list-item-container\"]//div[div[div[@role=\"slider\"]]]"
                        )
                    )).Text;
                }

                actions.MoveToElement(mouseSliderTimeVideo)
                    .ClickAndHold()
                    .Pause(TimeSpan.FromMilliseconds(2000))
                    .Perform();

                string timeLine = sliderTimeVideo.Split('/')[1];
                int minute = Int32.Parse(timeLine.Split(':')[0]);
                int second = Int32.Parse(timeLine.Split(':')[1]);
                TimeSpan time = TimeSpan.FromMinutes(minute) + TimeSpan.FromSeconds(second);
                Thread.Sleep(TimeSpan.FromMinutes(time.TotalMinutes));

                countView++;

                if (randomLike <= 80)
                {
                    actions.SendKeys("l").Perform();
                    countLike++;
                }

                webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                Thread.Sleep(3000);

                if (randomLike <= 80 && randomComment <= 60 && randomFollow <= 20)
                {
                    IWebElement buttonFollow = null;
                    if (count > 0)
                    {
                        buttonFollow = wait.Until(ExpectedConditions.ElementToBeClickable(
                            By.XPath(
                                $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//button[@data-e2e=\"feed-follow\"]"))
                        );
                    }
                    else
                    {
                        buttonFollow = wait.Until(ExpectedConditions.ElementToBeClickable(
                            By.XPath(
                                "//div[@data-e2e=\"recommend-list-item-container\"]//button[@data-e2e=\"feed-follow\"]"))
                        );
                    }

                    actions.MoveToElement(buttonFollow)
                        .Click()
                        .Pause(TimeSpan.FromMilliseconds(3000))
                        .Perform();
                    
                    countFollow++;
                }

                webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                Thread.Sleep(3000);

                if (randomLike <= 80 && randomComment <= 60)
                {
                    IWebElement comment = null;
                    var randomCommentLine = new Random();
                    var index = randomCommentLine.Next(ListCommentKeywords.Count);
                    string commentLine = ListCommentKeywords[index];
                    if (count > 0)
                    {
                        comment = wait.Until(ExpectedConditions.ElementIsVisible(
                            By.XPath(
                                $"//div[@data-e2e=\"recommend-list-item-container\"][{count}]//button[span[@data-e2e=\"comment-icon\"]]"))
                        );
                    }
                    else
                    {
                        comment = wait.Until(ExpectedConditions.ElementIsVisible(
                            By.XPath(
                                $"//div[@data-e2e=\"recommend-list-item-container\"]//button[span[@data-e2e=\"comment-icon\"]]")));
                    }

                    jsExecutor.ExecuteScript("arguments[0].click();", comment);

                    Thread.Sleep(3000);

                    webDriver.Manage().Window.Size = new Size(1000, Form1.windowHeight);

                    var commentInput = wait.Until(ExpectedConditions.ElementIsVisible(
                        By.XPath("//div[@data-e2e=\"comment-text\"]"))
                    );

                    actions.MoveToElement(commentInput)
                        .ClickAndHold()
                        .Pause(TimeSpan.FromMilliseconds(1000))
                        .Release()
                        .Pause(TimeSpan.FromMilliseconds(3000))
                        .SendKeys(commentLine)
                        .Pause(TimeSpan.FromMilliseconds(2000))
                        .SendKeys(Keys.Enter)
                        .Perform();

                    Thread.Sleep(4000);
                    var buttonClose = wait.Until(ExpectedConditions.ElementIsVisible(
                        By.XPath("//button[@aria-label=\"Close\"]"))
                    );

                    actions.MoveToElement(buttonClose)
                        .Click()
                        .Pause(TimeSpan.FromMilliseconds(3000))
                        .Perform();

                    countComment++;

                    Thread.Sleep(4000);
                    webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                    webDriver.Manage().Window.Size = new Size(Form1.windowWidth, Form1.windowHeight);
                    webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(delayAction);
                }

                dataGridViewProfie.Invoke(new Action(() =>
                {
                    var row = dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                        .Where(x => x.Cells["ID"].Value.ToString() == id).First();
                    row.Cells[6].Value = countView.ToString();
                    row.Cells[7].Value = countLike.ToString();
                    row.Cells[8].Value = countFollow.ToString();
                    row.Cells[9].Value = countComment.ToString();
                }));
                
                return countView + "|" + countLike + "|" + countComment + "|" + countFollow;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return "";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (CheckSetting())
                    {
                        buttonResetProfile.Enabled = false;
                        buttonDetele.Enabled = false;
                        buttonNext.Enabled = false;
                        buttonPrevious.Enabled = false;
                        buttonExport.Enabled = false;
                        buttonOpenFileCommentKeywords.Enabled = false;
                        buttonOpenFileSearchKeywords.Enabled = false;
                        textBoxApiCaptcha.Enabled = false;

                        if (_start == false) _start = true;

                        var queueWordingProfile = new ConcurrentQueue<string>();

                        column = Helper.getWidthScreen / windowWidth;
                        row = Helper.getHeightScreen / windowHeight;

                        dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                            .Where(row => (bool?)row.Cells[0].Value == true)
                            .ToList()
                            .ForEach(row => { queueWordingProfile.Enqueue(row.Cells[1].Value.ToString()); });

                        while (_start)
                        {
                            var tasks = new List<Task>();

                            if (queueWordingProfile.Count > 0)
                            {
                                for (var j = 0; j < _numberThread; j++) Chrome.listPossitionApp.Add(0);

                                for (var i = 0; i < _numberThread; i++)
                                {
                                    var task = Task.Run(() =>
                                    {
                                        if (queueWordingProfile.TryDequeue(out var id))
                                        {
                                            lock (id)
                                            {
                                                try
                                                {
                                                    var profile = ApiOmniLogin.ApiOmniLogin
                                                        .OpenProfileOmniLogin(id)
                                                        .Result;
                                                    if (profile != null && profile.Type != JTokenType.Null)
                                                        ActionViewTiktok(
                                                            id,
                                                            profile["drive_location"].ToString(),
                                                            profile["browser_location"].ToString(),
                                                            profile["remote_debug_address"].ToString()
                                                        );
                                                    else
                                                        dataGridViewProfie.Invoke(new Action(() =>
                                                        {
                                                            var row = dataGridViewProfie.Rows
                                                                .Cast<DataGridViewRow>()
                                                                .Where(x => x.Cells["ID"].Value.ToString() ==
                                                                            id)
                                                                .First();
                                                            row.Cells[0].Value = false;
                                                            row.Cells[5].Value = "Error";
                                                        }));
                                                }
                                                catch (Exception exception)
                                                {
                                                    Console.WriteLine("Error " + exception.GetType().Name + ": " +
                                                                      exception.Message);
                                                    throw exception;
                                                }
                                            }
                                        }
                                    });
                                    tasks.Add(task);
                                    Thread.Sleep(2000);
                                }
                                Task.WaitAll(tasks.ToArray());
                            }
                            else
                            {
                                buttonResetProfile.Enabled = true;
                                buttonDetele.Enabled = true;
                                buttonNext.Enabled = true;
                                buttonPrevious.Enabled = true;
                                buttonExport.Enabled = true;
                                buttonOpenFileCommentKeywords.Enabled = true;
                                buttonOpenFileSearchKeywords.Enabled = true;
                                textBoxApiCaptcha.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception)
                {
                    var processesChrome = Process.GetProcessesByName("chromedriver");
                    foreach (var processChrome in processesChrome) processChrome.Kill();
                }
            });
        }

        public void LoadProfileToGrid(List<JToken> list)
        {
            Task.Run(() =>
            {
                try
                {
                    var listProfile = list.ToList();
                    if (listProfile != null)
                    {
                        foreach (var profile in listProfile)
                            if (profile != null && profile.Type != JTokenType.Null)
                                dataGridViewProfie.Invoke(new Action(() =>
                                {
                                    var proxy = "";
                                    if (profile["embedded_proxy"] != null &&
                                        profile["embedded_proxy"].Type != JTokenType.Null)
                                        proxy = profile["embedded_proxy"]["host"] + ":" +
                                                profile["embedded_proxy"]["port"];
                                    dataGridViewProfie.Rows.Add(false, profile["id"], profile["name"], proxy, null);
                                }));
                    }
                    else
                    {
                        MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }

        private void dataGridViewProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (e.ColumnIndex == dataGridViewProfie.Columns["Open"].Index && e.RowIndex >= 0)
                    {
                        var row = dataGridViewProfie.Rows[e.RowIndex];
                        var id = row.Cells[1].Value.ToString();
                        var profile = ApiOmniLogin.ApiOmniLogin.OpenProfileOmniLogin(id).Result;
                        if (profile == null)
                        {
                            row.Cells[5].Value = "Error";
                            MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                        }
                    }
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }

        private async void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pageNumber == 1)
                {
                    buttonPrevious.Enabled = false;
                    MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (_listProfile.HasPreviousPage)
                    {
                        _listProfile = await GetPageLisAsync(--_pageNumber);
                        buttonPrevious.Enabled = _listProfile.HasPreviousPage;
                        buttonNext.Enabled = _listProfile.HasNextPage;
                        dataGridViewProfie.Rows.Clear();
                        dataGridViewProfie.Refresh();
                        LoadProfileToGrid(_listProfile.ToList());
                        IblPageNumber.Text = string.Format("Page {0}/{1}", _pageNumber, _listProfile.PageCount);
                    }
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pageNumber == _listProfile.PageCount)
                {
                    buttonNext.Enabled = false;
                    MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (_listProfile.HasNextPage)
                    {
                        _listProfile = await GetPageLisAsync(++_pageNumber);
                        buttonPrevious.Enabled = _listProfile.HasPreviousPage;
                        buttonNext.Enabled = _listProfile.HasNextPage;
                        dataGridViewProfie.Rows.Clear();
                        dataGridViewProfie.Refresh();
                        LoadProfileToGrid(_listProfile.ToList());
                        IblPageNumber.Text = string.Format("Page {0}/{1}", _pageNumber, _listProfile.PageCount);
                    }
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    _start = false;
                    buttonStart.Enabled = false;
                    var processesChrome = Process.GetProcessesByName("chromedriver");
                    foreach (var processChrome in processesChrome) processChrome.Kill();
                    MessageBox.Show("Stop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    buttonStart.Enabled = true;
                    buttonResetProfile.Enabled = true;
                    buttonDetele.Enabled = true;
                    buttonExport.Enabled = true;
                    buttonPrevious.Enabled = true;
                    buttonNext.Enabled = true;
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }

        private void buttonResetProfile_Click(object sender, EventArgs e)
        {
            try
            {
                LoadProfiles();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void buttonOpenFileKeywords_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                        Task.Run(() =>
                        {
                            textBoxPathFileSearchKeywords.Invoke(new Action(() =>
                            {
                                _pathFileSearchKeywords = openFileDialog.FileName;
                                textBoxPathFileSearchKeywords.Text = _pathFileSearchKeywords;
                            }));

                            if (!File.ReadAllText(_pathFileSearchKeywords).Equals(""))
                            {
                                ListSearchKeywords.Clear();
                                foreach (var line in File.ReadLines(_pathFileSearchKeywords))
                                    ListSearchKeywords.Add(line);
                            }
                        });
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void buttonOpenFileCommentKeywords_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                        Task.Run(() =>
                        {
                            textBoxPathFileCommentKeywords.Invoke(new Action(() =>
                            {
                                _pathFileCommentKeywords = openFileDialog.FileName;
                                textBoxPathFileCommentKeywords.Text = _pathFileCommentKeywords;
                            }));

                            if (!File.ReadAllText(_pathFileSearchKeywords).Equals(""))
                            {
                                ListCommentKeywords.Clear();
                                foreach (var line in File.ReadLines(_pathFileCommentKeywords))
                                    ListCommentKeywords.Add(line);
                            }
                        });
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (dataGridViewProfie.Rows != null &&
                        dataGridViewProfie.Rows.Count > 0)
                        dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                            .ToList()
                            .ForEach(row => { });
                    else
                        MessageBox.Show("Stop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (dataGridViewProfie.Rows != null &&
                        dataGridViewProfie.Rows.Count > 0)
                        dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                            .Where(row => (bool?)row.Cells[0].Value == true)
                            .ToList()
                            .ForEach(row =>
                            {
                                dataGridViewProfie.Invoke(new Action(() =>
                                {
                                    dataGridViewProfie.Rows.Remove(row);
                                }));
                            });
                    else
                        MessageBox.Show("Stop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }
    }
}