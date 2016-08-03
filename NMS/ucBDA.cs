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
    /// <param name="bdaID">BDA ID</param>
    /// <param name="btCode">Click한 버튼 Code</param>
    public delegate void UserControl_BDAControl(byte bdaID, byte btCode);

    public partial class ucBDA : UserControl
    {
        /// <summary>
        /// 사용자 정의 컨트롤에서의 제어 이벤트
        /// </summary>
        /// <param name="btCode">Click한 버튼 Code</param>
        public event UserControl_BDAControl bdaControlClick = null;

        #region BDA 감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<PictureBox> pbRuBDAAMPSt = new List<PictureBox>();
        private List<Label> lblAmpDbm = new List<Label>();
        private List<PictureBox> pbRuBDAUpsSt = new List<PictureBox>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region 기타 변수
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public byte bdaID = new byte();

        public bool flagInquiry = false;
        public bool flagLoopTest = false;

        private Color colorSelect = new Color();    //선택 색
        private Color colorError = new Color();    //선택 색
        private Color colorBase = new Color();      //기본 색
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public ucBDA()
        {
            InitializeComponent();

            #region BDA 감시화면 컨트롤 배열 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<PictureBox> pbRuBDAAMPSt = new List<PictureBox>();
            pbRuBDAAMPSt.Add(pbBDA_AMP1); pbRuBDAAMPSt.Add(pbBDA_AMP2); pbRuBDAAMPSt.Add(pbBDA_AMP3); pbRuBDAAMPSt.Add(pbBDA_AMP4);
            pbRuBDAAMPSt.Add(pbBDA_AMP5); pbRuBDAAMPSt.Add(pbBDAPower_12); pbRuBDAAMPSt.Add(pbBDAPower_24); pbRuBDAAMPSt.Add(pbBDAPower_220);

            //private List<Label> lblAmpDbm = new List<Label>();
            lblAmpDbm.Add(lblBDAGain1); lblAmpDbm.Add(lblBDAGain2); lblAmpDbm.Add(lblBDAGain3); lblAmpDbm.Add(lblBDAGain4); lblAmpDbm.Add(lblBDAGain5); lblAmpDbm.Add(lblBDAGain6);

            //private List<PictureBox> pbRuBDAUpsSt = new List<PictureBox>();
            pbRuBDAUpsSt.Add(pbBDAUps_Bypass); pbRuBDAUpsSt.Add(pbBDAUps_AC); pbRuBDAUpsSt.Add(pbBDAUps_Fail); pbRuBDAUpsSt.Add(pbBDAUps_Low); pbRuBDAUpsSt.Add(pbBDACommSt);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion

            colorSelect = Color.Lime;
            colorError = Color.Red;
            colorBase = Color.Transparent;
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

        public void BDANameSet(string bdaName)
        {
            SetText(lblBdaName, bdaName);
        }

        /// <summary>
        /// BDA 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="flagAction">활성화/비활성화</param>
        public void BdaStInit(bool flagAction)
        {
            int i = 0;

            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //SetEnable(panelBDA, flagAction);

                SetEnable(lblBDA1, flagAction);
                SetEnable(lblBDA2, flagAction);
                SetEnable(lblBDA3, flagAction);
                SetEnable(lblBDA4, flagAction);

                SetEnable(gbUPS, flagAction);
                SetEnable(gbAmp, flagAction);

                for (i = 0; i < 2; i++)
                {
                    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_OFF);
                    SetEnable(pbRuBDAAMPSt[i], flagAction);
                }
                SetImage(pbBDA_AMP6, NMS.Properties.Resources.st_OFF);
                SetEnable(pbBDA_AMP6, flagAction);

                //for (i = 2; i < 5; i++)
                //    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_OFF);
                //
                SetImage(pbRuBDAAMPSt[2], NMS.Properties.Resources.st_OFF);

                SetImage(pbRuBDAAMPSt[3], NMS.Properties.Resources.st_OFF);
                SetEnable(pbRuBDAAMPSt[3], flagAction);
                
                SetImage(pbRuBDAAMPSt[4], NMS.Properties.Resources.st_OFF);

                for (i = 5; i < 8; i++)
                {
                    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_OFF);
                    SetEnable(pbRuBDAAMPSt[i], flagAction);
                }
                /*
                for (i = 0; i < 8; i++)
                {
                    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_OFF);
                    SetEnable(pbRuBDAAMPSt[i], flagAction);
                }
                */

                for (i = 0; i < 5; i++)
                {
                    SetImage(pbRuBDAUpsSt[i], NMS.Properties.Resources.st_OFF);
                    SetEnable(pbRuBDAUpsSt[i], flagAction);
                }

                for (i = 0; i < 6; i++)
                    SetText(lblAmpDbm[i], "0");

                SetEnable(btBDA_LT, flagAction);
            }
        }

        /// <summary>
        /// BDA 상태를 표시한다.
        /// </summary>
        /// <param name="bdaData">BDA의 상태 Data</param>
        public void nmsRUBDASt_Display(BDA_St bdaData)
        {
            if (!gbUPS.Enabled) BdaStInit(true);

            int i = 0;

            //BDA의 상태(0:FM, 1:역무, 2:DMB, 3:방호, 4:TRS, 5:12V, 6:24V, 7:220V)
            for (i = 0; i < 2; i++)
            {
                if (bdaData.bdaAMPSt[i] == 0) SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Normal);
                else
                {
                    //if (bdaData.bdaAmpErrTime[i].AddMinutes(30) > DateTime.Now)
                    //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                    //    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Normal);
                    //}
                    //else
                    //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                        SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Error);
                    //}
                }
            }
            if (bdaData.bdaAMPSt[1] == 0) SetImage(pbBDA_AMP6, NMS.Properties.Resources.st_Normal);     //VHF TX의 값으로 VHF RX도 같이 표시
            else
            {
                //if (bdaData.bdaAmpErrTime[1].AddMinutes(30) > DateTime.Now)
                //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                //    SetImage(pbBDA_AMP6, NMS.Properties.Resources.st_Normal);
                //}
                //else
                //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    SetImage(pbBDA_AMP6, NMS.Properties.Resources.st_Error);
                //}
            }

            if (bdaData.bdaAMPSt[3] == 0) SetImage(pbRuBDAAMPSt[3], NMS.Properties.Resources.st_Normal);
            else
            {
                //if (bdaData.bdaAmpErrTime[3].AddMinutes(30) > DateTime.Now)
                //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                //    SetImage(pbRuBDAAMPSt[3], NMS.Properties.Resources.st_Normal);
                //}
                //else
                //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    SetImage(pbRuBDAAMPSt[3], NMS.Properties.Resources.st_Error);
                //}
            }

            for (i = 5; i < 8; i++)
            {
                if (bdaData.bdaAMPSt[i] == 0) SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Normal);
                else
                {
                    //if (bdaData.bdaAmpErrTime[i].AddMinutes(30) > DateTime.Now)
                    //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                    //    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Normal);
                    //}
                    //else
                    //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    //    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Error);
                    //}
                }
            }
            /*
            for (i = 0; i < 8; i++)
            {
                if (bdaData.bdaAMPSt[i] == 0)
                    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Normal);
                else
                    SetImage(pbRuBDAAMPSt[i], NMS.Properties.Resources.st_Error);
            }
            */

            for (i = 0; i < 5; i++)
                SetText(lblAmpDbm[i], bdaData.ampDBM[i].ToString());

            //UPS Bypass
            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //2012년01월04일 Bypass 무조건 정상으로 표시(마석 현장에서 수정)
                SetImage(pbRuBDAUpsSt[0], NMS.Properties.Resources.st_Normal);
            }
            else
            {
                if (bdaData.bdaUpsSt[2] == 0) SetImage(pbRuBDAUpsSt[0], NMS.Properties.Resources.st_Normal);
                else SetImage(pbRuBDAUpsSt[0], NMS.Properties.Resources.st_Error);
            }
            //UPS AC
            if (bdaData.bdaUpsSt[3] == 0) SetImage(pbRuBDAUpsSt[1], NMS.Properties.Resources.st_Normal);
            else
            {
                //if (bdaData.bdaUpsErrTime[3].AddMinutes(30) > DateTime.Now)
                //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                //    SetImage(pbRuBDAUpsSt[1], NMS.Properties.Resources.st_Normal);
                //}
                //else
                //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    SetImage(pbRuBDAUpsSt[1], NMS.Properties.Resources.st_Error);
                //}
            }
            //UPS Battery Low
            if (bdaData.bdaUpsSt[5] == 0) SetImage(pbRuBDAUpsSt[3], NMS.Properties.Resources.st_Normal);
            else
            {
                //if (bdaData.bdaUpsErrTime[5].AddMinutes(30) > DateTime.Now)
                //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                //    SetImage(pbRuBDAUpsSt[3], NMS.Properties.Resources.st_Normal);
                //}
                //else
                //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    SetImage(pbRuBDAUpsSt[3], NMS.Properties.Resources.st_Error);
                //}
            }
            //UPS Fail/UPS Comm Fail
            if (bdaData.bdaUpsSt[4] == 0 && bdaData.bdaUpsSt[6] == 0) SetImage(pbRuBDAUpsSt[2], NMS.Properties.Resources.st_Normal);
            else
            {
                //if (bdaData.bdaUpsErrTime[4].AddMinutes(30) > DateTime.Now)
                //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                //    SetImage(pbRuBDAUpsSt[2], NMS.Properties.Resources.st_Normal);
                //}
                //else
                //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    SetImage(pbRuBDAUpsSt[2], NMS.Properties.Resources.st_Error);
                //}
            }

            //AMP Comm
            if (bdaData.bdaUpsSt[7] == 0) SetImage(pbRuBDAUpsSt[4], NMS.Properties.Resources.st_Normal);
            else
            {
                //if (bdaData.bdaUpsErrTime[7].AddMinutes(30) > DateTime.Now)
                //{   //Error가 발생한지 30분이 안되었으므로 정상처리
                //    SetImage(pbRuBDAUpsSt[4], NMS.Properties.Resources.st_Normal);
                //}
                //else
                //{   //Error가 발생한지 30분이 지났으므로 Error 처리
                    SetImage(pbRuBDAUpsSt[4], NMS.Properties.Resources.st_Error);
                //}
            }
        }

        /// <summary>
        /// RU의 RSSI 값을 VHF RX에 표시한다.
        /// </summary>
        /// <param name="value">VHF RX 값</param>
        public void nmsRUBDA_VHFRX_Display(int value)
        {
            SetText(lblAmpDbm[5], value.ToString());
        }

        private void btBDAInquiry_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!flagInquiry) SetColor(btBDAInquiry, Color.Yellow);
                SetColor(btBDAInquiry, Color.Yellow);
                this.bdaControlClick(bdaID, 0);
            }
            catch
            {
            }
        }

        public void btBDAInquiry_ColorSet()
        {
            if (flagInquiry) SetColor(btBDAInquiry, colorSelect);
            else SetColor(btBDAInquiry, colorBase);
        }

        private void btBDA_LT_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!flagLoopTest) SetColor(btBDA_LT, Color.Yellow);
                SetColor(btBDA_LT, Color.Yellow);
                this.bdaControlClick(bdaID, 1);
            }
            catch
            {
            }
        }

        public void btLoopTest_ColorSet()
        {
            if (flagLoopTest) SetColor(btBDA_LT, colorSelect);
            else SetColor(btBDA_LT, colorBase);
        }
    }
}
