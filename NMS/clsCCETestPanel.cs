using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace NMS
{
    #region CCE Test Panel과의 통신 관련 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    /// <summary>
    /// 소켓과 연결이 되었음을 알려주기 위한 이벤트
    /// </summary>
    public delegate void socket_AcceptedEvent(int MyID);
    /// <summary>
    /// 소켓과의 연결이 닫혔음을 알려주기 위한 이벤트
    /// </summary>
    public delegate void socket_ServerClosedEvent(int MyID);

    #region 데이터 송/수신에 관한 기본 이벤트 정의
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    /// <summary>
    /// 송/수신한 Data를 Hex값으로 표현하기 위한 이벤트
    /// </summary>
    /// <param name="flagSend">true : 송신, false : 수신</param>
    /// <param name="strHex">송/수신된 Data 내용(Hex)</param>
    public delegate void SendReceiveDataViewEvent(int MyID, bool flagSend, string strData);

    /// <summary>
    /// Data 송/수신 이벤트
    /// </summary>
    /// <param name="flagSend">true : 송신, false : 수신</param>
    public delegate void DataSendReceiveEvent(int MyID, bool flagSend);
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion

    /// <summary>
    /// MPU부터 CPU 상태 Data 수신
    /// </summary>
    /// <param name="tmpCpuSt">CPU 상태 Data</param>
    public delegate void MPU_CpuStEvent(int MyID, CpuSt tmpCpuSt);

    /// <summary>
    /// MPU부터 CCP, Console I/F, Broad I/F 상태 Data 수신
    /// </summary>
    /// <param name="tmpCcpSt">CCP 9개의 Communication Fault 상태</param>
    /// <param name="tmpConsoleSt">Console I/F 9개의 상태</param>
    /// <param name="tmpBroadSt">Broad I/F의 상태</param>
    public delegate void MPU_CcpConsoleBroadStEvent(int MyID, CcpSt[] tmpCcpSt, ConsoleSt[] tmpConsoleSt, BroadSt tmpBroadSt);

    /// <summary>
    /// MPU부터 Broad I/F의 Broad 1,2,3 각각의 선택 기지국 상태
    /// </summary>
    /// <param name="tmpUnitSelectedSt">Broad 1,2,3 각각의 선택기지국 상태</param>
    public delegate void MPU_BroadUnitSelectedStEvent(int MyID, byte[,] tmpUnitSelectedSt);

    /// <summary>
    /// MPU부터 Base I/F 상태 Data 수신
    /// </summary>
    /// <param name="tmpBaseSt">Base I/F의 상태</param>
    public delegate void MPU_BaseStEvent(int MyID, BaseSt[] tmpBaseSt);

    /// <summary>
    /// MPU부터 Gain Data 수신
    /// </summary>
    /// <param name="id">Gain값을 송신한 장비 ID</param>
    /// <param name="tmpGainValue">Gain 값</param>
    public delegate void MPU_GainValueEvent(int MyID, byte id, byte[] tmpGainValue);

    /// <summary>
    /// CCE Test Panel로부터 각 I/F 사용유무 Data 수신
    /// </summary>
    /// <param name="tmpUseSt">각 I/F 사용유무 Data</param>
    public delegate void MPU_IFUseStEvent(int MyID, UseSt tmpUseSt);

    /// <summary>
    /// CCE Test Panel로부터 회선시험 레벨값 Data 수신
    /// </summary>
    /// <param name="revelValue">레벨 값</param>
    public delegate void MPU_LineTestValueEvent(int MyID, byte revelValue);
    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    #endregion

    class clsCCETestPanel
    {
        #region CCE Test Panel과의 통신 관련 이벤트 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 소켓과 연결이 되었음을 알려주기 위한 이벤트
        /// </summary>
        public event socket_AcceptedEvent socket_Accepted = null;
        /// <summary>
        /// 소켓과의 연결이 닫혔음을 알려주기 위한 이벤트
        /// </summary>
        public event socket_ServerClosedEvent socket_Closed = null;

        #region 데이터 송/수신에 관한 기본 이벤트 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 송/수신한 Data를 Hex값으로 표현하기 위한 이벤트
        /// </summary>
        /// <param name="flagSend">true : 송신, false : 수신</param>
        /// <param name="strHex">송/수신된 Data 내용(Hex)</param>
        public event SendReceiveDataViewEvent sendReceiveDataView = null;

        /// <summary>
        /// Data 송/수신 이벤트
        /// </summary>
        /// <param name="flagSend">true : 송신, false : 수신</param>
        public event DataSendReceiveEvent dataSendReceive = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region MPU와의 통신 관련 이벤트 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// MPU부터 CPU 상태 Data 수신
        /// </summary>
        /// <param name="tmpCpuSt">CPU 상태 Data</param>
        public event MPU_CpuStEvent mpu_CpuSt;

        /// <summary>
        /// MPU부터 CCP, Console I/F, Broad I/F 상태 Data 수신
        /// </summary>
        /// <param name="tmpCcpSt">CCP Communication Fault 상태</param>
        /// <param name="tmpConsoleSt">Console I/F 9개의 상태</param>
        /// <param name="tmpBroadSt">Broad I/F의 상태</param>
        public event MPU_CcpConsoleBroadStEvent mpu_CcpConsoleBroadSt;

        /// <summary>
        /// MPU부터 Broad I/F의 Broad 1,2,3 각각의 선택 기지국 상태
        /// </summary>
        /// <param name="tmpUnitSelectedSt">Broad 1,2,3 각각의 선택기지국 상태</param>
        public event MPU_BroadUnitSelectedStEvent mpu_BroadUnitSelectedSt;

        /// <summary>
        /// MPU부터 Base I/F 상태 Data 수신
        /// </summary>
        /// <param name="tmpBaseSt">Base I/F의 상태</param>
        public event MPU_BaseStEvent mpu_BaseSt;

        /// <summary>
        /// MPU부터 Gain Data 수신
        /// </summary>
        /// <param name="id">Gain값을 송신한 장비 ID</param>
        /// <param name="tmpGainValue">Gain 값</param>
        public event MPU_GainValueEvent mpu_GainValue;

        /// <summary>
        /// CCE Test Panel로부터 각 I/F 사용유무 Data 수신
        /// </summary>
        /// <param name="tmpUseSt">각 I/F 사용유무 Data</param>
        public event MPU_IFUseStEvent mpu_IfUseSt = null;

        /// <summary>
        /// CCE Test Panel로부터 회선시험 레벨값 Data 수신
        /// </summary>
        /// <param name="revelValue">레벨 값</param>
        public event MPU_LineTestValueEvent mpu_LineTestValue = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region GUI <==> CPU 프로토콜 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //GUI <==> CPU
        private const byte CMD_Polling = 0x50;   //P : Polling

        //GUI <== MPU
        private const byte CMD_MPU_ST = 0x4D;    //M : MPU 자체의 동작 상태와 전원부 상태 보고
        private const byte CMD_CIF_ST = 0x43;    //C : Conlol I/F와 Broad I/F의 동작 상태 보고
        private const byte CMD_BIF_ST = 0x42;    //B : Base I/F의 동작 상태 보고

        private const byte CMD_GAIN_ST = 0x47;   //G : Gain값 상태 보고

        private const byte CMD_BIF_GRP_ST = 0x52;    //R : Broad I/F의 선택 기지국 상태 보고

        //GUI ==> MPU
        private const byte CMD_MPU_Inquiry = 0x6D;    //m : MPU 자체의 동작 상태와 전원부 상태 요청
        private const byte CMD_CIF_Inquiry = 0x63;    //c : Conlol I/F와 Broad I/F의 동작 상태 요청
        private const byte CMD_BIF_Inquiry = 0x62;    //b : Base I/F의 동작 상태 요청

        private const byte CMD_GAIN_SET = 0x47;      //G : Gain값 상태 설정
        private const byte CMD_GAIN_Inquiry = 0x67;  //g : Gain값 상태 요청

        private const byte CMD_BIF_GRP_SET = 0x52;       //R : Broad I/F의 선택 기지국 상태 설정
        private const byte CMD_BIF_GRP_Inquiry = 0x72;   //r : Broad I/F의 선택 기지국 상태 요청

        private const byte CMD_MainChange = 0x4D;        //M : 주 MPU 절체
        private const byte CMD_StbyChange = 0x53;        //S : 예비 MPU 절체
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS PC <==> CCE TEST PANEM PC간 추가된 프로토콜 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public const byte CMD_TimeSet = 0x4A;       //J : 시간설정
        public const byte CMD_MU_ChPttSt = 0x4B;    //K : 각 MU의 채널 및 PTT 상태

        //장치와 상관없이 PC간의 Data
        public const byte CMD_Other = 0x40;     //@ : 각 장치와는 별도로 PC GUI간 통신

        //SUB_CMD
        //NMS PC <== CCE TEST PANEM PC
        public const byte CMD_IF_UseSt = 0x55;      //U : 각 I/F 사용 유무 보고

        //NMS PC ==> CCE TEST PANEM PC
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public int MyID = 0;

        private ServerSocket sSocket = null;
        private IPEndPoint localEndPoint = null;
        private SendReceive sUser = null;

        private string cceIP = null;
        private int netPort = new int();

        private bool flagConnection = new bool();   //Client 접속 여부

        //송신 관련
        private byte CMD = new byte();				//명령
        private byte dCntData = new int();			//Data 갯수
        private byte[] dBufData = new byte[256];	//Data

        private CcpSt[] tmpCcpSt = new CcpSt[9];
        private ConsoleSt[] tmpConsoleSt = new ConsoleSt[9];
        private BroadSt tmpBroadSt = new BroadSt();
        private BaseSt[] tmpBaseSt = new BaseSt[32];

        public clsCCETestPanel()
        {
        }

        public clsCCETestPanel(string tmpCCEIP, int tmpCCEPort)
        {
            cceIP = tmpCCEIP;
            netPort = tmpCCEPort;

            sSocket = new ServerSocket();
            sSocket.Accepted += new AcceptedEvent(sSocket_Accepted);

            sUser = new SendReceive();
            sUser.Received += new ReceivedEvent(sUser_Received);
            sUser.Closed += new CloseEvent(sUser_Closed);

            //Server 구현( Accept 대기 )
            localEndPoint = new IPEndPoint(IPAddress.Any, netPort);
            sSocket.Start(localEndPoint);

            int i = 0;

            for (i = 0; i < 9; i++)
            {
                tmpCcpSt[i] = new CcpSt();
                tmpConsoleSt[i] = new ConsoleSt();
            }
            for (i = 0; i < 32; i++)
                tmpBaseSt[i] = new BaseSt();
        }

        #region CCE Test Panel과의 통신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void sSocket_Accepted(Socket sock)
        {
            if (flagConnection)
            {
                sUser.Stop();
                flagConnection = false;
            }

            sUser.Start(sock);
            flagConnection = true;
            this.socket_Accepted(MyID);
        }

        void sUser_Closed(SendReceive SendRecv)
        {
            sUser.Stop();
            flagConnection = false;

            this.socket_Closed(MyID);
        }

        void sUser_Received(SendReceive SendRecv, byte[] buffer, int lng)
        {
            #region 수신된 Data 기본처리
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int i = 0, j = 0;

            int chkSum = 0, iLow, iHigh;
            byte bL = 0x00, bH = 0x00;

            if (clsCommon.flagDebug[MyID])
            {
                string tmpStrData = null;

                if (clsCommon.flagDataViewTypeASCII)
                {
                    tmpStrData = Encoding.Default.GetString(buffer, 0, lng);
                }
                else
                {
                    for (i = 0; i < lng; i++)
                        tmpStrData += string.Format(" {0:X2}", buffer[i]);
                }

                this.sendReceiveDataView(MyID, false, tmpStrData);
            }

            //CheckSum 검사
            for (i = 0; i < lng - 2; i++)
                chkSum = chkSum ^ buffer[i];

            iLow = chkSum & 0x0F;
            iHigh = chkSum >> 4;
            bH = clsCommon.HexaConvert(iHigh);
            bL = clsCommon.HexaConvert(iLow);

            if ((bH != buffer[lng - 2]) || (bL != buffer[lng - 1]))
            {
                //AddStatus("CheckSum 오류!!");
                return;
            }

            this.dataSendReceive(MyID, false);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            j = 2;
            byte tmpSuID = buffer[j++];     //수신 ID
            byte tmpSongID = buffer[j++];   //송신 ID
            byte tmpCMD = buffer[j++];      //CMD
            byte tmpLng = buffer[j++];      //Data 길이

            if (tmpSuID != clsCommon.ID_PC) return;     //수신 ID가 PC가 아니면 처리하지 않는다.

            byte[] tmpByte = new byte[8];

            switch (tmpCMD)
            {
                case CMD_Polling:
                    break;

                case CMD_MPU_ST:    //M : MPU 자체의 동작 상태와 전원부 상태 보고
                    CpuSt tmpCpuSt = new CpuSt();

                    //Main/Stby 동작 상태
                    tmpCpuSt.mainStby = buffer[j++];

                    //main cpu fault, stby cpu fault, main power fault, stby power fault
                    tmpCpuSt.cpuSt = BitInfoToByte(buffer[j++]);
                    this.mpu_CpuSt(MyID, tmpCpuSt);
                    break;

                case CMD_CIF_ST:    //C : Conlol I/F와 Broad I/F의 동작 상태 보고
                    #region Conlol I/F와 Broad I/F의 동작 상태 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //CCP의 Communication Fault 상태
                    tmpByte = BitInfoToByte(buffer[j++]);   //CCP9~16 Communication Fault
                    if (tmpByte[0] == 0) tmpCcpSt[8].flagCommunicationFault = true;
                    else tmpCcpSt[8].flagCommunicationFault = false;

                    tmpByte = BitInfoToByte(buffer[j++]);   //CCP1~8 Communication Fault
                    for (i = 0; i < 8; i++)
                    {
                        if (tmpByte[i] == 0) tmpCcpSt[i].flagCommunicationFault = true;
                        else tmpCcpSt[i].flagCommunicationFault = false;
                    }

                    //Console I/F의 Communication Fault 상태
                    tmpByte = BitInfoToByte(buffer[j++]);   //Console I/F 9 Communication Fault, Broad I/F Communication Fault
                    tmpConsoleSt[8].otherSt[0] = tmpByte[0];

                    tmpByte = BitInfoToByte(buffer[j++]);   //Console I/F 1~8 Communication Fault
                    for (i = 0; i < 8; i++)
                        tmpConsoleSt[i].otherSt[0] = tmpByte[i];

                    tmpBroadSt.otherSt[0] = tmpByte[1];

                    //Console I/F 1~9의 상태
                    for (i = 0; i < 9; i++)
                    {
                        //ch, ptt, broad
                        tmpByte = BitInfoToByte(buffer[j++]);

                        //CH
                        byte tmpCh = 0;

                        if (tmpByte[0] == 1) tmpCh = 1;
                        if (tmpByte[1] == 1) tmpCh += 2;

                        tmpConsoleSt[i].ch = (byte)(tmpCh + 1);

                        tmpConsoleSt[i].otherSt[1] = tmpByte[2];    //ptt
                        tmpConsoleSt[i].otherSt[2] = tmpByte[5];    //broad
                    }

                    //Broad I/F의 상태
                    tmpBroadSt.otherSt = BitInfoToByte(buffer[j++]);

                    //CCP의 PC 연결 상태
                    tmpByte = BitInfoToByte(buffer[j++]);   //CCP9~16 PC Communication Fault
                    if (tmpByte[0] == 0) tmpCcpSt[8].flagPCCommFault = true;
                    else tmpCcpSt[8].flagPCCommFault = false;

                    tmpByte = BitInfoToByte(buffer[j++]);   //CCP1~8 PC Communication Fault
                    for (i = 0; i < 8; i++)
                    {
                        if (tmpByte[i] == 0) tmpCcpSt[i].flagPCCommFault = true;
                        else tmpCcpSt[i].flagPCCommFault = false;
                    }

                    this.mpu_CcpConsoleBroadSt(MyID, tmpCcpSt, tmpConsoleSt, tmpBroadSt);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case CMD_BIF_ST:    //B : Base I/F의 동작 상태 보고
                    #region Base I/F의 동작 상태 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    //Base I/F의 Communication Fault 상태
                    for (i = 3; i >= 0; i--)
                    {
                        tmpByte = BitInfoToByte(buffer[j++]);

                        for (int k = 0; k < 8; k++)
                            tmpBaseSt[i * 8 + k].otherSt[0] = tmpByte[k];
                    }

                    //Base I/F 1~30의 상태
                    for (i = 0; i < 30; i++)
                    {
                        //ch, ptt, busy, ebysy, broad, fault tone 1, fault tone 2
                        tmpByte = BitInfoToByte(buffer[j++]);

                        //CH
                        byte tmpCh = 0;

                        if (tmpByte[0] == 1) tmpCh = 1;
                        if (tmpByte[1] == 1) tmpCh += 2;

                        tmpBaseSt[i].ch = (byte)(tmpCh + 1);
                        tmpBaseSt[i].otherSt[1] = tmpByte[2];   //ptt
                        tmpBaseSt[i].otherSt[2] = tmpByte[3];   //busy
                        tmpBaseSt[i].otherSt[3] = tmpByte[4];   //ebusy
                        tmpBaseSt[i].otherSt[4] = tmpByte[5];   //broad
                        tmpBaseSt[i].otherSt[5] = tmpByte[6];   //fault tone 1
                        tmpBaseSt[i].otherSt[6] = tmpByte[7];   //fault tone 2
                    }

                    this.mpu_BaseSt(MyID, tmpBaseSt);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case CMD_GAIN_ST:    //G : Gain값 상태 보고
                    #region Gain값 상태 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    byte[] tmpGainValue = new byte[8];

                    byte tmpID = buffer[j++];

                    //Gain값
                    if (tmpID == clsCommon.ID_Broad)
                    {   //Broad I/F의 Gain값은 4Byte
                        for (i = 0; i < 4; i++)
                            tmpGainValue[i] = buffer[j++];
                    }
                    else
                    {   //Console I/F와 Base I/F8의 Gain값은 Byte
                        for (i = 0; i < 8; i++)
                            tmpGainValue[i] = buffer[j++];
                    }

                    this.mpu_GainValue(MyID, tmpID, tmpGainValue);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case CMD_BIF_GRP_ST:    //R : Broad I/F의 선택 기지국 상태 보고
                    #region Broad I/F의 선택 기지국 상태 처리
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    byte[,] tmpUnitSelectedSt = new byte[3, 32];

                    //Broad I/F의 Broad 1,2,3 각각의 선택 기지국 상태
                    for (i = 0; i < 3; i++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            tmpByte = BitInfoToByte(buffer[j++]);   //Base I/F 1~8 Communication Fault

                            for (int l = 0; l < 8; l++)
                                tmpUnitSelectedSt[i, k * 8 + l] = tmpByte[l];
                        }
                    }

                    this.mpu_BroadUnitSelectedSt(MyID, tmpUnitSelectedSt);
                    //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    #endregion
                    break;

                case clsNMSMainMachine.CMD_LineTest:
                    byte tmpLevelValue = buffer[j++];
                    mpu_LineTestValue(MyID, tmpLevelValue);
                    break;

                case CMD_Other:
                    byte SubCMD = buffer[j++];  //Sub CMD

                    switch (SubCMD)
                    {
                        case CMD_IF_UseSt:      //U : 각 I/F의 사용 유무 보고
                            #region  각 I/F의 사용 유무 처리
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            UseSt tmpUseSt = new UseSt();

                            //CCP 사용유무
                            tmpByte = BitInfoToByte(buffer[j++]);
                            for (i = 0; i < 8; i++)
                            {
                                if (tmpByte[i] == 1) tmpUseSt.flagCCP[i] = true;
                                else tmpUseSt.flagCCP[i] = false;
                            }

                            //Console I/F 사용유무
                            tmpByte = BitInfoToByte(buffer[j++]);
                            for (i = 0; i < 8; i++)
                            {
                                if (tmpByte[i] == 1) tmpUseSt.flagConsole[i] = true;
                                else tmpUseSt.flagConsole[i] = false;
                            }

                            //기타 사용유무(CCP9, Console9, Broad)
                            tmpByte = BitInfoToByte(buffer[j++]);

                            if (tmpByte[0] == 1) tmpUseSt.flagCCP[8] = true;
                            else tmpUseSt.flagCCP[8] = false;

                            if (tmpByte[1] == 1) tmpUseSt.flagConsole[8] = true;
                            else tmpUseSt.flagConsole[8] = false;

                            if (tmpByte[2] == 1) tmpUseSt.flagBroad = true;
                            else tmpUseSt.flagBroad = false;

                            //Base I/F 사용유무
                            for (i = 0; i < 4; i++)
                            {
                                tmpByte = BitInfoToByte(buffer[j++]);
                                for (int k = 0; k < 8; k++)
                                {
                                    if (tmpByte[k] == 1) tmpUseSt.flagBase[i * 8 + k] = true;
                                    else tmpUseSt.flagBase[i * 8 + k] = false;
                                }
                            }

                            this.mpu_IfUseSt(MyID, tmpUseSt);
                            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            #endregion
                            break;
                    }
                    break;
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
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region CCE Test Panel과의 송신 Data 만들기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //NMS PC ==> CCE TEST PANEM PC

        /// <summary>
        /// 시간 설정 Data 만들기
        /// </summary>
        public void EditData_TimeSet()
        {
            CMD = CMD_TimeSet;      //U : 시간설정

            dCntData = 0;

            byte[] tmpTime = Encoding.Default.GetBytes(DateTime.Now.ToString("yyMMddHHmmss"));

            for (int i = 0; i < tmpTime.Length; i++)
                dBufData[dCntData++] = tmpTime[i];

            MakeSendData();
        }

        /// <summary>
        /// 각 MU의 채널 및 PTT 상태 Data 만들기
        /// </summary>
        /// <param name="tmpMuChPttSt">각 기지국의 PTT/채널 상태</param>
        /// <param name="lineTestingUnit">회선시험중인 기지국 번호</param>
        public void EditData_MU_ChPttSt(muChPttSt[] tmpMuChPttSt, byte lineTestingUnit)
        {
            CMD = CMD_MU_ChPttSt;       //K : 각 MU의 채널 및 PTT 상태

            dCntData = 0;

            int i = 0, j = 0;

            //PTT 상태 Data
            for (i = 0; i < 4; i++)
            {
                byte tmpData = 1;
                byte tmpPttData = 0;

                for (j = 0; j < 8; j++)
                {
                    if (tmpMuChPttSt[i * 8 + j].flagPtt)
                        tmpPttData += tmpData;

                    tmpData <<= 1;
                }

                dBufData[dCntData++] = tmpPttData;
            }

            //CH 상태 Data
            for (i = 0; i < 8; i++)
            {
                byte tmpData = 0;
                byte tmpChData = 0;

                for (j = 0; j < 4; j++)
                {
                    tmpData = (byte)(tmpMuChPttSt[i * 4 + j].ch - 1);

                    tmpData <<= j * 2;
                    tmpChData += tmpData;
                }

                dBufData[dCntData++] = tmpChData;
            }

            //회선시험중인 기지국 번호
            dBufData[dCntData++] = lineTestingUnit;
            
            MakeSendData();
        }

        /// <summary>
        /// 회선 시험 Data 만들기
        /// </summary>
        /// <param name="testMode">0:중지, 1:송신, 2:수신, 3:감청</param>
        public void EditData_LineTest(byte testMode, byte muID)
        {
            CMD = clsCommon.CMD_LineTest;       //T : 회선 시험

            dCntData = 0;

            dBufData[dCntData++] = testMode;
            dBufData[dCntData++] = muID;

            MakeSendData();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Data 송신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region 송신 Data를 Format에 맞게 편집
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// 송신 Data를 Format에 맞게 편집
        /// </summary>
        public void MakeSendData()
        {
            int cntMsg = 0;
            byte[] bufMsg = new byte[dCntData + 9];

            int i;
            int chkSum = 0, iLow, iHigh;

            cntMsg = 0;
            bufMsg[cntMsg++] = clsCommon.STX;
            bufMsg[cntMsg++] = clsCommon.SOM_CHK;

            bufMsg[cntMsg++] = clsCommon.ID_CPU;    //수신 ID : CPU
            bufMsg[cntMsg++] = clsCommon.ID_PC;     //송신 ID : PC

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

            SendData(bufMsg, cntMsg);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region Dataa 송신
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        /// <summary>
        /// Dataa 송신
        /// </summary>
        public void SendData(byte[] bufMsg, int cntMsg)
        {
            if (clsCommon.flagDebug[MyID])
            {
                string strData = null;

                if (clsCommon.flagDataViewTypeASCII)
                    strData = Encoding.Default.GetString(bufMsg, 0, cntMsg);
                else
                {
                    for (int i = 0; i < cntMsg; i++)
                        strData += string.Format(" {0:X2}", bufMsg[i]);
                }
                
                this.sendReceiveDataView(MyID, true, strData);  //송신 Data 보기 이벤트 전달
            }

            if (sUser != null)
                sUser.Send(bufMsg, cntMsg);

            this.dataSendReceive(MyID, true);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }

    //각 MU의 PTT, 채널 상태
    public class muChPttSt
    {
        public bool flagPtt = new bool();
        public byte ch = new byte();
    }

    //CCE Test Panel관련 변수
    public class CpuSt
    {
        public byte mainStby = new byte();
        public byte[] cpuSt = new byte[8];
    }

    public class UseSt
    {
        public bool[] flagCCP = new bool[9];
        public bool[] flagConsole = new bool[9];
        public bool flagBroad = new bool();
        public bool[] flagBase = new bool[32];
    }

    public class CcpSt
    {
        public bool flagCommunicationFault = new bool();
        public bool flagPCCommFault = new bool();
    }

    public class ConsoleSt
    {
        public byte ch;

        /// <summary>
        /// Console I/F의 기타 상태( 0:Communication, 1: PTT, 2:Broad )
        /// </summary>
        public byte[] otherSt = new byte[3];
        public int[] gainValue = new int[8];
    }

    public class BroadSt
    {
        /// <summary>
        /// Broad I/F의 기타 상태( 0:Enable1, 1:Enable2, 2:Enable3, 3:PTT1, 4:PTT2, 5:PTT3 )
        /// </summary>
        public byte[] otherSt = new byte[8];

        public int[] gainValue = new int[4];
        public byte[,] unitSelectedSt = new byte[3, 32];
    }

    public class BaseSt
    {
        public byte ch;

        /// <summary>
        /// Base I/F의 기타 상태( 0:Communication, 1:PTT, 2:Busy, 3:eBusy, 4:Broad, 5:FaultTone1, 6:FaultTone2 )
        /// </summary>
        public byte[] otherSt = new byte[7];
        public int[] gainValue = new int[8];
    }
}
