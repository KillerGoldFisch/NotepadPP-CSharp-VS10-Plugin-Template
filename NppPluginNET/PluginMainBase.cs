using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;

namespace NppPluginNET {
    public abstract class PluginMainBase {

        public PluginMainBase() {
            DirectoryInfo pluginHome = new DirectoryInfo(@"plugins\\$safeprojectname$");
            if (!pluginHome.Exists)
                try {
                    pluginHome.Create();
                } catch (Exception ex) { }
            AppDomain.CurrentDomain.AppendPrivatePath(pluginHome.FullName);
        }


        public abstract string PluginName();

        public abstract void CommandMenuInit();

        public abstract void OnLoad();

        public abstract void PluginCleanUp();
    }
}
