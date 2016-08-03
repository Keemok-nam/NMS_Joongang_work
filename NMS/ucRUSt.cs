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
    public partial class ucRUSt : UserControl
    {
        /// <summary>
        /// 사용자 정의 컨트롤에서의 제어 이벤트
        /// </summary>
        /// <param name="btCode">Click한 버튼 Code</param>
        public event UserControl_Control ruControlClick = null;

        #region RU감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<PictureBox> pbRuOtherSt1 = new List<PictureBox>();
        private List<PictureBox> pbRuOtherSt = new List<PictureBox>();
        private List<PictureBox> pbRuOtherSt2 = new List<PictureBox>();

        private List<PictureBox> pbRuPllLockSt = new List<PictureBox>();
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

        public ucRUSt()
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "전라선":
                case "중앙선":
                    InitializeComponent_();
                    break;

                case "경춘선":
                default:
                    InitializeComponent();
                    break;
            }

            #region RU감시화면 컨트롤 배열
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private ArrayList pbRuOtherSt1 = new ArrayList();
            pbRuOtherSt1.Add(pbRUAutoManual1); pbRuOtherSt1.Add(pbRUMainSpare1); pbRuOtherSt1.Add(pbRUWideNarrow1); pbRuOtherSt1.Add(pbRUAC); pbRuOtherSt1.Add(pbRUDC);
            pbRuOtherSt1.Add(pbRUCardSt2); pbRuOtherSt1.Add(pbRUCardSt3); pbRuOtherSt1.Add(pbRUCardSt4);

            //private List<PictureBox> ruOtherSt = new List<PictureBox>();
            pbRuOtherSt.Add(pbRUAutoManual2); pbRuOtherSt.Add(pbRUMainSpare2); pbRuOtherSt.Add(pbRUWideNarrow2);

            //private ArrayList pbRuOtherSt2 = new ArrayList();
            pbRuOtherSt2.Add(pbRUCardSt1);
            pbRuOtherSt2.Add(pbRUDataOptical); pbRuOtherSt2.Add(pbRUVoiceOptical); pbRuOtherSt2.Add(pbRUOptLD); pbRuOtherSt2.Add(pbRUOptPD);

            //private List<PictureBox> pbRuPllLockSt = new List<PictureBox>();
            pbRuPllLockSt.Add(pbRUPllLock1); pbRuPllLockSt.Add(pbRUPllLock2);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            colorSelect = Color.Lime;
            colorError = Color.Red;
            colorBase = Color.Transparent;

            //RU화면의 주/예비 절체 버튼
            btRUMainSpare1.Tag = 0;
            btRUMainSpare2.Tag = 1;

            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    SetImage(pb주예비동작상태, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb절체방법, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb무전기형식, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb광접속상태, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pbPaFault, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb카드상태, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb전원상태, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pbRSSI, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb송신출력, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    SetImage(pb송신출력설정, new Bitmap(clsCommon.ImagePath + "Ground_200_193.png"));
                    break;

                case "전라선":
                    panelRU주예비.Left = 118;
                    panelRU주예비.Top = 0;
                    panelRU절체방법.Left = 118;
                    panelRU절체방법.Top = 270;
                    panelRU무전기형식.Left = 118;
                    panelRU무전기형식.Top = 540;

                    panelRU송신출력.Left = 624;
                    panelRU송신출력.Top = 0;
                    panelRURssi.Left = 827;
                    panelRURssi.Top = 0;
                    panelRU송신출력설정.Left = 624;
                    panelRU송신출력설정.Top = 270;
                    panelRU광접속상태.Left = 624;
                    panelRU광접속상태.Top = 540;

                    panelRUPaFault.Left = 1130;
                    panelRUPaFault.Top = 0;
                    panelRU카드상태.Left = 1130;
                    panelRU카드상태.Top = 270;
                    panelRU전원상태.Left = 1130;
                    panelRU전원상태.Top = 540;

                    SetVisible(ucFMChild, false);
                    SetVisible(ucBDASourcetel, false);
                    break;

                case "중앙선":
                    panelRU주예비.Left = 18;
                    panelRU주예비.Top = 0;
                    panelRU절체방법.Left = 18;
                    panelRU절체방법.Top = 270;
                    panelRU무전기형식.Left = 18;
                    panelRU무전기형식.Top = 540;

                    panelRU송신출력.Left = 424;
                    panelRU송신출력.Top = 0;
                    panelRURssi.Left = 627;
                    panelRURssi.Top = 0;
                    panelRU송신출력설정.Left = 424;
                    panelRU송신출력설정.Top = 270;
                    panelRU광접속상태.Left = 424;
                    panelRU광접속상태.Top = 540;

                    panelRUPaFault.Left = 830;
                    panelRUPaFault.Top = 0;
                    panelRU카드상태.Left = 830;
                    panelRU카드상태.Top = 270;
                    panelRU전원상태.Left = 830;
                    panelRU전원상태.Top = 540;
                    
                    SetVisible(ucFMChild, true);
                    SetVisible(ucBDASourcetel, true);
                    break;
            }

            tmrSendOutTest.Interval = 10000;
            tmrSendOutTest.Tick += new EventHandler(tmrSendOutTest_Tick);
        }

        private bool flagWideNarrowChange = false;
        private void ucRUSt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    flagWideNarrowChange = !flagWideNarrowChange;
                    SetVisible(btRUWideNarrowChange, flagWideNarrowChange);
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

        /// <summary>
        /// RU 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="flagAction">활성화/비활성화</param>
        public void RuStInit(bool flagAction)
        {
            //SetEnable(panelRU주예비, flagAction);
            SetColor(btRUMainSpare1, colorBase);
            SetColor(btRUMainSpare2, colorBase);
            SetEnable(btRUMainSpare1, flagAction);
            SetEnable(btRUMainSpare2, flagAction);

            //SetEnable(panelRU절체방법, flagAction);
            SetEnable(lblRUAutoManual1, flagAction);
            SetEnable(lblRUAutoManual2, flagAction);
            SetImage(pbRUAutoManual1, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUAutoManual2, NMS.Properties.Resources.st_OFF);
            SetEnable(pbRUAutoManual1, flagAction);
            SetEnable(pbRUAutoManual2, flagAction);
            SetEnable(btRUAutoManualChange, flagAction);

            //SetEnable(panelRU무전기형식, flagAction);
            SetEnable(lblRUWideNarrow1, flagAction);
            SetEnable(lblRUWideNarrow2, flagAction);
            SetImage(pbRUWideNarrow1, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUWideNarrow2, NMS.Properties.Resources.st_OFF);
            SetEnable(pbRUWideNarrow1, flagAction);
            SetEnable(pbRUWideNarrow2, flagAction);
            SetEnable(btRUWideNarrowChange, flagAction);

            //SetEnable(panelRU광접속상태, flagAction);
            SetEnable(lbl광접속상태1, flagAction);
            SetEnable(lbl광접속상태2, flagAction);
            SetEnable(lbl광접속상태3, flagAction);
            SetEnable(lbl광접속상태4, flagAction);
            SetImage(pbRUDataOptical, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUVoiceOptical, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUOptLD, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUOptPD, NMS.Properties.Resources.st_OFF);
            SetEnable(pbRUDataOptical, flagAction);
            SetEnable(pbRUVoiceOptical, flagAction);
            SetEnable(pbRUOptLD, flagAction);
            SetEnable(pbRUOptPD, flagAction);

            //SetEnable(panelRUPaFault, flagAction);
            SetEnable(lblRUPllLock1, flagAction);
            SetEnable(lblRUPllLock2, flagAction);
            SetImage(pbRUPllLock1, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUPllLock2, NMS.Properties.Resources.st_OFF);
            SetEnable(pbRUPllLock1, flagAction);
            SetEnable(pbRUPllLock2, flagAction);

            //SetEnable(panelRU카드상태, flagAction);
            SetEnable(lblRUCardSt1, flagAction);
            SetEnable(lblRUCardSt2, flagAction);
            SetEnable(lblRUCardSt3, flagAction);
            SetEnable(lblLocalRemote, flagAction);
            SetImage(pbRUCardSt1, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUCardSt2, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUCardSt3, NMS.Properties.Resources.st_OFF);
            SetImage(pbRUCardSt4, NMS.Properties.Resources.st_OFF);
            SetEnable(pbRUCardSt1, flagAction);
            SetEnable(pbRUCardSt2, flagAction);
            SetEnable(pbRUCardSt3, flagAction);
            SetEnable(pbRUCardSt4, flagAction);

            //SetEnable(panelRU전원상태, flagAction);
            SetEnable(lbl전원상태1, flagAction);
            SetEnable(lbl전원상태2, flagAction);
            SetEnable(lbl전원상태3, flagAction);
            SetColor(btRUAC, colorBase);
            SetColor(btRUDC, colorBase);
            SetEnable(btRUAC, flagAction);
            SetEnable(btRUDC, flagAction);
            SetEnable(lblRUDCValue, flagAction);

            //SetEnable(panelRURssi, flagAction);
            SetEnable(lblRURssiValue, flagAction);

            //SetEnable(panelRU송신출력, flagAction);
            SetEnable(gbRURfMain, flagAction);
            SetEnable(btRUSendOutTest, flagAction);

            //SetEnable(panelRU송신출력설정, flagAction);
            SetEnable(lbl송신출력설정1, flagAction);
            SetEnable(lbl송신출력설정2, flagAction);
            SetEnable(lbl송신출력설정3, flagAction);
            SetEnable(lbl송신출력설정4, flagAction);
            SetEnable(lblRURfMainInquiry, flagAction);
            SetEnable(tbRURfMain, flagAction);
            SetEnable(btRURfMainSpare, flagAction);
        }

        /// <summary>
        /// RU 상태를 표시한다.
        /// </summary>
        /// <param name="ruData">RU의 상태 Data</param>
        public void nmsRUSt_Display(RUDetailData ruData)
        {
            if (!btRUMainSpare1.Enabled) RuStInit(true);

            int i = 0;

            //RU의 기타 상태(0:자동/수동절체방법상태, 1:주예비동작상태, 2:Wide/Narrow 상태, 3:AC 전원상태, 4:DC 전원상태,
            //              5:MODOPEN 상태, 6:PTT 상태, 7:Local/Remote 상태)
            for (i = 0; i < 3; i++)
            {
                if (ruData.otherSt1[i] == 0)
                {
                    SetImage(pbRuOtherSt1[i], NMS.Properties.Resources.st_ON);
                    SetImage(pbRuOtherSt[i], NMS.Properties.Resources.st_OFF);
                }
                else
                {
                    SetImage(pbRuOtherSt1[i], NMS.Properties.Resources.st_OFF);
                    SetImage(pbRuOtherSt[i], NMS.Properties.Resources.st_ON);
                }
            }

            //주/예비동작상태 표시할 컨트롤을 버튼으로 변경
            if (ruData.otherSt1[1] == 0)
            {
                SetColor(btRUMainSpare1, colorSelect);
                SetColor(btRUMainSpare2, colorBase);
            }
            else
            {
                SetColor(btRUMainSpare1, colorBase);

                //자동인데 예비이면 Error 표시
                if (ruData.otherSt1[0] == 0) SetColor(btRUMainSpare2, colorError);
                else SetColor(btRUMainSpare2, colorSelect);
            }

            //AC 상태 표시할 컨트롤을 버튼으로 변경
            if (ruData.otherSt1[3] == 0) SetColor(btRUAC, colorSelect);
            else SetColor(btRUAC, colorError);

            //DC 상태 표시할 컨트롤을 버튼으로 변경
            if (ruData.otherSt1[4] == 0) SetColor(btRUDC, colorSelect);
            else SetColor(btRUDC, colorError);

            for (i = 3; i < 6; i++)
            {
                if (ruData.otherSt1[i] == 0) SetImage(pbRuOtherSt1[i], NMS.Properties.Resources.st_Normal);
                else SetImage(pbRuOtherSt1[i], NMS.Properties.Resources.st_Error);
            }

            //PTT 상태
            if (ruData.otherSt1[6] == 0) SetImage(pbRuOtherSt1[6], NMS.Properties.Resources.st_OFF);
            else SetImage(pbRuOtherSt1[6], NMS.Properties.Resources.st_ON);

            //Local/Remote
            //SetImage(pbRuOtherSt1[7], NMS.Properties.Resources.st_ON);
            if (ruData.otherSt1[7] == 0) SetText(lblLocalRemote, "Local");
            else SetText(lblLocalRemote, "Remote");

            //RU의 기타 상태(0:RUCPU 상태, 1:데이터 광접속 상태, 2:음성 광접속 상태, 3:OPT LD 알람 상태, 4:OPT PD 알람 상태, 5:XMTR PLL LOCK 장애, 6:RCVR PLL LOCK 장애)
            for (i = 0; i < 4; i++)
            {
                if (i != 2)
                {
                    if (ruData.otherSt2[i] == 0) SetImage(pbRuOtherSt2[i], NMS.Properties.Resources.st_Normal);
                    else SetImage(pbRuOtherSt2[i], NMS.Properties.Resources.st_Error);
                }
            }
            if (ruData.otherSt2[4] == 0) SetImage(pbRuOtherSt2[4], NMS.Properties.Resources.st_OFF);
            else SetImage(pbRuOtherSt2[4], NMS.Properties.Resources.st_ON);

            //PLL LOCK 상태
            for (i = 5; i <= 6; i++)
            {
                if (ruData.otherSt2[i] == 0) SetImage(pbRuPllLockSt[i - 5], NMS.Properties.Resources.st_Normal);
                else SetImage(pbRuPllLockSt[i - 5], NMS.Properties.Resources.st_Error);
            }

            //DC전원값
            double tmpDcValue = ruData.dcValue / 10.0;
            SetText(lblRUDCValue, tmpDcValue.ToString("0.0") + " V");

            //주/예비 RF 출력 감시
            //PTT가 OFF이면 송신출력값도 0으로 변경한다.
            if (ruData.otherSt1[6] == 0) SetText(lblRURfMain, "0.0");
            else
            {
                //MU의 주/예비 RF 출력값
                double tmpRfValue = ruData.rfValue / 10.0;
                SetText(lblRURfMain, tmpRfValue.ToString("0.0"));
            }

            //주/예비 RF 출력 조회값
            int tmpRfValueInquiry = ruData.rfValueInquiry;
            SetText(lblRURfMainInquiry, tmpRfValueInquiry.ToString());

            //RX RSSI 감도값
            int tmpValue = ruData.rxRssiValue;
            tmpValue *= -1;
            SetText(lblRURssiValue, tmpValue.ToString() + " dBm");
        }

        /// <summary>
        /// 소스텔의 FM 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="flagAction">활성화/비활성화</param>
        public void FmStInit(bool flagAction)
        {
            ucFMChild.StInit(flagAction);
        }

        /// <summary>
        /// FM 상태를 표시한다.
        /// </summary>
        /// <param name="fmInfo">FM의 상태 Data</param>
        public void nmsFMSt_Display(FM_Info fmInfo)
        {
            ucFMChild.nmsSt_Display(fmInfo);
        }

        /// <summary>
        /// 소스텔의 BDA 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="bdaId">bdaId</param>
        /// <param name="flagAction">활성화/비활성화</param>
        public void BDAInit(byte bdaId, bool flagAction)
        {
            ucBDASourcetel.StInit(bdaId, flagAction);
        }

        /// <summary>
        /// BDA 상태를 표시한다.
        /// </summary>
        /// <param name="bdaId">bdaId</param>
        /// <param name="bdaInfo">BDA의 상태 Data</param>
        public void nmsBDASt_Display(byte bdaId, BDA_St bdaInfo)
        {
            ucBDASourcetel.nmsSt_Display(bdaId, bdaInfo);
        }
        
        private void btRUMainSpareChange_Click(object sender, EventArgs e)
        {
            byte index = Convert.ToByte(((Button)sender).Tag);

            try
            {
                this.ruControlClick(0, index, 0);
            }
            catch
            {
            }
        }

        private void btRUAutoManualChange_Click(object sender, EventArgs e)
        {
            try
            {
                this.ruControlClick(1, 0, 0);
            }
            catch
            {
            }
        }

        private void btRURfMainSpare_Click(object sender, EventArgs e)
        {
            byte rfValue = 0;

            try
            {
                rfValue = Convert.ToByte(tbRURfMain.Text);
            }
            catch
            {
            }

            try
            {
                this.ruControlClick(2, 0, rfValue);
            }
            catch
            {
            }
        }

        private void btRUWideNarrowChange_Click(object sender, EventArgs e)
        {
            try
            {
                this.ruControlClick(3, 0, 0);
            }
            catch
            {
            }
        }

        private void btRUSendOutTest_Click(object sender, EventArgs e)
        {
            try
            {
                this.ruControlClick(4, 0, 0);
            }
            catch
            {
            }
        }

        private void btBDAInit_Click(object sender, EventArgs e)
        {
            try
            {
                this.ruControlClick(5, 0, 0);
            }
            catch
            {
            }
        }

        public void btRuSendOutTest_ColorSet()
        {
            if (flagSendOutTest)
            {
                tmrSendOutTest.Start();
                SetColor(btRUSendOutTest, colorSelect);
            }
            else
            {
                tmrSendOutTest.Stop();
                SetColor(btRUSendOutTest, colorBase);
            }
        }

        private void tmrSendOutTest_Tick(object sender, EventArgs e)
        {
            tmrSendOutTest.Stop();

            try
            {
                this.ruControlClick(4, 0, 0);
                return;
            }
            catch
            {
            }

            tmrSendOutTest.Start();
        }
    }
}
