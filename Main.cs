using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NppPluginNET;

namespace $safeprojectname$
{
    public class Main : PluginMainBase
    {
        frmMyDlg frmMyDlg = null;

        #region " StartUp/CleanUp "
        public override string PluginName() { return "$safeprojectname$"; }

        public override void CommandMenuInit()
        {
            this.frmMyDlg = new frmMyDlg();

            PluginBase.SetCommand(0, "Hello World", helloworld, new ShortcutKey(true, false, true, Keys.X));
            PluginBase.SetCommand(frmMyDlg.GetID(), frmMyDlg.FormName(), this.frmMyDlg.Show, new ShortcutKey(true, false, true, Keys.C));
        }

        public override void OnLoad() { }
        public override void PluginCleanUp() { }
        #endregion

        #region " Menu functions "
        void helloworld()
        {
            MessageBox.Show("Hello World");           
        }
        #endregion
    }
}