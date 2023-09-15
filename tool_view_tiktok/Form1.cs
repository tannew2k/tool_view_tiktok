using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using tool_view_tiktok.UndetectChrome;
using PagedList;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using tool_view_tiktok.HunmanizeChrome;
using Helper = tool_view_tiktok.UndetectChrome.Helper;


namespace tool_view_tiktok
{
    public partial class Form1 : Form
    {
        private IPagedList<JToken> listProfile;
        private static int pageNumber = 1;
        private int numberThereas = 0;
        private bool isHeaderCheckBoxCliked = false;
        private static bool start = true;
        
        public static int delayAction = 0;
        public static int windowWidth = 0;
        public static int windowHeight = 0;
        public static int Column = 0;
        public static int Row = 0;
        
        internal CheckBox headerCheckBoxAction = null;
        internal Button openProfile = null;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBoxAction();
            headerCheckBoxAction.MouseClick += HeaderCheckBoxAction_MouseClick;
            listProfile = await GetPageLisAsync();
            buttonPrevious.Enabled = listProfile.HasPreviousPage;
            buttonNext.Enabled = listProfile.HasNextPage;
            LoadProfileToGrid(listProfile.ToList());
            IblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, listProfile.PageCount);
        }
        
        public void AddHeaderCheckBoxAction()
        {
            headerCheckBoxAction = new CheckBox();
            Rectangle rect = dataGridViewProfie.GetCellDisplayRectangle(0, -1, true);
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

        public void HeaderCheckBoxActionClick(CheckBox HcheckBox)
        {
            isHeaderCheckBoxCliked = true;
            foreach (DataGridViewRow Row in dataGridViewProfie.Rows)
            {
                ((DataGridViewCheckBoxCell)Row.Cells[0]).Value = HcheckBox.Checked;
            }
            dataGridViewProfie.RefreshEdit();
            isHeaderCheckBoxCliked = false;
        }
        
        public bool CheckSetting()
        {
            if ((int)numericUpDownWindowWidth.Value > 0 && 
                (int)numericUpDownWindowHeight.Value > 0  &&
                (int)numericUpDownNumberThersas.Value > 0 &&
                (int)numericUpDownDelayAction.Value > 0)
            {
                delayAction = (int)numericUpDownDelayAction.Value;
                windowWidth = (int)numericUpDownWindowWidth.Value;
                windowHeight = (int)numericUpDownWindowHeight.Value;
                numberThereas = (int)numericUpDownNumberThersas.Value;

                return true;
            }
            return false;
        }
        
        public async Task<IPagedList<JToken>> GetPageLisAsync(int page = 1, int pageSize = 20)
        {
            return await Task.Factory.StartNew(() =>
            {
                try
                {
                    var listProfile = ApiOmniLogin.ApiOmniLogin.GetProfileOmniLogin("asc").Result;
                    if (listProfile != null && listProfile.Type != JTokenType.Null)
                    {
                        return listProfile.ToPagedList(page, pageSize);   
                    }
                    MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return null;
                    
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }

        public void ActionViewTiktok(string driverExecutablePath, string browserExecutablePath, string debuggerAddress)
        {
            Random random = new Random();
            Chrome chrome = new Chrome();

            int indexPos = chrome.GetIndexOfPossitionApp(ref Chrome.listPossitionApp);
            var webDriver = chrome.CreateChorme(indexPos, driverExecutablePath, browserExecutablePath, debuggerAddress);

            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(delayAction * 60));
                MouseMovement mouseMovement = new MouseMovement(ref webDriver, ref random);
                KeyboardMovement keyboardMovement = new KeyboardMovement(ref webDriver, ref random);
                
                webDriver.Navigate().GoToUrl("https://www.tiktok.com");
            }
            catch (Exception )
            {
                Chrome.listPossitionApp.Remove(indexPos);
                webDriver.Quit();
            }
        }
        
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    if (CheckSetting() == true)
                    {
                        ConcurrentQueue<string> queueWordingrofile = new ConcurrentQueue<string>();
                        Chrome chrome = new Chrome();
                        
                        Column = Helper.getWidthScreen / windowWidth;
                        Row = Helper.getHeightScreen / windowHeight;

                        if (start == false)
                        {
                            start = true;
                        }

                        while (start == true)
                        {
                            dataGridViewProfie.Rows.Cast<DataGridViewRow>()
                                .Where(row => (bool?)row.Cells[0].Value == true)
                                .ToList()
                                .ForEach(row =>
                                {
                                    queueWordingrofile.Enqueue(row.Cells[1].Value.ToString());
                                });

                            if (queueWordingrofile.Count > 0)
                            {
                                var tasks = new List<Task>();
                                
                                for (int j = 0; j <= numberThereas; j++)
                                {
                                    Chrome.listPossitionApp.Add(0);
                                }

                                for (int j = 0; j <= numberThereas; j++)
                                {
                                    Task task = new Task(() =>
                                    {
                                        if (queueWordingrofile.TryDequeue(out string id))
                                        {
                                            var profile = ApiOmniLogin.ApiOmniLogin.OpenProfileOmniLogin(id).Result;
                                        }
                                        
                                    });
                                    tasks.Add(task);
                                    Thread.Sleep(2000);
                                }
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
                    Process[] processesChrome = Process.GetProcessesByName("chromedriver");
                    foreach (Process processChrome in processesChrome)
                    {
                        processChrome.Kill();
                    }
                    throw new NotImplementedException();
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
                        {
                            if (profile != null && profile.Type != JTokenType.Null)
                            {
                                dataGridViewProfie.Invoke(new Action(() =>
                                {
                                    string proxy = "";
                                    if (profile["embedded_proxy"] != null && profile["embedded_proxy"].Type != JTokenType.Null)
                                    {
                                        proxy = profile["embedded_proxy"]["host"] + ":" + profile["embedded_proxy"]["port"];
                                    }
                                    dataGridViewProfie.Rows.Add(false, profile["id"], profile["name"], proxy, null);
                                }));
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
                    throw new NotImplementedException();
                }
            });
        }
        
        private void dataGridViewProfie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    DataGridViewRow row = dataGridViewProfie.Rows[e.RowIndex];
                    string id = row.Cells[1].Value.ToString();
                    var profile = ApiOmniLogin.ApiOmniLogin.OpenProfileOmniLogin(id).Result;
                    if (profile == null && profile.Type == JTokenType.Null)
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

        private async void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageNumber == 1)
                {
                    buttonPrevious.Enabled = false;
                    MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (listProfile.HasPreviousPage)
                    {
                        listProfile = await GetPageLisAsync(--pageNumber);
                        buttonPrevious.Enabled = listProfile.HasPreviousPage;
                        buttonNext.Enabled = listProfile.HasNextPage;
                        dataGridViewProfie.Rows.Clear();
                        dataGridViewProfie.Refresh();
                        LoadProfileToGrid(listProfile.ToList());
                        IblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, listProfile.PageCount);   
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
                if (pageNumber == listProfile.PageCount)
                {
                    buttonNext.Enabled = false;
                    MessageBox.Show("Please try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    if (listProfile.HasNextPage)
                    {
                        listProfile = await GetPageLisAsync(++pageNumber);
                        buttonPrevious.Enabled = listProfile.HasPreviousPage;
                        buttonNext.Enabled = listProfile.HasNextPage;
                        dataGridViewProfie.Rows.Clear();
                        dataGridViewProfie.Refresh();
                        LoadProfileToGrid(listProfile.ToList());
                        IblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, listProfile.PageCount);
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
                    start = false;
                    MessageBox.Show("Stop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception)
                {
                    throw new NotImplementedException();
                }
            });
        }
        
        private async void buttonResetProfile_Click(object sender, EventArgs e)
        {
            try
            {
                listProfile = await GetPageLisAsync();
                buttonPrevious.Enabled = listProfile.HasPreviousPage;
                buttonNext.Enabled = listProfile.HasNextPage;
                dataGridViewProfie.Rows.Clear();
                dataGridViewProfie.Refresh();
                LoadProfileToGrid(listProfile.ToList());
                pageNumber = 1;
                IblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, listProfile.PageCount);
            }
            catch (Exception)
            {
                throw new NotImplementedException();     
            }
        }
    }
}