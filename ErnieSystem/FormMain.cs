using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Collections;

namespace ErnieSystem
{
    public partial class FormMain : Office2007Form
    {
#region Fields
        private bool m_bReverseOrder = true;
        private ArrayList m_ArrNames = new ArrayList();
        private bool m_bImportName = false;
        private int m_nSpecialPrice = 0;
        private int m_nFirstPrice = 0;
        private int m_nSecondPrice = 0;
        private int m_nThirdPrice = 0;
        private IniFileHelper m_iniFileHelper;
        private ExcelHelper m_xlsHelper = new ExcelHelper();
        private string strBackgroundImg = "";
        private int m_nShowNum = 1;
#endregion

#region Methods
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //获奖人数由用户在界面上设定
            textBoxX_SpecialAwardNum.Text = "1";
            textBoxX_FirstPriceNum.Text = "2";
            textBoxX_SecondPriceNum.Text = "5";
            textBoxX_ThirdPriceNum.Text = "10";

            //config.ini文件保存可修改的标题字符串
            string strPath = System.Environment.CurrentDirectory;
            m_iniFileHelper = new IniFileHelper(strPath + "\\config.ini");
            string strTitle = m_iniFileHelper.Read("System", "MainFormTitle");
            this.Text = strTitle;

            string strShowNum = m_iniFileHelper.Read("System", "ShowNum");
            if (strShowNum == "")
            {
                m_nShowNum = 1;
            }
            else
            {
                m_nShowNum = int.Parse(strShowNum); 
            }
        }

