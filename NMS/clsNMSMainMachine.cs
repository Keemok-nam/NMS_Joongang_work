using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace NMS
{
    #region NMS 주장치와의 통신 관련 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #region NMS 주장치 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    /// <summary>
    /// 소켓과 연결이 되었음을 알려주기 위한 이벤트
    /// </summary>
    public delegate void socket_ConnectedEvent();
    /// <summary>
    /// 소켓과의 연결이 닫혔음을 알려주기 위한 이벤트
    /// </summary>
    public delegate void socket_ClosedEvent();

    /// <summary>
    /// NMS 주장치와의 폴링 상태를 알려주기 위한 이벤트
    /// </summary>
    /// <param name="flag">true : 정상, false : 이상</param>
    public delegate void NMSMainMachine_PollingEvent(bool flag);

    /// <summary>
    /// NMS 주장치로부터 AF Gain(CCE, RC1, RC2, RC3)값 요청에 의한 응답Data 수신을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="afGain">수신한 AF Gain값</param>
    public delegate void NMSMainMachine_AFGainEvent(byte muID, AFGain[] afGain);

    /// <summary>
    /// NMS 주장치로부터 RU 감시 Data 수신을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="ruData">수신한 RU 감시 Data</param>
    public delegate void NMSMainMachine_RuStReportEvent(byte muID, byte ruID, RUDetailData ruData);

    /// <summary>
    /// NMS 주장치로부터 MU 감시 Data 수신을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="muData">수신한 MU 감시 Data</param>
    /// <param name="optSt">수신한 OPT 감시 Data</param>
    public delegate void NMSMainMachine_MuStReportEvent(byte muID, MUData muData);

    /// <summary>
    /// NMS 주장치로부터 UPS 감시 Data 수신을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="upsData">수신한 UPS 감시 Data</param>
    public delegate void NMSMainMachine_UpsStReportEvent(byte muID, UPSData upsData);

    /// <summary>
    /// NMS 주장치로부터 FM 감시 Data 수신을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="upsData">수신한 FM Data</param>
    public delegate void NMSMainMachine_FMStReportEvent(byte muID, byte ruID, byte[] fmData);

    /// <summary>
    /// NMS 주장치로부터 FM 감시 Data 수신을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="tmpFmInfo">수신한 소스텔의 FM Data</param>
    public delegate void NMSMainMachine_SourcetelFMStReportEvent(byte muID, byte ruID, FM_Info tmpFmInfo);

    /// <summary>
    /// NMS 주장치로부터 BDA 초기화 요청을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    public delegate void NMSMainMachine_BDAInitRequestEvent(byte muID, byte ruID);

    /// <summary>
    /// NMS 주장치로부터 BDA 초기화 설정Data 보고를 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="SetData">BDA 초기 설정 Data</param>
    public delegate void NMSMainMachine_BDAInitReportEvent(byte muID, byte ruID, BDAInit SetData);

    /// <summary>
    /// NMS 주장치로부터 BDA 상태Data 보고를 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    /// <param name="bdaSt">BDA 상태 Data</param>
    public delegate void NMSMainMachine_BDAStReportEvent(byte muID, byte ruID, byte bdaID, BDA_St bdaSt);

    /// <summary>
    /// NMS 주장치로부터 BDA LootTest 응답을 알려주기 위한 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    public delegate void NMSMainMachine_BDALoopTestEvent(byte muID, byte ruID, byte bdaID);

    /// <summary>
    /// NMS 주장치로부터 BDA 통신 상태 보고 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    public delegate void NMSMainMachine_BDACommStReportEvent(byte muID, byte ruID, byte[] bdaCommSt);

    /// <summary>
    /// NMS 주장치로부터 BDA RF 출력 보고 이벤트
    /// </summary>
    /// <param name="muID">MU ID</param>
    /// <param name="ruID">RU ID</param>
    /// <param name="bdaID">BDA ID</param>
    /// <param name="rfValue">RF 출력 설정값</param>
    public delegate void NMSMainMachine_BDARfValueReportEvent(byte muID, byte ruID, byte bdaID, byte rfValue);

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

    /// <summary>
    /// 수신한 Data를 CCE Test Panel로 송신하기 위한 이벤트
    /// </summary>
    /// <param name="dataBuf">Data</param>
    /// <param name="lng">Data 길이</param>
    public delegate void ReceiveDataEvent(byte[] dataBuf, int lng);
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion

    class clsNMSMainMachine
    {
        #region NMS 주장치 관련 이벤트 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// NMS 주장치의 CPU 소켓과 연결이 되었음을 알려주기 위한 이벤트
        /// </summary>
        public event socket_ConnectedEvent nms_SocketConnected = null;
        /// <summary>
        /// NMS 주장치의 CPU 소켓과의 연결이 닫혔음을 알려주기 위한 이벤트
        /// </summary>
        public event socket_ClosedEvent nms_SocketCloseed = null;

        /// <summary>
        /// NMS 주장치의 CPU와의 폴링 상태를 알려주기 위한 이벤트
        /// </summary>
        /// <param name="flag">true : 정상, false : 이상</param>
        public event NMSMainMachine_PollingEvent nms_Polling = null;
        
        /// <summary>
        /// NMS 주장치로부터 AF Gain(CCE, RC1, RC2, RC3)값 요청에 의한 응답Data 수신을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="afGain">수신한 AF Gain값</param>
        public event NMSMainMachine_AFGainEvent nms_AfGain = null;

        /// <summary>
        /// NMS 주장치로부터 RU 감시 Data 수신을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="ruData">수신한 RU 감시 Data</param>
        public event NMSMainMachine_RuStReportEvent nms_RuStReport = null;

        /// <summary>
        /// NMS 주장치로부터 MU 감시 Data 수신을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruData">수신한 MU 감시 Data</param>
        /// <param name="optSt">수신한 OPT 감시 Data</param>
        public event NMSMainMachine_MuStReportEvent nms_MuStReport = null;

        /// <summary>
        /// NMS 주장치로부터 UPS 감시 Data 수신을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="muData">수신한 UPS 감시 Data</param>
        public event NMSMainMachine_UpsStReportEvent nms_UpsStReport = null;

        /// <summary>
        /// NMS 주장치로부터 FM 감시 Data 수신을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="upsData">수신한 FM Data</param>
        public event NMSMainMachine_FMStReportEvent nms_FmStReport = null;
                
        /// <summary>
        /// NMS 주장치로부터 소스텔의 FM 감시 Data 수신을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="upsData">수신한 소스텔의 FM Data</param>
        public event NMSMainMachine_SourcetelFMStReportEvent nms_SourcetelFmStReport = null;

        /// <summary>
        /// NMS 주장치로부터 BDA 초기화 요청을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        public event NMSMainMachine_BDAInitRequestEvent nms_BDAInitRequest = null;

        /// <summary>
        /// NMS 주장치로부터 BDA 초기화 설정Data 보고를 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="SetData">BDA 초기 설정 Data</param>
        public event NMSMainMachine_BDAInitReportEvent nms_BDAInitReport = null;

        /// <summary>
        /// NMS 주장치로부터 BDA 상태Data 보고를 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        /// <param name="bdaSt">BDA 상태 Data</param>
        public event NMSMainMachine_BDAStReportEvent nms_BDAStReport = null;

        /// <summary>
        /// NMS 주장치로부터 BDA LootTest 응답을 알려주기 위한 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        public event NMSMainMachine_BDALoopTestEvent nms_BDALoopTest = null;

        /// <summary>
        /// NMS 주장치로부터 BDA 통신 상태 보고 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        public event NMSMainMachine_BDACommStReportEvent nms_BDACommStReport = null;

        /// <summary>
        /// NMS 주장치로부터 BDA RF 출력 보고 이벤트
        /// </summary>
        /// <param name="muID">MU ID</param>
        /// <param name="ruID">RU ID</param>
        /// <param name="bdaID">BDA ID</param>
        /// <param name="rfValue">RF 출력 설정값</param>
        public event NMSMainMachine_BDARfValueReportEvent nms_BDARfValueReport = null;

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

        /// <summary>
        /// 수신한 Data를 CCE Test Panel로 송신하기 위한 이벤트
        /// </summary>
        /// <param name="dataBuf">Data</param>
        /// <param name="lng">Data 길이</param>
        public event ReceiveDataEvent nms_receiveData = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

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
        private ClientSocket cSocket = null;

        public bool flagConnected = false;
        public byte cntNonReceive = 0;

        private string nmsIP = null;
        private int nmsPort = 0;

        private bool flagPolling = new bool();  //Polling이 정상적으로 이루어지고있는지의 여부
        private byte cntPolling = new byte();

        //송신 관련
        private byte CMD = new byte();				//명령
        private byte dCntData = new int();			//Data 갯수
        private byte[] dBufData = new byte[256];	//Data

        //재접속 관련 타이머 설정
        private Timer tmrNetwork = new Timer();
        private int cntTime = 0;

        private byte[] muRfValueTable = new byte[12];
        private byte[] ruRfValueTable = new byte[12];

        public clsNMSMainMachine()
        {
        }

        public clsNMSMainMachine(string ip, int port)
        {
            muRfValueTable[0] = 0x64;
            muRfValueTable[1] = 0x69;
            muRfValueTable[2] = 0x6D;
            muRfValueTable[3] = 0x71;
            muRfValueTable[4] = 0x75;
            muRfValueTable[5] = 0x78;
            muRfValueTable[6] = 0x7B;
            muRfValueTable[7] = 0x80;
            muRfValueTable[8] = 0x83;
            muRfValueTable[9] = 0x87;
            muRfValueTable[10] = 0x8A;
            muRfValueTable[11] = 0x8C;

            ruRfValueTable[0] = 0x7B;
            ruRfValueTable[1] = 0x83;
            ruRfValueTable[2] = 0x8A;
            ruRfValueTable[3] = 0x90;
            ruRfValueTable[4] = 0x97;
            ruRfValueTable[5] = 0x9D;
            ruRfValueTable[6] = 0xA3;
            ruRfValueTable[7] = 0xA8;
            ruRfValueTable[8] = 0xAD;
            ruRfValueTable[9] = 0xB2;
            ruRfValueTable[10] = 0xB7;
            ruRfValueTable[11] = 0xBB;

            nmsIP = ip;
            nmsPort = port;
        }

        #region NMS 주장치와의 통신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void SetNetwordInfomation(string ip, int port)
        {
            nmsIP = ip;
            nmsPort = port;
        }

        public void Start()
        {
            tmrNetwork.Stop();

            NetStart();

            tmrNetwork.Interval = 1000;
            tmrNetwork.Tick += new EventHandler(tmrNetwork_Tick);
            tmrNetwork.Start();
        }

        private void NetStart()
        {
            try
            {
                if (cSocket != null)
                {
                    if (cSocket.Connected)
                    {
                        cSocket.Close();
                        cSocket = null;
                    }
                }

                cSocket = new ClientSocket();
                cSocket.connectEvent += new ClientConnectedEvent(cSocket_connectEvent);
                cSocket.receivedEvent += new ClientReceivedEvent(cSocket_receivedEvent);
                cSocket.closedEvent += new ClientCloseEvent(cSocket_closedEvent);

                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(nmsIP), nmsPort);
                cSocket.Start(remoteEndPoint);
            }
            catch
            {
            }
        }

        void cSocket_connectEvent(ClientSocket cSock)
        {
            try
            {
                this.nms_SocketConnected();    //메인에 소켓 Connected 이벤트 전달
            }
            catch
            {
            }
        }

        void cSocket_receivedEvent(byte[] buffer, int lng)
        {
            this.nms_receiveData(buffer, lng);

            cntNonReceive = 0;

            #region 수신된 Data 기본처리
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int i = 0, j = 0;

            int chkSum = 0, iLow, iHigh;
            byte bL = 0x00, bH = 0x00;

            if (clsCommon.flagDebug[clsCommon.NMS])
            {
                string strData = null;

                if (clsCommon.flagDataViewTypeASCII)
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

            tmpMUId = (byte)(tmpMUId - 0x40);
            tmpRUId = (byte)(tmpRUId - 0x30);

            byte tmpBdaID = 0;

            switch (tmpCMD)
            {
                case CMD_FM_REPORT:     //F : FM장치 감시 Data 보고
                    switch (clsCommon.nmsGUIUser)
                    {
                        case "경춘선":
                            byte[] tmpFMSt = BitInfoToByte(buffer[j++]);    //FM 상태
                            this.nms_FmStReport(tmpMUId, tmpRUId, tmpFMSt);
                            break;

                        case "중앙선":
					        FM_Info tmpFmInfo = new FM_Info();

                            if (tmpRUId == 0)
                            {   //소스텔의 FM 모장치
                                tmpFmInfo.acVoltage = buffer[j++];
                                tmpFmInfo.acCurrent = buffer[j++];
                                tmpFmInfo.dc12Voltage = buffer[j++];
                                tmpFmInfo.dc12Current = buffer[j++];
                                tmpFmInfo.dc5Voltage = buffer[j++];
                                tmpFmInfo.dc5Current = buffer[j++];
                                tmpFmInfo.betteryVoltage = buffer[j++];
                                tmpFmInfo.betteryChangeCurrent = buffer[j++];
                                tmpFmInfo.betteryDisChangeCurrent = buffer[j++];

                                tmpFmInfo.acInputFail = buffer[j++];
                                tmpFmInfo.lnaFail = buffer[j++];
                                tmpFmInfo.dcOutputFail = buffer[j++];
                                tmpFmInfo.overDisChange = buffer[j++];
                                tmpFmInfo.ldAlarm = buffer[j++];
                                tmpFmInfo.ldPower = (sbyte)buffer[j++];
                                tmpFmInfo.pdAlarm = buffer[j++];
                                tmpFmInfo.pdPower = (sbyte)buffer[j++];
                                tmpFmInfo.alc = (sbyte)buffer[j++];
                                tmpFmInfo.alcDepth = (sbyte)buffer[j++];
                                tmpFmInfo.mgc = (sbyte)buffer[j++];
                                tmpFmInfo.rssi = (sbyte)buffer[j++];
                                tmpFmInfo.tssi = (sbyte)buffer[j++];
                                tmpFmInfo.onOff = buffer[j++];
                                tmpFmInfo.deviceFail = buffer[j++];
                                tmpFmInfo.temperature = (sbyte)buffer[j++];
                            }
                            else
                            {   //소스텔의 FM 자장치
                                tmpFmInfo.acVoltage = buffer[j++];
                                tmpFmInfo.acCurrent = buffer[j++];
                                j += 6;
                                tmpFmInfo.betteryVoltage = buffer[j++];
                                tmpFmInfo.betteryChangeCurrent = buffer[j++];
                                tmpFmInfo.acInputFail = buffer[j++];
                                tmpFmInfo.dcOutputFail = buffer[j++];
                                j++;
                                tmpFmInfo.ldAlarm = buffer[j++];
                                tmpFmInfo.ldPower = (sbyte)buffer[j++];
                                tmpFmInfo.pdAlarm = buffer[j++];
                                tmpFmInfo.pdPower = (sbyte)buffer[j++];
                                tmpFmInfo.rssi = (sbyte)buffer[j++];
                                tmpFmInfo.temperature = (sbyte)buffer[j++];
                                tmpFmInfo.tssiFwd = (sbyte)buffer[j++];
                                tmpFmInfo.tssiRev = (sbyte)buffer[j++];
                            }

                            this.nms_SourcetelFmStReport(tmpMUId, tmpRUId, tmpFmInfo);
                            break;

                        default:
                            break;
                    }
                    break;

                case CMD_PT_REPORT:     //B : 방호장치 감시 Data 보고
                    break;

                case CMD_TW_REPORT:     //V : 열차무선 감시 Data 보고
                    #region 열차무선 감시 Data 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    if (tmpRUId == 0)
                    {   //MU Data
                        MUData tmpMuData = new MUData();

                        tmpMuData.otherSt1 = BitInfoToByte(buffer[j++]);    //기타상태1
                        tmpMuData.otherSt2 = BitInfoToByte(buffer[j++]);    //기타상태2

                        tmpMuData.dcValue = buffer[j++];    //DC전원값

                        tmpMuData.rfValue[0] = buffer[j++];         //주 RF 출력값
                        tmpMuData.rxRssiValue[0] = buffer[j++];     //주 RX RSSI값

                        tmpMuData.rfValue[1] = buffer[j++];         //예비 RF 출력값
                        tmpMuData.rxRssiValue[1] = buffer[j++];     //예비 RX RSSI값

                        tmpMuData.rxRssiValue[2] = buffer[j++];     //감청용 RX RSSI값

                        tmpMuData.rfValueInquiry[0] = muRfValueCalculation(buffer[j++]);  //주 RF 출력조회값
                        tmpMuData.rfValueInquiry[1] = muRfValueCalculation(buffer[j++]);  //예비 RF 출력조회값

                        tmpMuData.chInfo[0] = buffer[j++];  //주 채널정보
                        tmpMuData.chInfo[1] = buffer[j++];  //예비 채널정보
                        tmpMuData.chInfo[2] = buffer[j++];  //감청 채널정보

                        tmpMuData.optMonSt = BitInfoToByte(buffer[j++]);    //OPT 통신 감시 상태
                        tmpMuData.optOtherSt = BitInfoToByte(buffer[j++]);  //OPT 기타 상태

                        tmpMuData.optDcValue = buffer[j++];     //OPT DC전원값

                        tmpMuData.optAlarmSt = BitInfoToByte(buffer[j++]);    //OPT LD/PD 알람 상태

                        tmpMuData.chReturn = buffer[j++];   //채널 복귀 상태

                        tmpMuData.pllLockErrorSt = BitInfoToByte(buffer[j++]);  //PLL Lock 장애 상태

                        j++;    //Testmode

                        tmpMuData.revelValue = buffer[j++]; //level 측정값

                        this.nms_MuStReport(tmpMUId, tmpMuData);
                    }
                    else
                    {   //RU Data
                        RUDetailData tmpRuData = new RUDetailData();

                        tmpRuData.otherSt1 = BitInfoToByte(buffer[j++]);   //기타상태1
                        tmpRuData.otherSt2 = BitInfoToByte(buffer[j++]);   //기타상태2

                        tmpRuData.dcValue = buffer[j++];    //DC전원값

                        tmpRuData.rfValue = buffer[j++]; //주 RF 출력값
                        tmpRuData.rfValueInquiry = ruRfValueCalculation(buffer[j++]); //주 RF 출력조회값

                        tmpRuData.rxRssiValue = buffer[j++];    //예비 RX RSSI 감도

                        this.nms_RuStReport(tmpMUId, tmpRUId, tmpRuData);
                    }
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case CMD_AFGain:    //Q : CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값 요청에 대한 응답
                    #region CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값 요청에 대한 응답 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    j++;    //예비

                    AFGain[] tmpAfGain = new AFGain[4];

                    for (i = 0; i < 4; i++)
                    {
                        tmpAfGain[i] = new AFGain();

                        tmpAfGain[i].gainTx = buffer[j++];
                        tmpAfGain[i].gainRx = buffer[j++];
                        tmpAfGain[i].gainMon = buffer[j++];
                    }

                    this.nms_AfGain(tmpMUId, tmpAfGain);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case CMD_UPS_REPORT:    //U : UPS 감시 Data 보고
                    #region UPS 감시 Data 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    UPSData tmpUpsData = new UPSData();

                    string tmpValue = string.Empty;

                    //입력전압
                    for (i = 0; i <= 4; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpUpsData.inVoltage = tmpValue;

                    tmpValue = string.Empty;
                    //과실전압
                    for (i = 0; i <= 4; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpUpsData.faultVoltage = tmpValue;

                    tmpValue = string.Empty;
                    //출력전압
                    for (i = 0; i <= 4; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpUpsData.outVoltage = tmpValue;

                    tmpValue = string.Empty;
                    //출력전류
                    for (i = 0; i <= 2; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpUpsData.currentPercent = tmpValue;

                    tmpValue = string.Empty;
                    //주파수
                    for (i = 0; i <= 3; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpUpsData.frequency = tmpValue;

                    tmpValue = string.Empty;
                    //배터리 전압
                    for (i = 0; i <= 3; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpValue = (Convert.ToDouble(tmpValue) * 18).ToString("00.0");
                    tmpUpsData.batteryVoltage = tmpValue;

                    tmpValue = string.Empty;
                    //온도
                    for (i = 0; i <= 3; i++)
                        tmpValue += Convert.ToChar(buffer[j++]);
                    tmpUpsData.temperature = tmpValue;

                    //상태
                    tmpUpsData.otherSt = BitInfoToByte(buffer[j++]);   //상태

                    this.nms_UpsStReport(tmpMUId, tmpUpsData);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case CMD_POLLING:
                    cntPolling = 0;
                    break;

                case CMD_BDA_Init:      //i : BDA 설정 초기화 요청 및 초기화
                    this.nms_BDAInitRequest(tmpMUId, tmpRUId);
                    break;

                case CMD_BDA_Set:       //r : BDA 설정 요청/응답
                    BDAInit tmpBDAInit = new BDAInit();

                    for (i = 0; i < 4; i++)
                        if (buffer[j++] == 1) tmpBDAInit.flagBDAEnable[i] = true;
                    tmpBDAInit.bdaFreqCode = buffer[j++];
                    if (buffer[j++] == 1) tmpBDAInit.flagBDAPollEnable = true;
                    tmpBDAInit.pollTime = buffer[j++];

                    this.nms_BDAInitReport(tmpMUId, tmpRUId, tmpBDAInit);
                    break;

                case CMD_BDA_StReport:  //s : BDA 상태 요청/응답
                    BDA_St tmpBDASt = new BDA_St();

                    tmpBdaID = buffer[j++];   //BDA ID

                    switch (clsCommon.nmsGUIUser)
                    {
                        case "경춘선":
                            //BDA 상태 : 0~4-FM,역무,DMB,방호,TRS, 5-12V, 6-24V, 7-220V 상태
                            tmpBDASt.bdaAMPSt = BitInfoToByte(buffer[j++]);
                            //BDA Gain값(FM, 역무, DMB, 방호, TRS)
                            for (i = 0; i < 5; i++)
                                tmpBDASt.ampDBM[i] = buffer[j++];
                            //BDA의 UPS 상태 : 3-UPS AC Off, 4-UPS Fail, 5-UPS Battery Low, 6-UPS Comm Fail, 7-AMP Comm Fail
                            tmpBDASt.bdaUpsSt = BitInfoToByte(buffer[j++]);
                            break;

                        case "중앙선":
                            int tmpPttValue = 0;

                            tmpBDASt.fmTemperature = (sbyte)buffer[j++];
                            tmpBDASt.fmTssi = (sbyte)buffer[j++];
                            tmpBDASt.fmAlarm = buffer[j++];

                            j++;
                            tmpBDASt.uhfBypass = buffer[j++];
                            tmpBDASt.uhfAcAlarm = buffer[j++];
                            tmpBDASt.uhfDcAlarm = buffer[j++];
                            tmpBDASt.uhfBatteryAlarm = buffer[j++];
                            tmpPttValue = buffer[j++] + (buffer[j++] * 0x100);
                            if (tmpPttValue > 300) tmpBDASt.uhfPtt1 = 1;
                            else tmpBDASt.uhfPtt1 = 0;
                            tmpPttValue = buffer[j++] + (buffer[j++] * 0x100);
                            if (tmpPttValue > 300) tmpBDASt.uhfPtt2 = 1;
                            else tmpBDASt.uhfPtt2 = 0;

                            j += 4;
                            tmpBDASt.vhfBypass = buffer[j++];
                            tmpBDASt.vhfAcAlarm = buffer[j++];
                            tmpBDASt.vhfDcAlarm = buffer[j++];
                            tmpBDASt.vhfBatteryAlarm = buffer[j++];
                            tmpPttValue = buffer[j++] + (buffer[j++] * 0x100);
                            if (tmpPttValue > 300) tmpBDASt.vhfPtt1 = 1;
                            else tmpBDASt.vhfPtt1 = 0;
                            tmpPttValue = buffer[j++] + (buffer[j++] * 0x100);
                            if (tmpPttValue > 300) tmpBDASt.vhfPtt2 = 1;
                            else tmpBDASt.vhfPtt2 = 0;
                            break;
                    }

                    this.nms_BDAStReport(tmpMUId, tmpRUId, tmpBdaID, tmpBDASt);
                    break;

                case CMD_BDA_LoopTest:  //o : BDA Loop Test 요청/응답
                    tmpBdaID = buffer[j++];   //BDA ID
                    this.nms_BDALoopTest(tmpMUId, tmpRUId, tmpBdaID);
                    break;

                case CMD_BDA_CommStReport:  //b : BDA 통신 상태 보고
                    //2011년 12월 06일 현장 : 일단 상태처리 안하도록 수정함.
                    /*
                    byte[] tmpBdaCommSt = new byte[4];

                    for (i = 0; i < 4; i++)
                        tmpBdaCommSt[i] = buffer[j++];
                    this.nms_BDACommStReport(tmpMUId, tmpRUId, tmpBdaCommSt);
                    */
                    break;

                case CMD_BDA_Rf:            //v : BDA Setup 상태 응답
                    tmpBdaID = buffer[j++];     //BDA ID
                    this.nms_BDARfValueReport(tmpMUId, tmpRUId, tmpBdaID, buffer[j++]);
                    break;
            }
        }

        void cSocket_closedEvent(ClientSocket cSock)
        {
            try
            {
                this.nms_SocketCloseed();    //메인에 소켓 Close 이벤트 전달
            }
            catch
            {
            }
        }

        private byte[] BitInfoToByte(byte bitInfo)
        {
            byte[] resultByte = new byte[8];

            byte tmpOP = 1;

            for (int i = 0; i < 8; i++)
            {
                if ((bitInfo & tmpOP) != 0) resultByte[i] = 1;
                tmpOP <<= 1;
            }

            return resultByte;
        }

        private byte muRfValueCalculation(byte tmpRfValueInquiry)
        {   //출력 조회값 계산
            for (int i = 0; i < 12; i++)
            {
                if (tmpRfValueInquiry < muRfValueTable[i])
                    return (byte)(i + 5);
            }

            return 17;
        }

        private byte ruRfValueCalculation(byte tmpRfValueInquiry)
        {   //출력 조회값 계산
            for (int i = 0; i < 12; i++)
            {
                if (tmpRfValueInquiry < ruRfValueTable[i])
                    return (byte)(i + 5);
            }

            return 17;
        }

        void tmrNetwork_Tick(object sender, EventArgs e)
        {
            tmrNetwork.Stop();

            if (cntTime++ > 5)
            {
                cntTime = 0;
                if (!cSocket.Connected) NetStart();
            }

            cntNonReceive++;

            if (cSocket.Connected)
            {   //접속상태인데 일정시간동안(약 1분) Data수신이 안되면 다시 접속한다.
                if (cntNonReceive > 60)
                {
                    cntNonReceive = 0;
                    NetStart();
                }
            }

            /*
            if (flagConnected)
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

                EditData_Polling();
            }
            */

            tmrNetwork.Start();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS 주장치와의 송신 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region 주/예비 절체 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 주/예비 절체 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="mainSpare">주/예비(0:주, 1:예비)</param>
        public void EditData_CTL_MainStbyChange(byte muID, byte ruID, byte mainSpare)
        {
            CMD = CMD_MsinStbyChange;

            dCntData = 0;

            dBufData[dCntData++] = mainSpare;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 절체방법(자동/수동) 변경 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 절체방법(자동/수동) 변경 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="autoManual">자동/수동 절체방법(0:자동, 1:수동)</param>
        public void EditData_CTL_AutoManualChange(byte muID, byte ruID, byte autoManual)
        {
            CMD = CMD_AutoManualChange;

            dCntData = 0;

            dBufData[dCntData++] = autoManual;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 무전기 형식(광대역/협대역) 절체 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 주무전기 형식(광대역/협대역) 절체 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="wideNarrow">0:Wide, 1:Narrow</param>
        public void EditData_CTL_WideNarrowChange(byte muID, byte ruID, byte wideNarrow)
        {
            CMD = CMD_WideNarrowChange;

            dCntData = 0;

            dBufData[dCntData++] = wideNarrow;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 주/예비 RF 출력값 설정 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 주/예비 RF 출력값 설정 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="mainSpare">주/예비(0:주, 1:예비)</param>
        /// <param name="rfValue">설정할 값</param>
        public void EditData_CTL_RFValueSet(byte muID, byte ruID, byte mainSpare, byte rfValue)
        {
            CMD = CMD_RFGainSet;

            dCntData = 0;

            dBufData[dCntData++] = mainSpare;   //주/예비
            dBufData[dCntData++] = rfValue;     //설정값

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region CCE/RC1/RC2/RC3 TX/RX/MOB AF Gain값 설정 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// CCE/RC1/RC2/RC3 TX/RX/MOB AF Gain값 설정 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="rcNum">제어할 종류(0:CCE, 1:RC1, 2:RC2, 3:RC3)</param>
        /// <param name="afGainValue">설정할 AF Gain값(0:TX, 1:RX, 2:MON)</param>
        public void EditData_CTL_AFValueSet(byte muID, byte ruID, byte rcNum, int[] afGainValue)
        {
            switch (rcNum)
            {
                case 0: CMD = CMD_AFGainSet_CCE; break;
                case 1: CMD = CMD_AFGainSet_RC1; break;
                case 2: CMD = CMD_AFGainSet_RC2; break;
                case 3: CMD = CMD_AFGainSet_RC3; break;
            }            

            dCntData = 0;

            for (int i = 0; i < 3; i++)
            {
                if (afGainValue[i] >= 0)
                    dBufData[dCntData++] = (byte)(afGainValue[i]);
                else
                    dBufData[dCntData++] = (byte)(Math.Abs(afGainValue[i]) + 0x80);
            }

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 장비 Data(CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값) 요청 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 장비 Data(CCE, RC1, RC2, RC3의 TX/RX/MON AF Gain값) 요청 Data 만들기
        /// </summary>
        /// <param name="muID">Gain값을 요청할 MU ID</param>
        public void EditData_AfGainInquiry(byte muID)
        {
            CMD = CMD_AFGain;

            dCntData = 0;

            MakeSendData(muID, 0);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 채널 복귀 시간 설정 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 채널 복귀 시간 설정 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="chReturnTimeValue">채널 복귀 시간 값</param>
        public void EditData_CTL_ChReturnTimeSet(byte muID, byte ruID, byte chReturnTimeValue)
        {
            CMD = CMD_ChReturnTimeSet;

            dCntData = 0;

            dBufData[dCntData++] = chReturnTimeValue;

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 송신 출력 시험 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 송신 출력 시험 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="flagAction">On/Off</param>
        public void EditData_CTL_SendOutTest(byte muID, byte ruID, bool flagAction)
        {
            CMD = CMD_SendOutTest;

            dCntData = 0;

            if (flagAction) dBufData[dCntData++] = 0x31;    //ON
            else dBufData[dCntData++] = 0x30;    //OFF

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 회선 시험 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 회선 시험 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="testMode">0:중지, 1:송신, 2:수신, 3:감청</param>
        public void EditData_CTL_LineTest(byte muID, byte ruID, byte testMode)
        {
            CMD = CMD_LineTest;

            dCntData = 0;

            dBufData[dCntData++] = testMode;

            MakeSendData(muID, ruID);
        }
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

            MakeSendData(0, 0);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 설정 초기화 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 설정 초기화 Data 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="tmpBDAInit">BDA 초기 설정값</param>
        public void EditData_BDA_InitSet(byte muID, byte ruID, BDAInit tmpBDAInit)
        {
            CMD = CMD_BDA_Init;

            dCntData = 0;

            //BDA Enable
            for (int i = 0; i < 4; i++)
            {
                if (tmpBDAInit.flagBDAEnable[i]) dBufData[dCntData++] = 1;   //Enable
                else dBufData[dCntData++] = 0;   //Disable
            }

            //BDA 주파수(2011년 11월 24일 - 주파수 설정은 따로 한다.)
            dBufData[dCntData++] = 0;

            //BDA Polling Enable
            if (tmpBDAInit.flagBDAPollEnable) dBufData[dCntData++] = 1;   //Enable
            else dBufData[dCntData++] = 0;   //Disable

            dBufData[dCntData++] = tmpBDAInit.pollTime; //폴링간격

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 초기 설정값 요청 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 초기 설정값 요청 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        public void EditData_BDA_InitInquiry(byte muID, byte ruID)
        {
            CMD = CMD_BDA_Set;

            dCntData = 0;
            
            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 상태 요청 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 상태 요청 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        public void EditData_BDA_StInquiry(byte muID, byte ruID, byte bdaID)
        {
            CMD = CMD_BDA_StReport;

            dCntData = 0;
            dBufData[dCntData++] = bdaID;   //BDA ID

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA LoopTest 요청 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA LoopTest 요청 만들기
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        public void EditData_BDA_LoopTest(byte muID, byte ruID, byte bdaID)
        {
            CMD = CMD_BDA_LoopTest;

            dCntData = 0;
            dBufData[dCntData++] = bdaID;   //BDA ID

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA Setup(Rf출력값 요청) 상태 요청
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA Setup(Rf출력값 요청) 상태 요청
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        public void EditData_BDA_RfValueInquiry(byte muID, byte ruID, byte bdaID)
        {
            CMD = CMD_BDA_Rf;

            dCntData = 0;
            dBufData[dCntData++] = bdaID;   //BDA ID

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA Setup(Rf출력값 설정) 설정
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA Setup(Rf출력값 설정) 설정
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="bdaID">제어할 BDA ID</param>
        /// <param name="rfValue">Rf 출력 설정값</param>
        public void EditData_BDA_RfValueSet(byte muID, byte ruID, byte bdaID, byte rfValue)
        {
            CMD = CMD_BDA_RfSet;

            dCntData = 0;
            dBufData[dCntData++] = bdaID;       //BDA ID

            dBufData[dCntData++] = rfValue;     //rfValue

            MakeSendData(muID, ruID);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 주파수 설정
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// BDA 주파수 설정
        /// </summary>
        /// <param name="muID">제어할 MU ID</param>
        /// <param name="ruID">제어할 RU ID</param>
        /// <param name="nowFreq">현재 주파수 코드</param>
        /// <param name="changeFreq">변경할 주파수 코드</param>
        public void EditData_BDA_FreqSet(byte muID, byte ruID, byte nowFreq, byte changeFreq)
        {
            CMD = CMD_BDA_FreqSet;

            dCntData = 0;
            dBufData[dCntData++] = nowFreq;
            dBufData[dCntData++] = changeFreq;

            MakeSendData(muID, ruID);
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

            bufMsg[cntMsg++] = clsCommon.Make_MUID(muID);     //MU ID
            bufMsg[cntMsg++] = clsCommon.Make_RUID(ruID);     //RU ID

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

                if (clsCommon.flagDataViewTypeASCII)
                    strData = Encoding.Default.GetString(bufMsg, 0, cntMsg);
                else
                {
                    for (i = 0; i < cntMsg; i++)
                        strData += string.Format(" {0:X2}", bufMsg[i]);
                }

                this.nms_SendReceiveDataView(true, strData);     //송신 Data 보기 이벤트 전달
            }

            cSocket.Send(bufMsg, cntMsg);

            this.nms_DataSendReceive(true);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }

    public class AFGain
    {
        public int gainTx = new int();
        public int gainRx = new int();
        public int gainMon = new int();

		public AFGain Clone()
		{
			AFGain afGain = new AFGain();

			afGain.gainTx = this.gainTx;
			afGain.gainRx = this.gainRx;
			afGain.gainMon = this.gainMon;

			return afGain;
		}
    }

    public class RUDetailData
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

        public RUDetailData()
        {
            int i = 0;

            for (i = 0; i < 8; i++)
            {
                otherSt1[i] = new byte();
                otherSt2[i] = new byte();
            }
        }

		public RUDetailData Clone()
		{
			RUDetailData ruDetailData = new RUDetailData();

			for (int i = 0; i < 8; i++)
			{
				ruDetailData.otherSt1[i] = this.otherSt1[i];
				ruDetailData.otherSt2[i] = this.otherSt2[i];
			}

			ruDetailData.dcValue = this.dcValue;
			ruDetailData.rfValue = this.rfValue;
			ruDetailData.rfValueInquiry = this.rfValueInquiry;
			ruDetailData.rxRssiValue = this.rxRssiValue;

			return ruDetailData;
		}
	}

    public class RUData
    {
        public RUDetailData ruData = new RUDetailData();

        public FmData fmData = new FmData();
        public FM_Info fmInfo = new FM_Info();

        public BDA_St[] bdaSt = new BDA_St[4];

        public RUData()
        {
            int i = 0;

            for (i = 0; i < 4; i++)
                bdaSt[i] = new BDA_St();
        }

		public RUData Clone()
		{
			RUData ruData = new RUData();

			ruData.ruData = this.ruData.Clone();
			ruData.fmData = this.fmData.Clone();
            ruData.fmInfo = this.fmInfo.Clone();

            for (int i = 0; i < 4; i++)
                ruData.bdaSt[i] = this.bdaSt[i].Clone();

			return ruData;
		}
	}

    public class CommErrCheck
    {
        /// <summary>
        /// 통신 Error를 감지할수 있는 변수
        /// 주/예비/감청 무전기와 통신시 하드웨어적으로 통신 Error를 감지하여 올라오는 경우가 있는데..
        /// 이를 일정한 시간동안 Error가 유지될 경우만 Error 처리하기위한 변수
        /// </summary>
        public int[] cntCommErr = new int[3];
        public bool[] flagCommErr = new bool[3];
    }

    public class MURUDataChange
    {
        public byte cntMuDataChange = new byte();
        public byte[] cntRuDataChange = new byte[4];

        public MURUDataChange()
        {
            int i = 0;

            for (i = 0; i < 4; i++)
                cntRuDataChange[i] = new byte();
        }

        public MURUDataChange Clone()
        {
            int i = 0;

            MURUDataChange muruDataChange = new MURUDataChange();

            muruDataChange.cntMuDataChange = this.cntMuDataChange;
            for (i = 0; i < 4; i++) muruDataChange.cntRuDataChange[i] = this.cntRuDataChange[i];

            return muruDataChange;
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
        /// OPT 통신 감시 및 각 CPU 카드 장착 상태(0:역용 주 통신 감시, 1:역용 예비 통신 감시, 2:역용 감청 통신 감시)
        /// </summary>
        public byte[] optMonSt = new byte[8];

        /// <summary>
        /// OPT 기타 상태(0:DC 전원상태, 1:MODOPEN 상태, 2:CCE PTT 상태, 5:MU Trx CPU 장착여부, 6:MU Opt CPU 장착여부, 7:MU UPS 연결 여부)
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

		public MUData Clone()
		{
			int i = 0;

			MUData muData = new MUData();

			for (i = 0; i < 8; i++)
			{
				muData.otherSt1[i] = this.otherSt1[i];
				muData.otherSt2[i] = this.otherSt2[i];
				muData.optMonSt[i] = this.optMonSt[i];
				muData.optOtherSt[i] = this.optOtherSt[i];
				muData.optAlarmSt[i] = this.optAlarmSt[i];
				muData.pllLockErrorSt[i] = this.pllLockErrorSt[i];
				muData.testMode[i] = this.testMode[i];
			}

			for (i = 0; i < 2; i++)
			{
				muData.rfValue[i] = this.rfValue[i];
				muData.rfValueInquiry[i] = this.rfValueInquiry[i];
			}

			for (i = 0; i < 3; i++)
			{
                muData.rxRssiValue[i] = this.rxRssiValue[i];
                muData.chInfo[i] = this.chInfo[i];
			}

			muData.dcValue = this.dcValue;
			muData.optDcValue = this.optDcValue;
			muData.chReturn = this.chReturn;
			muData.revelValue = this.revelValue;

			return muData;
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

		public UPSData Clone()
		{
			int i = 0;

			UPSData upsData = new UPSData();

			upsData.inVoltage = this.inVoltage;
			upsData.faultVoltage = this.inVoltage;
            upsData.outVoltage = this.outVoltage;
			upsData.currentPercent = this.currentPercent;
			upsData.frequency = this.frequency;
			upsData.batteryVoltage = this.batteryVoltage;
			upsData.temperature = this.temperature;

			for (i = 0; i < 8; i++)
				upsData.otherSt[i] = this.otherSt[i];

			return upsData;
		}
	}

    public class FmData
    {
        /// <summary>
        /// 상태(0:Power, 1:Rf)
        /// </summary>
        public byte[] otherSt = new byte[8];

        public FmData()
        {
            for (int i = 0; i < 8; i++)
                otherSt[i] = new byte();
        }

		public FmData Clone()
		{
			int i = 0;

			FmData fmData = new FmData();

			for (i = 0; i < 8; i++)
				fmData.otherSt[i] = this.otherSt[i];

			return fmData;
		}
	}

    public class MURUData
    {
        public MUData muData =new MUData();
        public UPSData upsData =new UPSData();
        public FmData fmData = new FmData();
        public FM_Info fmInfo = new FM_Info();
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

		public MURUData Clone()
		{
			int i = 0;

			MURUData muruData = new MURUData();

			muruData.muData = this.muData.Clone();
			muruData.upsData = this.upsData.Clone();
			muruData.fmData = this.fmData.Clone();
            muruData.fmInfo = this.fmInfo.Clone();
            for (i = 0; i < 4; i++) muruData.afGain[i] = this.afGain[i].Clone();
			for (i = 0; i < 5; i++) muruData.ruData[i] = this.ruData[i].Clone();

			return muruData;
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

		public BDAInit Clone()
		{
			BDAInit bdaInit = new BDAInit();

			for (int i = 0; i < 4; i++)
				bdaInit.flagBDAEnable[i] = this.flagBDAEnable[i];
			bdaInit.bdaFreqCode = this.bdaFreqCode;
			bdaInit.flagBDAPollEnable = this.flagBDAPollEnable;
			bdaInit.pollTime = this.pollTime;

			return bdaInit;
		}
    }

    public class BDA_St
    {
        //경춘선 BAD 정보
        public byte[] bdaAMPSt = new byte[8];
        public byte[] bdaUpsSt = new byte[8];

        public DateTime[] bdaAmpErrTime = new DateTime[8];
        public DateTime[] bdaUpsErrTime = new DateTime[8];

        public byte[] ampDBM = new byte[5];

        //소스텔의 BDA 정보
        /// <summary> MU ID </summary>
        public Int16 mu_id;
        /// <summary> RU ID </summary>
        public Int16 ru_id;
        /// <summary> BDA ID </summary>
        public Int16 bda_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        public sbyte fmTemperature = 0;
        public sbyte fmTssi = 0;
        public byte fmAlarm = 0;

        public byte vhfBypass = 0;
        public byte vhfAcAlarm = 0;
        public byte vhfDcAlarm = 0;
        public byte vhfBatteryAlarm = 0;
        public byte vhfPtt1 = 0;
        public byte vhfPtt2 = 0;

        public byte uhfBypass = 0;
        public byte uhfAcAlarm = 0;
        public byte uhfDcAlarm = 0;
        public byte uhfBatteryAlarm = 0;
        public byte uhfPtt1 = 0;
        public byte uhfPtt2 = 0;

        public BDA_St()
        {
            int i = 0;

            for (i = 0; i < 8; i++)
            {
                bdaAMPSt[i] = new byte();
                bdaUpsSt[i] = new byte();

                bdaAmpErrTime[i] = DateTime.Now;
                bdaUpsErrTime[i] = DateTime.Now;
            }
            
            for (i = 0; i < 5; i++)
                ampDBM[i] = new byte();
        }

		public BDA_St Clone()
		{
			BDA_St bdaSt = new BDA_St();

			for (int i = 0; i < 8; i++)
			{
				bdaSt.bdaAMPSt[i] = this.bdaAMPSt[i];
				bdaSt.bdaUpsSt[i] = this.bdaUpsSt[i];
				bdaSt.bdaAmpErrTime[i] = this.bdaAmpErrTime[i];
				bdaSt.bdaUpsErrTime[i] = this.bdaUpsErrTime[i];
			}

			for (int i = 0; i < 5; i++)
				bdaSt.ampDBM[i] = this.ampDBM[i];

            bdaSt.mu_id = this.mu_id;
            bdaSt.ru_id = this.ru_id;
            bdaSt.bda_id = this.bda_id;
            bdaSt.datetime = this.datetime;

            bdaSt.fmTemperature = this.fmTemperature;
            bdaSt.fmTssi = this.fmTssi;
            bdaSt.fmAlarm = this.fmAlarm;

            bdaSt.vhfBypass = this.vhfBypass;
            bdaSt.vhfAcAlarm = this.vhfAcAlarm;
            bdaSt.vhfDcAlarm = this.vhfDcAlarm;
            bdaSt.vhfBatteryAlarm = this.vhfBatteryAlarm;
            bdaSt.vhfPtt1 = this.vhfPtt1;
            bdaSt.vhfPtt2 = this.vhfPtt2;

            bdaSt.uhfBypass = this.uhfBypass;
            bdaSt.uhfAcAlarm = this.uhfAcAlarm;
            bdaSt.uhfDcAlarm = this.uhfDcAlarm;
            bdaSt.uhfBatteryAlarm = this.uhfBatteryAlarm;
            bdaSt.uhfPtt1 = this.uhfPtt1;
            bdaSt.uhfPtt2 = this.uhfPtt2;

			return bdaSt;
		}
	}

    public class FM_Info
    {
        /// <summary> MU ID </summary>
        public Int16 mu_id;
        /// <summary> RU ID </summary>
        public Int16 ru_id;
        /// <summary> 날자시간 </summary>
        public DateTime datetime;

        /// <summary> AC 전압</summary>
        public byte acVoltage = 0;
        /// <summary> AC 전류 </summary>
        public byte acCurrent = 0;
        /// <summary> DC 12V 전압</summary>
        public byte dc12Voltage = 0;
        /// <summary> DC 12V 전류 </summary>
        public byte dc12Current = 0;
        /// <summary> DC 5V 전압</summary>
        public byte dc5Voltage = 0;
        /// <summary> DC 5V 전류 </summary>b
        public byte dc5Current = 0;
        /// <summary> Bettery 전압</summary>
        public byte betteryVoltage = 0;
        /// <summary> Bettery Change 전류 </summary>
        public byte betteryChangeCurrent = 0;
        /// <summary> Bettery DisChange  전류 </summary>
        public byte betteryDisChangeCurrent = 0;

        /// <summary> AC Input Fail </summary>
        public byte acInputFail = 0;
        /// <summary> LAN Fail </summary>
        public byte lnaFail = 0;
        /// <summary> DC Output Fail </summary>
        public byte dcOutputFail = 0;
        /// <summary> Over DisChange </summary>
        public byte overDisChange = 0;
        /// <summary> LD Alarm </summary>
        public byte ldAlarm = 0;
        /// <summary> LD Power </summary>
        public sbyte ldPower = 0;
        /// <summary> PD Alarm </summary>
        public byte pdAlarm = 0;
        /// <summary> PD Power </summary>
        public sbyte pdPower = 0;
        /// <summary> ALC </summary>
        public sbyte alc = 0;
        /// <summary> ALC Depth </summary>
        public sbyte alcDepth = 0;
        /// <summary> MGC </summary>
        public sbyte mgc = 0;
        /// <summary> RSSI </summary>
        public sbyte rssi = 0;
        /// <summary> TSSI </summary>
        public sbyte tssi = 0;
        /// <summary> TSSIFWD </summary>
        public sbyte tssiFwd = 0;
        /// <summary> TSSIREV </summary>
        public sbyte tssiRev = 0;
        /// <summary> ON/OFF </summary>
        public byte onOff = 0;
        /// <summary> Device Fail </summary>
        public byte deviceFail = 0;
        /// <summary> Temperature </summary>
        public sbyte temperature = 0;

        public FM_Info Clone()
        {
            FM_Info fmInfo = new FM_Info();

            fmInfo.acVoltage = this.acVoltage;
            fmInfo.acCurrent = this.acCurrent;
            fmInfo.dc12Voltage = this.dc12Voltage;
            fmInfo.dc12Current = this.dc12Current;
            fmInfo.dc5Voltage = this.dc5Voltage;
            fmInfo.dc5Current = this.dc5Current;
            fmInfo.betteryVoltage = this.betteryVoltage;
            fmInfo.betteryChangeCurrent = this.betteryChangeCurrent;
            fmInfo.betteryDisChangeCurrent = this.betteryDisChangeCurrent;

            fmInfo.acInputFail = this.acInputFail;
            fmInfo.lnaFail = this.lnaFail;
            fmInfo.dcOutputFail = this.dcOutputFail;
            fmInfo.overDisChange = this.overDisChange;
            fmInfo.ldAlarm = this.ldAlarm;
            fmInfo.ldPower = this.ldPower;
            fmInfo.pdAlarm = this.pdAlarm;
            fmInfo.pdPower = this.pdPower;
            fmInfo.alc = this.alc;
            fmInfo.alcDepth = this.alcDepth;
            fmInfo.mgc = this.mgc;
            fmInfo.rssi = this.rssi;
            fmInfo.tssi = this.tssi;
            fmInfo.tssiFwd = this.tssiFwd;
            fmInfo.tssiRev = this.tssiRev;
            fmInfo.onOff = this.onOff;
            fmInfo.deviceFail = this.deviceFail;
            fmInfo.temperature = this.temperature;

            return fmInfo;
        }
    }

    public class MuRuName
    {
        public string muName = string.Empty;
        public RuBdaName[] ruName = new RuBdaName[4];
        public string[] rcName = new string[4];

        public MuRuName()
        {
            for (int i = 0; i < 4; i++)
            {
                ruName[i] = new RuBdaName();
                rcName[i] = string.Empty;
            }
        }

		public MuRuName Clone()
		{
			MuRuName muruName = new MuRuName();

			muruName.muName = this.muName;

			for (int i = 0; i < 4; i++)
			{
				muruName.ruName[i] = this.ruName[i].Clone();
				muruName.rcName[i] = this.rcName[i];
			}

			return muruName;
		}
    }

    public class RuBdaName
    {
        public string ruName = string.Empty;
        public string[] bdaName = new string[4];

        public RuBdaName()
        {
            for (int i = 0; i < 4; i++)
                bdaName[i] = string.Empty;
        }

		public RuBdaName Clone()
		{
			RuBdaName ruBdaName = new RuBdaName();

			ruBdaName.ruName = this.ruName;
			for (int i = 0; i < 4; i++) ruBdaName.bdaName[i] = this.bdaName[i];

			return ruBdaName;
		}
	}

    public class MuRuComSt
    {
        public bool flagMuFirst = false;

        public bool flagMu = true;
        public int cntMu = 0;

        public bool flagFmFirst = false;
        public bool flagFm = true;
        public int cntFm = 0;

        public bool flagUpsFirst = false;
        public bool flagUps = true;
        public int cntUps = 0;

        public RuBdaComSt[] ruBdaCommSt = new RuBdaComSt[4];

        public MuRuComSt()
        {
            for (int i = 0; i < 4; i++)
                ruBdaCommSt[i] = new RuBdaComSt();
        }

		public MuRuComSt Clone()
		{
			MuRuComSt muRuComSt = new MuRuComSt();

			muRuComSt.flagMuFirst = this.flagMuFirst;
			muRuComSt.flagMu = this.flagMu;
			muRuComSt.cntMu = this.cntMu;
            muRuComSt.flagFmFirst = this.flagFmFirst;
            muRuComSt.flagFm = this.flagFm;
			muRuComSt.cntFm = this.cntFm;
			muRuComSt.flagUps = this.flagUps;
			muRuComSt.cntUps = this.cntUps;

			for (int i = 0; i < 4; i++)
			{
			}

			return muRuComSt;
		}
    }

    public class RuBdaComSt
    {
        public bool flagRuFirst = false;

        public bool flagRu = true;
        public int cntRu = 0;

        public bool flagFmFirst = false;
        public bool flagFm = true;
        public int cntFm = 0;

        public bool[] flagBdaFirst = new bool[4];
        public bool[] flagBda = new bool[4];
        public bool[] flagOldBda = new bool[4];
        public int[] cntBda = new int[4];

        public RuBdaComSt()
        {
            for (int i = 0; i < 4; i++)
            {
                flagBdaFirst[i] = new bool();
                flagBda[i] = new bool();
                flagOldBda[i] = new bool();
                cntBda[i] = new int();

                flagBda[i] = true;
                cntBda[i] = 0;
            }
        }

		public RuBdaComSt Clone()
		{
			RuBdaComSt ruBdaComSt = new RuBdaComSt();

			ruBdaComSt.flagRuFirst = this.flagRuFirst;
			ruBdaComSt.flagRu = this.flagRu;
			ruBdaComSt.cntRu = this.cntRu;
            ruBdaComSt.flagFmFirst = this.flagFmFirst;
            ruBdaComSt.flagFm = this.flagFm;
			ruBdaComSt.cntFm = this.cntFm;

			for (int i = 0; i < 4; i++)
			{
				ruBdaComSt.flagBdaFirst[i] = this.flagBdaFirst[i];
				ruBdaComSt.flagBda[i] = this.flagBda[i];
				ruBdaComSt.flagOldBda[i] = this.flagOldBda[i];
				ruBdaComSt.cntBda[i] = this.cntBda[i];
			}

			return ruBdaComSt;
		}
	}

    public class CCEComSt
    {
        public bool flagCCE = new bool();
        public int cntCCE = new int();

        public CCEComSt()
        {
            flagCCE = false;
            cntCCE = 31;
        }

		public CCEComSt Clone()
		{
			CCEComSt cceComSt = new CCEComSt();

			cceComSt.flagCCE = this.flagCCE;
			cceComSt.cntCCE = this.cntCCE;

			return cceComSt;
		}
    }
}
