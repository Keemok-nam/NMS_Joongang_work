using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

using System.Collections;
using System.IO;

namespace NMS_Simulation
{
    public delegate void SetTextCallback(Control control, string text);
    public delegate void SetEnableCallback(Control control, bool flag);
    public delegate void SetColorCallback(Control control, Color color);
    public delegate void SetVisibleCallback(Control control, bool flag);
    public delegate void SetCheckedCallback(CheckBox control, bool flag);
    public delegate void SetRdButCheckedCallback(RadioButton control, bool flag);
    public delegate void SetValueCallback(ProgressBar control, int maxValue, int value);
    public delegate void SetTBValueCallback(TrackBar control, int value);
    public delegate void SetImageCallback(PictureBox control, Bitmap tmpBitmap);

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
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 공통 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public static string DefaultPath = Application.StartupPath.ToString() + @"\";
        public static string IconPath = Application.StartupPath.ToString() + @"\ICON\";
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
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public static bool[] flagDebug = new bool[CNTMACHINE];       //송수신 Data 보기 여부

        public static byte presentMUID = new byte();
        public static byte presentRUID = new byte();
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
            }

            return tmpVer;
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }

    public class AFGain
    {
        public int gainTx = new int();
        public int gainRx = new int();
        public int gainMon = new int();
    }

    public class RUData
    {
        /// <summary>
        /// RU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow상태, 3:AC 전원상태, 4:DC 전원상태,
        ///               5:MODOPEN 상태, 6:PTT 상태, 7:Local/Remote상태)
        /// </summary>
        public byte[] otherSt1 = new byte[8];
        /// <summary>
        /// RU의 기타 상태(8:RUCPU 상태,
        ///               9:데이터 광접속 상태, 10:음성 광접속 상태, 11:OPT LD 알람, 12:OPT PD 알람
        ///               13:XMTR PLL LOCK, 14:RCVR PLL LOCK 장애)
        /// </summary>
        public byte[] otherSt2 = new byte[8];

        /// <summary>
        /// RU의 DC전원값
        /// </summary>
        public byte dcValue = new byte();

        /// <summary>
        /// RU의 RF 출력값
        /// </summary>
        public byte rfValue = new byte();

        /// <summary>
        /// RU의 RF 조회값
        /// </summary>
        public byte rfValueInquiry = new byte();

        /// <summary>
        /// RU의 RX RSSI 값
        /// </summary>
        public byte rxRssiValue = new byte();

        public BDA_St[] bdaSt = new BDA_St[4];

        public RUData()
        {
            int i = 0;

            for (i = 0; i < 8; i++)
            {
                otherSt1[i] = new byte();
                otherSt2[i] = new byte();
            }

            for (i = 0; i < 4; i++)
                bdaSt[i] = new BDA_St();
        }
    }

    public class MUData
    {
        /// <summary>
        /// MU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RC1 PTT 상태)
        /// </summary>
        public byte[] otherSt1 = new byte[8];
        /// <summary>
        /// MU의 기타 상태(8: RC2 PTT 상태, 9: RC3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY)
        /// </summary>
        public byte[] otherSt2 = new byte[8];

        /// <summary>
        /// MU의 DC전원값
        /// </summary>
        public byte dcValue = new byte();

        /// <summary>
        /// MU의 주/예비 RF 출력값
        /// </summary>
        public byte[] rfValue = new byte[2];      //주/예비 RF 출력값
        /// <summary>
        /// MU의 역용 주/예비/감청용 RX RSSI 값
        /// </summary>
        public byte[] rxRssiValue = new byte[3];
        /// <summary>
        /// MU의 주/예비 RF 출력조회값
        /// </summary>
        public byte[] rfValueInquiry = new byte[2];     //주/예비 RF 출력조회값

        /// <summary>
        /// MU의 역용 주/예비/감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
        /// </summary>
        public byte[] chInfo = new byte[3];

        /// <summary>
        /// OPT 통신 감시 및 각 CPU 카드 장착 상태(0:역용 주 통신 감시, 1:역용 예비 통신 감시, 2:역용 감청 통신 감시, 3:MU Trx CPU 장착여부, 4:MU Opt CPU 장착여부, 5:MU UPS 연결 여부)
        /// </summary>
        public byte[] optMonSt = new byte[8];

        /// <summary>
        /// OPT 기타 상태(0:DC 전원상태, 1:MODOPEN 상태, 2:CCE PTT 상태)
        /// </summary>
        public byte[] optOtherSt = new byte[8];

        /// <summary>
        /// OPT DC전원값
        /// </summary>
        public byte optDcValue = new byte();

        /// <summary>
        /// OPT 알람 상태(0~3:OPT1~OPT4 LD 알람, 4~7:OPT1~OPT4 PD 알람)
        /// </summary>
        public byte[] optAlarmSt = new byte[8];

        /// <summary>
        /// 채널 복귀 상태( 0:Off, 1~255초 )
        /// </summary>
        public byte chReturn = new byte();

        /// <summary>
        /// PLL Lock 장애 상태(0:역용 주 PLL LOCK 장애, 1:역용 예비 PLL LOCK 장애, 2:감청 PLL LOCK 장애)
        /// </summary>
        public byte[] pllLockErrorSt = new byte[8];

        /// <summary>
        /// Test Mode(0:Off, 1:TX Test(Level 측정), 2:RX Test(Tone 송출), 3:Mon Test(Tone송출))
        /// </summary>
        public byte[] testMode = new byte[8];

        /// <summary>
        /// 레벨 측정값
        /// </summary>
        public byte revelValue = new byte();

        public MUData()
        {
            int i = 0;

            for (i = 0; i < 8; i++)
            {
                otherSt1[i] = new byte();
                otherSt2[i] = new byte();
                optMonSt[i] = new byte();
                optOtherSt[i] = new byte();
                optAlarmSt[i] = new byte();
                pllLockErrorSt[i] = new byte();
                testMode[i] = new byte();
            }

            for (i = 0; i < 2; i++)
            {
                rfValue[i] = new byte();
                rfValueInquiry[i] = new byte();
            }

            for (i = 0; i < 3; i++)
            {
                rxRssiValue[i] = new byte();
                chInfo[i] = new byte();
            }
        }
    }

    public class UPSData
    {
        /// <summary>
        /// 입력전압
        /// </summary>
        public string inVoltage = string.Empty;

        /// <summary>
        /// 과실전압
        /// </summary>
        public string faultVoltage = string.Empty;

        /// <summary>
        /// 출력전압
        /// </summary>
        public string outVoltage = string.Empty;

        /// <summary>
        /// 출력전류
        /// </summary>
        public string currentPercent = string.Empty;

        /// <summary>
        /// 주파수
        /// </summary>
        public string frequency = string.Empty;

        /// <summary>
        /// 배터리 전압
        /// </summary>
        public string batteryVoltage = string.Empty;

        /// <summary>
        /// 온도
        /// </summary>
        public string temperature = string.Empty;

        /// <summary>
        /// 상태(0:Beeper On, 1:Shutdown Active, 2:Test in Progress, 3:UPS Type is Standby, 4:UPS Failed, 5:Bypass/Boost or Buck Active, 6:Battery Low, 7:Utility Fail)
        /// </summary>
        public byte[] otherSt = new byte[8];

        public UPSData()
        {
            for (int i = 0; i < 8; i++)
                otherSt[i] = new byte();
        }
    }

    public class MURUData
    {
        public MUData muData = new MUData();
        public UPSData upsData = new UPSData();
        public AFGain[] afGain = new AFGain[4];
        public RUData[] ruData = new RUData[5];

        public MURUData()
        {
            int i = 0;

            for (i = 0; i < 4; i++)
                afGain[i] = new AFGain();

            for (i = 0; i < 5; i++)
                ruData[i] = new RUData();
        }
    }

    public class BDAInit
    {
        public bool[] flagBDAEnable = new bool[4];
        public byte bdaFreqCode = new byte();
        public bool flagBDAPollEnable = new bool();
        public byte pollTime = new byte();

        public BDAInit()
        {
            for (int i = 0; i < 4; i++)
                flagBDAEnable[i] = new bool();

            pollTime = 10;
        }
    }

    public class BDA_St
    {
        public byte[] bdaAMPSt = new byte[8];
        public byte[] bdaUpsSt = new byte[8];

        public byte[] ampDBM = new byte[5];

        public BDA_St()
        {
            int i = 0;

            for (i = 0; i < 8; i++)
            {
                bdaAMPSt[i] = new byte();
                bdaUpsSt[i] = new byte();
            }

            for (i = 0; i < 5; i++)
                ampDBM[i] = new byte();
        }
    }
}
