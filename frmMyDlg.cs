using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace $safeprojectname$ {
    public partial class frmMyDlg : NppPluginNET.NppPluginForm {
        public frmMyDlg() : base("My Dialog", NppPluginNET.NppTbMsg.DWS_DF_CONT_RIGHT, 1, true){
            InitializeComponent();
        }
    }
}
