using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NMS
{
    /// <summary>
    /// 사용자 정의 컨트롤에서의 제어 이벤트
    /// </summary>
    /// <param name="btCode">Click한 버튼 Code</param>
    /// <param name="index">주/예비, Wide/Narrow등등..</param>
    /// <param name="value">설정에 필요한 값</param>
    public delegate void UserControl_Control(byte btCode, byte index, byte value);

    public partial class ucMUSt : UserControl
    {
        /// <summary>
        /// 사용자 정의 컨트롤에서의 제어 이벤트
        /// </summary>
        /// <param name="btCode">Click한 버튼 Code</param>
        public event UserControl_Control muControlClick = null;

        #region MU감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<Button> btMURfMainSpare = new List<Button>();
        private List<Label> lblMURfMainSpare = new List<Label>();
        private List<Label> lblMURfMainSpareInquiry = new List<Label>();
        private List<TextBox> tbMURfMainSpare = new List<TextBox>();

        private List<Label> lblMUCHInfo = new List<Label>();
        private List<Label> lblMURXRSSI = new List<Label>();

        private List<PictureBox> pbMuOtherSt1 = new List<PictureBox>();
        private List<PictureBox> pbMuOtherSt = new List<PictureBox>();
        private List<PictureBox> pbMuOtherSt2 = new List<PictureBox>();

        private List<Label> lblRcName = new List<Label>();

        //OPT 상태 관련
        private List<PictureBox> pbOptMonSt = new List<PictureBox>();
        private List<PictureBox> pbOptOtherSt = new List<PictureBox>();
        private List<PictureBox> pbOptAlarmSt = new List<PictureBox>();

        private List<Label> lblOptLd = new List<Label>();
        private List<Label> lblOptPd = new List<Label>();

        private List<PictureBox> pbPllLockSt = new List<PictureBox>();

        //AF Gain 관련
        private List<GroupBox> gbAfGainRc = new List<GroupBox>();

        private List<Label> lblCCEAfGain = new List<Label>();
        private List<Label> lblRC1AfGain = new List<Label>();
        private List<Label> lblRC2AfGain = new List<Label>();
        private List<Label> lblRC3AfGain = new List<Label>();

        private List<TextBox> tbCCEAfGain = new List<TextBox>();
        private List<TextBox> tbRC1AfGain = new List<TextBox>();
        private List<TextBox> tbRC2AfGain = new List<TextBox>();
        private List<TextBox> tbRC3AfGain = new List<TextBox>();

        private List<Button> btAfGainSet = new List<Button>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
        
        #region 기타 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Timer tmrSendOutTest = new Timer();

        public bool flagSendOutTest = false;

        private Color colorSelect = new Color();    //선택 색
        private Color colorError = new Color();    //선택 색
        private Color colorBase = new Color();      //기본 색
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public ucMUSt()
        {

            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    InitializeComponent_전라선();
                    break;

                case "중앙선":
                    InitializeComponent();
                    break;

                case "경춘선":
                default:
                    InitializeComponent_경춘선();
                    break;
            }

            #region MU감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private ArrayList btMURfMainSpare = new ArrayList();
            btMURfMainSpare.Add(btMURfMainSpare1); btMURfMainSpare.Add(btMURfMainSpare2);
            //private ArrayList lblMURfMainSpare = new ArrayList();
            lblMURfMainSpare.Add(lblMURfMain); lblMURfMainSpare.Add(lblMURfSpare);
            //private List<Label> lblMURfMainSpareInquiry = new List<Label>();
            lblMURfMainSpareInquiry.Add(lblMURfMainInquiry); lblMURfMainSpareInquiry.Add(lblMURfSpareInquiry);
            //private ArrayList tbMURfMainSpare = new ArrayList();
            tbMURfMainSpare.Add(tbMURfMain); tbMURfMainSpare.Add(tbMURfSpare);

            //private ArrayList lblMUCHInfo = new ArrayList();
            lblMUCHInfo.Add(lblMUCHInfo1); lblMUCHInfo.Add(lblMUCHInfo2); lblMUCHInfo.Add(lblMUCHInfo3);
            //private ArrayList lblMURXRSSI = new ArrayList();
            lblMURXRSSI.Add(lblMURXRSSI1); lblMURXRSSI.Add(lblMURXRSSI2); lblMURXRSSI.Add(lblMURXRSSI3);

            //private List<PictureBox> pbMuOtherSt1 = new List<PictureBox>();
            pbMuOtherSt1.Add(pbMUAutoManual1); pbMuOtherSt1.Add(pbMUMainSpare1); pbMuOtherSt1.Add(pbMUWideNarrow1);
            pbMuOtherSt1.Add(pbMUAC); pbMuOtherSt1.Add(pbMUDC);
            pbMuOtherSt1.Add(pbMUModOpen);
            pbMuOtherSt1.Add(pbMURCSt1); pbMuOtherSt1.Add(pbMURCSt2);

            //private List<PictureBox> pbMuOtherSt = new List<PictureBox>();
            pbMuOtherSt.Add(pbMUAutoManual2); pbMuOtherSt.Add(pbMUMainSpare2); pbMuOtherSt.Add(pbMUWideNarrow2);

            //private List<PictureBox> pbMuOtherSt2 = new List<PictureBox>();
            pbMuOtherSt2.Add(pbMURCSt3); pbMuOtherSt2.Add(pbMURCSt4);
            pbMuOtherSt2.Add(pbMUSRSt1); pbMuOtherSt2.Add(pbMUSRSt2); pbMuOtherSt2.Add(pbMUSRSt3); pbMuOtherSt2.Add(pbMUSRSt4); pbMuOtherSt2.Add(pbMUSRSt5);

            //private List<Label> lblRcName = new List<Label>();
            lblRcName.Add(lblRcName1); lblRcName.Add(lblRcName2); lblRcName.Add(lblRcName3); lblRcName.Add(lblRcName4);

            //OPT 상태 관련
            //private List<PictureBox> pbOptMonSt = new List<PictureBox>();
            pbOptMonSt.Add(pbMUMon1); pbOptMonSt.Add(pbMUMon2); pbOptMonSt.Add(pbMUMon3); pbOptMonSt.Add(pbMUMon3); pbOptMonSt.Add(pbMUMon3);
            pbOptMonSt.Add(pbMUMon4); pbOptMonSt.Add(pbMUMon5); pbOptMonSt.Add(pbMUMon6);
            //private List<PictureBox> pbOptOtherSt = new List<PictureBox>();
            pbOptOtherSt.Add(pbMUOther1); pbOptOtherSt.Add(pbMUOther2); pbOptOtherSt.Add(pbMUOther3);
            //private List<PictureBox> pbOptAlarmSt = new List<PictureBox>();
            pbOptAlarmSt.Add(pbMUOptAlarm1); pbOptAlarmSt.Add(pbMUOptAlarm2); pbOptAlarmSt.Add(pbMUOptAlarm3); pbOptAlarmSt.Add(pbMUOptAlarm4);
            pbOptAlarmSt.Add(pbMUOptAlarm5); pbOptAlarmSt.Add(pbMUOptAlarm6); pbOptAlarmSt.Add(pbMUOptAlarm7); pbOptAlarmSt.Add(pbMUOptAlarm8);

            //private List<Label> lblOptLd = new List<Label>();
            lblOptLd.Add(lblOptLd1); lblOptLd.Add(lblOptLd2); lblOptLd.Add(lblOptLd3); lblOptLd.Add(lblOptLd4);
            //private List<Label> lblOptPd = new List<Label>();
            lblOptPd.Add(lblOptPd1); lblOptPd.Add(lblOptPd2); lblOptPd.Add(lblOptPd3); lblOptPd.Add(lblOptPd4);

            //private List<PictureBox> pbPllLockSt = new List<PictureBox>();
            pbPllLockSt.Add(pbMUPllLock1); pbPllLockSt.Add(pbMUPllLock2); pbPllLockSt.Add(pbMUPllLock3);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            colorSelect = Color.Lime;
            colorError = Color.Red;
            colorBase = Color.Transparent;

            //MU화면의 주/예비 절체 버튼
            btMUMainSpare1.Tag = 0;
            btMUMainSpare2.Tag = 1;

            //MU화면의 자동/수동 절체 버튼
            btMUAutoManual1.Tag = 0;
            btMUAutoManual2.Tag = 1;

            //MU화면의 주/예비 RF 출력 버튼
            btMURfMainSpare1.Tag = 0;
            btMURfMainSpare2.Tag = 1;

            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                    SetVisible(pbMUMon6, true);
                    SetVisible(lblMUMon6, true);

                    try
                    {
                        SetImage(pb무전기형식, new Bitmap(clsCommon.ImagePath + "Ground_300_180.png"));
                        SetImage(pbPowerSupply, new Bitmap(clsCommon.ImagePath + "Ground_300_180.png"));
                        SetImage(pb기타상태, new Bitmap(clsCommon.ImagePath + "Ground_300_180.png"));

                        SetImage(pb유무선감시장치, new Bitmap(clsCommon.ImagePath + "Ground_332_364.png"));
                        SetImage(pb광전송부감시상태, new Bitmap(clsCommon.ImagePath + "Ground_332_364.png"));
                    }
                    catch
                    {
                    }
                    break;

                case "중앙선":
                    SetEnable(panelMuAntennaMatchungUnit, false);
                    SetEnable(panelMu무선송수신기예비, false);
                    break;

                case "경춘선":
                default:
                    try
                    {
                        SetImage(pbAntenna, new Bitmap(clsCommon.ImagePath + "Ground_274_180.png"));
                        SetImage(pb무전기형식, new Bitmap(clsCommon.ImagePath + "Ground_274_180.png"));
                        SetImage(pbPowerSupply, new Bitmap(clsCommon.ImagePath + "Ground_274_180.png"));
                        SetImage(pb기타상태, new Bitmap(clsCommon.ImagePath + "Ground_274_180.png"));

                        SetImage(pb무선송수신기, new Bitmap(clsCommon.ImagePath + "Ground_434_422.png"));
                        SetImage(pb무선송수신기예비, new Bitmap(clsCommon.ImagePath + "Ground_434_422.png"));
                        SetImage(pb무선수신기, new Bitmap(clsCommon.ImagePath + "Ground_332_422.png"));

                        SetImage(pb유무선감시장치, new Bitmap(clsCommon.ImagePath + "Ground_274_364.png"));
                        SetImage(pb광전송부감시상태, new Bitmap(clsCommon.ImagePath + "Ground_332_278.png"));
                        SetImage(pb채널복귀시간, new Bitmap(clsCommon.ImagePath + "Ground_332_141.png"));
                    }
                    catch
                    {
                    }
                    break;
            }

            tmrSendOutTest.Interval = 10000;
            tmrSendOutTest.Tick += new EventHandler(tmrSendOutTest_Tick);
        }

        private bool flagWideNarrowChange = false;
        private void ucMUSt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    flagWideNarrowChange = !flagWideNarrowChange;
                    SetVisible(btMUWideNarrowChange, flagWideNarrowChange);
                }
            }
        }

        #region 컨트롤 제어(문자출력, 활성화 변경, 색변경)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //컨트롤의 위치/크기 지정
        private void SetLocationSize(Control control, int width, int height, int left, int top)
        {
            if (control.InvokeRequired)
            {
                SetControlLocationSizeCallback d = new SetControlLocationSizeCallback(SetLocationSize);
                this.Invoke(d, new object[] { control, width, height, left, top });
            }
            else
            {
                control.Width = width;
                control.Height = height;
                control.Left = left;
                control.Top = top;
            }
        }

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
        private void SetRdButChecked(RadioButton control, bool flag)
        {
            if (control.InvokeRequired)
            {
                SetRdButCheckedCallback d = new SetRdButCheckedCallback(SetRdButChecked);
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

        //ListView 컨트롤의 Item을 삭제하기 위함
        private void SetListViewItemClear(ListView lvControl)
        {
            if (lvControl.InvokeRequired)
            {
                SetListViewItemClearCallback d = new SetListViewItemClearCallback(SetListViewItemClear);
                this.Invoke(d, new object[] { lvControl });
            }
            else
            {
                lvControl.Items.Clear();
            }
        }

        //ListView 컨트롤의 Item을 추가하기 위함
        private void SetListViewItemInster(ListView lvControl, int index, ListViewItem lvItem)
        {
            if (lvControl.InvokeRequired)
            {
                SetListViewItemInsertCallback d = new SetListViewItemInsertCallback(SetListViewItemInster);
                this.Invoke(d, new object[] { lvControl, index, lvItem });
            }
            else
            {
                lvControl.Items.Insert(index, lvItem);
            }
        }

        //DataGridView의 모든 Row를 삭제하기 위함
        private void SetdataGridViewClear(DataGridView dgvControl)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewClearCallback d = new SetdataGridViewClearCallback(SetdataGridViewClear);
                this.Invoke(d, new object[] { dgvControl });
            }
            else
            {
                dgvControl.Rows.Clear();
            }
        }

        private void SetdataGridViewMuErrorStValue(DataGridView dgvControl, int index, string dateTime, string content)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewMuErrorStValueCallback d = new SetdataGridViewMuErrorStValueCallback(SetdataGridViewMuErrorStValue);
                this.Invoke(d, new object[] { dgvControl, index, dateTime, content });
            }
            else
            {
                dgvControl.Rows.Add();
                //dgvControl.Rows[index].Cells[0].Value = (index + 1).ToString();    //순번
                dgvControl.Rows[index].Cells[1].Value = dateTime;       //날자/시간
                dgvControl.Rows[index].Cells[2].Value = content;    //내용
            }
        }

        private void SetdataGridViewMuErrorStIndex(DataGridView dgvControl, int index, string dateTime, string content)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewMuErrorStValueCallback d = new SetdataGridViewMuErrorStValueCallback(SetdataGridViewMuErrorStIndex);
                this.Invoke(d, new object[] { dgvControl, index, dateTime, content });
            }
            else
            {
                dgvControl.Rows[index].Cells[0].Value = (index + 1).ToString();    //순번
            }
        }

        private void SetdataGridViewMuTxRxErxStValue(DataGridView dgvControl, int index, string content, string ch, string startDateTime, string stopDateTime)
        {
            if (dgvControl.InvokeRequired)
            {
                SetdataGridViewMuTxRxErxStValueCallback d = new SetdataGridViewMuTxRxErxStValueCallback(SetdataGridViewMuTxRxErxStValue);
                this.Invoke(d, new object[] { dgvControl, index, content, ch, startDateTime, stopDateTime });
            }
            else
            {
                dgvControl.Rows.Add();
                dgvControl.Rows[index].Cells[0].Value = (index + 1).ToString();    //순번
                dgvControl.Rows[index].Cells[1].Value = content;    //내용
                dgvControl.Rows[index].Cells[2].Value = ch;         //채널
                dgvControl.Rows[index].Cells[3].Value = startDateTime;  //시작시간
                dgvControl.Rows[index].Cells[4].Value = stopDateTime;   //중지시간
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        /*
        //사용안하는 컨트롤 초기화
        private void Control_중앙선_Disable()
        {
            SetImage(pbMUSRSt3, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUSRSt4, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUPllLock2, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUMon2, NMS.Properties.Resources.st_OFF);

            SetColor(btMUMainSpare1, colorBase);
            SetColor(btMUMainSpare2, colorBase);

            SetColor(btMUAutoManual1, colorBase);
            SetColor(btMUAutoManual2, colorBase);
        }
        */

        /// <summary>
        /// 유/무선부 감시장치중 RC의 이름을 설정한다.
        /// </summary>
        /// <param name="rcName">RC 이름</param>
        public void RCNameSet(string[] rcName)
        {
            for (int i = 1; i < 4; i++)
                SetText(lblRcName[i], rcName[i]);
        }

        /// <summary>
        /// MU 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="flagAction">활성화/비활성화</param>
        public void MuStInit(bool flagAction)
        {
            int i = 0;

            //SetEnable(panelMuAntennaMatchungUnit, flagAction);
            SetColor(btMUMainSpare1, colorBase);
            SetColor(btMUMainSpare2, colorBase);
            SetColor(btMUAutoManual1, colorBase);
            SetColor(btMUAutoManual2, colorBase);
            SetEnable(btMUMainSpare1, flagAction);
            SetEnable(btMUMainSpare2, flagAction);
            SetEnable(btMUAutoManual1, flagAction);
            SetEnable(btMUAutoManual2, flagAction);

            //SetEnable(panelMu무선송수신기, flagAction);
            SetEnable(gbMu주_송수신기채널정보, flagAction);
            SetEnable(gbMu주_송수신동작상태, flagAction);
            SetEnable(gbMu주_송수신장애상태, flagAction);
            SetEnable(gbMu주_송신출력설정, flagAction);
            SetEnable(btMUSendOutTest, flagAction);
            SetImage(pbMUSRSt1, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUSRSt2, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUPllLock1, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUMon1, NMS.Properties.Resources.st_OFF);
            SetEnable(pbMUSRSt1, flagAction);
            SetEnable(pbMUSRSt2, flagAction);
            SetEnable(pbMUPllLock1, flagAction);
            SetEnable(pbMUMon1, flagAction);
            
            //SetEnable(panelMu무선송수신기예비, flagAction);
            SetEnable(gbMu예비_송수신기채널정보, flagAction);
            SetEnable(gbMu예비_송수신동작상태, flagAction);
            SetEnable(gbMu예비_송수신장애상태, flagAction);
            SetEnable(gbMu예비_송신출력설정, flagAction);
            SetImage(pbMUSRSt3, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUSRSt4, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUPllLock2, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUMon2, NMS.Properties.Resources.st_OFF);

            //SetEnable(panelMu무선수신기, flagAction);
            SetEnable(gbMu감청수신기_채널정보, flagAction);
            SetEnable(gbMu감청수신기_동작상태, flagAction);
            SetEnable(gbMu감청수신기_장애상태, flagAction);
            SetImage(pbMUSRSt5, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUPllLock3, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUMon3, NMS.Properties.Resources.st_OFF);
            SetEnable(pbMUSRSt5, flagAction);
            SetEnable(pbMUPllLock3, flagAction);
            SetEnable(pbMUMon3, flagAction);

            //SetEnable(panelMu광전송부감시상태, flagAction);
            SetEnable(lbl광전송부감시상태1 , flagAction);
            SetEnable(lbl광전송부감시상태2, flagAction);
            SetEnable(lbl광전송부감시상태3, flagAction);
            SetEnable(lblMUOPTDCValue, flagAction);            
            for (i = 0; i < 4; i++)
            {
                SetEnable(lblOptLd[i], flagAction);
                SetEnable(lblOptPd[i], flagAction);
            }
            for (i = 0; i < 3; i++)
            {
                SetImage(pbOptOtherSt[i], NMS.Properties.Resources.st_OFF);
                SetEnable(pbOptOtherSt[i], flagAction);
            }
            for (i = 0; i < 8; i++)
            {
                SetImage(pbOptAlarmSt[i], NMS.Properties.Resources.st_OFF);
                SetEnable(pbOptAlarmSt[i], flagAction);
            }

            //SetEnable(panelMu채널복귀, flagAction);
            SetEnable(lbl채널복귀시간1, flagAction);
            SetEnable(lbl채널복귀시간2, flagAction);
            SetEnable(lblMUChReturnTime, flagAction);
            SetEnable(tbMUChReturnTime, flagAction);
            SetEnable(btMUChReturnTime, flagAction);
            /*
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //SetEnable(panelMu채널복귀, false);
                SetEnable(lbl채널복귀시간1, false);
                SetEnable(lbl채널복귀시간2, false);
                SetEnable(lblMUChReturnTime, false);
                SetEnable(tbMUChReturnTime, false);
                SetEnable(btMUChReturnTime, false);
            }
            else
            {
                //SetEnable(panelMu채널복귀, flagAction);
                SetEnable(lbl채널복귀시간1, flagAction);
                SetEnable(lbl채널복귀시간2, flagAction);
                SetEnable(lblMUChReturnTime, flagAction);
                SetEnable(tbMUChReturnTime, flagAction);
                SetEnable(btMUChReturnTime, flagAction);
            }
            */

            //SetEnable(panelMu무전기형식, flagAction);
            SetEnable(lblMUWideNarrowChange1, flagAction);
            SetEnable(lblMUWideNarrowChange2, flagAction);
            SetEnable(pbMUWideNarrow2, flagAction);
            SetImage(pbMUWideNarrow1, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUWideNarrow2, NMS.Properties.Resources.st_OFF);
            SetEnable(pbMUWideNarrow1, flagAction);
            SetEnable(pbMUWideNarrow2, flagAction);
            SetEnable(btMUWideNarrowChange, flagAction);

            //SetEnable(panelMuPowerSupply, flagAction);
            SetEnable(lblPowerSupply, flagAction);
            SetImage(pbMUAC, NMS.Properties.Resources.st_OFF);
            SetEnable(pbMUAC, flagAction);

            //SetEnable(panelMu유무선부감시장치, flagAction);
            SetEnable(lbl유무선감시장치1, flagAction);
            SetEnable(lbl유무선감시장치2, flagAction);
            SetEnable(lblRcName1, flagAction);
            SetEnable(lblRcName2, flagAction);
            SetEnable(lblRcName3, flagAction);
            SetEnable(lblRcName4, flagAction);
            SetEnable(lblRcName5, flagAction);
            SetEnable(lblMUDCValue, flagAction);
            SetImage(pbMUDC, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUModOpen, NMS.Properties.Resources.st_OFF);
            SetImage(pbMURCSt1, NMS.Properties.Resources.st_OFF);
            SetImage(pbMURCSt2, NMS.Properties.Resources.st_OFF);
            SetImage(pbMURCSt3, NMS.Properties.Resources.st_OFF);
            SetImage(pbMURCSt4, NMS.Properties.Resources.st_OFF);
            SetImage(pbMURCSt5, NMS.Properties.Resources.st_OFF);
            SetEnable(pbMUDC, flagAction);
            SetEnable(pbMUModOpen, flagAction);
            SetEnable(pbMURCSt1, flagAction);
            SetEnable(pbMURCSt2, flagAction);
            SetEnable(pbMURCSt3, flagAction);
            SetEnable(pbMURCSt4, flagAction);
            SetEnable(pbMURCSt5, flagAction);
            
            //SetEnable(panelMu기타상태, flagAction);
            SetEnable(lblMUMon4, flagAction);
            SetEnable(lblMUMon5, flagAction);
            SetEnable(lblMUMon6, flagAction);
            for (i = 3; i < 6; i++)
            {
                SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_OFF);
                SetEnable(pbOptMonSt[i], flagAction);
            }
        }

        /// <summary>
        /// MU 상태를 표시한다.
        /// </summary>
        /// <param name="muID">muID</param>
        /// <param name="muData">MU의 상태 Data</param>
        /// <param name="baseSt">주장치의 Base I/F의 상태</param>
        /// <param name="ruName">RU 이름</param>
        public void nmsMUSt_Display(byte muID, MUData muData, BaseSt[,] baseSt, RuBdaName[] ruName)
        {
            int i = 0;

            if (!gbMu주_송수신기채널정보.Enabled) MuStInit(true);

            if (clsCommon.flagSpare[muID - 1])  //주예비 다 있는경우
            {
                //SetEnable(panelMuAntennaMatchungUnit, true);
                SetEnable(btMUMainSpare1, true);
                SetEnable(btMUMainSpare2, true);
                SetEnable(btMUAutoManual1, true);
                SetEnable(btMUAutoManual2, true);

                //SetEnable(panelMu무선송수신기예비, true);
                SetEnable(gbMu예비_송수신기채널정보, true);
                SetEnable(gbMu예비_송수신동작상태, true);
                SetEnable(gbMu예비_송수신장애상태, true);
                SetEnable(gbMu예비_송신출력설정, true);
            }
            else    //주만 있는 경우
            {
                //SetEnable(panelMuAntennaMatchungUnit, false);
                SetColor(btMUMainSpare1, colorBase);
                SetColor(btMUMainSpare2, colorBase);
                SetColor(btMUAutoManual1, colorBase);
                SetColor(btMUAutoManual2, colorBase);
                SetEnable(btMUMainSpare1, false);
                SetEnable(btMUMainSpare2, false);
                SetEnable(btMUAutoManual1, false);
                SetEnable(btMUAutoManual2, false);

                //SetEnable(panelMu무선송수신기예비, false);
                SetEnable(gbMu예비_송수신기채널정보, false);
                SetEnable(gbMu예비_송수신동작상태, false);
                SetEnable(gbMu예비_송수신장애상태, false);
                SetEnable(gbMu예비_송신출력설정, false);
                SetImage(pbMUSRSt3, NMS.Properties.Resources.st_OFF);
                SetImage(pbMUSRSt4, NMS.Properties.Resources.st_OFF);
                SetImage(pbMUPllLock2, NMS.Properties.Resources.st_OFF);
                SetImage(pbMUMon2, NMS.Properties.Resources.st_OFF);
            }

            // MU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태,
            //               3:AC 전원상태, 4:DC 전원상태, 5:MONOPEN 상태, 6:CCE PTT 상태, 7: RX1 PTT 상태)
            for (i = 0; i < 3; i++)
            {
                if (muData.otherSt1[i] == 0)
                {
                    SetImage(pbMuOtherSt1[i], NMS.Properties.Resources.st_ON);
                    SetImage(pbMuOtherSt[i], NMS.Properties.Resources.st_OFF);
                }
                else
                {
                    SetImage(pbMuOtherSt1[i], NMS.Properties.Resources.st_OFF);
                    SetImage(pbMuOtherSt[i], NMS.Properties.Resources.st_ON);
                }
            }


            if (clsCommon.flagSpare[muID - 1])  //주예비 다 있는경우
            {
                //자동/수동절체상태 표시할 컨트롤을 버튼으로 변경
                if (muData.otherSt1[0] == 0)
                {
                    SetColor(btMUAutoManual1, colorSelect);
                    SetColor(btMUAutoManual2, colorBase);
                }
                else
                {
                    SetColor(btMUAutoManual1, colorBase);
                    SetColor(btMUAutoManual2, colorSelect);
                }

                //주/예비동작상태 표시할 컨트롤을 버튼으로 변경
                if (muData.otherSt1[1] == 0)
                {
                    SetColor(btMUMainSpare1, colorSelect);
                    SetColor(btMUMainSpare2, colorBase);
                }
                else
                {
                    SetColor(btMUMainSpare1, colorBase);

                    //자동인데 예비이면 Error 표시
                    if (muData.otherSt1[0] == 0) SetColor(btMUMainSpare2, colorError);
                    else SetColor(btMUMainSpare2, colorSelect);
                }
            }

            for (i = 3; i < 6; i++)
            {
                if (muData.otherSt1[i] == 0) SetImage(pbMuOtherSt1[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbMuOtherSt1[i], NMS.Properties.Resources.st_Error);
            }

            //CCE PTT
            if (muData.otherSt1[6] == 0)
            {
                SetImage(pbMuOtherSt1[6], NMS.Properties.Resources.st_OFF); //구로 CCE PTT
                SetImage(pbMURCSt5, NMS.Properties.Resources.st_OFF);       //대전 CCE PTT
            }
            else
            {
                bool flag1 = false;
                bool flag2 = false;

                //구로 주장치 검사
                for (i = 0; i < 30; i++)
                {
                    //PTT ON
                    if (baseSt[0, i].otherSt[1] == 1)
                    {
                        SetImage(pbMuOtherSt1[6], NMS.Properties.Resources.st_ON);  //구로 CCE PTT
                        break;
                    }
                }

                if (i >= 30) flag1 = true;

                //대전 주장치 검사
                for (i = 0; i < 30; i++)
                {
                    //PTT ON
                    if (baseSt[1, i].otherSt[1] == 1)
                    {
                        SetImage(pbMURCSt5, NMS.Properties.Resources.st_ON);        //대전 CCE PTT
                        break;
                    }
                }


                if (i >= 30) flag2 = true;

                if (flag1 && flag2)
                {
                    SetImage(pbMuOtherSt1[6], NMS.Properties.Resources.st_ON);  //구로 CCE PTT
                    SetImage(pbMURCSt5, NMS.Properties.Resources.st_ON);        //대전 CCE PTT
                }
            }

            //RC1 PTT
            if (muData.otherSt1[7] == 0) SetImage(pbMuOtherSt1[7], NMS.Properties.Resources.st_OFF);
            else SetImage(pbMuOtherSt1[7], NMS.Properties.Resources.st_ON);

            // MU의 기타 상태(8: RX2 PTT 상태, 9: RX3 PTT 상태, 10:역용 주 PTT, 11:역용 주 BUSY, 12:역용 예비 PTT, 13:역용 예비 BUSY, 14:역용 감청 BUSY)
            switch (clsCommon.nmsGUIUser)
            {
                    /*  2012년 04월 12일
                case "경춘선":
                    //경춘선의 경우 무전기가 구형이므로 역용 주 PTT를 감지할수 없음.
                    //그래서 송신출력값으로 역용 주 PTT를 제어하도록 함.
                    for (i = 0; i < 2; i++)
                    {
                        if (muData.otherSt2[i] == 0) SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_OFF);
                        else SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_ON);
                    }

                    for (i = 3; i < 7; i++)
                    {
                        if (muData.otherSt2[i] == 0) SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_OFF);
                        else SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_ON);
                    }
                    break;
                    */

                case "전라선":
                    if (clsCommon.flagSpare[muID - 1])  //주예비 다 있는경우
                    {
                        for (i = 0; i < 7; i++)
                        {
                            if (muData.otherSt2[i] == 0) SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_OFF);
                            else SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_ON);
                        }
                    }
                    else
                    {
                        for (i = 0; i < 4; i++)
                        {
                            if (muData.otherSt2[i] == 0) SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_OFF);
                            else SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_ON);
                        }
                        if (muData.otherSt2[6] == 0) SetImage(pbMuOtherSt2[6], NMS.Properties.Resources.st_OFF);
                        else SetImage(pbMuOtherSt2[6], NMS.Properties.Resources.st_ON);
                    }
                    break;

                case "경춘선":
                case "중앙선":
                    for (i = 0; i < 7; i++)
                    {
                        if (muData.otherSt2[i] == 0) SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_OFF);
                        else SetImage(pbMuOtherSt2[i], NMS.Properties.Resources.st_ON);
                    }
                    break;
            }

            //MU의 DC전원값
            double tmpDcValue = muData.dcValue / 10.0;
            SetText(lblMUDCValue, tmpDcValue.ToString("0.0") + " V");

            //MU의 주/예비 RF 출력값
            double tmpRfValue = 0;
            for (i = 0; i < 2; i++)
            {
                tmpRfValue = muData.rfValue[i] / 10.0;
                SetText(lblMURfMainSpare[i], tmpRfValue.ToString("0.0"));
            }

            /*  2012년 04월 12일
            //경춘선의 경우 무전기가 구형이므로 역용 주 PTT를 감지할수 없음.
            //그래서 송신출력값으로 역용 주 PTT를 제어하도록 함.
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                if (muData.rfValue[0] == 0) SetImage(pbMuOtherSt2[2], NMS.Properties.Resources.st_OFF);
                else SetImage(pbMuOtherSt2[2], NMS.Properties.Resources.st_ON);
            }
            */

            if (clsCommon.flagSpare[muID - 1])  //주예비 다 있는경우
            {
                //MU의 주/예비/감청용 RX RSSI 값
                for (i = 0; i < 3; i++)
                {
                    int tmpValue = muData.rxRssiValue[i];

                    //if (tmpValue >= 0x80) tmpValue = (tmpValue - 0x80) * -1;
                    tmpValue *= -1;
                    SetText(lblMURXRSSI[i], tmpValue.ToString() + " dBm");
                }
            }
            else
            {
                //MU의 주/예비/감청용 RX RSSI 값
                int tmpValue = muData.rxRssiValue[0];
                tmpValue *= -1;
                SetText(lblMURXRSSI[0], tmpValue.ToString() + " dBm");

                tmpValue = muData.rxRssiValue[2];
                tmpValue *= -1;
                SetText(lblMURXRSSI[2], tmpValue.ToString() + " dBm");
            }

            //MU의 주/예비 RF 출력조회값
            for (i = 0; i < 2; i++)
            {
                int tmpRfOutValue = muData.rfValueInquiry[i];
                SetText(lblMURfMainSpareInquiry[i], tmpRfOutValue.ToString());
            }

            //MU의 주/예비/감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
            string tmpCh = null;
            for (i = 0; i < 2; i++)
            {
                switch (muData.chInfo[i])
                {
                    //case 0: tmpCh = "REMOTE"; break;
                    case 1: tmpCh = "리모트 1 채널"; break;
                    case 2: tmpCh = "리모트 2 채널"; break;
                    case 3: tmpCh = "리모트 3 채널"; break;
                    case 4: tmpCh = "리모트 4 채널"; break;
                    case 5: tmpCh = "로컬 1 채널"; break;
                    case 6: tmpCh = "로컬 2 채널"; break;
                    case 7: tmpCh = "로컬 3 채널"; break;
                    case 8: tmpCh = "로컬 4 채널"; break;
                    case 10: tmpCh = "스캔중..."; break;
                    case 11: tmpCh = "스캔 1 채널 수신"; break;
                    case 12: tmpCh = "스캔 2 채널 수신"; break;
                    case 13: tmpCh = "스캔 3 채널 수신"; break;
                    case 14: tmpCh = "스캔 4 채널 수신"; break;
                    default: tmpCh = "리모트 1 채널"; break;
                }

                SetText(lblMUCHInfo[i], tmpCh);
            }

            //감청용 채널정보(0:Scan, 1:1CH, 2:2CH, 3:3CH, 4:4CH)
            tmpCh = null;
            switch (muData.chInfo[2])
            {
                case 0: tmpCh = "SCAN"; break;
                case 1: tmpCh = "1 채널 수신"; break;
                case 2: tmpCh = "2 채널 수신"; break;
                case 3: tmpCh = "3 채널 수신"; break;
                case 4: tmpCh = "4 채널 수신"; break;
                default: tmpCh = "1 채널 수신"; break;
            }
            SetText(lblMUCHInfo[2], tmpCh);

            /*  2012년 04월 12일
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시), 각 CPU카드 연결상태(5:MU TRX CPU 장착 상태, 6:MU OPT CPU 장착 상태, 7:UPS 연결 상태)
                //경춘선은 당분간 무조건 정상 표시
                for (i = 0; i < 3; i++)
                    SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Normal);

                for (i = 3; i < 6; i++)
                {
                    if (muData.optMonSt[i] == 0) SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Error);
                }
            }
            else
            */
            {
                if (clsCommon.flagSpare[muID - 1])  //주예비 다 있는경우
                {
                    //OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시)
                    for (i = 0; i < 3; i++)
                    {
                        if (muData.optMonSt[i] == 0) SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Normal);
                        else SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Error);
                    }
                }
                else
                {
                    //OPT의 통신 감시 상태(0:주 통신 감시, 1:예비 통신 감시, 2:감청 통신 감시)
                    if (muData.optMonSt[0] == 0) SetImage(pbOptMonSt[0], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbOptMonSt[0], NMS.Properties.Resources.st_Error);

                    if (muData.optMonSt[2] == 0) SetImage(pbOptMonSt[2], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbOptMonSt[2], NMS.Properties.Resources.st_Error);
                }
            }

            //OPT의 기타 상태(0:DC 전원 상태, 1:MODOPEN 상태, 2:CCE PTT 상태)
            for (i = 0; i < 2; i++)
            {
                if (muData.optOtherSt[i] == 0) SetImage(pbOptOtherSt[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbOptOtherSt[i], NMS.Properties.Resources.st_Error);
            }
            if (muData.optOtherSt[2] == 0) SetImage(pbOptOtherSt[2], NMS.Properties.Resources.st_OFF);
            else SetImage(pbOptOtherSt[2], NMS.Properties.Resources.st_ON);

            //각 CPU카드 연결상태(5:MU TRX CPU 장착 상태, 6:MU OPT CPU 장착 상태, 7:UPS 연결 상태) 
            for (i = 5; i < 8; i++)
            {
                if (muData.optOtherSt[i] == 0)
                    SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Normal);
                else
                    SetImage(pbOptMonSt[i], NMS.Properties.Resources.st_Error);
            }

            //OPT의 DC전원값
            double tmpOptDcValue = muData.optDcValue / 10.0;
            SetText(lblMUOPTDCValue, tmpOptDcValue.ToString("0.0") + " V");

            //OPT의 LD/PD 알람 상태(0~3:OPT1~4 LD 알람, 4~7:OPT1~4 PD 알람)
            for (i = 0; i < 4; i++)
            {
                if (ruName[i].ruName != "")
                {   //RU의 이름이 있는 경우만 알람여부 표시함
                    SetEnable(lblOptLd[i], true);
                    SetEnable(lblOptPd[i], true);

                    //OPT LD 알람 상태
                    if (muData.optAlarmSt[i] == 0) SetImage(pbOptAlarmSt[i], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbOptAlarmSt[i], NMS.Properties.Resources.st_Error);

                    //OPT PD 알람 상태
                    if (muData.optAlarmSt[i + 4] == 0) SetImage(pbOptAlarmSt[i + 4], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbOptAlarmSt[i + 4], NMS.Properties.Resources.st_Error);
                }
                else
                {
                    SetEnable(lblOptLd[i], false);
                    SetEnable(lblOptPd[i], false);

                    SetImage(pbOptAlarmSt[i], NMS.Properties.Resources.st_OFF);
                    SetImage(pbOptAlarmSt[i + 4], NMS.Properties.Resources.st_OFF);
                }
            }

            //for (i = 0; i < 8; i++)
            //{
            //    if (muData.optAlarmSt[i] == 0) SetImage(pbOptAlarmSt[i], NMS.Properties.Resources.st_Normal);
            //    else SetImage(pbOptAlarmSt[i], NMS.Properties.Resources.st_Error);
            //}

            //채널 복귀 시간 상태
            if (muData.chReturn == 0) SetText(lblMUChReturnTime, "OFF");
            else SetText(lblMUChReturnTime, muData.chReturn.ToString());

            /*  2012년 04월 12일
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //PLL LOCK 장애 상태(0:역용 주 PLL LOCK 장애 상태, 1:역용 예비 PLL LOCK 장애 상태, 2:감청용 PLL LOCK 장애 상태)
                //경춘선은 당분간 무조건 정상 표시
                for (i = 0; i < 3; i++)
                    SetImage(pbPllLockSt[i], NMS.Properties.Resources.st_Normal);
            }
            else
            */
            {
                if (clsCommon.flagSpare[muID - 1])  //주예비 다 있는경우
                {
                    //PLL LOCK 장애 상태(0:역용 주 PLL LOCK 장애 상태, 1:역용 예비 PLL LOCK 장애 상태, 2:감청용 PLL LOCK 장애 상태)
                    for (i = 0; i < 3; i++)
                    {
                        if (muData.pllLockErrorSt[i] == 0) SetImage(pbPllLockSt[i], NMS.Properties.Resources.st_Normal);
                        else SetImage(pbPllLockSt[i], NMS.Properties.Resources.st_Error);
                    }
                }
                else
                {
                    if (muData.pllLockErrorSt[0] == 0) SetImage(pbPllLockSt[0], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbPllLockSt[0], NMS.Properties.Resources.st_Error);

                    if (muData.pllLockErrorSt[2] == 0) SetImage(pbPllLockSt[2], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbPllLockSt[2], NMS.Properties.Resources.st_Error);
                }
            }

            /*
            switch (clsCommon.nmsGUIUser)
            {
                case "중앙선":
                    Control_중앙선_Disable();
                    break;

                default:
                    break;
            }
            */
        }

        /// <summary>
        /// 소스텔의 FM 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="flagAction">활성화/비활성화</param>
        public void FmStInit(bool flagAction)
        {
            try
            {
                ucFM.StInit(flagAction);
            }
            catch
            {
            }
        }
        
        /// <summary>
        /// FM 상태를 표시한다.
        /// </summary>
        /// <param name="fmInfo">FM의 상태 Data</param>
        public void nmsFMSt_Display(FM_Info fmInfo)
        {
            ucFM.nmsSt_Display(fmInfo);
        }

        private void btMUMainSpareChange_Click(object sender, EventArgs e)
        {
            byte index = Convert.ToByte(((Button)sender).Tag);

            try
            {
                this.muControlClick(0, index, 0);
            }
            catch
            {
            }
        }

        private void btMUAutoManualChange_Click(object sender, EventArgs e)
        {
            byte index = Convert.ToByte(((Button)sender).Tag);

            try
            {
                this.muControlClick(1, index, 0);
            }
            catch
            {
            }
        }

        private void btMURfMainSpare_Click(object sender, EventArgs e)
        {
            byte index = Convert.ToByte(((Button)sender).Tag);

            byte rfValue = 0;

            try
            {
                rfValue = Convert.ToByte(tbMURfMainSpare[index].Text);
            }
            catch
            {
            }

            try
            {
                this.muControlClick(2, index, rfValue);
            }
            catch
            {
            }
        }

        private void btMUWideNarrowChange_Click(object sender, EventArgs e)
        {
            try
            {
                this.muControlClick(3, 0, 0);
            }
            catch
            {
            }
        }

        private void btMUChReturnTime_Click(object sender, EventArgs e)
        {
            byte tmpChReturnTime = 0;

            try
            {
                tmpChReturnTime = Convert.ToByte(tbMUChReturnTime.Text);
            }
            catch
            {
            }

            try
            {
                this.muControlClick(4, 0, tmpChReturnTime);
            }
            catch
            {
            }
        }

        private void btMUSendOutTest_Click(object sender, EventArgs e)
        {
            try
            {
                this.muControlClick(5, 0, 0);
            }
            catch
            {
            }
        }

        public void btMuSendOutTest_ColorSet()
        {
            if (flagSendOutTest)
            {
                tmrSendOutTest.Start();
                SetColor(btMUSendOutTest, colorSelect);
            }
            else
            {
                tmrSendOutTest.Stop();
                SetColor(btMUSendOutTest, colorBase);
            }
        }

        private void tmrSendOutTest_Tick(object sender, EventArgs e)
        {
            tmrSendOutTest.Stop();

            try
            {
                this.muControlClick(5, 0, 0);
                return;
            }
            catch
            {
            }

            tmrSendOutTest.Start();
        }
    }
}
