using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace NMS_Simulation
{
    #region NMS 통신 관련 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #region 소켓 통신 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    public delegate void AcceptedEvent(Socket sock);
    public delegate void ReceivedEvent(SendReceive SendRecv, byte[] buffer, int lng);

    public delegate void CloseEvent(SendReceive SendRecv);
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion

    #region NMS GUI와의 통신 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    /// <summary>
    /// 소켓과 연결이 되었음을 알려주기 위한 이벤트
    /// </summary>
    public delegate void socket_AcceptedEvent();
    /// <summary>
    /// 소켓과의 연결이 닫혔음을 알려주기 위한 이벤트
    /// </summary>
    public delegate void socket_ClosedEvent();

    /// <summary>
    /// NMS GUI와의 폴링 상태를 알려주기 위한 이벤트
    /// </summary>
    /// <param name="flag">true : 정상, false : 이상</param>
    public delegate void NMSMainMachine_PollingEvent(bool flag);

    /// <summary>
    /// NMS GUI에서 "주/예비 절체" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="mainSpare">주/예비(0:주, 1:예비) 절체</param>
    public delegate void NMSMainMachine_MainSpareChangeEvent(byte muID, byte ruID, byte mainSpare);

    /// <summary>
    /// NMS GUI에서 "주/예비 절체" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="mainSpare">자동/수동(0:자동, 1:수동) 절체</param>
    public delegate void NMSMainMachine_AutoStbyChangeEvent(byte muID, byte ruID, byte autoManual);

    /// <summary>
    /// NMS GUI에서 "주/예비 RF 출력값" 설정하는 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="mainStby">0 : 주, 1 : 예비</param>
    /// <param name="rfValue">설정 값</param>
    public delegate void NMSMainMachine_RFGainSetEvent(byte muID, byte ruID, byte mainStby, byte rfValue);

    /// <summary>
    /// NMS GUI에서 "CCE/RC1/RC2/RC3의 TX/RX/MON AF Gain 값" 설정하는 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="rcNum">설정할 종류(0:CCE, 1:RC1, 2:RC2, 3:RC3)</param>
    /// <param name="value">AFGain 설정값</param>
    public delegate void NMSMainMachine_AFGainSetEvent(byte muID, byte ruID, byte rcNum, AFGain value);

    /// <summary>
    /// NMS GUI에서 AF Gain(CCE, RC1, RC2, RC3)값을 요청하는 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    public delegate void NMSMainMachine_AFGainInquiryEvent(byte muID, byte ruID);

    /// <summary>
    /// NMS GUI에서 "광대역/협대역 절체" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="wideNarrow">광대역/협대역(0/1) 절체</param>
    public delegate void NMSMainMachine_WideNarrowChangeEvent(byte muID, byte ruID, byte wideNarrow);

    /// <summary>
    /// NMS GUI에서 "채널복귀 시간 설정" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="chReturnTime">채널복귀 시간</param>
    public delegate void NMSMainMachine_ChReturnTimeSetEvent(byte muID, byte chReturnTime);

    /// <summary>
    /// NMS GUI에서 "BDA 초기 설정값 조회" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    public delegate void NMSMainMachine_BDAInitStInquiryEvent(byte muID, byte ruID);

    /// <summary>
    /// NMS GUI에서 "BDA 초기값 설정" 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaInit">BDA 초기 설정값</param>
    public delegate void NMSMainMachine_BDAInitStSetEvent(byte muID, byte ruID, BDAInit bdaInit);

    /// <summary>
    /// NMS GUI에서 "BDA 상태 조회" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    public delegate void NMSMainMachine_BDAStInquiryEvent(byte muID, byte ruID, byte bdaID);

    /// <summary>
    /// NMS GUI에서 "BDA LoopTest" 요청 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    public delegate void NMSMainMachine_BDALoopTestEvent(byte muID, byte ruID, byte bdaID);

    /// <summary>
    /// NMS GUI에서 "Rf 출력값 설정" 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    /// <param name="rfValue">Rf 출력값</param>
    public delegate void NMSMainMachine_BDARfSetEvent(byte muID, byte ruID, byte bdaID, byte rfValue);

    /// <summary>
    /// NMS GUI에서 "Rf 출력값 조회" 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    public delegate void NMSMainMachine_BDARfInquiryEvent(byte muID, byte ruID, byte bdaID);

    /// <summary>
    /// NMS GUI에서 "주파수 설정" 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="freqCode">현재 주파수, 변경할 주파수</param>
    public delegate void NMSMainMachine_BDAFreqSetEvent(byte muID, byte ruID, byte[] freqCode);

    /// <summary>
    /// 송/수신한 Data를 표현하기 위한 이벤트
    /// </summary>
    /// <param name="flagSend">true : 송신, false : 수신</param>
    /// <param name="strData">송/수신된 Data 내용</param>
    public delegate void NMSMainMachine_SendReceiveDataViewEvent(bool flagSend, string strData);

    /// <summary>
    /// Data 송/수신 이벤트
    /// </summary>
    public delegate void NMSMainMachine_DataSendReceiveEvent(bool flagSend);

    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion

    class clsNMSGUI
    {
        #region NMS GUI 관련 이벤트 정의(NMS 주장치 -> NMS GUI)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// NMS GUI의 CPU 소켓과 연결이 되었음을 알려주기 위한 이벤트
        /// </summary>
        public event socket_AcceptedEvent nms_SocketAccepted = null;
        /// <summary>
        /// NMS GUI의 CPU 소켓과의 연결이 닫혔음을 알려주기 위한 이벤트
        /// </summary>
        public event socket_ClosedEvent nms_SocketCloseed = null;

        /// <summary>
        /// NMS GUI의 CPU와의 폴링 상태를 알려주기 위한 이벤트
        /// </summary>
        /// <param name="flag">true : 정상, false : 이상</param>
        public event NMSMainMachine_PollingEvent nms_Polling = null;

        /// <summary>
        /// NMS GUI에서 "주/예비 절체" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="mainSpare">주/예비(0:주, 1:예비) 절체</param>
        public event NMSMainMachine_MainSpareChangeEvent nms_MainSpareChange = null;

        /// <summary>
        /// NMS GUI에서 "주/예비 절체" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="mainSpare">자동/수동(0:자동, 1:수동) 절체</param>
        public event NMSMainMachine_AutoStbyChangeEvent nms_AutoStbyChange = null;

        /// <summary>
        /// NMS GUI에서 "주/예비 RF 출력값" 설정하는 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="flagMain">true : 주, false : 예비</param>
        /// <param name="rfValue">설정 값</param>
        public event NMSMainMachine_RFGainSetEvent nms_RfGainSet = null;

        /// <summary>
        /// NMS GUI에서 "CCE/RC1/RC2/RC3의 TX/RX/MON AF Gain 값" 설정하는 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="rcNum">설정할 종류(0:CCE, 1:RC1, 2:RC2, 3:RC3)</param>
        /// <param name="value">AFGain 설정값</param>
        public event NMSMainMachine_AFGainSetEvent nms_AfGainSet = null;

        /// <summary>
        /// NMS GUI에서 AF Gain(CCE, RC1, RC2, RC3)값을 요청하는 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        public event NMSMainMachine_AFGainInquiryEvent nms_AfGainInquiry = null;

        /// <summary>
        /// NMS GUI에서 "광대역/협대역 절체" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="wideNarrow">광대역/협대역(0/1) 절체</param>
        public event NMSMainMachine_WideNarrowChangeEvent nms_WideNarrowChange = null;

        /// <summary>
        /// NMS GUI에서 "채널복귀 시간 설정" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="chReturnTime">채널복귀 시간</param>
        public event NMSMainMachine_ChReturnTimeSetEvent nms_ChReturnTimeSet = null;

        /// <summary>
        /// NMS GUI에서 "BDA 초기 설정값 조회" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        public event NMSMainMachine_BDAInitStInquiryEvent nms_BdaInitStInquiry = null;

        /// <summary>
        /// NMS GUI에서 "BDA 초기값 설정" 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaInit">BDA 초기 설정값</param>
        public event NMSMainMachine_BDAInitStSetEvent nms_BdaInitStSet = null;

        /// <summary>
        /// NMS GUI에서 "BDA 상태 조회" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        public event NMSMainMachine_BDAStInquiryEvent nms_BdaStInquiry = null;

        /// <summary>
        /// NMS GUI에서 "BDA LoopTest" 요청 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        public event NMSMainMachine_BDALoopTestEvent nms_BdaLoopTest = null;

        /// <summary>
        /// NMS GUI에서 "Rf 출력값 설정" 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        /// <param name="rfValue">Rf 출력값</param>
        public event NMSMainMachine_BDARfSetEvent nms_BdaRfSet = null;

        /// <summary>
        /// NMS GUI에서 "Rf 출력값 조회" 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        public event NMSMainMachine_BDARfInquiryEvent nms_BdaRfInquiry = null;

        /// <summary>
        /// NMS GUI에서 "주파수 설정" 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="freqCode">현재 주파수, 변경할 주파수</param>
        public event NMSMainMachine_BDAFreqSetEvent nms_BdaFreqSet = null;

        /// <summary>
        /// 송/수신한 Data를 표현하기 위한 이벤트
        /// </summary>
        /// <param name="flagSend">true : 송신, false : 수신</param>
        /// <param name="strData">송/수신된 Data 내용</param>
        public event NMSMainMachine_SendReceiveDataViewEvent nms_SendReceiveDataView = null;

        /// <summary>
        /// Data 송/수신 이벤트
        /// </summary>
        public event NMSMainMachine_DataSendReceiveEvent nms_DataSendReceive = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private frmMain fMain;

        #region GUI <==> NMS 주장치 프로토콜 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //GUI ==> NMS 주장치
        /// <summary>
        /// C : 주예비 절체 명령
        /// </summary>
        public const byte CMD_MsinStbyChange = 0x43;

        /// <summary>
        /// A : 자동/수동 절체 명령
        /// </summary>
        public const byte CMD_AutoManualChange = 0x41;

        /// <summary>
        /// Y : RF 출력 조절
        /// </summary>
        public const byte CMD_RFGainSet = 0x59;

        /// <summary>
        /// E : CCE TX/RX/MON AF Gain 조절
        /// </summary>
        public const byte CMD_AFGainSet_CCE = 0x45;
        /// <summary>
        /// 1 : RC1 TX/RX/MON AF Gain 조절
        /// </summary>
        public const byte CMD_AFGainSet_RC1 = 0x31;
        /// <summary>
        /// 2 : RC2 TX/RX/MON AF Gain 조절
        /// </summary>
        public const byte CMD_AFGainSet_RC2 = 0x32;
        /// <summary>
        /// 3 : RC3 TX/RX/MON AF Gain 조절
        /// </summary>
        public const byte CMD_AFGainSet_RC3 = 0x33;

        /// <summary>
        /// B : 광대역/협대역 절체
        /// </summary>
        public const byte CMD_WideNarrowChange = 0x42;

        /// <summary>
        /// W : 송신 출력 시험
        /// </summary>
        public const byte CMD_SendOutTest = 0x57;

        /// <summary>
        /// T : 회선 시험
        /// </summary>
        public const byte CMD_LineTest = 0x54;

        /// <summary>
        /// H : 채널 복귀시간 설정
        /// </summary>
        public const byte CMD_ChReturnTimeSet = 0x48;

        //NMS 주장치 ==> GUI
        /// <summary>
        /// F : FM장치 감시 Data 보고
        /// </summary>
        public const byte CMD_FM_REPORT = 0x46;
        /// <summary>
        /// B : 방호장치 감시 Data 보고
        /// </summary>
        public const byte CMD_PT_REPORT = 0x42;
        /// <summary>
        /// V : 열차무선 감시 Data 보고
        /// </summary>
        public const byte CMD_TW_REPORT = 0x56;
        /// <summary>
        /// U : UPS 감시 Data 보고
        /// </summary>
        public const byte CMD_UPS_REPORT = 0x55;

        //GUI <==> NMS 주장치
        /// <summary>
        /// Q : CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값 요청/응답
        /// </summary>
        public const byte CMD_AFGain = 0x51;
        /// <summary>
        /// P : 폴링
        /// </summary>
        public const byte CMD_POLLING = 0x50;

        //BDA관련 프로토콜
        /// <summary>
        /// i : BDA 설정 초기화 요청 및 초기화
        /// </summary>
        public const byte CMD_BDA_Init = 0x69;
        /// <summary>
        /// r : BDA 설정 요청/응답
        /// </summary>
        public const byte CMD_BDA_Set = 0x72;
        /// <summary>
        /// s : BDA 상태 요청/응답
        /// </summary>
        public const byte CMD_BDA_StReport = 0x73;
        /// <summary>
        /// o : BDA Loop Test 요청/응답
        /// </summary>
        public const byte CMD_BDA_LoopTest = 0x6F;

        /// <summary>
        /// b : BDA 통신 상태 보고
        /// </summary>
        public const byte CMD_BDA_CommStReport = 0x62;
        /// <summary>
        /// v : BDA Rf 출력 상태 요청/응답
        /// </summary>
        public const byte CMD_BDA_Rf = 0x76;
        /// <summary>
        /// w : BDA Rf 출력 설정
        /// </summary>
        public const byte CMD_BDA_RfSet = 0x77;
        /// <summary>
        /// f : BDA 주파수 설정
        /// </summary>
        public const byte CMD_BDA_FreqSet = 0x66;

        //DATA
        public const byte DATA_NOMAL = 0;   //정상
        public const byte DATA_ERROR = 1;   //장애

        public const byte DATA_ON = 0x30;
        public const byte DATA_OFF = 0x31;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        // Socket 관련 변수(TCP)
        private ServerSocket sSocket = null;
        private IPEndPoint localEndPoint = null;
        private SendReceive sUser = null;

        public bool flagAccepted = new bool();
        public bool flagServer = new bool();
        public bool flagConnection = new bool();

        private bool flagPolling = new bool();  //Polling이 정상적으로 이루어지고있는지의 여부
        private byte cntPolling = new byte();

        //송신 관련
        private byte CMD = new byte();				//명령
        private byte dCntData = new int();			//Data 갯수
        private byte[] dBufData = new byte[256];	//Data

        public bool flagASCII = false;

        //폴링 타이머 설정
        private Timer tmrPolling = new Timer();

        public clsNMSGUI()
        {
        }

        public clsNMSGUI(frmMain f)
            : this()
        {
            fMain = f;

            tmrPolling.Interval = 1000;
            tmrPolling.Tick += new EventHandler(tmrPolling_Tick);
            tmrPolling.Start();
        }

        #region NMS GUI와의 통신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void sSocket_Start(short netPort)
        {
            flagServer = true;

            //Server 구현( Accept 대기 )'
            sSocket = new ServerSocket();
            sSocket.Accepted += new AcceptedEvent(sSocket_Accepted);
            localEndPoint = new IPEndPoint(IPAddress.Any, netPort);
            sSocket.Start(localEndPoint);
        }

        public void sSocket_Stop()
        {
            flagServer = false;

            if (flagConnection)
            {
                sUser.Stop();
                flagConnection = false;
            }

            sSocket.Stop();
        }

        void sSocket_Accepted(Socket sock)
        {
            if (flagConnection)
            {
                sUser.Stop();
                sUser = null;
            }

            sUser = new SendReceive();
            sUser.Received += new ReceivedEvent(sUser_Received);
            sUser.Closed += new CloseEvent(sUser_Closed);
            sUser.Start(sock);

            flagConnection = true;

            this.nms_SocketAccepted();  //NMS GUI가 접속했음을 알려주는 이벤트
        }

        void sUser_Closed(SendReceive SendRecv)
        {
            if (flagConnection)
            {
                sUser.Stop();
                sUser = null;
            }

            flagConnection = false;
            this.nms_SocketCloseed();   //메인에 소켓 Close 이벤트 전달
        }

        void sUser_Received(SendReceive SendRecv, byte[] buffer, int lng)
        {
            #region 수신된 Data 기본처리
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int i = 0, j = 0;

            int chkSum = 0, iLow, iHigh;
            byte bL = 0x00, bH = 0x00;

            if (clsCommon.flagDebug[clsCommon.NMS])
            {
                string strData = null;

                if (fMain.flagDataViewTypeASCII)
                    strData = Encoding.Default.GetString(buffer, 0, lng);
                else
                {
                    for (i = 0; i < lng; i++)
                        strData += string.Format(" {0:X2}", buffer[i]);
                }

                this.nms_SendReceiveDataView(false, strData);
            }

            for (i = 0; i < lng - 2; i++)
                chkSum = chkSum ^ buffer[i];

            iLow = chkSum & 0x0F;
            iHigh = chkSum >> 4;
            bH = clsCommon.HexaConvert(iHigh);
            bL = clsCommon.HexaConvert(iLow);

            this.nms_DataSendReceive(false);

            if ((bH != buffer[lng - 2]) || (bL != buffer[lng - 1])) return;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            j = 2;
            byte tmpMUId = buffer[j++];     //MU ID
            byte tmpRUId = buffer[j++];     //RU ID
            byte tmpCMD = buffer[j++];      //CMD
            int tmpLng = buffer[j++];       //Data 길이

            byte tmpBdaId = 0;

            tmpMUId = (byte)(tmpMUId - 0x40);
            tmpRUId = (byte)(tmpRUId - 0x30);

            switch (tmpCMD)
            {
                case CMD_MsinStbyChange:    //0x43 - C : 주/예비 절체
                    byte mainSpare = clsCommon.AHD(buffer[j++]);   //주/예비
                    this.nms_MainSpareChange(tmpMUId, tmpRUId, mainSpare);
                    break;

                case CMD_AutoManualChange:
                    byte autoManual = clsCommon.AHD(buffer[j++]);  //Auto/Manual
                    this.nms_AutoStbyChange(tmpMUId, tmpRUId, autoManual);
                    break;

                case CMD_RFGainSet:     //F : RF 출력 조절
                    byte mainStby = clsCommon.AHD(buffer[j++]);        //주/예비
                    byte rfGainValue = buffer[j++];     //RF 출력값

                    this.nms_RfGainSet(tmpMUId, tmpRUId, mainStby, rfGainValue);
                    break;

                case CMD_AFGainSet_CCE:    //E : CCE/RC1/RC2/RC3 TX/RX/MOB AF Gain값 설정
                case CMD_AFGainSet_RC1:    //1
                case CMD_AFGainSet_RC2:    //2
                case CMD_AFGainSet_RC3:    //3
                    AFGain tmpAfGain = new AFGain();

                    tmpAfGain.gainTx = buffer[j++];
                    tmpAfGain.gainRx = buffer[j++];
                    tmpAfGain.gainMon = buffer[j++];

                    if (tmpAfGain.gainTx >= 0x80) tmpAfGain.gainTx = (tmpAfGain.gainTx - 0x80) * -1;
                    if (tmpAfGain.gainRx >= 0x80) tmpAfGain.gainRx = (tmpAfGain.gainRx - 0x80) * -1;
                    if (tmpAfGain.gainMon >= 0x80) tmpAfGain.gainMon = (tmpAfGain.gainMon - 0x80) * -1;

                    this.nms_AfGainSet(tmpMUId, tmpRUId, tmpCMD, tmpAfGain);
                    break;

                case CMD_AFGain:    //Q : CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값 요청
                    this.nms_AfGainInquiry(tmpMUId, tmpRUId);
                    break;

                case CMD_WideNarrowChange:      //B : 무전기 형식 절체
                    byte wideNarrow = clsCommon.AHD(buffer[j++]);
                    this.nms_WideNarrowChange(tmpMUId, tmpRUId, wideNarrow);
                    break;

                case CMD_ChReturnTimeSet:   //H : 채널복귀시간 설정
                    byte chReturnTime = buffer[j++];
                    this.nms_ChReturnTimeSet(tmpMUId, chReturnTime);
                    break;

                case CMD_BDA_Init:      //BDA 초기값 설정
                    BDAInit tmpBdaInitSt = new BDAInit();

                    for (i = 0; i < 4; i++)
                    {
                        if (buffer[j++] == 1)
                            tmpBdaInitSt.flagBDAEnable[i] = true;
                    }

                    j++;    //주파수 설정 사용안함

                    if (buffer[j++] == 1)
                        tmpBdaInitSt.flagBDAPollEnable = true;

                    tmpBdaInitSt.pollTime = buffer[j++];

                    this.nms_BdaInitStSet(tmpMUId, tmpRUId, tmpBdaInitSt);
                    break;

                case CMD_BDA_Set:       //BDA 설정값 요청
                    this.nms_BdaInitStInquiry(tmpMUId, tmpRUId);
                    break;

                case CMD_BDA_StReport:  //BDA 상태 요청
                    tmpBdaId = buffer[j++];     //BDA ID
                    this.nms_BdaStInquiry(tmpMUId, tmpRUId, tmpBdaId);
                    break;

                case CMD_BDA_LoopTest:  //BDA LoopTest 요청
                    tmpBdaId = buffer[j++];     //BDA ID
                    this.nms_BdaLoopTest(tmpMUId, tmpRUId, tmpBdaId);
                    break;

                case CMD_BDA_Rf:        //BDA RF 출력값 요청
                    tmpBdaId = buffer[j++];     //BDA ID
                    this.nms_BdaRfInquiry(tmpMUId, tmpRUId, tmpBdaId);
                    break;

                case CMD_BDA_RfSet:     //BDA RF 출력값 설정
                    tmpBdaId = buffer[j++];     //BDA ID
                    byte tmpRfValue = buffer[j++];  //Rf 출력값
                    this.nms_BdaRfSet(tmpMUId, tmpRUId, tmpBdaId, tmpRfValue);
                    break;

                case CMD_BDA_FreqSet:   //BDA 주파수 설정
                    byte[] tmpFreq = new byte[2];

                    tmpFreq[0] = buffer[j++];
                    tmpFreq[1] = buffer[j++];

                    this.nms_BdaFreqSet(tmpMUId, tmpRUId, tmpFreq);
                    break;

                case CMD_POLLING:
                    cntPolling = 0;
                    break;
            }
        }

        private byte[] BitInfoToByte(byte bitInfo)
        {
            byte[] resultByte = new byte[8];

            byte tmpOP = 1;

            for (int i = 0; i < 8; i++)
            {
                resultByte[i] = (byte)(bitInfo & tmpOP);
                tmpOP <<= 1;
            }

            return resultByte;
        }

        void tmrPolling_Tick(object sender, EventArgs e)
        {
            if (flagConnection)
            {
                if (++cntPolling > 5)
                {
                    cntPolling = 5;

                    if (flagPolling)
                    {
                        flagPolling = false;
                        this.nms_Polling(flagPolling);   //메인에 폴링이상 이벤트 전달
                    }
                }
                else
                {
                    if (!flagPolling)
                    {
                        flagPolling = true;
                        this.nms_Polling(flagPolling);   //메인에 폴링정상 이벤트 전달
                    }
                }

                //EditData_Polling();
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 송신 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region NMS GUI와의 송신 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region FM장치 감시 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// FM장치 감시 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        public void EditData_FMDataReport(byte muID, byte ruID)
        {
            CMD = CMD_FM_REPORT;

            dCntData = 0;

            //dBufData[dCntData++] = mainSpare;
            //dBufData[dCntData++] = autoManual;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 방호장치 감시 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 방호장치 감시 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        public void EditData_PTDataReport(byte muID, byte ruID)
        {
            CMD = CMD_PT_REPORT;

            dCntData = 0;

            //dBufData[dCntData++] = mainSpare;
            //dBufData[dCntData++] = autoManual;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 열차무선 감시 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 열차무선 감시 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        public void EditData_TWDataReport(byte muID, byte ruID, MURUData tmpMuRuData)
        {
            CMD = CMD_TW_REPORT;

            dCntData = 0;

            if (ruID == 0)
            {
                //MU Data
                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.muData.otherSt1);      //기타상태1
                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.muData.otherSt2);      //기타상태2

                dBufData[dCntData++] = tmpMuRuData.muData.dcValue;      //DC전원값

                dBufData[dCntData++] = tmpMuRuData.muData.rfValue[0];       //주 RF 출력값
                dBufData[dCntData++] = tmpMuRuData.muData.rxRssiValue[0];   //주 RX RSSI값

                dBufData[dCntData++] = tmpMuRuData.muData.rfValue[1];       //예비 RF 출력값
                dBufData[dCntData++] = tmpMuRuData.muData.rxRssiValue[1];   //예비 RX RSSI값

                dBufData[dCntData++] = tmpMuRuData.muData.rxRssiValue[2];   //감청용 RX RSSI값

                dBufData[dCntData++] = tmpMuRuData.muData.rfValueInquiry[0];    //주 RF 출력조회값
                dBufData[dCntData++] = tmpMuRuData.muData.rfValueInquiry[1];    //예비 RF 출력조회값

                dBufData[dCntData++] = tmpMuRuData.muData.chInfo[0];    //주 채널정보
                dBufData[dCntData++] = tmpMuRuData.muData.chInfo[1];    //예비 채널정보
                dBufData[dCntData++] = tmpMuRuData.muData.chInfo[2];    //감청용 채널정보

                //OPT Data
                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.muData.optMonSt);      //통신 감시 상태
                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.muData.optOtherSt);    //OPT 기타 상태

                dBufData[dCntData++] = tmpMuRuData.muData.optDcValue;      //OPT DC전원값

                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.muData.optAlarmSt);    //OPT 알람 상태

                dBufData[dCntData++] = tmpMuRuData.muData.chReturn;    //채널 복귀 시간

                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.muData.pllLockErrorSt);    //Pll Lock 장애 상태
            }
            else
            {   //RU Data
                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.ruData[ruID].otherSt1); //기타상태1
                dBufData[dCntData++] = ByteInfoToBit(tmpMuRuData.ruData[ruID].otherSt2); //기타상태2

                dBufData[dCntData++] = tmpMuRuData.ruData[ruID].dcValue;        //DC전원값

                dBufData[dCntData++] = tmpMuRuData.ruData[ruID].rfValue;         //주 RF 출력값
                dBufData[dCntData++] = tmpMuRuData.ruData[ruID].rfValueInquiry;  //주 RF 출력조회값
                dBufData[dCntData++] = tmpMuRuData.ruData[ruID].rxRssiValue;  //RSSI 감도
            }

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private byte ByteInfoToBit(byte[] byteInfo)
        {
            byte resultByte = 0;

            byte tmpOP = 1;

            for (int i = 0; i < 8; i++)
            {
                if (byteInfo[i] == 1)
                    resultByte += tmpOP;

                tmpOP <<= 1;
            }

            return resultByte;
        }

        #region CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값 요청에 대한 응답 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값 요청에 대한 응답 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        public void EditData_AFGainDataResponse(byte muID, byte ruID, AFGain[] afGain)
        {
            CMD = CMD_AFGain;

            dCntData = 0;

            dBufData[dCntData++] = 0;   //예비

            for (int i = 0; i < 4; i++)
            {
                if (afGain[i].gainTx < 0) afGain[i].gainTx = (afGain[i].gainTx * -1) + 0x80;
                if (afGain[i].gainRx < 0) afGain[i].gainRx = (afGain[i].gainRx * -1) + 0x80;
                if (afGain[i].gainMon < 0) afGain[i].gainMon = (afGain[i].gainMon * -1) + 0x80;

                dBufData[dCntData++] = (byte)afGain[i].gainTx;
                dBufData[dCntData++] = (byte)afGain[i].gainRx;
                dBufData[dCntData++] = (byte)afGain[i].gainMon;
            }

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region UPS 감시 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// UPS 감시 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        public void EditData_UPSDataReport(byte muID, UPSData upsData)
        {
            int i =0;
            CMD = CMD_UPS_REPORT;

            dCntData = 0;

            for (i = 0; i < 5; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.inVoltage[i]));    //입력전압
            for (i = 0; i < 5; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.faultVoltage[i])); //과실전압
            for (i = 0; i < 5; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.outVoltage[i]));   //출력전압

            for (i = 0; i < 3; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.currentPercent[i]));   //출력전류

            for (i = 0; i < 4; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.frequency[i]));        //주파수
            for (i = 0; i < 4; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.batteryVoltage[i]));   //배터리 전압
            for (i = 0; i < 4; i++)
                dBufData[dCntData++] = (byte)(Convert.ToChar(upsData.temperature[i]));      //온도
            
            dBufData[dCntData++] = ByteInfoToBit(upsData.otherSt);      //기타상태

            MakeSendData(muID, 0);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 경춘선용 FM 감시 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 경춘선용 FM Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="fmData">경춘선용 FM Data</param>
        public void EditData_FmDataReport(byte muID, byte ruID, byte fmData)
        {
            CMD = CMD_FM_REPORT;

            dCntData = 0;

            dBufData[dCntData++] = fmData;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 초기설정값 보고 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 초기설정값 보고 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="tmpBdaData">BDA Data</param>
        public void EditData_BDAInitReport(byte muID, byte ruID, BDAInit bdaInit)
        {
            CMD = CMD_BDA_Set; 

            dCntData = 0;

            for (int i = 0; i < 4; i++)
            {
                if (bdaInit.flagBDAEnable[i]) dBufData[dCntData++] = 1;
                else dBufData[dCntData++] = 0;
            }

            dBufData[dCntData++] = bdaInit.bdaFreqCode;

            if (bdaInit.flagBDAPollEnable) dBufData[dCntData++] = 1;
            else dBufData[dCntData++] = 0;

            dBufData[dCntData++] = bdaInit.pollTime;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 감시 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 감시 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        /// <param name="tmpBdaData">BDA Data</param>
        public void EditData_BDAStDataReport(byte muID, byte ruID, byte bdaID, BDA_St tmpBdaData)
        {
            CMD = CMD_BDA_StReport;

            dCntData = 0;

            dBufData[dCntData++] = bdaID;   //BDA ID

            dBufData[dCntData++] = ByteInfoToBit(tmpBdaData.bdaAMPSt);      //기타상태1

            for (int i = 0; i < 5; i++)
                dBufData[dCntData++] = tmpBdaData.ampDBM[i];

            dBufData[dCntData++] = ByteInfoToBit(tmpBdaData.bdaUpsSt);      //기타상태2

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA LoopTest 응답 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA LoopTest 응답 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        public void EditData_BdaLoopTest(byte muID, byte ruID, byte bdaID)
        {
            CMD = CMD_BDA_LoopTest;
            
            dCntData = 0;

            dBufData[dCntData++] = bdaID;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA Rf출력값 보고 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 출력값 보고 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        /// <param name="rfValue">Rf출력값</param>
        public void EditData_BdaRfValueReport(byte muID, byte ruID, byte bdaID, byte rfValue)
        {
            CMD = CMD_BDA_Rf;

            dCntData = 0;
            dBufData[dCntData++] = bdaID;
            dBufData[dCntData++] = rfValue;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 통신상태 보고 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 통신상태 보고 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaCommSt">BDA 통신상태</param>
        public void EditData_BDACommStReport(byte muID, byte ruID, byte[] bdaCommSt)
        {
            CMD = CMD_BDA_CommStReport;

            dCntData = 0;

            for (int i = 0; i < 4; i++)
                dBufData[dCntData++] = bdaCommSt[i];

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 폴링 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 폴링 Data 만들기
        /// </summary>
        public void EditData_Polling()
        {
            CMD = CMD_POLLING;

            dCntData = 0;

            MakeSendData(0x30, 0x30);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 송신 Data를 Format에 맞게 편집
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 송신 Data를 Format에 맞게 편집
        /// </summary>
        /// <param name="muID">MUID 값</param>
        /// <param name="ruID">RUID 값</param>
        public void MakeSendData(byte muID, byte ruID)
        {
            int cntMsg = 0;
            byte[] bufMsg = new byte[dCntData + 9];

            int i;
            int chkSum = 0, iLow, iHigh;

            cntMsg = 0;
            bufMsg[cntMsg++] = clsCommon.STX;
            bufMsg[cntMsg++] = clsCommon.SOM_CHK;

            bufMsg[cntMsg++] = Make_MUID(muID);     //MU ID
            bufMsg[cntMsg++] = Make_RUID(ruID);     //RU ID

            bufMsg[cntMsg++] = CMD;       //CMD

            bufMsg[cntMsg++] = dCntData;    //LEN

            for (i = 0; i < dCntData; i++)
                bufMsg[cntMsg++] = dBufData[i];   //Data            

            bufMsg[cntMsg++] = clsCommon.ETX;

            //CheckSum
            for (i = 0; i < cntMsg; i++)
                chkSum = chkSum ^ bufMsg[i];

            iLow = chkSum & 0x0F;
            iHigh = chkSum >> 4;
            bufMsg[cntMsg++] = clsCommon.HexaConvert(iHigh);
            bufMsg[cntMsg++] = clsCommon.HexaConvert(iLow);

            if (clsCommon.flagDebug[clsCommon.NMS])
            {
                string strData = null;

                if (fMain.flagDataViewTypeASCII)
                    strData = Encoding.Default.GetString(bufMsg, 0, cntMsg);
                else
                {
                    for (i = 0; i < cntMsg; i++)
                        strData += string.Format(" {0:X2}", bufMsg[i]);
                }

                this.nms_SendReceiveDataView(true, strData);     //송신 Data 보기 이벤트 전달
            }

            if (sUser != null)
                sUser.Send(bufMsg, cntMsg);

            this.nms_DataSendReceive(true);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private byte Make_MUID(byte muID)
        {
            if (muID == 0) return 0x30;
            else return (byte)(muID + 0x40);
        }

        private byte Make_RUID(byte ruID)
        {
            return (byte)(ruID + 0x30);
        }
    }
}
