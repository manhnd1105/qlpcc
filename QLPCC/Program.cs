using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLPCC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             //Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Home\\key\\");
             //try
             //{
             //    string name = (string)reg.GetValue("Key");
             //    int res = string.Compare(name, "GWH28-DGCMP-P6RC4-6J4MT-3HFDY");
             //    if (res == 0)
             //    {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmDangNhap());
             //    }
             //    else
             //    {
             //        MessageBox.Show("Phần mềm chưa đăng kí bản quyền !");
             //    }

             //}
             //catch
             //{
             //    MessageBox.Show("Phần mềm chưa đăng kí bản quyền !");
             //}

        }
    }
}