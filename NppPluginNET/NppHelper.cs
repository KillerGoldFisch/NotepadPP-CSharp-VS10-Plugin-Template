using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NppPluginNET;

namespace NppPluginNET {
    public static class NppHelper {

        /// <summary>
        /// Get the text of a document.
        /// </summary>
        /// <param name="curScintilla">The Schiintilla of the document to get.</param>
        /// <returns></returns>
        public static string GetDocumentText(IntPtr curScintilla) {
            int length = (int)Win32.SendMessage(curScintilla, SciMsg.SCI_GETLENGTH, 0, 0) + 1;
            StringBuilder sb = new StringBuilder(length);
            Win32.SendMessage(curScintilla, SciMsg.SCI_GETTEXT, length, sb);
            return sb.ToString();
        }
        /// <summary>
        /// Get the text of the current active document.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDocumentText() {
            IntPtr curScintilla = PluginBase.GetCurrentScintilla();
            return GetDocumentText(curScintilla);
        }

        public static void SetCurrentDocumentText(string text) {
            Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_SETTEXT, 0, text);
        }

        public static int GetCurrentLineNumber() {
            int pos = Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_GETCURRENTPOS, 0, 0).ToInt32();
            int line = Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_LINEFROMPOSITION, pos, 0).ToInt32();
            return line;
        }

        public static void SetCurrentLineNumber(int line) {
            /*int pos = Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_POSITIONFROMLINE, line, 0).ToInt32();
            Win32.SendMessage(PluginBase.GetCurrentScintilla(), SciMsg.SCI_SETCURRENTPOS, pos, pos);*/
            IntPtr curScintilla = PluginBase.GetCurrentScintilla();
            Win32.SendMessage(curScintilla, SciMsg.SCI_ENSUREVISIBLE, line, 0);
            Win32.SendMessage(curScintilla, SciMsg.SCI_GOTOLINE, line, 0);
            Win32.SendMessage(curScintilla, SciMsg.SCI_GRABFOCUS, 0, 0);
        }

        public static string GetCurrentFilename() {
            StringBuilder sb = new StringBuilder(256);
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_GETFILENAME, 256, sb);
            return sb.ToString();
        }
        /// <summary>
        /// Get the text of all open documents into an ArrayList.
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetAllDocumentText() {
            ArrayList DocumentText = new ArrayList();
            for (int window = 0; window < 2; window++) {
                int currentdoc = -1; int newdoc = -1;
                while (currentdoc == newdoc) {
                    newdoc++;
                    Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_ACTIVATEDOC, window, newdoc);
                    currentdoc = (int)Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_GETCURRENTDOCINDEX, 0, window);
                    if (currentdoc == newdoc) {
                        DocumentText.Add(GetCurrentDocumentText());
                    }
                }
            }
            return DocumentText;
        }
    }
}