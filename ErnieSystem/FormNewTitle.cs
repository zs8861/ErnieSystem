using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ErnieSystem
{
    public partial class FormNewTitle : Office2007Form
    {
#region Fields
        private IniFileHelper m_iniFileHelper;
#endregion        

#region Methods
        public FormNewTitle()
        {
            InitializeComponent();
        }

        private void FormNewTitle_Load(object sender, EventArgs e)
        {
            string strPath = System.Environment.CurrentDirectory;
            m_iniFileHelper = new IniFileHelper(strPath + "\\config.ini");
        }

        private void buttonX_OK_Click(object sender, EventArgs e)
        {
            string strTitle = textBoxX_NewTitle.Text;
            m_iniFileHelper.Write("System", "MainFormTitle", strTitle);
            MessageBox.Show("标题修改成功，请重启软件生效！");
        }

        private void buttonX_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion


    }
}