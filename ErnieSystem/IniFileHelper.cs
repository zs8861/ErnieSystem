using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

namespace ErnieSystem
{
    public class IniFileHelper
    {
        #region DllImport
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);
        #endregion

        #region Fields
        private string m_strPath = null; //*.ini file path
        #endregion

        #region Methods
        public IniFileHelper(string path)
        {
            m_strPath = path;
        }

        /// <summary>
        /// read parameter
        /// </summary>
        /// <param name="section">section value</param>
        /// <param name="key">key value</param>
        /// <returns>return the string value of the key in the section</returns>
        public string Read(string section, string key)
        {
            // the number of byte reading from *.ini file
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", temp, 255, m_strPath);
            return temp.ToString();
        }

        /// <summary>
        /// write parameter
        /// </summary>
        /// <param name="section">section value</param>
        /// <param name="key">key value</param>
        /// <param name="value">the value of the key</param>
        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, m_strPath);
        }
        #endregion
    }
}
