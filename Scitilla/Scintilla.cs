#region Using Directives

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NppPluginNET;

#endregion Using Directives


namespace ScintillaNET
{
    public class Scintilla
    {
        #region Fields

        /*private static readonly object _autoCSelectionEventKey = new object();
        private static readonly object _callTipClickEventKeyNative = new object();
        private static readonly object _charAddedEventKeyNative = new object();
        private static readonly object _doubleClickEventKey = new object();
        private static readonly object _dwellEndEventKeyNative = new object();
        private static readonly object _dwellStartEventKeyNative = new object();
        private static readonly object _hotspotClickEventKey = new object();
        private static readonly object _hotspotDoubleClickEventKey = new object();
        private static readonly object _indicatorClickKeyNative = new object();
        private static readonly object _indicatorReleaseKeyNative = new object();
        private static readonly object _keyEventKey = new object();
        private static readonly object _macroRecordEventKeyNative = new object();
        private static readonly object _marginClickEventKeyNative = new object();
        private static readonly object _modifiedEventKey = new object();
        private static readonly object _modifyAttemptROEventKey = new object();
        private static readonly object _needShownEventKey = new object();
        private static readonly object _paintedEventKey = new object();
        private static readonly object _savePointeftEventKeyNative = new object();
        private static readonly object _savePointReachedEventKeyNative = new object();
        private static readonly object _styleNeededEventKeyNative = new object();
        private static readonly object _updateUIEventKey = new object();
        private static readonly object _uriDroppedEventKeyNative = new object();
        private static readonly object _userListSelectionEventKeyNative = new object();
        private static readonly object _zoomEventKey = new object();*/
        //private LastSelection lastSelection = new LastSelection();
        private const uint TEXT_MODIFIED_FLAGS = Constants.SC_MOD_BEFOREDELETE | Constants.SC_MOD_BEFOREINSERT |
                                                    Constants.SC_MOD_DELETETEXT | Constants.SC_MOD_INSERTTEXT;

        private Encoding _encoding;

        public IntPtr Handle;

        #endregion Fields

        #region Methods

        public static Scintilla GetCurrentScintilla() { return new Scintilla(PluginBase.GetCurrentScintilla()); }

        public Scintilla(IntPtr pntr) { this.Handle = pntr; this._encoding = Encoding.UTF8; }


        public void AddRefDocument(IntPtr pDoc)
        {
            this.SendMessageDirect(Constants.SCI_ADDREFDOCUMENT, IntPtr.Zero, pDoc);
        }


        unsafe public void AddStyledText(int length, byte[] s)
        {
            fixed (byte* bp = s)
                this.SendMessageDirect(Constants.SCI_ADDSTYLEDTEXT, (IntPtr)length, (IntPtr)bp);
        }


        public void AddText(int length, string s)
        {
            this.SendMessageDirect(Constants.SCI_ADDTEXT, length, s);
        }


        public void Allocate(int bytes)
        {
            this.SendMessageDirect(Constants.SCI_ALLOCATE, bytes, 0);
        }


        public void AppendText(int length, string s)
        {
            this.SendMessageDirect(Constants.SCI_APPENDTEXT, length, s);
        }


        public void AssignCmdKey(int keyDefinition, int sciCommand)
        {
            this.SendMessageDirect(Constants.SCI_ASSIGNCMDKEY, keyDefinition, sciCommand);
        }