        private void buttonX_InportNameList_Click(object sender, EventArgs e)
        {
            m_ArrNames.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\";
            ofd.RestoreDirectory = true;
            ofd.Filter = "Excel文档(*.xls)|*.xls|Excel文档(*.xlsx)|*.xlsx|所有文件(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //从Excel表中导入抽奖名单
                string strFileName = ofd.FileName;
                m_xlsHelper.Open(strFileName);

                int nRow = 1;
                int nCol = 1;
                string strName;
                while (true)
                {
                    strName = m_xlsHelper.ReadData(nRow, nCol);
                    if (strName.Trim() != "")
                    {
                        m_ArrNames.Add(strName);
                        nRow++;
                    }
                    else
                    {
                        break;
                    }
                }
                m_xlsHelper.Close();
                m_bImportName = true;
                MessageBox.Show("摇奖名单导入成功！");
            }

            
//             //导入抽奖人员名单，格式为一行一个名字，普通文本文档，
//             m_ArrNames.Clear();
//             OpenFileDialog ofd = new OpenFileDialog();
//             ofd.InitialDirectory = @"c:\";
//             ofd.RestoreDirectory = true;
//             ofd.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
// 
//             if (ofd.ShowDialog() == DialogResult.OK)
//             {
//                 string strFileName = ofd.FileName;
//                 FileStream fs = new FileStream(strFileName, FileMode.Open);
//                 StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("gb2312"));
//                 while (sr.EndOfStream == false)
//                 {
//                     String s = sr.ReadLine();
//                     m_ArrNames.Add(s);
//                 }
// 
//                 /* 暂不显示所有人员名单
//                 string strName = null;
//                 for (int i = 0; i < m_ArrNames.Count; i++)
//                 {
//                     strName += m_ArrNames[i] + ",";
//                 }
//                 MessageBox.Show(strName);
//                  */
// 
//                 MessageBox.Show("摇奖名单导入成功！");
//                 sr.Close();
//                 fs.Close();
// 
//                 m_bImportName = true;
//             }    

        }

        
        /// <summary>
        /// 判断一个字符串中所有字符是否都是数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool IsNumberFromString(string str)
        {
            bool bRet = true;
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++ ) 
                {
                    if (!char.IsNumber(str[i]))
                    {
                        bRet = false;
                        break;
                    }                   
                }
            }
            return bRet;
        }

        private void buttonX_StartErnie_Click(object sender, EventArgs e)
        {
            if (m_bImportName)
            {
                if (!IsNumberFromString(textBoxX_SpecialAwardNum.Text) || !IsNumberFromString(textBoxX_FirstPriceNum.Text) ||
                    !IsNumberFromString(textBoxX_SecondPriceNum.Text) || !IsNumberFromString(textBoxX_ThirdPriceNum.Text))
                {
                    MessageBox.Show("含有非法字符，请重新输入！");
                    return;
                }
                m_nSpecialPrice = int.Parse(textBoxX_SpecialAwardNum.Text);
                m_nFirstPrice = int.Parse(textBoxX_FirstPriceNum.Text);
                m_nSecondPrice = int.Parse(textBoxX_SecondPriceNum.Text);
                m_nThirdPrice = int.Parse(textBoxX_ThirdPriceNum.Text);

                if (m_nSpecialPrice <= 0 || m_nFirstPrice <= 0 || m_nSecondPrice <= 0 || m_nThirdPrice <= 0)
                {
                    MessageBox.Show("获奖人数设置错误，请重新设置！");
                    return;
                }

                int nAllPriceNum = m_nSpecialPrice + m_nFirstPrice + m_nSecondPrice + m_nThirdPrice;

                if (nAllPriceNum < m_ArrNames.Count)
                {
                    m_bImportName = false;

                    //将数据传入抽奖窗体对象
                    FormErnie fe = new FormErnie();
                    fe.SpecialPrice = m_nSpecialPrice;
                    fe.FirstPrice = m_nFirstPrice;
                    fe.SecondPrice = m_nSecondPrice;
                    fe.ThirdPrice = m_nThirdPrice;
                    fe.ArrNames = (ArrayList)m_ArrNames.Clone();
                    fe.StrBackgroundImg = strBackgroundImg;
                    m_nShowNum = int.Parse(m_iniFileHelper.Read("System", "ShowNum"));
                    fe.ShowNum = m_nShowNum;
                    fe.Show();                    
                }
                else
                {
                    MessageBox.Show("获奖人数 超过 参与人数，请重新设置！");
                }
            }
            else
            {
                MessageBox.Show("请先进行抽奖名单导入操作！");
            }
        }

        //该函数可删除
        private void checkBoxX_ReverseOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxX_ReverseOrder.Checked)
            {
                m_bReverseOrder = true;
            }
            else
            {
                m_bReverseOrder = false;
            }
        }

        private void buttonX_ModifyTitle_Click(object sender, EventArgs e)
        {
            FormNewTitle fnt = new FormNewTitle();
            fnt.ShowDialog();
        }
        private void textBoxX_SpecialAwardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                errorProvider1.SetError(textBoxX_SpecialAwardNum, "请输入0-9间数字!");
                textBoxX_SpecialAwardNum.Text = string.Empty;
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxX_SpecialAwardNum, "");
            } 
        }

        private void textBoxX_FirstPriceNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                errorProvider1.SetError(textBoxX_FirstPriceNum, "请输入0-9间数字!");
                textBoxX_FirstPriceNum.Text = string.Empty;
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxX_FirstPriceNum, "");
            } 
        }

        private void textBoxX_SecondPriceNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                errorProvider1.SetError(textBoxX_SecondPriceNum, "请输入0-9间数字!");
                textBoxX_SecondPriceNum.Text = string.Empty;
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxX_SecondPriceNum, "");
            } 
        }

        private void textBoxX_ThirdPriceNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                errorProvider1.SetError(textBoxX_ThirdPriceNum, "请输入0-9间数字!");
                textBoxX_ThirdPriceNum.Text = string.Empty;
                return;
            }
            else
            {
                errorProvider1.SetError(textBoxX_ThirdPriceNum, "");
            } 
        }

        private void buttonX_ModifyEnieNum_Click(object sender, EventArgs e)
        {
            FormShowNum fsn = new FormShowNum();
            fsn.ShowDialog();
        }

        private void buttonX_ModifyBackGround_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\";
            ofd.RestoreDirectory = true;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //从Excel表中导入抽奖名单
                strBackgroundImg = ofd.FileName;
                MessageBox.Show("摇奖背景修改成功！");
            }

//             Image img = Image.FromFile(@"c:\3.jpg");
//             this.BackgroundImage = img;
        }

#endregion
    }
}
