using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

using System.Collections;
using System.IO;

namespace NMS
{
    public delegate void SetControlLocationSizeCallback(Control control, int width, int height, int left, int top);
    public delegate void SetTextCallback(Control control, string text);
    public delegate void SetEnableCallback(Control control, bool flag);
    public delegate void SetColorCallback(Control control, Color color);
    public delegate void SetVisibleCallback(Control control, bool flag);
    public delegate void SetCheckedCallback(CheckBox control, bool flag);
    public delegate void SetRdButCheckedCallback(RadioButton control, bool flag);
    public delegate void SetValueCallback(ProgressBar control, int maxValue, int value);
    public delegate void SetTBValueCallback(TrackBar control, int value);
    public delegate void SetImageCallback(PictureBox control, Bitmap tmpBitmap);

    public delegate void SetListViewItemClearCallback(ListView lvControl);
    public delegate void SetListViewItemInsertCallback(ListView lvControl, int index, ListViewItem lvItem);

    public delegate void SetdataGridViewClearCallback(DataGridView dgvControl);
    public delegate void SetdataGridViewMuErrorStValueCallback(DataGridView dgvControl, int index, string dateTime, string content);
    public delegate void SetdataGridViewMuTxRxErxStValueCallback(DataGridView dgvControl, int index, string content, string ch, string startDateTime, string stopDateTime);

    //public delegate void SetDataGridViewClearCallback(DataGridView dgvControl);
    //public delegate void SetDataGridViewDataAddCallback(DataGridView dgvControl, IndiInfo[] tmpIndiInfo);
    //public delegate void SetDataGridViewFirstDisplayedScrollingRowIndexCallback(DataGridView dgvControl, int index);

    //public delegate void UdpReceivedEvent(clsUdpSocket uSock, byte[] buffer, int lng);
    //public delegate void UdpClientReceivedEvent(byte[] buffer, int lng);
    
    //public delegate void ComReceivedEvent(clsUnitM comPort, byte[] buffer, int lng);

    /// <summary>
    /// 현재 상태를 상황창에 표시하는 이벤트
    /// </summary>
    /// <param name="strStatus">상황창에 표시할 문구</param>
    public delegate void StatusDisplay(string strStatus);

    public class clsCommon
    {
        #region 공통 프로토콜 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //공통
        public const byte SOM = 0x7E;               //시작과 끝을 나타낸다.
        public const byte SOM_CHK = 0x55;           //7E 55 : Data의 시작
        public const byte EOM_CHK = 0xAA;           //7E AA : Data의 끝

        public const byte STX = 0x02;               //시작과 끝을 나타낸다.
        public const byte ETX = 0x03;               //7E 55 : Data의 시작

        public const byte TAB = 0x09;               //
        public const byte CR = 0x0D;                //7E 55 : Data의 시작

        public const byte CMD_LineTest = 0x54;      //T : 회선 시험
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 공통 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public static string DefaultPath = Application.StartupPath.ToString() + @"\";
        public static string ImagePath = Application.StartupPath.ToString() + @"\Image\";
        public static string IconPath = Application.StartupPath.ToString() + @"\ICON\";
        public static string DataBasePath = Application.StartupPath.ToString() + @"\DataBase\";
        public static string LogPath = Application.StartupPath.ToString() + @"\Log\";
        public static string SetupPath = Application.StartupPath.ToString() + @"\Setup\";
        public static string SoundPath = Application.StartupPath.ToString() + @"\Sound\";
        public static string InfoPath = Application.StartupPath.ToString() + @"\Info\";
        public static string CapturePath = Application.StartupPath.ToString() + @"\Capture\";
        public static string RecordPath = Application.StartupPath.ToString() + @"\Record\";

        public static string tmpVer = string.Empty;

        public const byte CNTMENU = 1;

        #region 장비별 index
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public const byte CNTMACHINE = 8;

        public const byte NMS = 0;          //NMS 주장치
        public const byte CCE1 = 1;         //구로 CCE Test Panel
        public const byte CCE2 = 2;         //대전 CCE Test Panel
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public static string nmsGUIUser = string.Empty;

        public static bool[] flagDebug = new bool[CNTMACHINE];       //송수신 Data 보기 여부

        public static byte presentMUID = new byte();
        public static byte presentRUID = new byte();

        public static bool flagDataViewTypeASCII = false;      //송/수신 Data 보기방법(T : ASCII, F : HEX)

        //주장치(CCE Test Panel)에서 사용하는 ID
        public const byte ID_CPU = 0xF0;
        public const byte ID_Console = 0x30;     //0x30 ~ 0x38
        public const byte ID_Broad = 0x39;
        public const byte ID_Base = 0x00;       //0x00 ~ 0x1D
        public const byte ID_PC = 0x40;

        public static int stationCount = 0;

        public static bool flagLineTest = new bool();

        public static MuRuName[] muruName = null;

