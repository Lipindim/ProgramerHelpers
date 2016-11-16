using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerHelpers
{
    public static class RegistryOperation
    {
        public static void Write(string aLocalPath, string aKey, string aValue)
        {
            RegistryKey _regKey = null;
            try
            {
                string _regKeyName = @"Software\LipinCorp\ProgrammerHelpers" + aLocalPath;
                _regKey = Registry.CurrentUser.CreateSubKey(_regKeyName);
                if (_regKey == null) return;
                _regKey.SetValue(aKey, aValue);
            }
            catch
            {
                if (_regKey != null)
                {
                    _regKey.Close();
                }
            }
        }

        public static string Read(string aLocalPath, string aKey)
        {
            RegistryKey _regKey = null;
            try
            {
                string _regKeyName = @"Software\LipinCorp\ProgrammerHelpers" + aLocalPath;
                _regKey = Registry.CurrentUser.OpenSubKey(_regKeyName);
                if (_regKey == null) return string.Empty;
                return _regKey.GetValue(aKey).ToString();
            }
            catch
            {
                if (_regKey != null)
                {
                    _regKey.Close();
                }
                return string.Empty;
            }
        }
    }
}
