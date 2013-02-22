using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using $safeprojectname$;

namespace NppPluginNET {

    public class NppPluginForm : Form {

        private int id = -1;

        protected Bitmap tbBmp = $safeprojectname$.Properties.Resources.star;
        protected Bitmap tbBmp_tbTab = $safeprojectname$.Properties.Resources.star_bmp;

        protected Icon tbIcon = null;

        private string name = "NONAME";

        public string FormName() { return name; }

        protected NppTbMsg FormMask = NppTbMsg.DWS_ICONTAB | NppTbMsg.DWS_ICONBAR;

        private bool isInit = false;

        public NppPluginForm() { }

        public NppPluginForm(string name, NppTbMsg msg = NppTbMsg.DWS_DF_CONT_RIGHT, int id = -1, bool toolbaricon = false) {
            this.name = name;
            FormMask |= msg;
            this.id = id;

            if(toolbaricon)
                NppPluginNETEventbus.OnNPPN_TBMODIFICATION += new NppPluginNETEventbus.OnNPPN_TBMODIFICATIONHandler(NppPluginNETEventbus_OnNPPN_TBMODIFICATION);
        }

        void NppPluginNETEventbus_OnNPPN_TBMODIFICATION(SCNotification scnNotification) {
            toolbarIcons tbIcons = new toolbarIcons();
            tbIcons.hToolbarBmp = tbBmp.GetHbitmap();
            IntPtr pTbIcons = Marshal.AllocHGlobal(Marshal.SizeOf(tbIcons));
            Marshal.StructureToPtr(tbIcons, pTbIcons, false);
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_ADDTOOLBARICON, this.id, pTbIcons);
            Marshal.FreeHGlobal(pTbIcons);
        }

        public void Show() {
            if (!isInit) {
                isInit = true;

                using (Bitmap newBmp = new Bitmap(16, 16)) {
                    Graphics g = Graphics.FromImage(newBmp);
                    ColorMap[] colorMap = new ColorMap[1];
                    colorMap[0] = new ColorMap();
                    colorMap[0].OldColor = Color.Fuchsia;
                    colorMap[0].NewColor = Color.FromKnownColor(KnownColor.ButtonFace);
                    ImageAttributes attr = new ImageAttributes();
                    attr.SetRemapTable(colorMap);
                    g.DrawImage(tbBmp_tbTab, new Rectangle(0, 0, 16, 16), 0, 0, 16, 16, GraphicsUnit.Pixel, attr);
                    tbIcon = Icon.FromHandle(newBmp.GetHicon());
                }

                NppTbData _nppTbData = new NppTbData();
                _nppTbData.hClient = this.Handle;
                _nppTbData.pszName = this.FormName();
                _nppTbData.dlgID = id;
                _nppTbData.uMask = FormMask;
                _nppTbData.hIconTab = (uint)tbIcon.Handle;
                _nppTbData.pszModuleName = UnmanagedExports.main.PluginName();
                IntPtr _ptrNppTbData = Marshal.AllocHGlobal(Marshal.SizeOf(_nppTbData));
                Marshal.StructureToPtr(_nppTbData, _ptrNppTbData, false);

                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_DMMREGASDCKDLG, 0, _ptrNppTbData);
            } else {
                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_DMMSHOW, 0, this.Handle);
            }
        }

        public int GetID() { return id; }
    }
}