        public bool AutoCActive()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCACTIVE, 0, 0) != 0;
        }


        public void AutoCCancel()
        {
            this.SendMessageDirect(Constants.SCI_AUTOCCANCEL, 0, 0);
        }


        public void AutoCComplete()
        {
            this.SendMessageDirect(Constants.SCI_AUTOCCOMPLETE, 0, 0);
        }


        public bool AutoCGetAutoHide()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETAUTOHIDE, 0, 0) != 0;
        }


        public bool AutoCGetCancelAtStart()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETCANCELATSTART, 0, 0) != 0;
        }


        public bool AutoCGetChooseSingle()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETCHOOSESINGLE, 0, 0) != 0;
        }


        public int AutoCGetCurrent()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETCURRENT, 0, 0);
        }


        public bool AutoCGetDropRestOfWord()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETDROPRESTOFWORD, 0, 0) != 0;
        }


        public bool AutoCGetIgnoreCase()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETIGNORECASE, 0, 0) != 0;
        }


        public int AutoCGetMaxHeight()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETMAXHEIGHT, 0, 0);
        }


        public int AutoCGetMaxWidth()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCGETMAXWIDTH, 0, 0);
        }


        char AutoCGetSeparator()
        {
            return (char)this.SendMessageDirect(Constants.SCI_AUTOCGETSEPARATOR, 0, 0);
        }


        char AutoCGetTypeSeparator()
        {
            return (char)this.SendMessageDirect(Constants.SCI_AUTOCGETTYPESEPARATOR, 0, 0);
        }


        public int AutoCPosStart()
        {
            return this.SendMessageDirect(Constants.SCI_AUTOCPOSSTART, 0, 0);
        }


        public void AutoCSelect(string select)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSELECT, VOID.NULL, select);
        }


        public void AutoCSetAutoHide(bool autoHide)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETAUTOHIDE, autoHide, 0);
        }


        public void AutoCSetCancelAtStart(bool cancel)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETCANCELATSTART, cancel, 0);
        }


        public void AutoCSetChooseSingle(bool chooseSingle)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETCHOOSESINGLE, chooseSingle, 0);
        }


        public void AutoCSetDropRestOfWord(bool dropRestOfWord)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETDROPRESTOFWORD, dropRestOfWord, 0);
        }


        public void AutoCSetFillUps(string chars)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETFILLUPS, VOID.NULL, chars);
        }


        public void AutoCSetIgnoreCase(bool ignoreCase)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETIGNORECASE, ignoreCase, 0);
        }


        public void AutoCSetMaxHeight(int rowCount)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETMAXHEIGHT, rowCount, 0);
        }


        public void AutoCSetMaxWidth(int characterCount)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETMAXWIDTH, characterCount, 0);
        }


        public void AutoCSetSeparator(char separator)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETSEPARATOR, separator, 0);
        }


        public void AutoCSetTypeSeparator(char separatorCharacter)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSETTYPESEPARATOR, (int)separatorCharacter, 0);
        }


        public void AutoCShow(int lenEntered, string list)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSHOW, lenEntered, list);
        }


        public void AutoCStops(string chars)
        {
            this.SendMessageDirect(Constants.SCI_AUTOCSTOPS, VOID.NULL, chars);
        }


        public void BackTab()
        {
            this.SendMessageDirect(Constants.SCI_BACKTAB, 0, 0);
        }


        public void BeginUndoAction()
        {
            this.SendMessageDirect(Constants.SCI_BEGINUNDOACTION, 0, 0);
        }


        public void BraceBadLight(int pos1)
        {
            this.SendMessageDirect(Constants.SCI_BRACEBADLIGHT, pos1, 0);
        }


        public void BraceHighlight(int pos1, int pos2)
        {
            this.SendMessageDirect(Constants.SCI_BRACEHIGHLIGHT, pos1, pos2);
        }


        public int BraceMatch(int pos, int maxReStyle)
        {
            return this.SendMessageDirect(Constants.SCI_BRACEMATCH, pos, maxReStyle);
        }


        public bool CallTipActive()
        {
            return this.SendMessageDirect(Constants.SCI_CALLTIPACTIVE, 0, 0) != 0;
        }


        public void CallTipCancel()
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPCANCEL, 0, 0);
        }


        public int CallTipGetPosStart()
        {
            return this.SendMessageDirect(Constants.SCI_CALLTIPPOSSTART, 0, 0);
        }


        public void CallTipSetBack(int colour)
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPSETBACK, colour, 0);
        }


        public void CallTipSetFore(int colour)
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPSETFORE, colour, 0);
        }


        public void CallTipSetForeHlt(int colour)
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPSETFOREHLT, colour, 0);
        }


        public void CallTipSetHlt(int hlStart, int hlEnd)
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPSETHLT, hlStart, hlEnd);
        }


        public void CallTipShow(int posStart, string definition)
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPSHOW, posStart, definition);
        }


        public void CallTipUseStyle(int tabsize)
        {
            this.SendMessageDirect(Constants.SCI_CALLTIPUSESTYLE, tabsize, 0);
        }


        public void Cancel()
        {
            this.SendMessageDirect(Constants.SCI_CANCEL, 0, 0);
        }


        public bool CanRedo()
        {
            return this.SendMessageDirect(Constants.SCI_CANREDO, 0, 0) != 0;
        }


        public bool CanUndo()
        {
            return this.SendMessageDirect(Constants.SCI_CANUNDO, 0, 0) != 0;
        }


        public void CharLeft()
        {
            this.SendMessageDirect(Constants.SCI_CHARLEFT, 0, 0);
        }


        public void CharLeftExtend()
        {
            this.SendMessageDirect(Constants.SCI_CHARLEFTEXTEND, 0, 0);
        }


        public void CharLeftRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_CHARLEFTRECTEXTEND, 0, 0);
        }


        public void CharRight()
        {
            this.SendMessageDirect(Constants.SCI_CHARRIGHT, 0, 0);
        }


        public void CharRightExtend()
        {
            this.SendMessageDirect(Constants.SCI_CHARRIGHTEXTEND, 0, 0);
        }


        public void CharRightRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_CHARRIGHTRECTEXTEND, 0, 0);
        }


        public void ChooseCaretX()
        {
            this.SendMessageDirect(Constants.SCI_CHOOSECARETX, 0, 0);
        }


        public void Clear()
        {
            this.SendMessageDirect(Constants.SCI_CLEAR, 0, 0);
        }


        public void ClearAll()
        {
            this.SendMessageDirect(Constants.SCI_CLEARALL, 0, 0);
        }


        public void ClearAllCmdKeys()
        {
            this.SendMessageDirect(Constants.SCI_CLEARALLCMDKEYS, 0, 0);
        }


        public void ClearCmdKey(int keyDefinition)
        {
            this.SendMessageDirect(Constants.SCI_CLEARCMDKEY, keyDefinition, 0);
        }


        public void ClearDocumentStyle()
        {
            this.SendMessageDirect(Constants.SCI_CLEARDOCUMENTSTYLE, 0, 0);
        }


        public void ClearRegisteredImages()
        {
            this.SendMessageDirect(Constants.SCI_CLEARREGISTEREDIMAGES, 0, 0);
        }


        public void Colourise(int start, int end)
        {
            this.SendMessageDirect(Constants.SCI_COLOURISE, start, end);
        }


        public void ConvertEols(int eolMode)
        {
            this.SendMessageDirect(Constants.SCI_CONVERTEOLS, eolMode, 0);
        }


        IntPtr CreateDocument()
        {
            return (IntPtr)this.SendMessageDirect(Constants.SCI_CREATEDOCUMENT, 0, 0);
        }


        public void DeleteBack()
        {
            this.SendMessageDirect(Constants.SCI_DELETEBACK, 0, 0);
        }


        public void DeleteBackNotLine()
        {
            this.SendMessageDirect(Constants.SCI_DELETEBACKNOTLINE, 0, 0);
        }


        public void DelLineLeft()
        {
            this.SendMessageDirect(Constants.SCI_DELLINELEFT, 0, 0);
        }


        public void DelLineRight()
        {
            this.SendMessageDirect(Constants.SCI_DELLINERIGHT, 0, 0);
        }


        public void DelWordLeft()
        {
            this.SendMessageDirect(Constants.SCI_DELWORDLEFT, 0, 0);
        }


        public void DelWordRight()
        {
            this.SendMessageDirect(Constants.SCI_DELWORDRIGHT, 0, 0);
        }


        public int DocLineFromVisible(int displayLine)
        {
            return this.SendMessageDirect(Constants.SCI_DOCLINEFROMVISIBLE, displayLine, 0);
        }


        public void DocumentEnd()
        {
            this.SendMessageDirect(Constants.SCI_DOCUMENTEND, 0, 0);
        }


        public void DocumentEndExtend()
        {
            this.SendMessageDirect(2319, 0, 0);
        }


        public void DocumentStart()
        {
            this.SendMessageDirect(Constants.SCI_DOCUMENTSTART, 0, 0);
        }


        public void DocumentStartExtend()
        {
            this.SendMessageDirect(Constants.SCI_DOCUMENTSTARTEXTEND, 0, 0);
        }


        public void EditToggleOvertype()
        {
            this.SendMessageDirect(Constants.SCI_EDITTOGGLEOVERTYPE, 0, 0);
        }


        public void EmptyUndoBuffer()
        {
            this.SendMessageDirect(Constants.SCI_EMPTYUNDOBUFFER, 0, 0);
        }


        public int EncodeFromUtf8(string utf8, out string encoded)
        {
            throw new NotSupportedException();
        }


        public void EndUndoAction()
        {
            this.SendMessageDirect(Constants.SCI_ENDUNDOACTION, 0, 0);
        }


        public void EnsureVisible(int line)
        {
            this.SendMessageDirect(Constants.SCI_ENSUREVISIBLE, line, 0);
        }


        public void EnsureVisibleEnforcePolicy(int line)
        {
            this.SendMessageDirect(Constants.SCI_ENSUREVISIBLEENFORCEPOLICY, line, 0);
        }


        public int FindColumn(int line, int column)
        {
            return this.SendMessageDirect(Constants.SCI_FINDCOLUMN, line, column);
        }


        unsafe public int FindText(int searchFlags, ref TextToFind ttf)
        {
            //	{wi17869} 2008-08-15 Chris Rickard
            //	searchFlags weren't getting sent to SendMessageDirect. IntPtr.Zero was.
            //	This has been fixed
            fixed (TextToFind* ttfp = &ttf)
                return (int)this.SendMessageDirect(Constants.SCI_FINDTEXT, (IntPtr)searchFlags, (IntPtr)ttfp);
        }


        unsafe public int FormatRange(bool bDraw, ref RangeToFormat pfr)
        {
            fixed (RangeToFormat* rtfp = &pfr)
                return (int)this.SendMessageDirect(Constants.SCI_FORMATRANGE, (IntPtr)(bDraw ? 1 : 0), (IntPtr)rtfp);
        }


        public void FormFeed()
        {
            this.SendMessageDirect(Constants.SCI_FORMFEED, 0, 0);
        }


        public int GetAnchor()
        {
            return this.SendMessageDirect(Constants.SCI_GETANCHOR, 0, 0);
        }


        public bool GetBackSpaceUnIndents()
        {
            return this.SendMessageDirect(Constants.SCI_GETBACKSPACEUNINDENTS, 0, 0) != 0;
        }


        public bool GetBufferedDraw()
        {
            return this.SendMessageDirect(Constants.SCI_GETBUFFEREDDRAW, 0, 0) != 0;
        }


        public int GetCaretFore()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETFORE, 0, 0);
        }


        public int GetCaretLineBack()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETLINEBACK, 0, 0);
        }


        public int GetCaretLineBackAlpha()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETLINEBACKALPHA, 0, 0);
        }


        public bool GetCaretLineVisible()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETLINEVISIBLE, 0, 0) != 0;
        }


        public int GetCaretPeriod()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETPERIOD, 0, 0);
        }


        public bool GetCaretSticky()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETSTICKY, 0, 0) != 0;
        }


        public int GetCaretStyle()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETSTYLE, 0, 0);
        }


        public int GetCaretWidth()
        {
            return this.SendMessageDirect(Constants.SCI_GETCARETWIDTH, 0, 0);
        }


        char GetCharAt(int position)
        {
            return (char)this.SendMessageDirect(Constants.SCI_GETCHARAT, position, 0);
        }


        public int GetCodePage()
        {
            return this.SendMessageDirect(Constants.SCI_GETCODEPAGE, 0, 0);
        }


        public int GetColumn(int position)
        {
            return this.SendMessageDirect(Constants.SCI_GETCOLUMN, position, 0);
        }


        public int GetControlCharSymbol()
        {
            return this.SendMessageDirect(Constants.SCI_GETCONTROLCHARSYMBOL, 0, 0);
        }


        public int GetCurrentPos()
        {
            return this.SendMessageDirect(Constants.SCI_GETCURRENTPOS, 0, 0);
        }


        public int GetCursor()
        {
            return this.SendMessageDirect(Constants.SCI_GETCURSOR, 0, 0);
        }


        IntPtr GetDocPointer()
        {
            return this.SendMessageDirect(Constants.SCI_GETDOCPOINTER, IntPtr.Zero, IntPtr.Zero);
        }


        public int GetEdgeColour()
        {
            return this.SendMessageDirect(Constants.SCI_GETEDGECOLOUR, 0, 0);
        }


        public int GetEdgeColumn()
        {
            return this.SendMessageDirect(Constants.SCI_GETEDGECOLUMN, 0, 0);
        }


        public int GetEdgeMode()
        {
            return this.SendMessageDirect(Constants.SCI_GETEDGEMODE, 0, 0);
        }


        public bool GetEndAtLastLine()
        {
            return this.SendMessageDirect(Constants.SCI_GETENDATLASTLINE, 0, 0) != 0;
        }


        public int GetEndStyled()
        {
            return this.SendMessageDirect(Constants.SCI_GETENDSTYLED, 0, 0);
        }


        public int GetEolMode()
        {
            return this.SendMessageDirect(Constants.SCI_GETEOLMODE, 0, 0);
        }


        public bool GetFocus()
        {
            return this.SendMessageDirect(Constants.SCI_GETFOCUS, 0, 0) != 0;
        }


        public bool GetFoldExpanded(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETFOLDEXPANDED, line, 0) != 0;
        }


        public uint GetFoldLevel(int line)
        {
            return (uint)this.SendMessageDirect(Constants.SCI_GETFOLDLEVEL, line, 0);
        }


        public int GetFoldParent(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETFOLDPARENT, line, 0);
        }


        public int GetHighlightGuide()
        {
            return this.SendMessageDirect(Constants.SCI_GETHIGHLIGHTGUIDE, 0, 0);
        }


        public int GetHotspotActiveBack()
        {
            return this.SendMessageDirect(Constants.SCI_GETHOTSPOTACTIVEBACK, 0, 0);
        }


        public int GetHotspotActiveFore()
        {
            return this.SendMessageDirect(Constants.SCI_GETHOTSPOTACTIVEFORE, 0, 0);
        }


        public bool GetHotspotActiveUnderline()
        {
            return this.SendMessageDirect(Constants.SCI_GETHOTSPOTACTIVEUNDERLINE, 0, 0) != 0;
        }


        public bool GetHotspotSingleLine()
        {
            return this.SendMessageDirect(Constants.SCI_GETHOTSPOTSINGLELINE, 0, 0) != 0;
        }


        public bool GetHScrollBar()
        {
            return this.SendMessageDirect(Constants.SCI_GETHSCROLLBAR, 0, 0) != 0;
        }


        public int GetIndent()
        {
            return this.SendMessageDirect(Constants.SCI_GETINDENT, 0, 0);
        }


        public bool GetIndentationGuides()
        {
            return this.SendMessageDirect(Constants.SCI_GETINDENTATIONGUIDES, 0, 0) != 0;
        }


        public int GetIndicatorCurrent()
        {
            return this.SendMessageDirect(Constants.SCI_GETINDICATORCURRENT, 0, 0);
        }


        public int GetIndicatorValue()
        {
            return this.SendMessageDirect(Constants.SCI_GETINDICATORVALUE, 0, 0);
        }


        public int GetLastChild(int line, int level)
        {
            return this.SendMessageDirect(Constants.SCI_GETLASTCHILD, line, level);
        }


        public int GetLength()
        {
            return this.SendMessageDirect(Constants.SCI_GETLENGTH, 0, 0);
        }


        public int GetLexer()
        {
            return this.SendMessageDirect(Constants.SCI_GETLEXER, 0, 0);
        }


        public int GetLine(int line, out string text)
        {
            int length = this.SendMessageDirect(Constants.SCI_GETLINE, line, 0);
            if (length == 0)
            {
                text = string.Empty;
                return 0;
            }

            return this.SendMessageDirect(Constants.SCI_GETLINE, (IntPtr)line, out text, length);
        }


        public int GetLineEndPosition(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINEENDPOSITION, line, 0);
        }


        public int GetLineIndentation(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINEINDENTATION, line, 0);
        }


        public int GetLineIndentPosition(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINEINDENTPOSITION, line, 0);
        }


        public int GetLineSelEndPosition(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINESELENDPOSITION, line, 0);
        }


        public int GetLineSelStartPosition(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINESELSTARTPOSITION, line, 0);
        }


        public int GetLineState(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINESTATE, line, 0);
        }


        public bool GetLineVisible(int line)
        {
            return this.SendMessageDirect(Constants.SCI_GETLINEVISIBLE, line, 0) != 0;
        }


        public int GetMarginLeft()
        {
            return this.SendMessageDirect(Constants.SCI_GETMARGINLEFT, 0, 0);
        }


        public int GetMarginMaskN(int margin)
        {
            return this.SendMessageDirect(Constants.SCI_GETMARGINMASKN, margin, 0);
        }


        public int GetMarginRight()
        {
            return this.SendMessageDirect(Constants.SCI_GETMARGINRIGHT, 0, 0);
        }


        public bool GetMarginSensitiveN(int margin)
        {
            return this.SendMessageDirect(Constants.SCI_GETMARGINSENSITIVEN, margin, 0) != 0;
        }


        public int GetMarginTypeN(int margin)
        {
            return this.SendMessageDirect(Constants.SCI_GETMARGINTYPEN, margin, 0);
        }


        public int GetMarginWidthN(int margin)
        {
            return this.SendMessageDirect(Constants.SCI_GETMARGINWIDTHN, margin, 0);
        }


        public int GetMaxLineState()
        {
            return this.SendMessageDirect(Constants.SCI_GETMAXLINESTATE, 0, 0);
        }


        public int GetModEventMask()
        {
            return this.SendMessageDirect(Constants.SCI_GETMODEVENTMASK, 0, 0);
        }


        public bool GetModify()
        {
            return this.SendMessageDirect(Constants.SCI_GETMODIFY, 0, 0) != 0;
        }


        public bool GetMouseDownCaptures()
        {
            return this.SendMessageDirect(Constants.SCI_GETMOUSEDOWNCAPTURES, 0, 0) != 0;
        }


        public int GetMouseDwellTime()
        {
            return this.SendMessageDirect(Constants.SCI_GETMOUSEDWELLTIME, 0, 0);
        }


        public bool GetOvertype()
        {
            return this.SendMessageDirect(Constants.SCI_GETOVERTYPE, 0, 0) != 0;
        }


        public int GetPrintColourMode()
        {
            return this.SendMessageDirect(Constants.SCI_GETPRINTCOLOURMODE, 0, 0);
        }


        public int GetPrintMagnification()
        {
            return this.SendMessageDirect(Constants.SCI_GETPRINTMAGNIFICATION, 0, 0);
        }


        public int GetPrintWrapMode()
        {
            return this.SendMessageDirect(Constants.SCI_GETPRINTWRAPMODE, 0, 0);
        }


        public void GetProperty(string key, out string value)
        {
            this.SendMessageDirect(Constants.SCI_GETPROPERTY, key, out value);
        }


        public void GetPropertyExpanded(string key, out string value)
        {
            this.SendMessageDirect(Constants.SCI_GETPROPERTYEXPANDED, key, out value);
        }


        public int GetPropertyInt(string key, int @default)
        {
            return this.SendMessageDirect(Constants.SCI_GETPROPERTYINT, key, @default);
        }


        public bool GetReadOnly()
        {
            return this.SendMessageDirect(Constants.SCI_GETREADONLY, 0, 0) != 0;
        }


        public int GetScrollWidth()
        {
            return this.SendMessageDirect(Constants.SCI_GETSCROLLWIDTH, 0, 0);
        }


        public int GetSearchFlags()
        {
            return this.SendMessageDirect(Constants.SCI_GETSEARCHFLAGS, 0, 0);
        }


        public int GetSelectionEnd()
        {
            return this.SendMessageDirect(Constants.SCI_GETSELECTIONEND, 0, 0);
        }


        public int GetSelectionMode()
        {
            return this.SendMessageDirect(Constants.SCI_GETSELECTIONMODE, 0, 0);
        }


        public int GetSelectionStart()
        {
            return this.SendMessageDirect(Constants.SCI_GETSELECTIONSTART, 0, 0);
        }


        public void GetSelText(out string text)
        {
            int length = this.GetSelectionEnd() - this.GetSelectionStart() + 1;
            this.SendMessageDirect(Constants.SCI_GETSELTEXT, IntPtr.Zero, out text, length);
        }


        public int GetStatus()
        {
            return this.SendMessageDirect(Constants.SCI_GETSTATUS, 0, 0);
        }


        byte GetStyleAt(int position)
        {
            return (byte)this.SendMessageDirect(Constants.SCI_GETSTYLEAT, position, 0);
        }


        public int GetStyleBits()
        {
            return this.SendMessageDirect(Constants.SCI_GETSTYLEBITS, 0, 0);
        }


        public int GetStyleBitsNeeded()
        {
            return this.SendMessageDirect(Constants.SCI_GETSTYLEBITSNEEDED, 0, 0);
        }


        unsafe public void GetStyledText(ref TextRange tr)
        {
            fixed (TextRange* trp = &tr)
                this.SendMessageDirect(Constants.SCI_GETSTYLEDTEXT, IntPtr.Zero, (IntPtr)trp);
        }


        public bool GetTabIndents()
        {
            return this.SendMessageDirect(Constants.SCI_GETTABINDENTS, 0, 0) != 0;
        }


        public int GetTabWidth()
        {
            return this.SendMessageDirect(Constants.SCI_GETTABWIDTH, 0, 0);
        }


        public int GetTargetEnd()
        {
            return this.SendMessageDirect(Constants.SCI_GETTARGETEND, 0, 0);
        }


        public int GetTargetStart()
        {
            return this.SendMessageDirect(Constants.SCI_GETTARGETSTART, 0, 0);
        }


        public int GetText(int length, out string text)
        {
            return (int)this.SendMessageDirect(Constants.SCI_GETTEXT, (IntPtr)length, out text, length);
        }


        unsafe public int GetTextRange(ref TextRange tr)
        {
            fixed (TextRange* trp = &tr)
                return (int)this.SendMessageDirect(Constants.SCI_GETTEXTRANGE, IntPtr.Zero, (IntPtr)trp);
        }


        public int GetTextLength()
        {
            return this.SendMessageDirect(Constants.SCI_GETTEXTLENGTH, 0, 0);
        }


        public bool GetTwoPhaseDraw()
        {
            return this.SendMessageDirect(Constants.SCI_GETTWOPHASEDRAW, 0, 0) != 0;
        }


        public bool GetUndoCollection()
        {
            return this.SendMessageDirect(Constants.SCI_GETUNDOCOLLECTION, 0, 0) != 0;
        }


        public bool GetUsePalette()
        {
            return this.SendMessageDirect(Constants.SCI_GETUSEPALETTE, 0, 0) != 0;
        }


        public bool GetUseTabs()
        {
            return this.SendMessageDirect(Constants.SCI_GETUSETABS, 0, 0) != 0;
        }


        public bool GetViewEol()
        {
            return this.SendMessageDirect(Constants.SCI_GETVIEWEOL, 0, 0) != 0;
        }


        public int GetViewWs()
        {
            return this.SendMessageDirect(Constants.SCI_GETVIEWWS, 0, 0);
        }


        public bool GetVScrollBar()
        {
            return this.SendMessageDirect(Constants.SCI_GETVSCROLLBAR, 0, 0) != 0;
        }


        public int GetXOffset()
        {
            return this.SendMessageDirect(Constants.SCI_GETXOFFSET, 0, 0);
        }


        public int GetZoom()
        {
            return this.SendMessageDirect(Constants.SCI_GETZOOM, 0, 0);
        }


        public void GotoLine(int line)
        {
            this.SendMessageDirect(Constants.SCI_GOTOLINE, line, 0);
        }


        public void GotoPos(int position)
        {
            this.SendMessageDirect(Constants.SCI_GOTOPOS, position, 0);
        }


        public void GrabFocus()
        {
            this.SendMessageDirect(Constants.SCI_GRABFOCUS, 0, 0);
        }


        public void HideLines(int lineStart, int lineEnd)
        {
            this.SendMessageDirect(Constants.SCI_HIDELINES, lineStart, lineEnd);
        }


        public void HideSelection(bool hide)
        {
            this.SendMessageDirect(Constants.SCI_HIDESELECTION, hide, 0);
        }


        public void Home()
        {
            this.SendMessageDirect(Constants.SCI_HOME, 0, 0);
        }


        public void HomeDisplay()
        {
            this.SendMessageDirect(Constants.SCI_HOMEDISPLAY, 0, 0);
        }


        public void HomeDisplayExtend()
        {
            this.SendMessageDirect(Constants.SCI_HOMEDISPLAYEXTEND, 0, 0);
        }


        public void HomeExtend()
        {
            this.SendMessageDirect(Constants.SCI_HOMEEXTEND, 0, 0);
        }


        public void HomeRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_HOMERECTEXTEND, 0, 0);
        }


        public void HomeWrap()
        {
            this.SendMessageDirect(Constants.SCI_HOMEWRAP, 0, 0);
        }


        public void HomeWrapExtend()
        {
            this.SendMessageDirect(Constants.SCI_HOMEWRAPEXTEND, 0, 0);
        }


        public uint IndicatorAllOnFor(int position)
        {
            return (uint)this.SendMessageDirect(Constants.SCI_INDICATORALLONFOR, position, 0);
        }


        public void IndicatorClearRange(int position, int fillLength)
        {
            this.SendMessageDirect(Constants.SCI_INDICATORCLEARRANGE, position, fillLength);
        }


        public int IndicatorEnd(int indicator, int position)
        {
            return this.SendMessageDirect(Constants.SCI_INDICATOREND, indicator, position);
        }


        public void IndicatorFillRange(int position, int fillLength)
        {
            this.SendMessageDirect(Constants.SCI_INDICATORFILLRANGE, position, fillLength);
        }


        public int IndicatorStart(int indicator, int position)
        {
            return this.SendMessageDirect(Constants.SCI_INDICATORSTART, indicator, position);
        }


        public int IndicatorValueAt(int indicator, int position)
        {
            return this.SendMessageDirect(Constants.SCI_INDICATORVALUEAT, indicator, position);
        }


        public int IndicGetFore(int indicatorNumber)
        {
            return this.SendMessageDirect(Constants.SCI_INDICGETFORE, indicatorNumber, 0);
        }


        public int IndicGetStyle(int indicatorNumber)
        {
            return this.SendMessageDirect(Constants.SCI_INDICGETSTYLE, indicatorNumber, 0);
        }


        public bool IndicGetUnder(int indicatorNumber)
        {
            return this.SendMessageDirect(Constants.SCI_INDICGETUNDER, indicatorNumber, 0) != 0;
        }


        public void IndicSetFore(int indicatorNumber, int colour)
        {
            this.SendMessageDirect(Constants.SCI_INDICSETFORE, indicatorNumber, colour);
        }


        public void IndicSetStyle(int indicatorNumber, int indicatorStyle)
        {
            this.SendMessageDirect(Constants.SCI_INDICSETSTYLE, indicatorNumber, indicatorStyle);
        }


        public void IndicSetUnder(int indicatorNumber, bool under)
        {
            this.SendMessageDirect(Constants.SCI_INDICSETUNDER, indicatorNumber, under);
        }


        public void InsertText(int pos, string text)
        {
            this.SendMessageDirect(Constants.SCI_INSERTTEXT, pos, text);
        }


        public void LineCopy()
        {
            this.SendMessageDirect(Constants.SCI_LINECOPY, 0, 0);
        }


        public void LineCut()
        {
            this.SendMessageDirect(Constants.SCI_LINECUT, 0, 0);
        }


        public void LineDelete()
        {
            this.SendMessageDirect(Constants.SCI_LINEDELETE, 0, 0);
        }


        public void LineDown()
        {
            this.SendMessageDirect(Constants.SCI_LINEDOWN, 0, 0);
        }


        public void LineDownExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEDOWNEXTEND, 0, 0);
        }


        public void LineDownRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEDOWNRECTEXTEND, 0, 0);
        }


        public void LineDuplicate()
        {
            this.SendMessageDirect(Constants.SCI_LINEDUPLICATE, 0, 0);
        }


        public void LineEnd()
        {
            this.SendMessageDirect(Constants.SCI_LINEEND, 0, 0);
        }


        public void LineEndDisplay()
        {
            this.SendMessageDirect(Constants.SCI_LINEENDDISPLAY, 0, 0);
        }


        public void LineEndDisplayExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEENDDISPLAYEXTEND, 0, 0);
        }


        public void LineEndExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEENDEXTEND, 0, 0);
        }


        public void LineEndRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEENDRECTEXTEND, 0, 0);
        }


        public void LineEndWrap()
        {
            this.SendMessageDirect(Constants.SCI_LINEENDWRAP, 0, 0);
        }


        public void LineEndWrapExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEENDWRAPEXTEND, 0, 0);
        }


        public int LineFromPosition(int pos)
        {
            return this.SendMessageDirect(Constants.SCI_LINEFROMPOSITION, pos, 0);
        }


        public int LineLength(int line)
        {
            return this.SendMessageDirect(Constants.SCI_LINELENGTH, line, 0);
        }


        public void LineScroll(int columns, int lines)
        {
            this.SendMessageDirect(Constants.SCI_LINESCROLL, columns, lines);
        }


        public void LineScrollDown()
        {
            this.SendMessageDirect(Constants.SCI_LINESCROLLDOWN, 0, 0);
        }


        public void LineScrollUp()
        {
            this.SendMessageDirect(Constants.SCI_LINESCROLLUP, 0, 0);
        }


        public int LinesOnScreen()
        {
            return this.SendMessageDirect(Constants.SCI_LINESONSCREEN, 0, 0);
        }


        public void LineTranspose()
        {
            this.SendMessageDirect(Constants.SCI_LINETRANSPOSE, 0, 0);
        }


        public void LineUp()
        {
            this.SendMessageDirect(Constants.SCI_LINEUP, 0, 0);
        }


        public void LineUpExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEUPEXTEND, 0, 0);
        }


        public void LineUpRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_LINEUPRECTEXTEND, 0, 0);
        }


        public void LoadLexerLibrary(string path)
        {
            this.SendMessageDirect(Constants.SCI_LOADLEXERLIBRARY, VOID.NULL, path);
        }


        public void LowerCase()
        {
            this.SendMessageDirect(Constants.SCI_LOWERCASE, 0, 0);
        }


        public int MarkerAdd(int line, int markerNumber)
        {
            return this.SendMessageDirect(Constants.SCI_MARKERADD, line, markerNumber);
        }


        public void MarkerAddSet(int line, uint markerMask)
        {
            this.SendMessageDirect(Constants.SCI_MARKERADDSET, line, markerMask);
        }


        public void MarkerDefine(int markerNumber, int markerSymbol)
        {
            this.SendMessageDirect(Constants.SCI_MARKERDEFINE, markerNumber, markerSymbol);
        }


        public void MarkerDefinePixmap(int markerNumber, string xpm)
        {
            this.SendMessageDirect(Constants.SCI_MARKERDEFINEPIXMAP, markerNumber, xpm);
        }


        public void MarkerDelete(int line, int markerNumber)
        {
            this.SendMessageDirect(Constants.SCI_MARKERDELETE, line, markerNumber);
        }


        public void MarkerDeleteAll(int markerNumber)
        {
            this.SendMessageDirect(Constants.SCI_MARKERDELETEALL, markerNumber, 0);
        }


        public void MarkerDeleteHandle(int handle)
        {
            this.SendMessageDirect(Constants.SCI_MARKERDELETEHANDLE, handle, 0);
        }


        public int MarkerGet(int line)
        {
            return this.SendMessageDirect(Constants.SCI_MARKERGET, line, 0);
        }


        public int MarkerLineFromHandle(int handle)
        {
            return this.SendMessageDirect(Constants.SCI_MARKERLINEFROMHANDLE, handle, 0);
        }


        public int MarkerNext(int lineStart, uint markerMask)
        {
            return this.SendMessageDirect(Constants.SCI_MARKERNEXT, lineStart, markerMask);
        }


        public int MarkerPrevious(int lineStart, uint markerMask)
        {
            return this.SendMessageDirect(Constants.SCI_MARKERPREVIOUS, lineStart, markerMask);
        }


        public void MarkerSetAlpha(int markerNumber, int alpha)
        {
            this.SendMessageDirect(Constants.SCI_MARKERSETALPHA, markerNumber, alpha);
        }


        public void MarkerSetBack(int markerNumber, int colour)
        {
            this.SendMessageDirect(Constants.SCI_MARKERSETBACK, markerNumber, colour);
        }


        public void MarkerSetFore(int markerNumber, int colour)
        {
            this.SendMessageDirect(Constants.SCI_MARKERSETFORE, markerNumber, colour);
        }


        public void MoveCaretInsideView()
        {
            this.SendMessageDirect(Constants.SCI_MOVECARETINSIDEVIEW, 0, 0);
        }


        public void NewLine()
        {
            this.SendMessageDirect(Constants.SCI_NEWLINE, 0, 0);
        }


        public void Null()
        {
            this.SendMessageDirect(Constants.SCI_NULL, 0, 0);
        }


        public void PageDown()
        {
            this.SendMessageDirect(Constants.SCI_PAGEDOWN, 0, 0);
        }


        public void PageDownExtend()
        {
            this.SendMessageDirect(Constants.SCI_PAGEDOWNEXTEND, 0, 0);
        }


        public void PageDownRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_PAGEDOWNRECTEXTEND, 0, 0);
        }


        public void PageUp()
        {
            this.SendMessageDirect(Constants.SCI_PAGEUP, 0, 0);
        }


        public void PageUpExtend()
        {
            this.SendMessageDirect(Constants.SCI_PAGEUPEXTEND, 0, 0);
        }


        public void PageUpRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_PAGEUPRECTEXTEND, 0, 0);
        }


        public void ParaDown()
        {
            this.SendMessageDirect(Constants.SCI_PARADOWN, 0, 0);
        }


        public void ParaDownExtend()
        {
            this.SendMessageDirect(Constants.SCI_PARADOWNEXTEND, 0, 0);
        }


        public void ParaUp()
        {
            this.SendMessageDirect(Constants.SCI_PARAUP, 0, 0);
        }


        public void ParaUpExtend()
        {
            this.SendMessageDirect(Constants.SCI_PARAUPEXTEND, 0, 0);
        }


        public int PointXFromPosition(int position)
        {
            return this.SendMessageDirect(Constants.SCI_POINTXFROMPOSITION, VOID.NULL, position);
        }


        public int PointYFromPosition(int position)
        {
            return this.SendMessageDirect(Constants.SCI_POINTYFROMPOSITION, VOID.NULL, position);
        }


        public int PositionAfter(int position)
        {
            return this.SendMessageDirect(Constants.SCI_POSITIONAFTER, position, 0);
        }


        public int PositionBefore(int position)
        {
            return this.SendMessageDirect(Constants.SCI_POSITIONBEFORE, position, 0);
        }


        public int PositionFromLine(int line)
        {
            return this.SendMessageDirect(Constants.SCI_POSITIONFROMLINE, line, 0);
        }


        public int PositionFromPoint(int x, int y)
        {
            return this.SendMessageDirect(Constants.SCI_POSITIONFROMPOINT, x, y);
        }


        public int PositionFromPointClose(int x, int y)
        {
            return this.SendMessageDirect(Constants.SCI_POSITIONFROMPOINTCLOSE, x, y);
        }


        public void Redo()
        {
            this.SendMessageDirect(Constants.SCI_REDO, 0, 0);
        }


        public void RegisterImage(int type, string xpmData)
        {
            this.SendMessageDirect(Constants.SCI_REGISTERIMAGE, type, xpmData);
        }


        public void ReleaseDocument(IntPtr pDoc)
        {
            this.SendMessageDirect(Constants.SCI_RELEASEDOCUMENT, IntPtr.Zero, pDoc);
        }


        public void ReplaceSel(string text)
        {
            this.SendMessageDirect(Constants.SCI_REPLACESEL, VOID.NULL, text);
        }


        public int ReplaceTarget(int length, string text)
        {
            return this.SendMessageDirect(Constants.SCI_REPLACETARGET, length, text);
        }


        public int ReplaceTargetRE(int length, string text)
        {
            return this.SendMessageDirect(Constants.SCI_REPLACETARGETRE, length, text);
        }


        public void ScrollCaret()
        {
            this.SendMessageDirect(Constants.SCI_SCROLLCARET, 0, 0);
        }


        public void SearchAnchor()
        {
            this.SendMessageDirect(Constants.SCI_SEARCHANCHOR, 0, 0);
        }


        public int SearchInTarget(int length, string text)
        {
            return this.SendMessageDirect(Constants.SCI_SEARCHINTARGET, length, text);
        }


        public int SearchNext(int searchFlags, string text)
        {
            return this.SendMessageDirect(Constants.SCI_SEARCHNEXT, searchFlags, text);
        }


        public int SearchPrev(int searchFlags, string text)
        {
            return this.SendMessageDirect(Constants.SCI_SEARCHPREV, searchFlags, text);
        }


        public void SelectAll()
        {
            this.SendMessageDirect(Constants.SCI_SELECTALL, 0, 0);
        }


        public void SelectionDuplicate()
        {
            this.SendMessageDirect(Constants.SCI_SELECTIONDUPLICATE, 0, 0);
        }


        public bool SelectionIsRectangle()
        {
            return this.SendMessageDirect(Constants.SCI_SELECTIONISRECTANGLE, 0, 0) != 0;
        }




        /// <summary>
        ///     Gets the text of the line containing the caret.
        /// </summary>
        /// <returns>A <see cref="String" /> representing the text of the line containing the caret.</returns>
        public unsafe string GetCurrentLine() {
            int tmp;
            return GetCurrentLine(out tmp);
        }


        /// <summary>
        ///     Gets the text of the line containing the caret and the current caret position within that line.
        /// </summary>
        /// <param name="caretPosition">When this method returns, contains the byte offset of the current caret position with the line.</param>
        /// <returns>A <see cref="String" /> representing the text of the line containing the caret.</returns>
        public unsafe string GetCurrentLine(out int caretPosition) {
            int length = this.SendMessageDirect(NativeMethods.SCI_GETCURLINE, IntPtr.Zero, IntPtr.Zero).ToInt32();
            byte[] buffer = new byte[length];
            fixed (byte* bp = buffer)
                caretPosition = this.SendMessageDirect(NativeMethods.SCI_GETCURLINE, new IntPtr(buffer.Length), new IntPtr(bp)).ToInt32();

            return _encoding.GetString(buffer, 0, length - 1);
        }






        /// <summary>
        ///     Inserts text at the current cursor position
        /// </summary>
        /// <param name="text">Text to insert</param>
        /// <returns>The range inserted</returns>
        public void InsertText(string text) {
            this.AddText(_encoding.GetByteCount(text), text);
        }


        //  Various overloads provided for syntactical convinience.
        //  note that the return value is int (32 bit signed Integer). 
        //  If you are invoking a message that returns a pointer or
        //  handle like SCI_GETDIRECTFUNCTION or SCI_GETDOCPOINTER
        //  you MUST use the IntPtr overload to ensure 64bit compatibility
        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,)
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg)
        {
            return (int)this.SendMessageDirect(msg, IntPtr.Zero, IntPtr.Zero);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">wParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, int wParam)
        {
            return (int)this.SendMessageDirect(msg, (IntPtr)wParam, IntPtr.Zero);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (bool,)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">boolean wParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, bool wParam)
        {
            return (int)this.SendMessageDirect(msg, (IntPtr)(wParam ? 1 : 0), IntPtr.Zero);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,stringresult)    
        /// Notes:
        ///  Helper method to wrap all calls to messages that take a char*
        ///  in the lParam and returns a regular .NET String. This overload
        ///  assumes there will be no wParam and obtains the string _length
        ///  by calling the message with a 0 lParam. 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="text">String output</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, out string text)
        {
            int length = this.SendMessageDirect(msg, 0, 0);
            return this.SendMessageDirect(msg, IntPtr.Zero, out text, length);
        }


        // This file contains all the implementation of INativeScintilla
        /// <summary>
        /// This is the primary Native communication method with Scintilla
        /// used by this control. All the other overloads call into this one.
        /// </summary>
        IntPtr SendMessageDirect(uint msg, IntPtr wParam, IntPtr lParam)
        {
            //if (!this.IsDisposed)
            //{
                Message m = new Message();
                m.Msg = (int)msg;
                m.WParam = wParam;
                m.LParam = lParam;
                m.HWnd = Handle;

                //  DefWndProc is the Window Proc associated with the window
                //  class for this control created by Windows Forms. It will
                //  in turn call Scintilla's DefWndProc Directly. This has 
                //  the same net effect as using Scintilla's DirectFunction
                //  in that SendMessage isn't used to get the message to 
                //  Scintilla but requires 1 less PInvoke and I don't have
                //  to maintain the FunctionPointer and "this" reference
                //DefWndProc(ref m);

                m.Result = Win32.SendMessage(m.HWnd, m.Msg, m.WParam, m.LParam);

                return m.Result;
            //}
            //else
            //{
            //    return IntPtr.Zero;
            //}
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">wParam</param>
        /// <param name="lParam">lParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, int wParam, int lParam)
        {
            return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,uint)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">wParam</param>
        /// <param name="lParam">lParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, int wParam, uint lParam)
        {
            //	Hrm, just found out that no explicit conversion exists from uint to
            //	IntPtr. So first it converts it to a signed int, then to IntPtr. Of
            //	course if you have a large uint, it will overflow causing an 
            //	ArithmiticOverflowException. So we first have to do the conversion
            //	ourselves to a signed in inside an unchecked region to prevent the
            //	exception.
            unchecked
            {
                int i = (int)lParam;
                return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)i);
            }
            
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="NULL">always pass null--Unused parameter</param>
        /// <param name="lParam">lParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, VOID wParam, int lParam)
        {
            return (int)this.SendMessageDirect(msg, IntPtr.Zero, (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (bool,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">boolean wParam</param>
        /// <param name="lParam">int lParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, bool wParam, int lParam)
        {
            return (int)this.SendMessageDirect(msg, (IntPtr)(wParam ? 1 : 0), (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,bool)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">int wParam</param>
        /// <param name="lParam">boolean lParam</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, int wParam, bool lParam)
        {
            return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)(lParam ? 1 : 0));
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,stringresult)    
        /// Notes:
        ///  Helper method to wrap all calls to messages that take a char*
        ///  in the lParam and returns a regular .NET String. This overload
        ///  assumes there will be no wParam and obtains the string _length
        ///  by calling the message with a 0 lParam. 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="text">String output</param>
        /// <returns></returns>
        public int SendMessageDirect(uint msg, int wParam, out string text)
        {
            int length = this.SendMessageDirect(msg, 0, 0);
            return this.SendMessageDirect(msg, (IntPtr)wParam, out text, length);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (?)    
        /// Notes:
        ///  Helper method to wrap all calls to messages that take a char*
        ///  in the wParam and set a regular .NET String in the lParam. 
        ///  Both the _length of the string and an additional wParam are used 
        ///  so that various string Message styles can be acommodated.
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">int wParam</param>
        /// <param name="text">String output</param>
        /// <param name="_length">_length of the input buffer</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, IntPtr wParam, out string text, int length)
        {
            IntPtr ret;

            //  Allocate a buffer the size of the string + 1 for 
            //  the NULL terminator. Scintilla always sets this
            //  regardless of the encoding
            byte[] buffer = new byte[length + 1];

            //  Get a direct pointer to the the head of the buffer
            //  to pass to the message along with the wParam. 
            //  Scintilla will fill the buffer with string data.
            fixed (byte* bp = buffer)
            {
                ret = this.SendMessageDirect(msg, wParam, (IntPtr)bp);

                //	If this string is NULL terminated we want to trim the
                //	NULL before converting it to a .NET String
                if (bp[length - 1] == 0)
                    length--;
            }


            //  buffer contains the text encoded in the document format as specified by
            //	encoding. Convert it to a .NET UTF-16 string
            text = _encoding.GetString(buffer, 0, length);

            return (int)ret;
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,string)    
        /// Notes:
        ///  This helper method handles all messages that take
        ///  const char* as an input string in the lParam. In
        ///  some messages Scintilla expects a NULL terminated string
        ///  and in others it depends on the string _length passed in
        ///  as wParam. This method handles both situations and will
        ///  NULL terminate the string either way. 
        /// 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">int wParam</param>
        /// <param name="lParam">string lParam</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, int wParam, string lParam)
        {
            //  Just as when retrieving we make to convert .NET's
            //  UTF-16 strings into a document encoded byte array.
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(lParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)bp);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,string)    
        /// 
        /// Notes:
        ///  This helper method handles all messages that take
        ///  const char* as an input string in the lParam. In
        ///  some messages Scintilla expects a NULL terminated string
        ///  and in others it depends on the string _length passed in
        ///  as wParam. This method handles both situations and will
        ///  NULL terminate the string either way. 
        /// 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="NULL">always pass null--Unused parameter</param>
        /// <param name="lParam">string lParam</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, VOID NULL, string lParam)
        {
            //  Just as when retrieving we make to convert .NET's
            //  UTF-16 strings into a document encoded byte array.
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(lParam)))
                return (int)this.SendMessageDirect(msg, IntPtr.Zero, (IntPtr)bp);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,string)    
        /// 
        /// Notes:
        ///    Used by SCI_SETPROPERTY
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <param name="lParam">string lParam</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, string wParam, string lParam)
        {
            fixed (byte* bpw = _encoding.GetBytes(ZeroTerminated(wParam)))
            fixed (byte* bpl = _encoding.GetBytes(ZeroTerminated(lParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)bpw, (IntPtr)bpl);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,stringresult)    
        /// 
        /// Notes:
        ///  This one is used specifically by SCI_GETPROPERTY and SCI_GETPROPERTYEXPANDED
        ///  so it assumes it's usage
        /// 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <param name="stringResult">Stringresult output</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, string wParam, out string stringResult)
        {
            IntPtr ret;

            fixed (byte* bpw = _encoding.GetBytes(ZeroTerminated(wParam)))
            {
                int length = (int)this.SendMessageDirect(msg, (IntPtr)bpw, IntPtr.Zero);


                byte[] buffer = new byte[length + 1];

                fixed (byte* bpl = buffer)
                    ret = this.SendMessageDirect(msg, (IntPtr)bpw, (IntPtr)bpl);

                stringResult = _encoding.GetString(buffer, 0, length);
            }

            return (int)ret;
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <param name="lParam">int lParam</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, string wParam, int lParam)
        {
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(wParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)bp, (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <returns></returns>
        unsafe public int SendMessageDirect(uint msg, string wParam)
        {
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(wParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)bp, IntPtr.Zero);
        }


        public void SetAnchor(int position)
        {
            this.SendMessageDirect(Constants.SCI_SETANCHOR, position, 0);
        }


        public void SetBackSpaceUnIndents(bool bsUnIndents)
        {
            this.SendMessageDirect(Constants.SCI_SETBACKSPACEUNINDENTS, bsUnIndents, 0);
        }


        public void SetBufferedDraw(bool isBuffered)
        {
            this.SendMessageDirect(Constants.SCI_SETBUFFEREDDRAW, isBuffered, 0);
        }


        public void SetCaretFore(int alpha)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETFORE, alpha, 0);
        }


        public void SetCaretLineBack(int show)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETLINEBACK, show, 0);
        }


        public void SetCaretLineBackAlpha(int alpha)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETLINEBACKALPHA, alpha, 0);
        }


        public void SetCaretLineVisible(bool colour)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETLINEVISIBLE, colour, 0);
        }


        public void SetCaretPeriod(int milliseconds)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETPERIOD, milliseconds, 0);
        }


        public void SetCaretSticky(bool useCaretStickyBehaviour)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETSTICKY, useCaretStickyBehaviour, 0);
        }


        public void SetCaretStyle(int style)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETSTYLE, style, 0);
        }


        public void SetCaretWidth(int pixels)
        {
            this.SendMessageDirect(Constants.SCI_SETCARETWIDTH, pixels, 0);
        }


        public void SetCharsDefault()
        {
            this.SendMessageDirect(Constants.SCI_SETCHARSDEFAULT, 0, 0);
        }


        public void SetCodePage(int codePage)
        {
            this.SendMessageDirect(Constants.SCI_SETCODEPAGE, codePage, 0);
            _encoding = Encoding.GetEncoding(codePage);
        }


        public void SetControlCharSymbol(int symbol)
        {
            this.SendMessageDirect(Constants.SCI_SETCONTROLCHARSYMBOL, symbol, 0);
        }


        public void SetCurrentPos(int position)
        {
            this.SendMessageDirect(Constants.SCI_SETCURRENTPOS, position, 0);
        }


        public void SetCursor(int curType)
        {
            this.SendMessageDirect(Constants.SCI_SETCURSOR, curType, 0);
        }


        public void SetDocPointer(IntPtr pDoc)
        {
            this.SendMessageDirect(Constants.SCI_SETDOCPOINTER, IntPtr.Zero, pDoc);
        }


        public void SetEdgeColour(int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETEDGECOLOUR, colour, 0);
        }


        public void SetEdgeColumn(int column)
        {
            this.SendMessageDirect(Constants.SCI_SETEDGECOLUMN, column, 0);
        }


        public void SetEdgeMode(int mode)
        {
            this.SendMessageDirect(Constants.SCI_SETEDGEMODE, mode, 0);
        }


        public void SetEndAtLastLine(bool endAtLastLine)
        {
            this.SendMessageDirect(Constants.SCI_SETENDATLASTLINE, endAtLastLine, 0);
        }


        public void SetEolMode(int eolMode)
        {
            this.SendMessageDirect(Constants.SCI_SETEOLMODE, eolMode, 0);
        }


        public void SetFocus(bool focus)
        {
            this.SendMessageDirect(Constants.SCI_SETFOCUS, focus, 0);
        }


        public void SetFoldExpanded(int line, bool expanded)
        {
            this.SendMessageDirect(Constants.SCI_SETFOLDEXPANDED, line, expanded);
        }


        public void SetFoldFlags(int flags)
        {
            this.SendMessageDirect(Constants.SCI_SETFOLDFLAGS, flags, 0);
        }


        public void SetFoldLevel(int line, uint level)
        {
            this.SendMessageDirect(Constants.SCI_SETFOLDLEVEL, line, level);
        }


        public void SetFoldMarginColour(bool useSetting, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETFOLDMARGINCOLOUR, useSetting, colour);
        }


        public void SetFoldMarginHiColour(bool useSetting, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETFOLDMARGINHICOLOUR, useSetting, colour);
        }


        public void SetHighlightGuide(int column)
        {
            this.SendMessageDirect(Constants.SCI_SETHIGHLIGHTGUIDE, column, 0);
        }


        public void SetHotspotActiveBack(bool useHotspotBackColour, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETHOTSPOTACTIVEBACK, useHotspotBackColour, colour);
        }


        public void SetHotspotActiveFore(bool useHotspotForeColour, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETHOTSPOTACTIVEFORE, useHotspotForeColour, colour);
        }


        public void SetHotspotActiveUnderline(bool underline)
        {
            this.SendMessageDirect(Constants.SCI_SETHOTSPOTACTIVEUNDERLINE, underline, 0);
        }


        public void SetHotspotSingleLine(bool singleLine)
        {
            this.SendMessageDirect(Constants.SCI_SETHOTSPOTSINGLELINE, singleLine, 0);
        }


        public void SetHScrollBar(bool visible)
        {
            this.SendMessageDirect(Constants.SCI_SETHSCROLLBAR, visible, 0);
        }


        public void SetIndent(int widthInChars)
        {
            this.SendMessageDirect(Constants.SCI_SETINDENT, widthInChars, 0);
        }


        public void SetIndentationGuides(bool view)
        {
            this.SendMessageDirect(Constants.SCI_SETINDENTATIONGUIDES, view, 0);
        }


        public void SetIndicatorCurrent(int indicator)
        {
            this.SendMessageDirect(Constants.SCI_SETINDICATORCURRENT, indicator, 0);
        }


        public void SetIndicatorValue(int value)
        {
            this.SendMessageDirect(Constants.SCI_SETINDICATORVALUE, value, 0);
        }


        public void SetKeywords(int keywordSet, string keyWordList)
        {
            this.SendMessageDirect(Constants.SCI_SETKEYWORDS, keywordSet, keyWordList);
        }


        public int SetLengthForEncode(int bytes)
        {
            throw new NotSupportedException();
        }


        public void SetLexer(int lexer)
        {
            this.SendMessageDirect(Constants.SCI_SETLEXER, lexer, 0);
        }


        public void SetLexerLanguage(string name)
        {
            this.SendMessageDirect(Constants.SCI_SETLEXERLANGUAGE, VOID.NULL, name);
        }


        public void SetLineIndentation(int line, int indentation)
        {
            this.SendMessageDirect(Constants.SCI_SETLINEINDENTATION, line, indentation);
        }


        public void SetLineState(int line, int value)
        {
            this.SendMessageDirect(Constants.SCI_SETLINESTATE, line, value);
        }


        public void SetMarginLeft(int pixels)
        {
            this.SendMessageDirect(Constants.SCI_SETMARGINLEFT, 0, pixels);
        }


        public void SetMarginMaskN(int margin, int mask)
        {
            this.SendMessageDirect(Constants.SCI_SETMARGINMASKN, margin, mask);
        }


        public void SetMarginRight(int pixels)
        {
            this.SendMessageDirect(Constants.SCI_SETMARGINRIGHT, 0, pixels);
        }


        public void SetMarginSensitiveN(int margin, bool sensitive)
        {
            this.SendMessageDirect(Constants.SCI_SETMARGINSENSITIVEN, margin, sensitive);
        }


        public void SetMarginTypeN(int margin, int type)
        {
            this.SendMessageDirect(Constants.SCI_SETMARGINTYPEN, margin, type);
        }


        public void SetMarginWidthN(int margin, int pixelWidth)
        {
            this.SendMessageDirect(Constants.SCI_SETMARGINWIDTHN, margin, pixelWidth);
        }


        public void SetModEventMask(int modEventMask)
        {
            this.SendMessageDirect(Constants.SCI_SETMODEVENTMASK, modEventMask, 0);
        }


        public void SetMouseDownCaptures(bool captures)
        {
            this.SendMessageDirect(Constants.SCI_SETMOUSEDOWNCAPTURES, captures, 0);
        }


        public void SetMouseDwellTime(int mouseDwellTime)
        {
            this.SendMessageDirect(Constants.SCI_SETMOUSEDWELLTIME, mouseDwellTime, 0);
        }


        public void SetOvertype(bool overType)
        {
            this.SendMessageDirect(Constants.SCI_SETOVERTYPE, overType, 0);
        }


        public void SetPrintColourMode(int mode)
        {
            this.SendMessageDirect(Constants.SCI_SETPRINTCOLOURMODE, mode, 0);
        }


        public void SetPrintMagnification(int magnification)
        {
            this.SendMessageDirect(Constants.SCI_SETPRINTMAGNIFICATION, magnification, 0);
        }


        public void SetPrintWrapMode(int wrapMode)
        {
            this.SendMessageDirect(Constants.SCI_SETPRINTWRAPMODE, wrapMode, 0);
        }


        public void SetProperty(string key, string value)
        {
            this.SendMessageDirect(Constants.SCI_SETPROPERTY, key, value);
        }


        public void SetReadOnly(bool readOnly)
        {
            this.SendMessageDirect(Constants.SCI_SETREADONLY, readOnly, 0);
        }


        public void SetSavePoint()
        {
            this.SendMessageDirect(Constants.SCI_SETSAVEPOINT, 0, 0);
        }


        public void SetScrollWidth(int pixelWidth)
        {
            this.SendMessageDirect(Constants.SCI_SETSCROLLWIDTH, pixelWidth, 0);
        }


        public void SetSearchFlags(int searchFlags)
        {
            this.SendMessageDirect(Constants.SCI_SETSEARCHFLAGS, searchFlags, 0);
        }


        public void SetSel(int anchorPos, int currentPos)
        {
            this.SendMessageDirect(Constants.SCI_SETSEL, anchorPos, currentPos);
        }


        public void SetSelBack(bool useSelectionBackColour, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETSELBACK, useSelectionBackColour, colour);
        }


        public void SetSelectionEnd(int position)
        {
            this.SendMessageDirect(Constants.SCI_SETSELECTIONEND, position, 0);
        }


        public void SetSelectionMode(int mode)
        {
            this.SendMessageDirect(Constants.SCI_SETSELECTIONMODE, mode, 0);
        }


        public void SetSelectionStart(int position)
        {
            this.SendMessageDirect(Constants.SCI_SETSELECTIONSTART, position, 0);
        }


        public void SetSelFore(bool useSelectionForeColour, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETSELFORE, useSelectionForeColour, colour);
        }


        public void SetStatus(int status)
        {
            this.SendMessageDirect(Constants.SCI_SETSTATUS, status, 0);
        }


        public void SetStyleBits(int bits)
        {
            this.SendMessageDirect(Constants.SCI_SETSTYLEBITS, bits, 0);
        }


        public void SetStyling(int length, int style)
        {
            this.SendMessageDirect(Constants.SCI_SETSTYLING, length, style);
        }


        public void SetStylingEx(int length, string styles)
        {
            this.SendMessageDirect(Constants.SCI_SETSTYLINGEX, length, styles);
        }


        public void SetTabIndents(bool tabIndents)
        {
            this.SendMessageDirect(Constants.SCI_SETTABINDENTS, tabIndents, 0);
        }


        public void SetTabWidth(int widthInChars)
        {
            this.SendMessageDirect(Constants.SCI_SETTABWIDTH, widthInChars, 0);
        }


        public void SetTargetEnd(int pos)
        {
            this.SendMessageDirect(Constants.SCI_SETTARGETEND, pos, 0);
        }


        public void SetTargetStart(int pos)
        {
            this.SendMessageDirect(Constants.SCI_SETTARGETSTART, pos, 0);
        }


        public void SetText(string text)
        {
            this.SendMessageDirect(Constants.SCI_SETTEXT, VOID.NULL, text);
        }


        public void SetTwoPhaseDraw(bool twoPhase)
        {
            this.SendMessageDirect(Constants.SCI_SETTWOPHASEDRAW, twoPhase, 0);
        }


        public void SetUndoCollection(bool collectUndo)
        {
            this.SendMessageDirect(Constants.SCI_SETUNDOCOLLECTION, collectUndo, 0);
        }


        public void SetUsePalette(bool allowPaletteUse)
        {
            this.SendMessageDirect(Constants.SCI_SETUSEPALETTE, allowPaletteUse, 0);
        }


        public void SetUseTabs(bool useTabs)
        {
            this.SendMessageDirect(Constants.SCI_SETUSETABS, useTabs, 0);
        }


        public void SetViewEol(bool visible)
        {
            this.SendMessageDirect(Constants.SCI_SETVIEWEOL, visible, 0);
        }


        public void SetViewWs(int wsMode)
        {
            this.SendMessageDirect(Constants.SCI_SETVIEWWS, wsMode, 0);
        }


        public void SetVisiblePolicy(int visiblePolicy, int visibleSlop)
        {
            this.SendMessageDirect(Constants.SCI_SETVISIBLEPOLICY, visiblePolicy, visibleSlop);
        }


        public void SetVScrollBar(bool visible)
        {
            this.SendMessageDirect(Constants.SCI_SETVSCROLLBAR, visible, 0);
        }


        public void SetWhitespaceBack(bool useWhitespaceBackColour, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETWHITESPACEBACK, useWhitespaceBackColour, colour);
        }


        public void SetWhitespaceChars(string chars)
        {
            this.SendMessageDirect(Constants.SCI_SETWHITESPACECHARS, VOID.NULL, chars);
        }


        public void SetWhitespaceFore(bool useWhitespaceForeColour, int colour)
        {
            this.SendMessageDirect(Constants.SCI_SETWHITESPACEFORE, useWhitespaceForeColour, colour);
        }


        public void SetWordChars(string chars)
        {
            this.SendMessageDirect(Constants.SCI_SETWORDCHARS, VOID.NULL, chars);
        }


        public void SetXCaretPolicy(int caretPolicy, int caretSlop)
        {
            this.SendMessageDirect(Constants.SCI_SETXCARETPOLICY, caretPolicy, caretSlop);
        }


        public void SetXOffset(int xOffset)
        {
            this.SendMessageDirect(Constants.SCI_SETXOFFSET, xOffset, 0);
        }


        public void SetYCaretPolicy(int caretPolicy, int caretSlop)
        {
            this.SendMessageDirect(Constants.SCI_SETYCARETPOLICY, caretPolicy, caretSlop);
        }


        public void SetZoom(int zoomInPoints)
        {
            this.SendMessageDirect(Constants.SCI_SETZOOM, zoomInPoints, 0);
        }


        public void ShowLines(int lineStart, int lineEnd)
        {
            this.SendMessageDirect(Constants.SCI_SHOWLINES, lineStart, lineEnd);
        }


        public void StartRecord()
        {
            this.SendMessageDirect(Constants.SCI_STARTRECORD, 0, 0);
        }


        public void StartStyling(int position, int mask)
        {
            this.SendMessageDirect(Constants.SCI_STARTSTYLING, position, mask);
        }


        public void StopRecord()
        {
            this.SendMessageDirect(Constants.SCI_STOPRECORD, 0, 0);
        }


        public void StutteredPageDown()
        {
            this.SendMessageDirect(Constants.SCI_STUTTEREDPAGEDOWN, 0, 0);
        }


        public void StutteredPageDownExtend()
        {
            this.SendMessageDirect(Constants.SCI_STUTTEREDPAGEDOWNEXTEND, 0, 0);
        }


        public void StutteredPageUp()
        {
            this.SendMessageDirect(Constants.SCI_STUTTEREDPAGEUP, 0, 0);
        }


        public void StutteredPageUpExtend()
        {
            this.SendMessageDirect(Constants.SCI_STUTTEREDPAGEUPEXTEND, 0, 0);
        }


        public void StyleClearAll()
        {
            this.SendMessageDirect(Constants.SCI_STYLECLEARALL, 0, 0);
        }


        public int StyleGetBack(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETBACK, styleNumber, 0);
        }


        public bool StyleGetBold(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETBOLD, styleNumber, 0) != 0;
        }


        public int StyleGetCase(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETCASE, styleNumber, 0);
        }


        public bool StyleGetChangeable(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETCHANGEABLE, styleNumber, 0) != 0;
        }


        public int StyleGetCharacterSet(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETCHARACTERSET, styleNumber, 0);
        }


        public bool StyleGetEOLFilled(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETEOLFILLED, styleNumber, 0) != 0;
        }


        public void StyleGetFont(int styleNumber, out string fontName)
        {
            string s;
            int length = this.SendMessageDirect(Constants.SCI_STYLEGETFONT, styleNumber, 0);
            this.SendMessageDirect(Constants.SCI_STYLEGETFONT, (IntPtr)styleNumber, out s, length);
            fontName = s;
        }


        public int StyleGetFore(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETFORE, styleNumber, 0);
        }


        public bool StyleGetHotspot(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETHOTSPOT, styleNumber, 0) != 0;
        }


        public bool StyleGetItalic(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETITALIC, styleNumber, 0) != 0;
        }


        public int StyleGetSize(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETSIZE, 0, 0);
        }


        public bool StyleGetUnderline(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETUNDERLINE, styleNumber, 0) != 0;
        }


        public bool StyleGetVisible(int styleNumber)
        {
            return this.SendMessageDirect(Constants.SCI_STYLEGETVISIBLE, styleNumber, 0) != 0;
        }


        public void StyleResetDefault()
        {
            this.SendMessageDirect(Constants.SCI_STYLERESETDEFAULT, 0, 0);
        }


        public void StyleSetBack(int styleNumber, int colour)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETBACK, styleNumber, colour);
        }


        public void StyleSetBold(int styleNumber, bool bold)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETBOLD, styleNumber, bold);
        }


        public void StyleSetCase(int styleNumber, int caseMode)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETCASE, styleNumber, caseMode);
        }


        public void StyleSetChangeable(int styleNumber, bool changeable)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETCHANGEABLE, styleNumber, changeable);
        }


        public void StyleSetCharacterSet(int styleNumber, int charSet)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETCHARACTERSET, styleNumber, charSet);
        }


        public void StyleSetEOLFilled(int styleNumber, bool eolFilled)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETEOLFILLED, styleNumber, eolFilled);
        }


        public void StyleSetFont(int styleNumber, string fontName)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETFONT, styleNumber, fontName);
        }


        public void StyleSetFore(int styleNumber, int colour)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETFORE, styleNumber, colour);
        }


        public void StyleSetHotspot(int styleNumber, bool hotspot)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETHOTSPOT, styleNumber, hotspot);
        }


        public void StyleSetItalic(int styleNumber, bool italic)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETITALIC, styleNumber, italic);
        }


        public void StyleSetSize(int styleNumber, int sizeInPoints)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETSIZE, styleNumber, sizeInPoints);
        }


        public void StyleSetUnderline(int styleNumber, bool underline)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETUNDERLINE, styleNumber, underline);
        }


        public void StyleSetVisible(int styleNumber, bool visible)
        {
            this.SendMessageDirect(Constants.SCI_STYLESETVISIBLE, styleNumber, visible);
        }


        public void Tab()
        {
            this.SendMessageDirect(Constants.SCI_TAB, 0, 0);
        }


        //	These 3 methods don't really make sense when targeting .NET
        //	which stores strings as UTF-16. I guess if you really wanted
        //	to have it it would make more sense to have the strings 
        //	as byte[]s instead.
        public int TargetAsUtf8(out string s)
        {
            throw new NotSupportedException();
        }


        public void TargetFromSelection()
        {
            this.SendMessageDirect(Constants.SCI_TARGETFROMSELECTION, 0, 0);
        }


        public int TextHeight(int line)
        {
            return this.SendMessageDirect(Constants.SCI_TEXTHEIGHT, line, 0);
        }


        public int TextWidth(int styleNumber, string text)
        {
            return this.SendMessageDirect(Constants.SCI_TEXTWIDTH, styleNumber, text);
        }


        public void ToggleCaretSticky()
        {
            this.SendMessageDirect(Constants.SCI_TOGGLECARETSTICKY, 0, 0);
        }


        public void ToggleFold(int line)
        {
            this.SendMessageDirect(Constants.SCI_TOGGLEFOLD, line, 0);
        }


        public void Undo()
        {
            this.SendMessageDirect(Constants.SCI_UNDO, 0, 0);
        }


        public void UpperCase()
        {
            this.SendMessageDirect(Constants.SCI_UPPERCASE, 0, 0);
        }


        public void UsePopUp(bool bEnablePopup)
        {
            this.SendMessageDirect(Constants.SCI_USEPOPUP, bEnablePopup, 0);
        }


        public void UserListShow(int listType, string list)
        {
            this.SendMessageDirect(Constants.SCI_USERLISTSHOW, listType, list);
        }


        public void VCHome()
        {
            this.SendMessageDirect(Constants.SCI_VCHOME, 0, 0);
        }


        public void VCHomeExtend()
        {
            this.SendMessageDirect(Constants.SCI_VCHOMEEXTEND, 0, 0);
        }


        public void VCHomeRectExtend()
        {
            this.SendMessageDirect(Constants.SCI_VCHOMERECTEXTEND, 0, 0);
        }


        public void VCHomeWrap()
        {
            this.SendMessageDirect(Constants.SCI_VCHOMEWRAP, 0, 0);
        }


        public void VCHomeWrapExtend()
        {
            this.SendMessageDirect(Constants.SCI_VCHOMEWRAPEXTEND, 0, 0);
        }


        public int VisibleFromDocLine(int docLine)
        {
            return this.SendMessageDirect(Constants.SCI_VISIBLEFROMDOCLINE, docLine, 0);
        }


        public int WordEndPosition(int position, bool onlyWordCharacters)
        {
            return this.SendMessageDirect(Constants.SCI_WORDENDPOSITION, position, onlyWordCharacters);
        }


        public void WordLeft()
        {
            this.SendMessageDirect(Constants.SCI_WORDLEFT, 0, 0);
        }


        public void WordLeftEnd()
        {
            this.SendMessageDirect(Constants.SCI_WORDLEFTEND, 0, 0);
        }


        public void WordLeftEndExtend()
        {
            this.SendMessageDirect(Constants.SCI_WORDLEFTENDEXTEND, 0, 0);
        }


        public void WordLeftExtend()
        {
            this.SendMessageDirect(Constants.SCI_WORDLEFTEXTEND, 0, 0);
        }


        public void WordPartLeft()
        {
            this.SendMessageDirect(Constants.SCI_WORDPARTLEFT, 0, 0);
        }


        public void WordPartLeftExtend()
        {
            this.SendMessageDirect(Constants.SCI_WORDPARTLEFTEXTEND, 0, 0);
        }


        public void WordPartRight()
        {
            this.SendMessageDirect(Constants.SCI_WORDPARTRIGHT, 0, 0);
        }


        public void WordPartRightExtend()
        {
            this.SendMessageDirect(Constants.SCI_WORDPARTRIGHTEXTEND, 0, 0);
        }


        public void WordRight()
        {
            this.SendMessageDirect(Constants.SCI_WORDRIGHT, 0, 0);
        }


        public void WordRightEnd()
        {
            this.SendMessageDirect(Constants.SCI_WORDRIGHTEND, 0, 0);
        }


        public void WordRightEndExtend()
        {
            this.SendMessageDirect(Constants.SCI_WORDRIGHTENDEXTEND, 0, 0);
        }


        public void WordRightExtend()
        {
            this.SendMessageDirect(Constants.SCI_WORDRIGHTEXTEND, 0, 0);
        }


        public int WordStartPosition(int position, bool onlyWordCharacters)
        {
            return this.SendMessageDirect(Constants.SCI_WORDSTARTPOSITION, position, onlyWordCharacters);
        }


        public void ZoomIn()
        {
            this.SendMessageDirect(Constants.SCI_ZOOMIN, 0, 0);
        }


        public void ZoomOut()
        {
            this.SendMessageDirect(Constants.SCI_ZOOMOUT, 0, 0);
        }


        private static string ZeroTerminated(string param)
        {
            if (string.IsNullOrEmpty(param))
                return "\0";
            else if (!param.EndsWith("\0"))
                return param + "\0";
            return param;
        }

        #endregion Methods

        /*
        #region SendDirect

        //  Various overloads provided for syntactical convinience.
        //  note that the return value is int (32 bit signed Integer). 
        //  If you are invoking a message that returns a pointer or
        //  handle like SCI_GETDIRECTFUNCTION or SCI_GETDOCPOINTER
        //  you MUST use the IntPtr overload to ensure 64bit compatibility
        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,)
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg) {
            return (int)this.SendMessageDirect(msg, IntPtr.Zero, IntPtr.Zero);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">wParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, int wParam) {
            return (int)this.SendMessageDirect(msg, (IntPtr)wParam, IntPtr.Zero);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (bool,)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">boolean wParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, bool wParam) {
            return (int)this.SendMessageDirect(msg, (IntPtr)(wParam ? 1 : 0), IntPtr.Zero);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,stringresult)    
        /// Notes:
        ///  Helper method to wrap all calls to messages that take a char*
        ///  in the lParam and returns a regular .NET String. This overload
        ///  assumes there will be no wParam and obtains the string _length
        ///  by calling the message with a 0 lParam. 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="text">String output</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, out string text) {
            int length = this.SendMessageDirect(msg, 0, 0);
            return this.SendMessageDirect(msg, IntPtr.Zero, out text, length);
        }


        // This file contains all the implementation of INativeScintilla
        /// <summary>
        /// This is the primary Native communication method with Scintilla
        /// used by this control. All the other overloads call into this one.
        /// </summary>
        IntPtr SendMessageDirect(uint msg, IntPtr wParam, IntPtr lParam) {
            if (!this.IsDisposed) {
                Message m = new Message();
                m.Msg = (int)msg;
                m.WParam = wParam;
                m.LParam = lParam;
                m.HWnd = Handle;

                //  DefWndProc is the Window Proc associated with the window
                //  class for this control created by Windows Forms. It will
                //  in turn call Scintilla's DefWndProc Directly. This has 
                //  the same net effect as using Scintilla's DirectFunction
                //  in that SendMessage isn't used to get the message to 
                //  Scintilla but requires 1 less PInvoke and I don't have
                //  to maintain the FunctionPointer and "this" reference
                DefWndProc(ref m);

                return m.Result;
            } else {
                return IntPtr.Zero;
            }
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">wParam</param>
        /// <param name="lParam">lParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, int wParam, int lParam) {
            return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,uint)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">wParam</param>
        /// <param name="lParam">lParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, int wParam, uint lParam) {
            //	Hrm, just found out that no explicit conversion exists from uint to
            //	IntPtr. So first it converts it to a signed int, then to IntPtr. Of
            //	course if you have a large uint, it will overflow causing an 
            //	ArithmiticOverflowException. So we first have to do the conversion
            //	ourselves to a signed in inside an unchecked region to prevent the
            //	exception.
            unchecked {
                int i = (int)lParam;
                return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)i);
            }

        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="NULL">always pass null--Unused parameter</param>
        /// <param name="lParam">lParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, VOID wParam, int lParam) {
            return (int)this.SendMessageDirect(msg, IntPtr.Zero, (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (bool,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">boolean wParam</param>
        /// <param name="lParam">int lParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, bool wParam, int lParam) {
            return (int)this.SendMessageDirect(msg, (IntPtr)(wParam ? 1 : 0), (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,bool)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">int wParam</param>
        /// <param name="lParam">boolean lParam</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, int wParam, bool lParam) {
            return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)(lParam ? 1 : 0));
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,stringresult)    
        /// Notes:
        ///  Helper method to wrap all calls to messages that take a char*
        ///  in the lParam and returns a regular .NET String. This overload
        ///  assumes there will be no wParam and obtains the string _length
        ///  by calling the message with a 0 lParam. 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="text">String output</param>
        /// <returns></returns>
        int SendMessageDirect(uint msg, int wParam, out string text) {
            int length = this.SendMessageDirect(msg, 0, 0);
            return this.SendMessageDirect(msg, (IntPtr)wParam, out text, length);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (?)    
        /// Notes:
        ///  Helper method to wrap all calls to messages that take a char*
        ///  in the wParam and set a regular .NET String in the lParam. 
        ///  Both the _length of the string and an additional wParam are used 
        ///  so that various string Message styles can be acommodated.
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">int wParam</param>
        /// <param name="text">String output</param>
        /// <param name="_length">_length of the input buffer</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, IntPtr wParam, out string text, int length) {
            IntPtr ret;

            //  Allocate a buffer the size of the string + 1 for 
            //  the NULL terminator. Scintilla always sets this
            //  regardless of the encoding
            byte[] buffer = new byte[length + 1];

            //  Get a direct pointer to the the head of the buffer
            //  to pass to the message along with the wParam. 
            //  Scintilla will fill the buffer with string data.
            fixed (byte* bp = buffer) {
                ret = this.SendMessageDirect(msg, wParam, (IntPtr)bp);

                //	If this string is NULL terminated we want to trim the
                //	NULL before converting it to a .NET String
                if (bp[length - 1] == 0)
                    length--;
            }


            //  buffer contains the text encoded in the document format as specified by
            //	encoding. Convert it to a .NET UTF-16 string
            text = _encoding.GetString(buffer, 0, length);

            return (int)ret;
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (int,string)    
        /// Notes:
        ///  This helper method handles all messages that take
        ///  const char* as an input string in the lParam. In
        ///  some messages Scintilla expects a NULL terminated string
        ///  and in others it depends on the string _length passed in
        ///  as wParam. This method handles both situations and will
        ///  NULL terminate the string either way. 
        /// 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">int wParam</param>
        /// <param name="lParam">string lParam</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, int wParam, string lParam) {
            //  Just as when retrieving we make to convert .NET's
            //  UTF-16 strings into a document encoded byte array.
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(lParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)wParam, (IntPtr)bp);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (,string)    
        /// 
        /// Notes:
        ///  This helper method handles all messages that take
        ///  const char* as an input string in the lParam. In
        ///  some messages Scintilla expects a NULL terminated string
        ///  and in others it depends on the string _length passed in
        ///  as wParam. This method handles both situations and will
        ///  NULL terminate the string either way. 
        /// 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="NULL">always pass null--Unused parameter</param>
        /// <param name="lParam">string lParam</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, VOID NULL, string lParam) {
            //  Just as when retrieving we make to convert .NET's
            //  UTF-16 strings into a document encoded byte array.
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(lParam)))
                return (int)this.SendMessageDirect(msg, IntPtr.Zero, (IntPtr)bp);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,string)    
        /// 
        /// Notes:
        ///    Used by SCI_SETPROPERTY
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <param name="lParam">string lParam</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, string wParam, string lParam) {
            fixed (byte* bpw = _encoding.GetBytes(ZeroTerminated(wParam)))
            fixed (byte* bpl = _encoding.GetBytes(ZeroTerminated(lParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)bpw, (IntPtr)bpl);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,stringresult)    
        /// 
        /// Notes:
        ///  This one is used specifically by SCI_GETPROPERTY and SCI_GETPROPERTYEXPANDED
        ///  so it assumes it's usage
        /// 
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <param name="stringResult">Stringresult output</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, string wParam, out string stringResult) {
            IntPtr ret;

            fixed (byte* bpw = _encoding.GetBytes(ZeroTerminated(wParam))) {
                int length = (int)this.SendMessageDirect(msg, (IntPtr)bpw, IntPtr.Zero);


                byte[] buffer = new byte[length + 1];

                fixed (byte* bpl = buffer)
                    ret = this.SendMessageDirect(msg, (IntPtr)bpw, (IntPtr)bpl);

                stringResult = _encoding.GetString(buffer, 0, length);
            }

            return (int)ret;
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,int)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <param name="lParam">int lParam</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, string wParam, int lParam) {
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(wParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)bp, (IntPtr)lParam);
        }


        /// <summary>
        /// Handles Scintilla Call Style:
        ///    (string,)    
        /// </summary>
        /// <param name="msg">Scintilla Message Number</param>
        /// <param name="wParam">string wParam</param>
        /// <returns></returns>
        unsafe int SendMessageDirect(uint msg, string wParam) {
            fixed (byte* bp = _encoding.GetBytes(ZeroTerminated(wParam)))
                return (int)this.SendMessageDirect(msg, (IntPtr)bp, IntPtr.Zero);
        }

        #endregion
        */

        #region Types

        /// <summary>
        ///     Holds the last previous selection's properties, to let us know when we should fire SelectionChanged
        /// </summary>
        private class LastSelection
        {
            #region Fields

            private int _end;
            private int _length;
            private int _start;

            #endregion Fields


            #region Properties

            public int End
            {
                get { return _end; }
                set
                {
                    _end = value;
                }
            }


            public int Length
            {
                get { return _length; }
                set
                {
                    _length = value;
                }
            }


            public int Start
            {
                get { return _start; }
                set
                {
                    _start = value;
                }
            }

            #endregion Properties
        }

        #endregion Types
    }
}
