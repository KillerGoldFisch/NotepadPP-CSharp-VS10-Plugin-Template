using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppPluginNET {
    public static class NppPluginNETEventbus {

        #region AUTO

        /// <summary>
        ///<para> To notify plugins that all the procedures of launchment of notepad++ are done.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_READY;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = 0;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_READYHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that all the procedures of launchment of notepad++ are done.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_READY;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = 0;</para>
        /// </summary>
        public static event OnNPPN_READYHandler OnNPPN_READY;


        /// <summary>
        ///<para> To notify plugins that toolbar icons can be registered</para>
        ///<para>scnNotification.nmhdr.code = NPPN_TB_MODIFICATION;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = 0;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_TBMODIFICATIONHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that toolbar icons can be registered</para>
        ///<para>scnNotification.nmhdr.code = NPPN_TB_MODIFICATION;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = 0;</para>
        /// </summary>
        public static event OnNPPN_TBMODIFICATIONHandler OnNPPN_TBMODIFICATION;


        /// <summary>
        ///<para> To notify plugins that the current file is about to be closed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFORECLOSE;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILEBEFORECLOSEHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is about to be closed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFORECLOSE;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILEBEFORECLOSEHandler OnNPPN_FILEBEFORECLOSE;


        /// <summary>
        ///<para> To notify plugins that the current file is just opened</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEOPENED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILEOPENEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is just opened</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEOPENED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILEOPENEDHandler OnNPPN_FILEOPENED;


        /// <summary>
        ///<para> To notify plugins that the current file is just closed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILECLOSED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILECLOSEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is just closed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILECLOSED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILECLOSEDHandler OnNPPN_FILECLOSED;


        /// <summary>
        ///<para> To notify plugins that the current file is about to be opened</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFOREOPEN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILEBEFOREOPENHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is about to be opened</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFOREOPEN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILEBEFOREOPENHandler OnNPPN_FILEBEFOREOPEN;


        /// <summary>
        ///<para> To notify plugins that the current file is about to be saved</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFOREOPEN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILEBEFORESAVEHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is about to be saved</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFOREOPEN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILEBEFORESAVEHandler OnNPPN_FILEBEFORESAVE;


        /// <summary>
        ///<para> To notify plugins that the current file is just saved</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILESAVED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILESAVEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is just saved</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILESAVED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILESAVEDHandler OnNPPN_FILESAVED;


        /// <summary>
        ///<para> To notify plugins that Notepad++ is about to be shutdowned.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_SHUTDOWN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = 0;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_SHUTDOWNHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that Notepad++ is about to be shutdowned.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_SHUTDOWN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = 0;</para>
        /// </summary>
        public static event OnNPPN_SHUTDOWNHandler OnNPPN_SHUTDOWN;


        /// <summary>
        ///<para> To notify plugins that a buffer was activated (put to foreground).</para>
        ///<para>scnNotification.nmhdr.code = NPPN_BUFFERACTIVATED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = activatedBufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_BUFFERACTIVATEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that a buffer was activated (put to foreground).</para>
        ///<para>scnNotification.nmhdr.code = NPPN_BUFFERACTIVATED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = activatedBufferID;</para>
        /// </summary>
        public static event OnNPPN_BUFFERACTIVATEDHandler OnNPPN_BUFFERACTIVATED;


        /// <summary>
        ///<para> To notify plugins that the language in the current doc is just changed.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_LANGCHANGED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = currentBufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_LANGCHANGEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the language in the current doc is just changed.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_LANGCHANGED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = currentBufferID;</para>
        /// </summary>
        public static event OnNPPN_LANGCHANGEDHandler OnNPPN_LANGCHANGED;


        /// <summary>
        ///<para> To notify plugins that user initiated a WordStyleDlg change.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_WORDSTYLESUPDATED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = currentBufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_WORDSTYLESUPDATEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that user initiated a WordStyleDlg change.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_WORDSTYLESUPDATED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = currentBufferID;</para>
        /// </summary>
        public static event OnNPPN_WORDSTYLESUPDATEDHandler OnNPPN_WORDSTYLESUPDATED;


        /// <summary>
        ///<para> To notify plugins that plugin command shortcut is remapped.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_SHORTCUTSREMAPPED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = ShortcutKeyStructurePointer;</para>
        ///<para>scnNotification.nmhdr.idFrom = cmdID;</para>
        ///<para>where ShortcutKeyStructurePointer is pointer of struct ShortcutKey:</para>
        ///<para>struct ShortcutKey {</para>
        ///<para>    bool _isCtrl;</para>
        ///<para>    bool _isAlt;</para>
        ///<para>    bool _isShift;</para>
        ///<para>    UCHAR _key;</para>
        ///<para>};</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_SHORTCUTREMAPPEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that plugin command shortcut is remapped.</para>
        ///<para>scnNotification.nmhdr.code = NPPN_SHORTCUTSREMAPPED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = ShortcutKeyStructurePointer;</para>
        ///<para>scnNotification.nmhdr.idFrom = cmdID;</para>
        ///<para>where ShortcutKeyStructurePointer is pointer of struct ShortcutKey:</para>
        ///<para>struct ShortcutKey {</para>
        ///<para>    bool _isCtrl;</para>
        ///<para>    bool _isAlt;</para>
        ///<para>    bool _isShift;</para>
        ///<para>    UCHAR _key;</para>
        ///<para>};</para>
        /// </summary>
        public static event OnNPPN_SHORTCUTREMAPPEDHandler OnNPPN_SHORTCUTREMAPPED;


        /// <summary>
        ///<para> To notify plugins that the current file is about to be loaded</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFOREOPEN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = NULL;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILEBEFORELOADHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that the current file is about to be loaded</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEBEFOREOPEN;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = NULL;</para>
        /// </summary>
        public static event OnNPPN_FILEBEFORELOADHandler OnNPPN_FILEBEFORELOAD;


        /// <summary>
        ///<para> To notify plugins that file open operation failed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEOPENFAILED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_FILELOADFAILEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that file open operation failed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_FILEOPENFAILED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = hwndNpp;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_FILELOADFAILEDHandler OnNPPN_FILELOADFAILED;


        /// <summary>
        ///<para> To notify plugins that current document change the readonly status,</para>
        ///<para>scnNotification.nmhdr.code = NPPN_READONLYCHANGED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = bufferID;</para>
        ///<para>scnNotification.nmhdr.idFrom = docStatus;</para>
        ///<para> where bufferID is BufferID</para>
        ///<para>       docStatus can be combined by DOCSTAUS_READONLY and DOCSTAUS_BUFFERDIRTY</para>
        ///<para>DOCSTAUS_READONLY = 1,</para>
        ///<para>DOCSTAUS_BUFFERDIRTY = 2,</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_READONLYCHANGEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that current document change the readonly status,</para>
        ///<para>scnNotification.nmhdr.code = NPPN_READONLYCHANGED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = bufferID;</para>
        ///<para>scnNotification.nmhdr.idFrom = docStatus;</para>
        ///<para> where bufferID is BufferID</para>
        ///<para>       docStatus can be combined by DOCSTAUS_READONLY and DOCSTAUS_BUFFERDIRTY</para>
        ///<para>DOCSTAUS_READONLY = 1,</para>
        ///<para>DOCSTAUS_BUFFERDIRTY = 2,</para>
        /// </summary>
        public static event OnNPPN_READONLYCHANGEDHandler OnNPPN_READONLYCHANGED;


        /// <summary>
        ///<para> To notify plugins that document order is changed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_DOCORDERCHANGED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = newIndex;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnNPPN_DOCORDERCHANGEDHandler(SCNotification scnNotification);
        /// <summary>
        ///<para> To notify plugins that document order is changed</para>
        ///<para>scnNotification.nmhdr.code = NPPN_DOCORDERCHANGED;</para>
        ///<para>scnNotification.nmhdr.hwndFrom = newIndex;</para>
        ///<para>scnNotification.nmhdr.idFrom = BufferID;</para>
        /// </summary>
        public static event OnNPPN_DOCORDERCHANGEDHandler OnNPPN_DOCORDERCHANGED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_STYLENEEDEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_STYLENEEDEDHandler OnSCN_STYLENEEDED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_CHARADDEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_CHARADDEDHandler OnSCN_CHARADDED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_SAVEPOINTREACHEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_SAVEPOINTREACHEDHandler OnSCN_SAVEPOINTREACHED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_SAVEPOINTLEFTHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_SAVEPOINTLEFTHandler OnSCN_SAVEPOINTLEFT;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_MODIFYATTEMPTROHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_MODIFYATTEMPTROHandler OnSCN_MODIFYATTEMPTRO;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_KEYHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_KEYHandler OnSCN_KEY;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_DOUBLECLICKHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_DOUBLECLICKHandler OnSCN_DOUBLECLICK;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_UPDATEUIHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_UPDATEUIHandler OnSCN_UPDATEUI;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_MODIFIEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_MODIFIEDHandler OnSCN_MODIFIED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_MACRORECORDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_MACRORECORDHandler OnSCN_MACRORECORD;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_MARGINCLICKHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_MARGINCLICKHandler OnSCN_MARGINCLICK;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_NEEDSHOWNHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_NEEDSHOWNHandler OnSCN_NEEDSHOWN;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_PAINTEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_PAINTEDHandler OnSCN_PAINTED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_USERLISTSELECTIONHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_USERLISTSELECTIONHandler OnSCN_USERLISTSELECTION;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_URIDROPPEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_URIDROPPEDHandler OnSCN_URIDROPPED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_DWELLSTARTHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_DWELLSTARTHandler OnSCN_DWELLSTART;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_DWELLENDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_DWELLENDHandler OnSCN_DWELLEND;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_ZOOMHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_ZOOMHandler OnSCN_ZOOM;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_HOTSPOTCLICKHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_HOTSPOTCLICKHandler OnSCN_HOTSPOTCLICK;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_HOTSPOTDOUBLECLICKHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_HOTSPOTDOUBLECLICKHandler OnSCN_HOTSPOTDOUBLECLICK;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_CALLTIPCLICKHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_CALLTIPCLICKHandler OnSCN_CALLTIPCLICK;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_AUTOCSELECTIONHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_AUTOCSELECTIONHandler OnSCN_AUTOCSELECTION;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_INDICATORCLICKHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_INDICATORCLICKHandler OnSCN_INDICATORCLICK;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_INDICATORRELEASEHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_INDICATORRELEASEHandler OnSCN_INDICATORRELEASE;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_AUTOCCANCELLEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_AUTOCCANCELLEDHandler OnSCN_AUTOCCANCELLED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_AUTOCCHARDELETEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_AUTOCCHARDELETEDHandler OnSCN_AUTOCCHARDELETED;


        /// <summary>

        /// </summary>
        /// <param name="nc">SCNotification</param>
        public delegate void OnSCN_SCROLLEDHandler(SCNotification scnNotification);
        /// <summary>

        /// </summary>
        public static event OnSCN_SCROLLEDHandler OnSCN_SCROLLED;


        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nc"></param>
        public delegate void OnNPPN_UNKNOWNMSGHandler(SCNotification nc);
        /// <summary>
        /// 
        /// </summary>
        public static event OnNPPN_UNKNOWNMSGHandler OnNPPN_UNKNOWNMSG;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nc"></param>
        public delegate void OnNPPN_CATCHALLHandler(SCNotification nc);
        /// <summary>
        /// 
        /// </summary>
        public static event OnNPPN_CATCHALLHandler OnNPPN_CATCHALL;


        public static void _triggerevent(SCNotification nc) {

            if (OnNPPN_CATCHALL != null)
                OnNPPN_CATCHALL(nc);

            switch (nc.nmhdr.code) {
                #region AUTO

                case (uint)NppMsg.NPPN_READY:
                    if (OnNPPN_READY != null)
                        OnNPPN_READY(nc);
                    break;
                case (uint)NppMsg.NPPN_TBMODIFICATION:
                    if (OnNPPN_TBMODIFICATION != null)
                        OnNPPN_TBMODIFICATION(nc);
                    break;
                case (uint)NppMsg.NPPN_FILEBEFORECLOSE:
                    if (OnNPPN_FILEBEFORECLOSE != null)
                        OnNPPN_FILEBEFORECLOSE(nc);
                    break;
                case (uint)NppMsg.NPPN_FILEOPENED:
                    if (OnNPPN_FILEOPENED != null)
                        OnNPPN_FILEOPENED(nc);
                    break;
                case (uint)NppMsg.NPPN_FILECLOSED:
                    if (OnNPPN_FILECLOSED != null)
                        OnNPPN_FILECLOSED(nc);
                    break;
                case (uint)NppMsg.NPPN_FILEBEFOREOPEN:
                    if (OnNPPN_FILEBEFOREOPEN != null)
                        OnNPPN_FILEBEFOREOPEN(nc);
                    break;
                case (uint)NppMsg.NPPN_FILEBEFORESAVE:
                    if (OnNPPN_FILEBEFORESAVE != null)
                        OnNPPN_FILEBEFORESAVE(nc);
                    break;
                case (uint)NppMsg.NPPN_FILESAVED:
                    if (OnNPPN_FILESAVED != null)
                        OnNPPN_FILESAVED(nc);
                    break;
                case (uint)NppMsg.NPPN_SHUTDOWN:
                    if (OnNPPN_SHUTDOWN != null)
                        OnNPPN_SHUTDOWN(nc);
                    break;
                case (uint)NppMsg.NPPN_BUFFERACTIVATED:
                    if (OnNPPN_BUFFERACTIVATED != null)
                        OnNPPN_BUFFERACTIVATED(nc);
                    break;
                case (uint)NppMsg.NPPN_LANGCHANGED:
                    if (OnNPPN_LANGCHANGED != null)
                        OnNPPN_LANGCHANGED(nc);
                    break;
                case (uint)NppMsg.NPPN_WORDSTYLESUPDATED:
                    if (OnNPPN_WORDSTYLESUPDATED != null)
                        OnNPPN_WORDSTYLESUPDATED(nc);
                    break;
                case (uint)NppMsg.NPPN_SHORTCUTREMAPPED:
                    if (OnNPPN_SHORTCUTREMAPPED != null)
                        OnNPPN_SHORTCUTREMAPPED(nc);
                    break;
                case (uint)NppMsg.NPPN_FILEBEFORELOAD:
                    if (OnNPPN_FILEBEFORELOAD != null)
                        OnNPPN_FILEBEFORELOAD(nc);
                    break;
                case (uint)NppMsg.NPPN_FILELOADFAILED:
                    if (OnNPPN_FILELOADFAILED != null)
                        OnNPPN_FILELOADFAILED(nc);
                    break;
                case (uint)NppMsg.NPPN_READONLYCHANGED:
                    if (OnNPPN_READONLYCHANGED != null)
                        OnNPPN_READONLYCHANGED(nc);
                    break;
                case (uint)NppMsg.NPPN_DOCORDERCHANGED:
                    if (OnNPPN_DOCORDERCHANGED != null)
                        OnNPPN_DOCORDERCHANGED(nc);
                    break;
                case (uint)SciMsg.SCN_STYLENEEDED:
                    if (OnSCN_STYLENEEDED != null)
                        OnSCN_STYLENEEDED(nc);
                    break;
                case (uint)SciMsg.SCN_CHARADDED:
                    if (OnSCN_CHARADDED != null)
                        OnSCN_CHARADDED(nc);
                    break;
                case (uint)SciMsg.SCN_SAVEPOINTREACHED:
                    if (OnSCN_SAVEPOINTREACHED != null)
                        OnSCN_SAVEPOINTREACHED(nc);
                    break;
                case (uint)SciMsg.SCN_SAVEPOINTLEFT:
                    if (OnSCN_SAVEPOINTLEFT != null)
                        OnSCN_SAVEPOINTLEFT(nc);
                    break;
                case (uint)SciMsg.SCN_MODIFYATTEMPTRO:
                    if (OnSCN_MODIFYATTEMPTRO != null)
                        OnSCN_MODIFYATTEMPTRO(nc);
                    break;
                case (uint)SciMsg.SCN_KEY:
                    if (OnSCN_KEY != null)
                        OnSCN_KEY(nc);
                    break;
                case (uint)SciMsg.SCN_DOUBLECLICK:
                    if (OnSCN_DOUBLECLICK != null)
                        OnSCN_DOUBLECLICK(nc);
                    break;
                case (uint)SciMsg.SCN_UPDATEUI:
                    if (OnSCN_UPDATEUI != null)
                        OnSCN_UPDATEUI(nc);
                    break;
                case (uint)SciMsg.SCN_MODIFIED:
                    if (OnSCN_MODIFIED != null)
                        OnSCN_MODIFIED(nc);
                    break;
                case (uint)SciMsg.SCN_MACRORECORD:
                    if (OnSCN_MACRORECORD != null)
                        OnSCN_MACRORECORD(nc);
                    break;
                case (uint)SciMsg.SCN_MARGINCLICK:
                    if (OnSCN_MARGINCLICK != null)
                        OnSCN_MARGINCLICK(nc);
                    break;
                case (uint)SciMsg.SCN_NEEDSHOWN:
                    if (OnSCN_NEEDSHOWN != null)
                        OnSCN_NEEDSHOWN(nc);
                    break;
                case (uint)SciMsg.SCN_PAINTED:
                    if (OnSCN_PAINTED != null)
                        OnSCN_PAINTED(nc);
                    break;
                case (uint)SciMsg.SCN_USERLISTSELECTION:
                    if (OnSCN_USERLISTSELECTION != null)
                        OnSCN_USERLISTSELECTION(nc);
                    break;
                case (uint)SciMsg.SCN_URIDROPPED:
                    if (OnSCN_URIDROPPED != null)
                        OnSCN_URIDROPPED(nc);
                    break;
                case (uint)SciMsg.SCN_DWELLSTART:
                    if (OnSCN_DWELLSTART != null)
                        OnSCN_DWELLSTART(nc);
                    break;
                case (uint)SciMsg.SCN_DWELLEND:
                    if (OnSCN_DWELLEND != null)
                        OnSCN_DWELLEND(nc);
                    break;
                case (uint)SciMsg.SCN_ZOOM:
                    if (OnSCN_ZOOM != null)
                        OnSCN_ZOOM(nc);
                    break;
                case (uint)SciMsg.SCN_HOTSPOTCLICK:
                    if (OnSCN_HOTSPOTCLICK != null)
                        OnSCN_HOTSPOTCLICK(nc);
                    break;
                case (uint)SciMsg.SCN_HOTSPOTDOUBLECLICK:
                    if (OnSCN_HOTSPOTDOUBLECLICK != null)
                        OnSCN_HOTSPOTDOUBLECLICK(nc);
                    break;
                case (uint)SciMsg.SCN_CALLTIPCLICK:
                    if (OnSCN_CALLTIPCLICK != null)
                        OnSCN_CALLTIPCLICK(nc);
                    break;
                case (uint)SciMsg.SCN_AUTOCSELECTION:
                    if (OnSCN_AUTOCSELECTION != null)
                        OnSCN_AUTOCSELECTION(nc);
                    break;
                case (uint)SciMsg.SCN_INDICATORCLICK:
                    if (OnSCN_INDICATORCLICK != null)
                        OnSCN_INDICATORCLICK(nc);
                    break;
                case (uint)SciMsg.SCN_INDICATORRELEASE:
                    if (OnSCN_INDICATORRELEASE != null)
                        OnSCN_INDICATORRELEASE(nc);
                    break;
                case (uint)SciMsg.SCN_AUTOCCANCELLED:
                    if (OnSCN_AUTOCCANCELLED != null)
                        OnSCN_AUTOCCANCELLED(nc);
                    break;
                case (uint)SciMsg.SCN_AUTOCCHARDELETED:
                    if (OnSCN_AUTOCCHARDELETED != null)
                        OnSCN_AUTOCCHARDELETED(nc);
                    break;
                case (uint)SciMsg.SCN_SCROLLED:
                    if (OnSCN_SCROLLED != null)
                        OnSCN_SCROLLED(nc);
                    break;

                #endregion
                default:
                    if (OnNPPN_UNKNOWNMSG != null)
                        OnNPPN_UNKNOWNMSG(nc);
                    break;
            }
        }
    }
}
