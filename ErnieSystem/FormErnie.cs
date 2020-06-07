using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace ErnieSystem
{
    public partial class FormErnie : Form
    {
#region DllImport
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        public static extern Int32 ShowWindow(Int32 hwnd, Int32 nCmdShow);
        public const Int32 SW_SHOW = 5; public const Int32 SW_HIDE = 0;

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        private static extern Int32 SystemParametersInfo(Int32 uAction, Int32 uParam, ref Rectangle lpvParam, Int32 fuWinIni);
        public const Int32 SPIF_UPDATEINIFILE = 0x1;
        public const Int32 SPI_SETWORKAREA = 47;
        public const Int32 SPI_GETWORKAREA = 48;

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern Int32 FindWindow(string lpClassName, string lpWindowName);
#endregion

#region Fields
        Boolean m_IsFullScreen = true;//标记是否全屏
        private int specialPrice = 0;
        private int firstPrice = 0;
        private int secondPrice = 0;
        private int thirdPrice = 0;
        private ArrayList arrNames = new ArrayList();
        private Thread m_thrdStartErnie = null;
        private bool m_bStartOrEndErnie = false;
        private ArrayList m_arrThirdPrice = new ArrayList();
        private ArrayList m_arrSecondPrice = new ArrayList();
        private ArrayList m_arrFirstPrice = new ArrayList();
        private ArrayList m_arrSpecialPrice = new ArrayList();
        private IniFileHelper m_iniFileHelper;
        private string strBackgroundImg = "";
        private int showNum = 1;

#endregion

#region Methods
        public FormErnie()
        {
            InitializeComponent();
        }

        private void FormErnie_Load(object sender, EventArgs e)
        {
            if (strBackgroundImg != "")
            {
                Image img = Image.FromFile(strBackgroundImg);
                this.BackgroundImage = img;
            }
            string strPath = System.Environment.CurrentDirectory;
            m_iniFileHelper = new IniFileHelper(strPath + "\\config.ini");
            string strTitle = m_iniFileHelper.Read("System", "MainFormTitle");

            labelX3.Text = strTitle + "\r\n(按回车键开始)";
            labelX1.Text = "特等奖：" + this.specialPrice.ToString() + "名, " + "一等奖：" + this.firstPrice.ToString() + "名, " +
                                   "二等奖：" + this.secondPrice.ToString() + "名, " + "三等奖：" + this.thirdPrice.ToString() + "名";
            this.Text = strTitle;

            this.SuspendLayout();
            if (m_IsFullScreen)//全屏 ,按特定的顺序执行
            {
                SetFormFullScreen(m_IsFullScreen);
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.Activate();//
            }
            else//还原，按特定的顺序执行——窗体状态，窗体边框，设置任务栏和工作区域
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                SetFormFullScreen(m_IsFullScreen);
                this.Activate();
            }
            this.ResumeLayout(false);

            m_thrdStartErnie = new Thread(new ThreadStart(StartErnie));
            m_thrdStartErnie.Start();
        }

        public Boolean SetFormFullScreen(Boolean fullscreen)//, ref Rectangle rectOld
        {
            Rectangle rectOld = Rectangle.Empty;
            Int32 hwnd = 0;
            hwnd = FindWindow("Shell_TrayWnd", null);//获取任务栏的句柄

            if (hwnd == 0) return false;

            if (fullscreen)//全屏
            {
                ShowWindow(hwnd, SW_HIDE);//隐藏任务栏

                SystemParametersInfo(SPI_GETWORKAREA, 0, ref rectOld, SPIF_UPDATEINIFILE);//get  屏幕范围
                Rectangle rectFull = Screen.PrimaryScreen.Bounds;//全屏范围
                SystemParametersInfo(SPI_SETWORKAREA, 0, ref rectFull, SPIF_UPDATEINIFILE);//窗体全屏幕显示
            }
            else//还原 
            {
                ShowWindow(hwnd, SW_SHOW);//显示任务栏

                SystemParametersInfo(SPI_SETWORKAREA, 0, ref rectOld, SPIF_UPDATEINIFILE);//窗体还原
            }
            return true;
        }

        private void FormErnie_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: //按ESC键，结束摇奖线程，恢复窗口并关闭
                    if (m_bStartOrEndErnie)
                    {
                        //安全结束线程
                        m_bStartOrEndErnie = false;
                        Thread.Sleep(50);
                        m_thrdStartErnie.Abort();
                        m_thrdStartErnie = null;
                    }
                    e.Handled = true;
                    this.WindowState = FormWindowState.Normal;//还原  
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    SetFormFullScreen(false);
                    this.Close();
                    break;

                case Keys.Enter: //设置摇奖开始和停止开关量
                    //在这里处理摇奖动作
                    m_bStartOrEndErnie = !m_bStartOrEndErnie;
                    break;
            }
        }

        public delegate void label_delegate(string str);

        public void setLabelX3Text(string str)
        {
            if (this.InvokeRequired)
            {
                label_delegate dt = new label_delegate(setLabelX3Text);
                labelX3.Invoke(dt, new object[] { str });
            }
            else
            {
                labelX3.Text = str;
            }
        }

        public void setLabelX1Text(string str)
        {
            if (this.InvokeRequired)
            {
                label_delegate dt = new label_delegate(setLabelX1Text);
                labelX1.Invoke(dt, new object[] { str });
            }
            else
            {
                labelX1.Text = str;
            }
        }

        /// <summary>
        /// 开始摇奖函数
        /// </summary>
        /// <returns></returns>
        private void StartErnie()
        {
            Random ra = new Random(); //随机数对象

            while (true)
            {
                if (m_bStartOrEndErnie)
                {
                    int nRemeber = 0;
                    int nPos = 0;

                    int i;
                    for (i = 0; i < arrNames.Count; i++)
                    {
                        string strTemp = null;
                        int nShowNum = ShowNum;
                        while (nShowNum > 0)
                        {                        
                            nShowNum--;
                            nPos = ra.Next(arrNames.Count);
                            strTemp += arrNames[nPos].ToString() + "\r\n";
                        }

                        setLabelX3Text(strTemp);
                        Thread.Sleep(20);

                        if (!m_bStartOrEndErnie)
                        {
                            nRemeber = i;
                            setLabelX3Text(arrNames[nRemeber].ToString());
                            break;
                        }
                    }
                    if (i >= arrNames.Count)
                    {
                        continue;
                    }

                    if (thirdPrice > 0)
                    {
                        thirdPrice--;
                        m_arrThirdPrice.Add(arrNames[nRemeber]);
                        //setLabelX3Text("三等奖：" + arrNames[nRemeber].ToString());
                        arrNames.RemoveAt(nRemeber);

                        string strThirdPrice = "三等奖：";
                        for (int j = 0; j < m_arrThirdPrice.Count; j++)
                        {
                            strThirdPrice += m_arrThirdPrice[j].ToString() + ", ";
                            setLabelX1Text(strThirdPrice);
                        }                        
                    }
                    else if (secondPrice > 0)
                    {
                        secondPrice--;
                        m_arrSecondPrice.Add(arrNames[nRemeber]);
                        //setLabelX3Text("二等奖：" + arrNames[nRemeber].ToString());
                        arrNames.RemoveAt(nRemeber);

                        string strSecondPrice = "二等奖：";
                        for (int j = 0; j < m_arrSecondPrice.Count; j++)
                        {
                            strSecondPrice += m_arrSecondPrice[j].ToString() + ", ";
                            setLabelX1Text(strSecondPrice);
                        }
                    }
                    else if (firstPrice > 0)
                    {
                        firstPrice--;
                        m_arrFirstPrice.Add(arrNames[nRemeber]);
                        //setLabelX3Text("一等奖：" + arrNames[nRemeber].ToString());
                        arrNames.RemoveAt(nRemeber);

                        string strFirstPrice = "一等奖：";
                        for (int j = 0; j < m_arrFirstPrice.Count; j++)
                        {
                            strFirstPrice += m_arrFirstPrice[j].ToString() + ", ";
                            setLabelX1Text(strFirstPrice);
                        }
                    }
                    else if (specialPrice > 0)
                    {
                        specialPrice--;
                        m_arrSpecialPrice.Add(arrNames[nRemeber]);
                        //setLabelX3Text("特等奖：" + arrNames[nRemeber].ToString());
                        arrNames.RemoveAt(nRemeber);

                        string strSpecialPrice = "特等奖：";
                        for (int j = 0; j < m_arrSpecialPrice.Count; j++)
                        {
                            strSpecialPrice += m_arrSpecialPrice[j].ToString() + ", ";
                            setLabelX1Text(strSpecialPrice);
                        }
                    }
                    else
                    {
                        string strSpecialPrice = "特等奖：";
                        string strFirstPrice = "一等奖：";
                        string strSecondPrice = "二等奖：";
                        string strThirdPrice = "三等奖：";

                        for (int j = 0; j < m_arrSpecialPrice.Count; j++)
                        {
                            strSpecialPrice += m_arrSpecialPrice[j].ToString() + "\r\n";
                        }
                        for (int j = 0; j < m_arrFirstPrice.Count; j++)
                        {
                            strFirstPrice += m_arrFirstPrice[j].ToString() + "\r\n";
                        }
                        for (int j = 0; j < m_arrSecondPrice.Count; j++)
                        {
                            strSecondPrice += m_arrSecondPrice[j].ToString() + "\r\n";
                        }
                        for (int j = 0; j < m_arrThirdPrice.Count; j++)
                        {
                            strThirdPrice += m_arrThirdPrice[j].ToString() + "\r\n";
                        }

                        labelX3.Font = new System.Drawing.Font("微软雅黑", 30);
                        setLabelX3Text(strSpecialPrice + strFirstPrice + strSecondPrice + strThirdPrice + "抽奖完毕，请按ESC键退出!");

                        //导出获奖名单：
                        string strToTxt = labelX3.Text;
                        DateTime dt = DateTime.Now;
                        string strTime = string.Format("{0:D4}-{1:D2}-{2:D2}_{3:D2}{4:D2}{5:D2}.txt", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
                        //string strTime = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString() + "_" + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString() + ".txt";
                        StreamWriter sw = new StreamWriter(strTime, false, Encoding.GetEncoding("gb2312"));
                        sw.WriteLine(strToTxt);
                        sw.Close();//写入

                        break; //抽奖完毕，请退出
                    }

                    if (thirdPrice == 0)
                    {
                        thirdPrice--;
                        setLabelX3Text("三等奖：" + m_arrThirdPrice[m_arrThirdPrice.Count-1].ToString() + "\r\n(按Enter开始抽二等奖)");
                    }
                    if (secondPrice == 0)
                    {
                        secondPrice--;
                        setLabelX3Text("二等奖：" + m_arrSecondPrice[m_arrSecondPrice.Count - 1].ToString() + "\r\n(按Enter开始抽一等奖)");
                    }
                    if (firstPrice == 0)
                    {
                        firstPrice--;
                        setLabelX3Text("一等奖：" + m_arrFirstPrice[m_arrFirstPrice.Count - 1].ToString() + "\r\n(按Enter开始抽特等奖)");
                    }
                    if (specialPrice == 0)
                    {
                        setLabelX3Text("特等奖：" + m_arrSpecialPrice[m_arrSpecialPrice.Count - 1].ToString() + "\r\n(抽奖结束，按Enter键进入获奖名单-->)");
                    }

                }
                else
                {
                    Thread.Sleep(20);
                }
            }
        }
#endregion

#region Property
        public int SpecialPrice
        {
            get { return specialPrice; }
            set { specialPrice = value; }
        }

        public int FirstPrice
        {
            get { return firstPrice; }
            set { firstPrice = value; }
        }

        public int SecondPrice
        {
            get { return secondPrice; }
            set { secondPrice = value; }
        }

        public int ThirdPrice
        {
            get { return thirdPrice; }
            set { thirdPrice = value; }
        }

        public System.Collections.ArrayList ArrNames
        {
            get { return arrNames; }
            set { arrNames = value; }
        }

        public string StrBackgroundImg
        {
            get { return strBackgroundImg; }
            set { strBackgroundImg = value; }
        }

        public int ShowNum
        {
            get { return showNum; }
            set { showNum = value; }
        }
#endregion
    }
}