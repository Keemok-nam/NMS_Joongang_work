using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace NMS_Simulation
{
    public partial class frmMain : Form
    {
        #region 폼 관련 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private frmDebug frmDG = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion 폼 관련 변수

        #region 컨트롤 배열 정의
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #region MU감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private ArrayList tbMURfMainSpare = new ArrayList();
        private ArrayList tbMURfMainSpareInquiry = new ArrayList();
        private ArrayList tbMUCHInfo = new ArrayList();
        private ArrayList tbMURXRSSI = new ArrayList();

        private ArrayList chkMuOtherSt1 = new ArrayList();
        private ArrayList chkMuOtherSt = new ArrayList();
        private ArrayList chkMuOtherSt2 = new ArrayList();

        private List<CheckBox> chkPllLock = new List<CheckBox>();
        
        //OPT 관련 컨트롤 배열
        private ArrayList chkOptMon = new ArrayList();
        private ArrayList chkOptOther = new ArrayList();
        private ArrayList chkOptAlarm = new ArrayList();        

        //AF Gain 관련
        private ArrayList tbCCEAfGain = new ArrayList();
        private ArrayList tbRC1AfGain = new ArrayList();
        private ArrayList tbRC2AfGain = new ArrayList();
        private ArrayList tbRC3AfGain = new ArrayList();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region RU감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private ArrayList tbRURfMainSpare = new ArrayList();
        private ArrayList tbRURfMainSpareInquiry = new ArrayList();

        private ArrayList chkRuOtherSt1 = new ArrayList();
        private ArrayList chkRuOtherSt = new ArrayList();
        private ArrayList chkRuOtherSt2 = new ArrayList();

        private List<CheckBox> chkBDAEnable = new List<CheckBox>();
        private List<RadioButton> rbBDAFreq = new List<RadioButton>();
        private List<CheckBox> chkBdaComm = new List<CheckBox>();
        
        private List<CheckBox>[] chkBdaUps = new List<CheckBox>[4];
        private List<CheckBox>[] chkBdaOther = new List<CheckBox>[4];
        private List<TextBox>[] tbBdaAmp = new List<TextBox>[4];

        private List<TextBox> tbBdaRf = new List<TextBox>();
        
        private List<Button> btBdaDataSend = new List<Button>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private ArrayList stationList = new ArrayList();

        #region NMS GUI와의 Network 통신에 관한 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private clsNMSGUI nmsGUI = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region MU/RU 상태 저장 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private MURUData[] muruData = null;
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 기타 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private Color colorSelect = new Color();    //회선 선택색
        private Color colorBase = new Color();      //회선 기본색

        public bool flagDataViewTypeASCII = new bool();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public frmMain()
        {
            InitializeComponent();

            int i = 0;

            #region 컨트롤 배열 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #region MU감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private ArrayList tbMURfMainSpare = new ArrayList();
            tbMURfMainSpare.Add(tbMURfMain); tbMURfMainSpare.Add(tbMURfSpare);
            //private ArrayList tbMURfMainSpareInquiry = new ArrayList();
            tbMURfMainSpareInquiry.Add(tbMURfMainInquiry); tbMURfMainSpareInquiry.Add(tbMURfSpareInquiry);
            //private ArrayList tbMUCHInfo = new ArrayList();
            tbMUCHInfo.Add(tbMUCHInfo1); tbMUCHInfo.Add(tbMUCHInfo2); tbMUCHInfo.Add(tbMUCHInfo3);
            //private ArrayList tbMURXRSSI = new ArrayList();
            tbMURXRSSI.Add(tbMURXRSSI1); tbMURXRSSI.Add(tbMURXRSSI2); tbMURXRSSI.Add(tbMURXRSSI3);

            //private List<CheckBox> chkMuOtherSt1 = new List<CheckBox>();
            chkMuOtherSt1.Add(rbMUAutoManual1); chkMuOtherSt1.Add(rbMUMainSpare1); chkMuOtherSt1.Add(rbMUWideNarrow1);
            chkMuOtherSt1.Add(chkMUAC); chkMuOtherSt1.Add(chkMUDC);
            chkMuOtherSt1.Add(chkMUModOpen);
            chkMuOtherSt1.Add(chkMURCSt1); chkMuOtherSt1.Add(chkMURCSt2);

            //private ArrayList chkMuOtherSt = new ArrayList();
            chkMuOtherSt.Add(rbMUAutoManual2); chkMuOtherSt.Add(rbMUMainSpare2); chkMuOtherSt.Add(rbMUWideNarrow2);

            //private List<CheckBox> chkMuOtherSt2 = new List<CheckBox>();
            chkMuOtherSt2.Add(chkMURCSt3); chkMuOtherSt2.Add(chkMURCSt4);
            chkMuOtherSt2.Add(chkMUSRSt1); chkMuOtherSt2.Add(chkMUSRSt2); chkMuOtherSt2.Add(chkMUSRSt3); chkMuOtherSt2.Add(chkMUSRSt4); chkMuOtherSt2.Add(chkMUSRSt5);

            //private List<CheckBox> chkPllLock = new List<CheckBox>();
            chkPllLock.Add(chkPllLock1); chkPllLock.Add(chkPllLock2); chkPllLock.Add(chkPllLock3);

            //OPT 관련 컨트롤 배열
            //private ArrayList chkOptMon = new ArrayList();
            chkOptMon.Add(chkOptMon1); chkOptMon.Add(chkOptMon2); chkOptMon.Add(chkOptMon3); chkOptMon.Add(chkOptMon4); chkOptMon.Add(chkOptMon5); chkOptMon.Add(chkOptMon6);
            //private ArrayList chkOptOther = new ArrayList();
            chkOptOther.Add(chkOptOther1); chkOptOther.Add(chkOptOther2); chkOptOther.Add(chkOptOther3);
            //private ArrayList chkOptAlarm = new ArrayList();
            chkOptAlarm.Add(chkOptAlarm1); chkOptAlarm.Add(chkOptAlarm2); chkOptAlarm.Add(chkOptAlarm3); chkOptAlarm.Add(chkOptAlarm4);
            chkOptAlarm.Add(chkOptAlarm5); chkOptAlarm.Add(chkOptAlarm6); chkOptAlarm.Add(chkOptAlarm7); chkOptAlarm.Add(chkOptAlarm8);

            //AF Gain 관련
            //private ArrayList tbCCEAfGain = new ArrayList();
            tbCCEAfGain.Add(tbCCEAfGain1); tbCCEAfGain.Add(tbCCEAfGain2); tbCCEAfGain.Add(tbCCEAfGain3);
            //private ArrayList tbRC1AfGain = new ArrayList();
            tbRC1AfGain.Add(tbRC1AfGain1); tbRC1AfGain.Add(tbRC1AfGain2); tbRC1AfGain.Add(tbRC1AfGain3);
            //private ArrayList tbRC2AfGain = new ArrayList();
            tbRC2AfGain.Add(tbRC2AfGain1); tbRC2AfGain.Add(tbRC2AfGain2); tbRC2AfGain.Add(tbRC2AfGain3);
            //private ArrayList tbRC3AfGain = new ArrayList();
            tbRC3AfGain.Add(tbRC3AfGain1); tbRC3AfGain.Add(tbRC3AfGain2); tbRC3AfGain.Add(tbRC3AfGain3);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private ArrayList tbRURfMainSpare = new ArrayList();
            tbRURfMainSpare.Add(tbRURfMain);
            //private ArrayList tbRURfMainSpareInquiry = new ArrayList();
            tbRURfMainSpareInquiry.Add(tbRURfMainInquiry);

            //private ArrayList chkRuOtherSt1 = new ArrayList();
            chkRuOtherSt1.Add(rbRUAutoManual1); chkRuOtherSt1.Add(rbRUMainSpare1); chkRuOtherSt1.Add(rbRUWideNarrow1);
            chkRuOtherSt1.Add(chkRUAC); chkRuOtherSt1.Add(chkRUDC);
            chkRuOtherSt1.Add(chkRUCardSt2); chkRuOtherSt1.Add(chkRUCardSt3); chkRuOtherSt1.Add(chkRUCardSt4);

            //private ArrayList chkRuOtherSt = new ArrayList();
            chkRuOtherSt.Add(rbRUAutoManual2); chkRuOtherSt.Add(rbRUMainSpare2); chkRuOtherSt.Add(rbRUWideNarrow2);

            //private ArrayList chkRuOtherSt2 = new ArrayList();
            chkRuOtherSt2.Add(chkRUCardSt1);
            chkRuOtherSt2.Add(chkRUDataOptical); chkRuOtherSt2.Add(chkRUVoiceOptical); chkRuOtherSt2.Add(chkRuOptLD); chkRuOtherSt2.Add(chkRuOptPD);

            //private List<CheckBox> chkBDAEnable = new List<CheckBox>();
            chkBDAEnable.Add(chkBDAEnable1); chkBDAEnable.Add(chkBDAEnable2); chkBDAEnable.Add(chkBDAEnable3); chkBDAEnable.Add(chkBDAEnable4);
            //private List<RadioButton> rbBDAFreq = new List<RadioButton>();
            rbBDAFreq.Add(rbBDAFreq1); rbBDAFreq.Add(rbBDAFreq2); rbBDAFreq.Add(rbBDAFreq3); rbBDAFreq.Add(rbBDAFreq4); rbBDAFreq.Add(rbBDAFreq5);
            //private List<CheckBox> chkBdaComm = new List<CheckBox>();
            chkBdaComm.Add(chkBdaComm1); chkBdaComm.Add(chkBdaComm2); chkBdaComm.Add(chkBdaComm3); chkBdaComm.Add(chkBdaComm4);

            for (i = 0; i < 4; i++)
            {
                chkBdaUps[i] = new List<CheckBox>();
                chkBdaOther[i] = new List<CheckBox>();
                tbBdaAmp[i] = new List<TextBox>();
            }

            //private List<CheckBox>[] chkBdaUps = new List<CheckBox>[4];
            chkBdaUps[0].Add(chkBda1_UpsBypass); chkBdaUps[0].Add(chkBda1_UpsAC); chkBdaUps[0].Add(chkBda1_UpsFail); chkBdaUps[0].Add(chkBda1_UpsLow); chkBdaUps[0].Add(chkBda1_UpsFail); chkBdaUps[0].Add(chkBda1_Comm);
            chkBdaUps[1].Add(chkBda2_UpsBypass); chkBdaUps[1].Add(chkBda2_UpsAC); chkBdaUps[1].Add(chkBda2_UpsFail); chkBdaUps[1].Add(chkBda2_UpsLow); chkBdaUps[1].Add(chkBda2_UpsFail); chkBdaUps[1].Add(chkBda2_Comm);
            chkBdaUps[2].Add(chkBda3_UpsBypass); chkBdaUps[2].Add(chkBda3_UpsAC); chkBdaUps[2].Add(chkBda3_UpsFail); chkBdaUps[2].Add(chkBda3_UpsLow); chkBdaUps[2].Add(chkBda3_UpsFail); chkBdaUps[2].Add(chkBda3_Comm);
            chkBdaUps[3].Add(chkBda4_UpsBypass); chkBdaUps[3].Add(chkBda4_UpsAC); chkBdaUps[3].Add(chkBda4_UpsFail); chkBdaUps[3].Add(chkBda4_UpsLow); chkBdaUps[3].Add(chkBda4_UpsFail); chkBdaUps[3].Add(chkBda4_Comm);
            //private List<CheckBox>[] chkBdaOther = new List<CheckBox>[4];
            chkBdaOther[0].Add(chkBda1_AMP1); chkBdaOther[0].Add(chkBda1_AMP2); chkBdaOther[0].Add(chkBda1_AMP3); chkBdaOther[0].Add(chkBda1_AMP4); chkBdaOther[0].Add(chkBda1_AMP5); chkBdaOther[0].Add(chkBda1_12); chkBdaOther[0].Add(chkBda1_24); chkBdaOther[0].Add(chkBda1_220);
            chkBdaOther[1].Add(chkBda2_AMP1); chkBdaOther[1].Add(chkBda2_AMP2); chkBdaOther[1].Add(chkBda2_AMP3); chkBdaOther[1].Add(chkBda2_AMP4); chkBdaOther[1].Add(chkBda2_AMP5); chkBdaOther[1].Add(chkBda2_12); chkBdaOther[1].Add(chkBda2_24); chkBdaOther[1].Add(chkBda2_220);
            chkBdaOther[2].Add(chkBda3_AMP1); chkBdaOther[2].Add(chkBda3_AMP2); chkBdaOther[2].Add(chkBda3_AMP3); chkBdaOther[2].Add(chkBda3_AMP4); chkBdaOther[2].Add(chkBda3_AMP5); chkBdaOther[2].Add(chkBda3_12); chkBdaOther[2].Add(chkBda3_24); chkBdaOther[2].Add(chkBda3_220);
            chkBdaOther[3].Add(chkBda4_AMP1); chkBdaOther[3].Add(chkBda4_AMP2); chkBdaOther[3].Add(chkBda4_AMP3); chkBdaOther[3].Add(chkBda4_AMP4); chkBdaOther[3].Add(chkBda4_AMP5); chkBdaOther[3].Add(chkBda4_12); chkBdaOther[3].Add(chkBda4_24); chkBdaOther[3].Add(chkBda4_220);
            //private List<TextBox>[] tbBdaAmp = new List<TextBox>[4];
            tbBdaAmp[0].Add(tbBda1_Amp1); tbBdaAmp[0].Add(tbBda1_Amp2); tbBdaAmp[0].Add(tbBda1_Amp3); tbBdaAmp[0].Add(tbBda1_Amp4); tbBdaAmp[0].Add(tbBda1_Amp5);
            tbBdaAmp[1].Add(tbBda2_Amp1); tbBdaAmp[1].Add(tbBda2_Amp2); tbBdaAmp[1].Add(tbBda2_Amp3); tbBdaAmp[1].Add(tbBda2_Amp4); tbBdaAmp[1].Add(tbBda2_Amp5);
            tbBdaAmp[2].Add(tbBda3_Amp1); tbBdaAmp[2].Add(tbBda3_Amp2); tbBdaAmp[2].Add(tbBda3_Amp3); tbBdaAmp[2].Add(tbBda3_Amp4); tbBdaAmp[2].Add(tbBda3_Amp5);
            tbBdaAmp[3].Add(tbBda4_Amp1); tbBdaAmp[3].Add(tbBda4_Amp2); tbBdaAmp[3].Add(tbBda4_Amp3); tbBdaAmp[3].Add(tbBda4_Amp4); tbBdaAmp[3].Add(tbBda4_Amp5);

            //private List<TextBox> tbBdaRf = new List<TextBox>();
            tbBdaRf.Add(tbBdaRf1); tbBdaRf.Add(tbBdaRf2); tbBdaRf.Add(tbBdaRf3); tbBdaRf.Add(tbBdaRf4);

            //private List<Button> btBdaDataSend = new List<Button>();        
            btBdaDataSend.Add(btBdaDataSend1); btBdaDataSend.Add(btBdaDataSend2); btBdaDataSend.Add(btBdaDataSend3); btBdaDataSend.Add(btBdaDataSend4);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            for (i = 0; i < 4; i++)
                btBdaDataSend[i].Tag = i;

            #region 파일로 부터 역 List 정보 읽어오기
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            StreamReader fr = null;

            try
            {
                fr = File.OpenText(clsCommon.DefaultPath + "경춘선.txt");

                string tmpStation = fr.ReadLine();

                stationList.Add("");
                while (tmpStation != null)
                {
                    stationList.Add(tmpStation);
                    tmpStation = fr.ReadLine();
                }
            }
            catch
            {
            }

            fr.Close();
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            GetTreeView();  //Tree 만들기

            #region 역사별 MU/RU 상태 저장 변수 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            muruData = new MURUData[stationList.Count];

            for (i = 0; i < muruData.Length; i++)
                muruData[i] = new MURUData();

            for (i = 1; i < muruData.Length; i++)
            {
                MUDataRead((byte)i);    //MU의 Data 읽어오기
                AFGainDataRead((byte)i);    //MU의 CCE/RC1/RC2/RC3 AFGain값 읽어오기

                for (byte j = 0; j < 4; j++)
                    RUDataRead((byte)i, j); //RU의 Data 읽어오기
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region NMS주장치와의 Network통신 관련 초기화 작업
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            nmsGUI = new clsNMSGUI(this);

            nmsGUI.nms_SocketAccepted += new socket_AcceptedEvent(nmsGUI_nms_SocketAccepted);
            nmsGUI.nms_SocketCloseed += new socket_ClosedEvent(nmsGUI_nms_SocketCloseed);

            nmsGUI.nms_SendReceiveDataView += new NMSMainMachine_SendReceiveDataViewEvent(nmsGUI_nms_SendReceiveDataView);
            nmsGUI.nms_DataSendReceive += new NMSMainMachine_DataSendReceiveEvent(nmsGUI_nms_DataSendReceive);
            nmsGUI.nms_Polling += new NMSMainMachine_PollingEvent(nmsGUI_nms_Polling);

            nmsGUI.nms_MainSpareChange += new NMSMainMachine_MainSpareChangeEvent(nmsGUI_nms_MainSpareChange);
            nmsGUI.nms_AutoStbyChange += new NMSMainMachine_AutoStbyChangeEvent(nmsGUI_nms_AutoStbyChange);
            nmsGUI.nms_RfGainSet += new NMSMainMachine_RFGainSetEvent(nmsGUI_nms_RfGainSet);
            nmsGUI.nms_AfGainSet += new NMSMainMachine_AFGainSetEvent(nmsGUI_nms_AfGainSet);
            nmsGUI.nms_AfGainInquiry += new NMSMainMachine_AFGainInquiryEvent(nmsGUI_nms_AfGainInquiry);
            nmsGUI.nms_WideNarrowChange += new NMSMainMachine_WideNarrowChangeEvent(nmsGUI_nms_WideNarrowChange);
            nmsGUI.nms_ChReturnTimeSet += new NMSMainMachine_ChReturnTimeSetEvent(nmsGUI_nms_ChReturnTimeSet);

            nmsGUI.nms_BdaInitStSet += new NMSMainMachine_BDAInitStSetEvent(nmsGUI_nms_BdaInitStSet);
            nmsGUI.nms_BdaInitStInquiry += new NMSMainMachine_BDAInitStInquiryEvent(nmsGUI_nms_BdaInitStInquiry);
            nmsGUI.nms_BdaStInquiry += new NMSMainMachine_BDAStInquiryEvent(nmsGUI_nms_BdaStInquiry);
            nmsGUI.nms_BdaLoopTest += new NMSMainMachine_BDALoopTestEvent(nmsGUI_nms_BdaLoopTest);
            nmsGUI.nms_BdaRfInquiry += new NMSMainMachine_BDARfInquiryEvent(nmsGUI_nms_BdaRfInquiry);
            nmsGUI.nms_BdaRfSet += new NMSMainMachine_BDARfSetEvent(nmsGUI_nms_BdaRfSet);
            nmsGUI.nms_BdaFreqSet += new NMSMainMachine_BDAFreqSetEvent(nmsGUI_nms_BdaFreqSet);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            AddStatus("NMS 주장치 Simulation 프로그램이 시작되었습니다.");
        }

        #region 컨트롤 제어(문자출력, 활성화 변경, 색변경)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //컨트롤에 문자를 출력하기 위함
        private void SetText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }

        //컨트롤에 문자를 출력하기 위함
        private void SetTextAppend(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextAppend);
                this.Invoke(d, new object[] { control, text });
            }
            else
            {
                if (((TextBox)control).Text.Length > 2048)
                    ((TextBox)control).Text = ((TextBox)control).Text.Substring(1024);
                //if (((TextBox)control).Text.Length > 1024)
                //    ((TextBox)control).Text = ((TextBox)control).Text.Substring(512);

                ((TextBox)control).Text += text;

                ((TextBox)control).SelectionStart = ((TextBox)control).Text.Length;//맨 마지막 선택...
                ((TextBox)control).ScrollToCaret();
            }
        }

        //컨트롤의 활성화 여부를 결정하기 위함
        private void SetEnable(Control control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetEnableCallback d = new SetEnableCallback(SetEnable);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Enabled = flag;
            }
        }

        //컨트롤에 색을 변경하기 위함
        private void SetColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetColor);
                this.Invoke(d, new object[] { control, color });
            }
            else
            {
                control.BackColor = color;
            }
        }

        //컨트롤의 글자색을 변경하기 위함
        private void SetForeColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetForeColor);
                this.Invoke(d, new object[] { control, color });
            }
            else
            {
                control.ForeColor = color;
            }
        }

        //컨트롤의 Visible값을 변경하기 위함
        private void SetVisible(Control control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetVisibleCallback d = new SetVisibleCallback(SetVisible);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Visible = flag;
            }
        }

        //컨트롤에 체크하기 위함
        private void SetChecked(CheckBox control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetCheckedCallback d = new SetCheckedCallback(SetChecked);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Checked = flag;
            }
        }

        //컨트롤에 체크하기 위함
        private void SetChecked(RadioButton control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetRdButCheckedCallback d = new SetRdButCheckedCallback(SetChecked);
                this.Invoke(d, new object[] { control, flag });
            }
            else
            {
                control.Checked = flag;
            }
        }

        //컨트롤의 Value값을 변경하기 위함
        private void SetValue(ProgressBar control, int maxValue, int value)
        {
            if (control.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetValue);
                this.Invoke(d, new object[] { control, maxValue, value });
            }
            else
            {
                control.Maximum = maxValue;
                control.Value = value;
            }
        }

        //TrackBar 컨트롤에 value값을 변경하기 위함
        private void SetValue(TrackBar control, int value)
        {
            if (control.InvokeRequired)
            {
                SetTBValueCallback d = new SetTBValueCallback(SetValue);
                this.Invoke(d, new object[] { control, value });
            }
            else
            {
                control.Value = value;
            }
        }

        //PictureBox에 그림을 변경하기 위함
        private void SetImage(PictureBox control, Bitmap bitmap)
        {
            if (control.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                this.Invoke(d, new object[] { control, bitmap });
            }
            else
            {
                control.Image = bitmap;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region AddStatus( 현재상태 로그파일에 저장 )
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void AddStatus(string tmpMsg)
        {
            try
            {
                string FilePath = clsCommon.LogPath + DateTime.Now.Year.ToString();
                if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);

                string strMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + tmpMsg;

                string fileName = FilePath + @"\" + DateTime.Now.ToShortDateString() + ".txt";

                StreamWriter fw = File.AppendText(fileName);
                fw.WriteLine(strMsg);
                fw.Close();

                strMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n" + tmpMsg;
                SetText(tbMessage, strMsg);
            }
            catch
            {
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (frmDG == null)
                {
                    frmDG = new frmDebug(this);
                    frmDG.Show();
                }
                else
                {
                    MessageBox.Show("이미실행되어 있습니다.", "중복실행확인", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        #region Tree 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void GetTreeView()
        {   //Tree 만들기
            TreeNode tmpMU = null;;
            TreeNode tmpRU = null; ;

            for (int i = 1; i < stationList.Count; i++)
            {
                tmpMU = new TreeNode();

                tmpMU.Text = stationList[i].ToString();
                tmpMU.Name = stationList[i].ToString();
                tmpMU.Tag = i.ToString() + ":0";

                for (int j = 0; j < 4; j++)
                {
                    tmpRU = new TreeNode();

                    tmpRU.Text = "RU" + (j + 1).ToString();
                    tmpRU.Name = "RU" + (j + 1).ToString();
                    tmpRU.Tag = i.ToString() + ":" + (j + 1).ToString();

                    tmpMU.Nodes.Add(tmpRU);
                }

                tvStation.Nodes.Add(tmpMU);
            }
        }

        private void tvStation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] tmpInfo = null;

            tmpInfo = (tvStation.SelectedNode.Tag.ToString()).Split(new char[] { ':' });
            clsCommon.presentMUID = Convert.ToByte(tmpInfo[0]);
            clsCommon.presentRUID = Convert.ToByte(tmpInfo[1]);

            MURUStatusView();   //MU/RU 상태 보기
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS GUI와의 통신 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void btStart_Click(object sender, EventArgs e)
        {
            nmsGUI.sSocket_Start(Convert.ToInt16(tbPort.Text));
            SetColor(btStart, Color.YellowGreen);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            nmsGUI.sSocket_Stop();
            SetColor(btStart, SystemColors.Control);
        }

        #region NMS GUI와의 소켓 접속관련 이벤트
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsGUI_nms_SocketAccepted()
        {
            SetColor(lbl_NMSConnected, Color.Lime);
            AddStatus("NMS GUI가 접속하였습니다.");
        }

        void nmsGUI_nms_SocketCloseed()
        {
            SetColor(lbl_NMSConnected, Color.Blue);
            AddStatus("NMS GUI와의 접속이 끊겼습니다.");
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS GUI와의 Data 송수신 관련 이벤트(Data 보기, 송/수신 표시, 폴링)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsGUI_nms_SendReceiveDataView(bool flagSend, string strData)
        {
            if (flagSend) frmDG.SetTxData(clsCommon.NMS, strData);
            else frmDG.SetRxData(clsCommon.NMS, strData);
        }

        void nmsGUI_nms_DataSendReceive(bool flagSend)
        {
            if (flagSend)
            {
                if (lbl_NMSTX.BackColor == Color.Lime) SetColor(lbl_NMSTX, Color.Blue);
                else SetColor(lbl_NMSTX, Color.Lime);
            }
            else
            {
                if (lbl_NMSRX.BackColor == Color.Lime) SetColor(lbl_NMSRX, Color.Blue);
                else SetColor(lbl_NMSRX, Color.Lime);
            }
        }

        void nmsGUI_nms_Polling(bool flag)
        {
            if (flag) SetColor(lbl_NMSConnected, Color.Lime);
            else SetColor(lbl_NMSConnected, Color.Red);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region NMS GUI에서의 제어 이벤트
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsGUI_nms_MainSpareChange(byte muID, byte ruID, byte mainSpare)
        {
            if (ruID == 0)
                muruData[muID].muData.otherSt1[1] = mainSpare;   //주/예비 동작상태
            else
                muruData[muID].ruData[ruID].otherSt1[1] = mainSpare;   //주/예비 동작상태

            MURUStatusView(muID, ruID);

            //적용된것 송신
            if (ruID == 0) MUDataSend(muID);
            else RUDataSend(muID, ruID);
        }

        void nmsGUI_nms_AutoStbyChange(byte muID, byte ruID, byte autoManual)
        {
            if (ruID == 0)
                muruData[muID].muData.otherSt1[0] = autoManual;  //자동/수동 절체방법
            else
                muruData[muID].ruData[ruID].otherSt1[0] = autoManual;  //자동/수동 절체방법

            MURUStatusView(muID, ruID);

            //적용된것 송신
            if (ruID == 0) MUDataSend(muID);
            else RUDataSend(muID, ruID);
        }

        void nmsGUI_nms_RfGainSet(byte muID, byte ruID, byte mainStby, byte rfValue)
        {
            if (ruID == 0) muruData[muID].muData.rfValue[mainStby] = rfValue;
            else muruData[muID].ruData[ruID].rfValue = rfValue;

            MURUStatusView(muID, ruID);

            //적용된것 송신
            if (ruID == 0) MUDataSend(muID);
            else RUDataSend(muID, ruID);
        }

        void nmsGUI_nms_WideNarrowChange(byte muID, byte ruID, byte wideNarrow)
        {
            if (ruID == 0) muruData[muID].muData.otherSt1[2] = wideNarrow;
            else muruData[muID].ruData[ruID].otherSt1[2] = wideNarrow;

            MURUStatusView(muID, ruID);

            //적용된것 송신
            if (ruID == 0) MUDataSend(muID);
            else RUDataSend(muID, ruID);
        }

        void nmsGUI_nms_ChReturnTimeSet(byte muID, byte chReturnTime)
        {
            muruData[muID].muData.chReturn = chReturnTime;

            MURUStatusView(muID, 0);

            //적용된것 송신
            MUDataSend(muID);
        }

        void nmsGUI_nms_AfGainSet(byte muID, byte ruID, byte rcNum, AFGain value)
        {   //CCE/RC1/RC2/RC3의 TX/RX/MON의 AFGainr값 설정
            switch (rcNum)
            {
                case clsNMSGUI.CMD_AFGainSet_CCE: rcNum = 0; break;
                case clsNMSGUI.CMD_AFGainSet_RC1: rcNum = 1; break;
                case clsNMSGUI.CMD_AFGainSet_RC2: rcNum = 2; break;
                case clsNMSGUI.CMD_AFGainSet_RC3: rcNum = 3; break;
            }

            muruData[muID].afGain[rcNum] = value;

            nmsGUI.EditData_AFGainDataResponse(muID, ruID, muruData[muID].afGain);   //적용된것 송신

            MURUStatusView(muID, ruID);
        }

        void nmsGUI_nms_AfGainInquiry(byte muID, byte ruID)
        {   //CCE/RC1/RC2/RC3의 TX/RX/MON의 AFGain값 요청
            nmsGUI.EditData_AFGainDataResponse(muID, ruID, muruData[muID].afGain);
        }
        
        #region NMS GUI에서의 BDA 제어 이벤트
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        void nmsGUI_nms_BdaInitStSet(byte muID, byte ruID, BDAInit bdaInit)
        {   //BDA 초기값 설정
            for (int i = 0; i < 4; i++)
                SetChecked(chkBDAEnable[i], bdaInit.flagBDAEnable[i]);
            SetChecked(chkBDAPollEnable, bdaInit.flagBDAPollEnable);
            SetText(tbBDAPollTime, bdaInit.pollTime.ToString());
        }

        void nmsGUI_nms_BdaInitStInquiry(byte muID, byte ruID)
        {
            int i = 0;
            BDAInit tmpBdaInitSt = new BDAInit();

            for (i = 0; i < 4; i++)
            {
                if (chkBDAEnable[i].Checked)
                    tmpBdaInitSt.flagBDAEnable[i] = true;
            }
            if (chkBDAPollEnable.Checked)
                tmpBdaInitSt.flagBDAPollEnable = true;

            for (i = 0; i < 5; i++)
            {
                if (rbBDAFreq[i].Checked)
                {
                    tmpBdaInitSt.bdaFreqCode = (byte)i;
                    break;
                }
            }
            
            tmpBdaInitSt.pollTime = Convert.ToByte(tbBDAPollTime.Text);

            nmsGUI.EditData_BDAInitReport(muID, ruID, tmpBdaInitSt);
        }

        void nmsGUI_nms_BdaStInquiry(byte muID, byte ruID, byte bdaID)
        {
            BdaNowDataReadSend(muID, ruID, bdaID - 1);
        }

        void nmsGUI_nms_BdaLoopTest(byte muID, byte ruID, byte bdaID)
        {
            nmsGUI.EditData_BdaLoopTest(muID, ruID, bdaID);
        }

        void nmsGUI_nms_BdaRfInquiry(byte muID, byte ruID, byte bdaID)
        {
            nmsGUI.EditData_BdaRfValueReport(muID, ruID, bdaID, Convert.ToByte(tbBdaRf[bdaID - 1].Text));
        }

        void nmsGUI_nms_BdaRfSet(byte muID, byte ruID, byte bdaID, byte rfValue)
        {
            SetText(tbBdaRf[bdaID - 1], rfValue.ToString());
        }

        void nmsGUI_nms_BdaFreqSet(byte muID, byte ruID, byte[] freqCode)
        {
            SetChecked(rbBDAFreq[freqCode[1]], true);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void btMUDataSend_Click(object sender, EventArgs e)
        {
            MuNowDataRead();
            MUDataSend(clsCommon.presentMUID);
        }

        private void btUPSDataSend_Click(object sender, EventArgs e)
        {
            UPSNowDataRead();
            nmsGUI.EditData_UPSDataReport(clsCommon.presentMUID, muruData[clsCommon.presentMUID].upsData);
        }

        private void btMuFMDataSend_Click(object sender, EventArgs e)
        {
            byte tmpMuFm = 0;

            if (!chkMuFmPower.Checked) tmpMuFm +=1;
            if (!chkMuFmRf.Checked) tmpMuFm += 2;

            nmsGUI.EditData_FmDataReport(clsCommon.presentMUID, clsCommon.presentRUID, tmpMuFm);
        }

        private void btRUDataSend_Click(object sender, EventArgs e)
        {
            RuNowDataRead();
            RUDataSend(clsCommon.presentMUID, clsCommon.presentRUID);
        }

        private void btRuFMDataSend_Click(object sender, EventArgs e)
        {
            byte tmpRuFm = 0;

            if (!chkRuFmPower.Checked) tmpRuFm += 1;
            if (!chkRuFmRf.Checked) tmpRuFm += 2;

            nmsGUI.EditData_FmDataReport(clsCommon.presentMUID, clsCommon.presentRUID, tmpRuFm);
        }

        private void btBdaDataSend_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);
            BdaNowDataReadSend(clsCommon.presentMUID, clsCommon.presentRUID, index);
        }

        private void btBdaCommDataSend_Click(object sender, EventArgs e)
        {
            byte[] tmpBdaComm = new byte[4];

            for (int i = 0; i < 4; i++)
                if (chkBdaComm[i].Checked) tmpBdaComm[i] = 1;

            nmsGUI.EditData_BDACommStReport(clsCommon.presentMUID, clsCommon.presentRUID, tmpBdaComm);
        }

        //Data 송신주기 설정
        private void chkApply_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApply.Checked)
            {   //적용
                tmrCycle.Interval = Convert.ToInt32(tbInterval.Text) / 5;
                tmrCycle.Start();
            }
            else
            {
                tmrCycle.Stop();
            }
        }

        private byte sendMUID = 1;
        private bool flagMUDataSend = true;
        private byte sendRUID = 1;

        private void tmrCycle_Tick(object sender, EventArgs e)
        {
            tmrCycle.Stop();

            if (flagMUDataSend)
            {   //MU Data 송신
                flagMUDataSend = false;

                MUDataSend(sendMUID);
            }
            else
            {
                try
                {
                    RUDataSend(sendMUID, sendRUID++);
                }
                catch
                {
                }

                if (sendRUID > 4)
                {
                    sendRUID = 1;

                    flagMUDataSend = true;  //다음역 MU Data 송신
                    if (++sendMUID >= stationList.Count) sendMUID = 1;
                }
            }

            tmrCycle.Start();
        }

        //BDA Data 송신주기 설정
        private void chkBDAApply_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBDAApply.Checked)
            {   //적용
                tmrBDACycle.Interval = Convert.ToInt32(tbBDAInterval.Text) / 4;
                tmrBDACycle.Start();
            }
            else
            {
                tmrBDACycle.Stop();
            }
        }

        private byte sendBDAID = 0;
        private void tmrBDACycle_Tick(object sender, EventArgs e)
        {
            tmrBDACycle.Stop();

            BdaNowDataReadSend(clsCommon.presentMUID, clsCommon.presentRUID, sendBDAID++);

            if (sendBDAID > 3)
                sendBDAID = 0;

            tmrBDACycle.Start();
        }

        private void MUDataSend(byte muID)
        {
            nmsGUI.EditData_TWDataReport(muID, 0, muruData[muID]);
        }

        private void RUDataSend(byte muID, byte ruID)
        {
            nmsGUI.EditData_TWDataReport(muID, ruID, muruData[muID]);
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void MUDataRead(byte muID)
        {
            int i = 0;

            try
            {
                string fileName = clsCommon.DefaultPath + stationList[muID].ToString() + "MU.txt";

                MUData tmpMUData = new MUData();

                StreamReader fr = File.OpenText(fileName);
                {
                    // MU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태,
                    //               3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RC1 PTT 상태)
                    for (i = 0; i < 8; i++) tmpMUData.otherSt1[i] = Convert.ToByte(fr.ReadLine());

                    // MU의 기타 상태(8: RC2 PTT 상태, 9: RC3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY)
                    for (i = 0; i < 7; i++) tmpMUData.otherSt2[i] = Convert.ToByte(fr.ReadLine());

                    tmpMUData.dcValue = Convert.ToByte(fr.ReadLine());  //MU의 DC전원값
                                        
                    //MU의 주/예비 RF 출력값
                    for (i = 0; i < 2; i++) tmpMUData.rfValue[i] = Convert.ToByte(fr.ReadLine());

                    //MU의 주/예비/감청용 RX RSSI 값
                    for (i = 0; i < 3; i++) tmpMUData.rxRssiValue[i] = Convert.ToByte(fr.ReadLine());

                    //MU의 주/예비 RF 출력조회값
                    for (i = 0; i < 2; i++) tmpMUData.rfValueInquiry[i] = Convert.ToByte(fr.ReadLine());

                    //MU의 주/예비/감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
                    for (i = 0; i < 3; i++) tmpMUData.chInfo[i] = Convert.ToByte(fr.ReadLine());

                    //OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시, 3:MU Trx CPU, 4:Mu Opt CPU, 5:MU UPS)
                    for (i = 0; i < 6; i++) tmpMUData.optMonSt[i] = Convert.ToByte(fr.ReadLine());                    

                    //OPT의 기타 상태(0:DC 전원 상태, 1:MODOPEN 상태, 2:CCE PTT 상태)
                    for (i = 0; i < 3; i++) tmpMUData.optOtherSt[i] = Convert.ToByte(fr.ReadLine());

                    //OPT의 DC전원값
                    tmpMUData.optDcValue = Convert.ToByte(fr.ReadLine());

                    //OPT의 LD/PD 알람 상태(0~3:OPT1~4 LD 알람, 4~7:OPT1~4 PD 알람)
                    for (i = 0; i < 8; i++) tmpMUData.optAlarmSt[i] = Convert.ToByte(fr.ReadLine());

                    //채널 복귀 상태
                    tmpMUData.chReturn = Convert.ToByte(fr.ReadLine());

                    //PLL Lock 장애(주,예비,감청)
                    for (i = 0; i < 3; i++) tmpMUData.pllLockErrorSt[i] = Convert.ToByte(fr.ReadLine());
                }
                fr.Close();

                muruData[muID].muData = tmpMUData;
            }
            catch
            {
            }
        }

        private void AFGainDataRead(byte muID)
        {
            try
            {
                string fileName = clsCommon.DefaultPath + stationList[muID].ToString() + "AFGain.txt";

                StreamReader fr = File.OpenText(fileName);

                for (int i = 0; i < 4; i++)
                {
                    muruData[muID].afGain[i].gainTx = Convert.ToInt32(fr.ReadLine());
                    muruData[muID].afGain[i].gainRx = Convert.ToInt32(fr.ReadLine());
                    muruData[muID].afGain[i].gainMon = Convert.ToInt32(fr.ReadLine());                    
                }
                fr.Close();
            }
            catch
            {
            }
        }

        private void RUDataRead(byte muID, byte ruID)
        {
            int i = 0;

            try
            {
                string fileName = clsCommon.DefaultPath + stationList[muID].ToString() + "RU" + ruID.ToString() + ".txt";

                RUData tmpRUData = new RUData();

                StreamReader fr = File.OpenText(fileName);
                {
                    //RU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태,
                    //              5:MODOPEN 상태, 6:PTT 상태, 7:Local/Remote 상태)
                    for (i = 0; i < 8; i++) tmpRUData.otherSt1[i] = Convert.ToByte(fr.ReadLine());

                    //RU의 기타 상태(0:RUCPU 상태, 1:데이터 광접속 상태, 2:음성 광접속 상태, 3:OPT LD 알람 상태, 4:OPT PD 알람 상태)
                    for (i = 0; i < 5; i++) tmpRUData.otherSt2[i] = Convert.ToByte(fr.ReadLine());
                    //XMTR PLL Lock 장애, RCVR PLL LOCK 장애

                    tmpRUData.dcValue = Convert.ToByte(fr.ReadLine());  //RU의 DC전원값
                                        
                    //RU의 주/예비 RF 출력값
                    for (i = 0; i < 1; i++) tmpRUData.rfValue = Convert.ToByte(fr.ReadLine());

                    //RU의 주/예비 RF 출력조회값
                    for (i = 0; i < 1; i++) tmpRUData.rfValueInquiry = Convert.ToByte(fr.ReadLine());

                    //RSSI감도
                    tmpRUData.rxRssiValue = Convert.ToByte(fr.ReadLine());
                }
                fr.Close();

                muruData[muID].ruData[ruID] = tmpRUData;
            }
            catch
            {
            }
        }

        #region MU or RU 상태 보기
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void MURUStatusView(byte muID, byte ruID)
        {
            if (muID == clsCommon.presentMUID && ruID == clsCommon.presentRUID)
                MURUStatusView();
        }

        private void MURUStatusView()
        {
            int i = 0;

            if (clsCommon.presentRUID == 0)
            {   //MU
                SetVisible(gbMU, true);
                SetVisible(gbRU, false);

                SetText(gbMU, stationList[clsCommon.presentMUID].ToString() + "역의 MU 상태");

                MUData tmpMUData = muruData[clsCommon.presentMUID].muData;

                #region MU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RC1 PTT 상태)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 3; i++)
                {   //0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태
                    if (tmpMUData.otherSt1[i] == 0)
                    {
                        SetChecked((RadioButton)chkMuOtherSt1[i], true);  //정상
                        SetChecked((RadioButton)chkMuOtherSt[i], false);
                    }
                    else
                    {
                        SetChecked((RadioButton)chkMuOtherSt1[i], false);    //이상
                        SetChecked((RadioButton)chkMuOtherSt[i], true);
                    }
                }

                for (i = 3; i < 8; i++)
                {   //3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RC1 PTT 상태
                    if (tmpMUData.otherSt1[i] == 0) SetChecked((CheckBox)chkMuOtherSt1[i], true);  //정상
                    else SetChecked((CheckBox)chkMuOtherSt1[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 기타 상태(8: RC2 PTT 상태, 9: RC3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 7; i++)
                {   //8: RC2 PTT 상태, 9: RC3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY
                    if (tmpMUData.otherSt2[i] == 0) SetChecked((CheckBox)chkMuOtherSt2[i], true);  //정상
                    else SetChecked((CheckBox)chkMuOtherSt2[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 DC전원값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                double tmpDcValue = tmpMUData.dcValue / 10.0;
                SetText(tbMUDCValue, tmpDcValue.ToString("0.0"));
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 주/예비 RF 출력값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 2; i++)
                {
                    int tmpValue = tmpMUData.rfValue[i];

                    SetText((TextBox)tbMURfMainSpare[i], tmpValue.ToString());
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 주/예비/감청용 RX RSSI 값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 3; i++)
                {
                    int tmpValue = tmpMUData.rxRssiValue[i];

                    if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                    SetText((TextBox)tbMURXRSSI[i], tmpValue.ToString());
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 주/예비 RF 출력조회값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 2; i++)
                {
                    int tmpValue = tmpMUData.rfValueInquiry[i];

                    if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                    SetText((TextBox)tbMURfMainSpareInquiry[i], tmpValue.ToString());
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 주/예비/감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 3; i++)
                {
                    string tmpCh = null;

                    switch (tmpMUData.chInfo[i])
                    {
                        case 0: tmpCh = "SCAN"; break;
                        case 1: tmpCh = "1"; break;
                        case 2: tmpCh = "2"; break;
                        case 3: tmpCh = "3"; break;
                    }

                    SetText((TextBox)tbMUCHInfo[i], tmpCh);
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region CCE/RC1/RC2/RC3의 AFGain값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                SetText((TextBox)tbCCEAfGain[0], muruData[clsCommon.presentMUID].afGain[0].gainTx.ToString());
                SetText((TextBox)tbCCEAfGain[1], muruData[clsCommon.presentMUID].afGain[0].gainRx.ToString());
                SetText((TextBox)tbCCEAfGain[2], muruData[clsCommon.presentMUID].afGain[0].gainMon.ToString());

                SetText((TextBox)tbRC1AfGain[0], muruData[clsCommon.presentMUID].afGain[1].gainTx.ToString());
                SetText((TextBox)tbRC1AfGain[1], muruData[clsCommon.presentMUID].afGain[1].gainRx.ToString());
                SetText((TextBox)tbRC1AfGain[2], muruData[clsCommon.presentMUID].afGain[1].gainMon.ToString());

                SetText((TextBox)tbRC2AfGain[0], muruData[clsCommon.presentMUID].afGain[2].gainTx.ToString());
                SetText((TextBox)tbRC2AfGain[1], muruData[clsCommon.presentMUID].afGain[2].gainRx.ToString());
                SetText((TextBox)tbRC2AfGain[2], muruData[clsCommon.presentMUID].afGain[2].gainMon.ToString());

                SetText((TextBox)tbRC3AfGain[0], muruData[clsCommon.presentMUID].afGain[3].gainTx.ToString());
                SetText((TextBox)tbRC3AfGain[1], muruData[clsCommon.presentMUID].afGain[3].gainRx.ToString());
                SetText((TextBox)tbRC3AfGain[2], muruData[clsCommon.presentMUID].afGain[3].gainMon.ToString());
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시, 3:MU Trx CPU, 4:MU Opt CPU, 5:MU UPS)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 6; i++)
                {
                    if (tmpMUData.optMonSt[i] == 0) SetChecked((CheckBox)chkOptMon[i], true);  //정상
                    else SetChecked((CheckBox)chkOptMon[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region OPT의 기타 상태(0:DC 전원 상태, 1:MODOPEN 상태, 2:CCE PTT 상태)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 3; i++)
                {
                    if (tmpMUData.optOtherSt[i] == 0) SetChecked((CheckBox)chkOptOther[i], true);  //정상
                    else SetChecked((CheckBox)chkOptOther[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region DC전원값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                double tmpOptDcValue = tmpMUData.optDcValue / 10.0;
                SetText(tbOptDCValue, tmpOptDcValue.ToString("0.0"));
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region OPT의 LD/PD 알람 상태(0~3:OPT1~4 LD 알람, 4~7:OPT1~4 PD 알람)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 8; i++)
                {
                    if (tmpMUData.optAlarmSt[i] == 0) SetChecked((CheckBox)chkOptAlarm[i], true);  //정상
                    else SetChecked((CheckBox)chkOptAlarm[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region MU의 채널 복귀 시간
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                SetText(tbChReturnTime, tmpMUData.chReturn.ToString());
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region PLL LOCK 장애 표시
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 3; i++)
                {
                    if (tmpMUData.pllLockErrorSt[i] == 0) SetChecked(chkPllLock[i], true);  //정상
                    else SetChecked(chkPllLock[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion                
            }
            else
            {   //RU
                SetVisible(gbMU, false);
                SetVisible(gbRU, true);

                SetText(gbRU, stationList[clsCommon.presentMUID].ToString() + "역의 RU" + clsCommon.presentRUID.ToString() + " 상태");

                RUData tmpRUData = muruData[clsCommon.presentMUID].ruData[clsCommon.presentRUID];

                #region RU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MODOPEN 상태, 6:PTT 상태, 7:Local/Remote 상태)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 3; i++)
                {   //0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태
                    if (tmpRUData.otherSt1[i] == 0)
                    {
                        SetChecked((RadioButton)chkRuOtherSt1[i], true);  //정상
                        SetChecked((RadioButton)chkRuOtherSt[i], false);
                    }
                    else
                    {
                        SetChecked((RadioButton)chkRuOtherSt1[i], false);    //이상
                        SetChecked((RadioButton)chkRuOtherSt[i], true);
                    }
                }

                for (i = 3; i < 8; i++)
                {   //3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:PTT 상태, 7:Local/Remote 상태
                    if (tmpRUData.otherSt1[i] == 0) SetChecked((CheckBox)chkRuOtherSt1[i], true);  //정상
                    else SetChecked((CheckBox)chkRuOtherSt1[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region RU의 기타 상태(0:RUCPU 상태, 1:데이터 광접속 상태, 2:음성 광접속 상태, 3:OPT LD 알람 상태, 4:OPT PD 알람 상태)
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                for (i = 0; i < 5; i++)
                {
                    if (tmpRUData.otherSt2[i] == 0) SetChecked((CheckBox)chkRuOtherSt2[i], true);  //정상
                    else SetChecked((CheckBox)chkRuOtherSt2[i], false);    //이상
                }
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region RU의 DC전원값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                double tmpDcValue = tmpRUData.dcValue / 10.0;
                SetText(tbRUDCValue, tmpDcValue.ToString("0.0"));
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region RU의 주/예비 RF 출력값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                int tmpValue = tmpRUData.rfValue;

                if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                SetText(tbRURfMain, tmpValue.ToString());
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region RU의 주/예비 RF 출력조회값
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                tmpValue = tmpRUData.rfValueInquiry;

                if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                SetText(tbRURfMainInquiry, tmpValue.ToString());
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion

                #region RU의 RSSI 감도
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                SetText(tbRURXRSSI, tmpRUData.rxRssiValue.ToString());
                //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                #endregion
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void MuNowDataRead()
        {
            int i = 0;

            #region MU Data 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            MUData tmpMUData = new MUData();

            #region MU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RX1 PTT 상태)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 3; i++)
            {
                if (((RadioButton)chkMuOtherSt1[i]).Checked) tmpMUData.otherSt1[i] = 0;
                else tmpMUData.otherSt1[i] = 1;
            }

            for (i = 3; i < 8; i++)
            {
                if (((CheckBox)chkMuOtherSt1[i]).Checked) tmpMUData.otherSt1[i] = 0;
                else tmpMUData.otherSt1[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 기타 상태(8: RC2 PTT 상태, 9: RC3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 7; i++)
            {
                if (((CheckBox)chkMuOtherSt2[i]).Checked) tmpMUData.otherSt2[i] = 0;
                else tmpMUData.otherSt2[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 DC전원값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int tmpDCValue = (int)(Convert.ToDouble(tbMUDCValue.Text) * 10);
            tmpMUData.dcValue = (byte)tmpDCValue;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 주/예비 RF 출력값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 2; i++)
            {
                int tmpValue = Convert.ToInt32(((TextBox)tbMURfMainSpare[i]).Text);

                if (tmpValue < 0) tmpValue = (tmpValue * -1) + 0x80;
                tmpMUData.rfValue[i] = (byte)tmpValue;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 주/예비/감청용 RX RSSI 값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 3; i++)
            {
                int tmpValue = Convert.ToInt32(((TextBox)tbMURXRSSI[i]).Text);

                if (tmpValue < 0) tmpValue = (tmpValue * -1) + 0x80;
                tmpMUData.rxRssiValue[i] = (byte)tmpValue;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 주/예비 RF 출력조회값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 2; i++)
            {
                int tmpValue = Convert.ToInt32(((TextBox)tbMURfMainSpareInquiry[i]).Text);

                if (tmpValue < 0) tmpValue = (tmpValue * -1) + 0x80;
                tmpMUData.rfValueInquiry[i] = (byte)tmpValue;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 주/예비/감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            byte muChInfo = 0;
            for (i = 0; i < 3; i++)
            {
                switch (((TextBox)tbMUCHInfo[i]).Text)
                {
                    case "SCAN": muChInfo = 0; break;
                    case "1": muChInfo = 1; break;
                    case "2": muChInfo = 2; break;
                    case "3": muChInfo = 3; break;
                }

                tmpMUData.chInfo[i] = muChInfo;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시, 3:MU Trx CPU, 4:MU Opt CPU, 5:MU UPS)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 6; i++)
            {
                if (((CheckBox)chkOptMon[i]).Checked) tmpMUData.optMonSt[i] = 0;
                else tmpMUData.optMonSt[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region OPT의 기타 상태(0:DC 전원 상태, 1:MODOPEN 상태, 2:CCE PTT 상태)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 3; i++)
            {
                if (((CheckBox)chkOptOther[i]).Checked) tmpMUData.optOtherSt[i] = 0;
                else tmpMUData.optOtherSt[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 DC전원값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int tmpOptDCValue = (int)(Convert.ToDouble(tbOptDCValue.Text) * 10);
            tmpMUData.optDcValue = (byte)tmpOptDCValue;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region OPT의 LD/PD 알람 상태(0~3:OPT1~4 LD 알람, 4~7:OPT1~4 PD 알람)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 8; i++)
            {
                if (((CheckBox)chkOptAlarm[i]).Checked) tmpMUData.optAlarmSt[i] = 0;
                else tmpMUData.optAlarmSt[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 채널 복귀 시간
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            tmpMUData.chReturn = Convert.ToByte(tbChReturnTime.Text);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region MU의 Pll Lock 장애
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 3; i++)
            {
                if (chkPllLock[i].Checked) tmpMUData.pllLockErrorSt[i] = 0;
                else tmpMUData.pllLockErrorSt[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            muruData[clsCommon.presentMUID].muData = tmpMUData;

            MUDataSave(clsCommon.presentMUID);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void AfGainNowDataRead()
        {
            #region CCE/RC1/RC2/RC3의 AFGain값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            muruData[clsCommon.presentMUID].afGain[0].gainTx = Convert.ToInt32(((TextBox)tbCCEAfGain[0]).Text);
            muruData[clsCommon.presentMUID].afGain[0].gainRx = Convert.ToInt32(((TextBox)tbCCEAfGain[1]).Text);
            muruData[clsCommon.presentMUID].afGain[0].gainMon = Convert.ToInt32(((TextBox)tbCCEAfGain[2]).Text);

            muruData[clsCommon.presentMUID].afGain[1].gainTx = Convert.ToInt32(((TextBox)tbRC1AfGain[0]).Text);
            muruData[clsCommon.presentMUID].afGain[1].gainRx = Convert.ToInt32(((TextBox)tbRC1AfGain[1]).Text);
            muruData[clsCommon.presentMUID].afGain[1].gainMon = Convert.ToInt32(((TextBox)tbRC1AfGain[2]).Text);

            muruData[clsCommon.presentMUID].afGain[2].gainTx = Convert.ToInt32(((TextBox)tbRC2AfGain[0]).Text);
            muruData[clsCommon.presentMUID].afGain[2].gainRx = Convert.ToInt32(((TextBox)tbRC2AfGain[1]).Text);
            muruData[clsCommon.presentMUID].afGain[2].gainMon = Convert.ToInt32(((TextBox)tbRC2AfGain[2]).Text);

            muruData[clsCommon.presentMUID].afGain[3].gainTx = Convert.ToInt32(((TextBox)tbRC3AfGain[0]).Text);
            muruData[clsCommon.presentMUID].afGain[3].gainRx = Convert.ToInt32(((TextBox)tbRC3AfGain[1]).Text);
            muruData[clsCommon.presentMUID].afGain[3].gainMon = Convert.ToInt32(((TextBox)tbRC3AfGain[2]).Text);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void btMUSave_Click(object sender, EventArgs e)
        {
            MuNowDataRead();

            #region AFGain값 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            AfGainNowDataRead();

            AFGainDataSave(clsCommon.presentMUID);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void UPSNowDataRead()
        {
            #region UPS Data 저장
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            UPSData tmpUPSData = new UPSData();

            tmpUPSData.inVoltage = tbUpsInputVoltage.Text;          //입력전압 5
            tmpUPSData.faultVoltage = tbFaultVoltage.Text;             //과실전압 5
            tmpUPSData.outVoltage = tbUpsOutVoltage.Text;           //출력전압 5
            tmpUPSData.currentPercent = tbUpsCurrentPercent.Text;   //출력전류 3
            tmpUPSData.frequency = tbUpsFrequency.Text;             //주파수 4
            tmpUPSData.batteryVoltage = tbUpsBatteryVoltage.Text;   //배터리 전압 4
            tmpUPSData.temperature = tbUpsTemperature.Text;         //온도 4

            if (chkUpsAC.Checked) tmpUPSData.otherSt[4] = 0;
            else tmpUPSData.otherSt[4] = 1;
            if (chkUpsBypass.Checked) tmpUPSData.otherSt[5] = 0;
            else tmpUPSData.otherSt[5] = 1;
            if (chkUpsBattery.Checked) tmpUPSData.otherSt[6] = 0;
            else tmpUPSData.otherSt[6] = 1;
            if (chkUpsFail.Checked) tmpUPSData.otherSt[7] = 0;
            else tmpUPSData.otherSt[7] = 1;

            muruData[clsCommon.presentMUID].upsData = tmpUPSData;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
        }

        private void RuNowDataRead()
        {
            int i = 0;

            RUData tmpRUData = new RUData();

            #region RU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MODOPEN 상태, 6:PTT 상태, 7:Local/Remote 상태)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 3; i++)
            {
                if (((RadioButton)chkRuOtherSt1[i]).Checked) tmpRUData.otherSt1[i] = 0;
                else tmpRUData.otherSt1[i] = 1;
            }

            for (i = 3; i < 8; i++)
            {
                if (((CheckBox)chkRuOtherSt1[i]).Checked) tmpRUData.otherSt1[i] = 0;
                else tmpRUData.otherSt1[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU의 기타 상태(0:RUCPU 상태, 1:데이터 광접속 상태, 2:음성 광접속 상태, 3:OPT LD 알람 상태, 4:OPT PD 알람 상태)
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            for (i = 0; i < 5; i++)
            {
                if (((CheckBox)chkRuOtherSt2[i]).Checked) tmpRUData.otherSt2[i] = 0;
                else tmpRUData.otherSt2[i] = 1;
            }
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU의 DC전원값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int tmpDCValue = (int)(Convert.ToDouble(tbRUDCValue.Text) * 10);
            tmpRUData.dcValue = (byte)tmpDCValue;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU의 주/예비 RF 출력값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            int tmpValue = Convert.ToInt32(tbRURfMain.Text);

            if (tmpValue < 0) tmpValue = (tmpValue * -1) + 0x80;
            tmpRUData.rfValue = (byte)tmpValue;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU의 주/예비 RF 출력조회값
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            tmpValue = Convert.ToInt32(tbRURfMainInquiry.Text);

            if (tmpValue < 0) tmpValue = (tmpValue * -1) + 0x80;
            tmpRUData.rfValueInquiry = (byte)tmpValue;
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            #region RU의 RSSI 감도
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            tmpRUData.rxRssiValue = Convert.ToByte(tbRURXRSSI.Text);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            muruData[clsCommon.presentMUID].ruData[clsCommon.presentRUID] = tmpRUData;
        }

        private void BdaNowDataReadSend(int muID, int ruID, int index)
        {
            int i = 0;

            BDA_St tmpBdaSt = new BDA_St();

            for (i = 0; i < 8; i++)
            {
                if (chkBdaOther[index][i].Checked) tmpBdaSt.bdaAMPSt[i] = 0;
                else tmpBdaSt.bdaAMPSt[i] = 1;
            }

            for (i = 0; i < 6; i++)
            {
                if (chkBdaUps[index][i].Checked) tmpBdaSt.bdaUpsSt[i + 2] = 0;
                else tmpBdaSt.bdaUpsSt[i + 2] = 1;
            }

            for (i = 0; i < 5; i++)
            {
                try
                {
                    tmpBdaSt.ampDBM[i] = Convert.ToByte(tbBdaAmp[index][i].Text);
                }
                catch
                {
                    tmpBdaSt.ampDBM[i] = 0;
                }
            }

            nmsGUI.EditData_BDAStDataReport((byte)muID, (byte)ruID, (byte)(index + 1), tmpBdaSt);
        }

        private void btRUSave_Click(object sender, EventArgs e)
        {
            RuNowDataRead();
            RUDataSave(clsCommon.presentMUID, clsCommon.presentRUID);
        }

        private void MUDataSave(byte muID)
        {
            int i = 0;

            try
            {
                string fileName = clsCommon.DefaultPath + stationList[muID].ToString() + "MU.txt";

                MUData tmpMUData = muruData[muID].muData;

                StreamWriter fw = File.CreateText(fileName);
                {
                    //MU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RX1 PTT 상태)
                    for (i = 0; i < 8; i++) fw.WriteLine(tmpMUData.otherSt1[i]);

                    //MU의 기타 상태(8: RC2 PTT 상태, 9: RC3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY)
                    for (i = 0; i < 7; i++) fw.WriteLine(tmpMUData.otherSt2[i]);

                    fw.WriteLine(tmpMUData.dcValue);    //MU의 DC전원값

                    //MU의 주/예비 RF 출력값
                    for (i = 0; i < 2; i++) fw.WriteLine(tmpMUData.rfValue[i]);

                    //MU의 주/예비/감청용 RX RSSI 값
                    for (i = 0; i < 3; i++) fw.WriteLine(tmpMUData.rxRssiValue[i]);

                    //MU의 주/예비 RF 출력조회값
                    for (i = 0; i < 2; i++) fw.WriteLine(tmpMUData.rfValueInquiry[i]);

                    //MU의 주/예비/감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
                    for (i = 0; i < 3; i++) fw.WriteLine(tmpMUData.chInfo[i]);

                    //OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시)
                    for (i = 0; i < 6; i++) fw.WriteLine(tmpMUData.optMonSt[i]);

                    //OPT의 기타 상태(0:DC 전원 상태, 1:MODOPEN 상태, 2:CCE PTT 상태)
                    for (i = 0; i < 3; i++) fw.WriteLine(tmpMUData.optOtherSt[i]);

                    fw.WriteLine(tmpMUData.optDcValue);    //DC전원값

                    //OPT의 LD/PD 알람 상태(0~3:OPT1~4 LD 알람, 4~7:OPT1~4 PD 알람)
                    for (i = 0; i < 8; i++) fw.WriteLine(tmpMUData.optAlarmSt[i]);

                    fw.WriteLine(tmpMUData.chReturn);    //채널 복귀 시간

                    //Pll Lock 장애 상태(0~3:OPT1~4 LD 알람, 4~7:OPT1~4 PD 알람)
                    for (i = 0; i < 3; i++) fw.WriteLine(tmpMUData.pllLockErrorSt[i]);
                }
                fw.Close();
            }
            catch
            {
            }
        }

        private void AFGainDataSave(byte muID)
        {
            try
            {
                string fileName = clsCommon.DefaultPath + stationList[muID].ToString() + "AFGain.txt";

                StreamWriter fw = File.CreateText(fileName);

                for (int i = 0; i < 4; i++)
                {
                    AFGain tmpAFGain = muruData[muID].afGain[i];

                    fw.WriteLine(tmpAFGain.gainTx);
                    fw.WriteLine(tmpAFGain.gainRx);
                    fw.WriteLine(tmpAFGain.gainMon);
                }
                fw.Close();
            }
            catch
            {
            }
        }

        private void RUDataSave(byte muID, byte ruID)
        {
            int i = 0;

            try
            {
                string fileName = clsCommon.DefaultPath + stationList[muID].ToString() + "RU" + ruID.ToString() + ".txt";

                RUData tmpRUData = muruData[muID].ruData[ruID];

                StreamWriter fw = File.CreateText(fileName);
                {
                    //RU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태, 5:MODOPEN 상태, 6:PTT 상태, 7:Local/Remote 상태)                    for (i = 0; i < 6; i++) fw.WriteLine(tmpRUData.otherSt[i]);
                    for (i = 0; i < 8; i++) fw.WriteLine(tmpRUData.otherSt1[i]);

                    //RU의 기타 상태(0:RUCPU 상태, 1:데이터 광접속 상태, 2:음성 광접속 상태, 3:OPT LD 알람 상태, 4:OPT PD 알람 상태);
                    for (i = 0; i < 5; i++) fw.WriteLine(tmpRUData.otherSt2[i]);

                    fw.WriteLine(tmpRUData.dcValue);    //RU의 DC전원값

                    //RU의 주/예비 RF 출력값
                    fw.WriteLine(tmpRUData.rfValue);

                    //RU의 주/예비 RF 출력조회값
                    fw.WriteLine(tmpRUData.rfValueInquiry);

                    //RU의 RSSI 감도
                    fw.WriteLine(tmpRUData.rxRssiValue);
                }
                fw.Close();
            }
            catch
            {
            }
        }

        #region 각 폼의 중복실행을 막기위한 메소드
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void frmClose(byte index)
        {
            switch (index)
            {
                case 0:     //frmDebug
                    for (int i = 0; i < clsCommon.CNTMACHINE; i++)
                        clsCommon.flagDebug[i] = false;

                    frmDG = null;
                    break;
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }
}