        public static MuRuFmExist[] muruFmExist = new MuRuFmExist[100];
        public static MuRuComSt[] muruComSt = new MuRuComSt[100];
        public static CCEComSt[] cceComSt = new CCEComSt[3];

        //MU/RU 송신출력 관련 Table
        public static byte[] muRfValueTable = new byte[13];
        public static byte[] ruRfValueTable = new byte[13];

        //MU/RU Error 여부
        public static bool[,,] flagMuRuBdaError = new bool[24, 5, 5];
        public static bool[] flagUPSError = new bool[24];

        public static bool[] flagStationAlarm = new bool[100];
        public static bool[] flagSpare = new bool[100];     //MU의 예비가 있으면 True, 없으면 False

        public static ErrorContent[] errContent = new ErrorContent[6];
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region ASCII -> HEX -> DECIMAL
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public static byte AHD(int iTmp)
        {
            if ((iTmp >= 0x30) && (iTmp <= 0x39))
                return (byte)(iTmp - 48);
            else
                return (byte)(iTmp - 55);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region HexaConvert
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public static byte HexaConvert(int by)
        {
            byte b = 0x00;

            switch (by)
            {
                case 0: b = 0x30; break;
                case 1: b = 0x31; break;
                case 2: b = 0x32; break;
                case 3: b = 0x33; break;
                case 4: b = 0x34; break;
                case 5: b = 0x35; break;
                case 6: b = 0x36; break;
                case 7: b = 0x37; break;
                case 8: b = 0x38; break;
                case 9: b = 0x39; break;
                case 10: b = 0x41; break;
                case 11: b = 0x42; break;
                case 12: b = 0x43; break;
                case 13: b = 0x44; break;
                case 14: b = 0x45; break;
                case 15: b = 0x46; break;
            }
            return b;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region CheckSum 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public static byte MakeCheckSum(byte[] tmpBuf, int lng)
        {
            //CheckSum 검사
            int dcuChkSum = 0;

            for (int i = 0; i < lng; i++)
                dcuChkSum = dcuChkSum ^ tmpBuf[i];

            return (byte)dcuChkSum;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Version Check
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public static int VerCheck(string ver)
        {
            int tmpVer = -1;

            switch (ver)
            {
                case "Ver 1.00": tmpVer = 0; break;
                case "Ver 1.01": tmpVer = 1; break;
                case "Ver 1.02": tmpVer = 2; break;
                case "Ver 1.03": tmpVer = 3; break;
                case "Ver 1.04": tmpVer = 4; break;
                case "Ver 1.05": tmpVer = 5; break;
                case "Ver 1.06": tmpVer = 6; break;
                case "Ver 1.07": tmpVer = 7; break;
                case "Ver 1.08": tmpVer = 8; break;
                case "Ver 1.09": tmpVer = 9; break;
                case "Ver 1.10": tmpVer = 10; break;
                case "Ver 1.11": tmpVer = 11; break;
                case "Ver 1.12": tmpVer = 12; break;
                case "Ver 1.13": tmpVer = 13; break;
                case "Ver 1.14": tmpVer = 14; break;
                case "Ver 1.15": tmpVer = 15; break;
                case "Ver 1.16": tmpVer = 16; break;
                case "Ver 1.17": tmpVer = 17; break;
                case "Ver 1.18": tmpVer = 18; break;
                case "Ver 1.19": tmpVer = 19; break;
                case "Ver 1.20": tmpVer = 20; break;
                case "Ver 1.21": tmpVer = 21; break;
                case "Ver 1.22": tmpVer = 22; break;
                case "Ver 1.23":
                case "Ver 1.24":
                case "Ver 1.25":
                case "Ver 1.26":
                case "Ver 1.27":
                case "Ver 1.28": tmpVer = 23; break;
                case "Ver 1.29": tmpVer = 24; break;
                case "Ver 1.30":
                case "Ver 1.31":
                case "Ver 1.32": tmpVer = 25; break;
            }

            return tmpVer;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public static byte Make_MUID(byte muID)
        {
            if (muID == 0) return 0x30;
            else return (byte)(muID + 0x40);
        }

        public static byte Make_RUID(byte ruID)
        {
            return (byte)(ruID + 0x30);
        }
    }

    public class rcInfo
    {
        public String name;

        public bool flagVisibel = new bool();

        public int top = new int();
        public int left = new int();

        public int width = new int();
        public int height = new int();

        public byte muID = new byte();
        public byte ruID = new byte();
    }

    public class rcButtonInfo
    {
        public rcInfo[] rcBtInfo = new rcInfo[24];

        public rcButtonInfo()
        {
            for (int i = 0; i < 24; i++)
                rcBtInfo[i] = new rcInfo();
        }
    }

    public class MuRuFmExist
    {
        public bool flagMu = false;
        public bool[] flagRu = new bool[4];

        public MuRuFmExist()
        {
            for (int i = 0; i < 4; i++)
                flagRu[i] = false;
        }
    }

    public class ErrorContent
    {
        public List<string> errName = new List<string>();
        public List<string> errContent = new List<string>();
    }
}
