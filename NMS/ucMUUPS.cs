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
    public partial class ucMUUPS : UserControl
    {
        public ucMUUPS()
        {
            switch (clsCommon.nmsGUIUser)
            {
                case "경춘선":
                    InitializeComponent();
                    break;

                case "중앙선":
                case "전라선":
                    InitializeComponent_();

                    if (clsCommon.nmsGUIUser == "중앙선") SetEnable(panelMuUPS, false);
                    break;
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
        /// UPS 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="flagAction">활성화/비활성화</param>
        public void UpsStInit(bool flagAction)
        {
            if (clsCommon.nmsGUIUser == "중앙선") return;

            //SetEnable(panelMuUPS, flagAction);
            SetEnable(lblUPS1, flagAction);
            SetEnable(lblUPS2, flagAction);
            SetEnable(lblUPS3, flagAction);
            SetEnable(lblUPS4, flagAction);
            SetEnable(lblUPS5, flagAction);
            SetEnable(lblUPS6, flagAction);
            SetEnable(lblUPS7, flagAction);
            SetEnable(lblUPS8, flagAction);
            SetEnable(lblUPS9, flagAction);
            SetEnable(lblUPS10, flagAction);
            SetEnable(lblUPS11, flagAction);

            SetEnable(lblMUIP, flagAction);
            SetEnable(lblMUFault, flagAction);
            SetEnable(lblMUOP, flagAction);
            SetEnable(lblMUOPCurrent, flagAction);
            SetEnable(lblMUFrequency, flagAction);
            SetEnable(lblMUBattery, flagAction);
            SetEnable(lblMUTemperature, flagAction);

            SetImage(pbMUIP, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUBattery, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUBypass, NMS.Properties.Resources.st_OFF);
            SetImage(pbMUUPS, NMS.Properties.Resources.st_OFF);
            SetEnable(pbMUIP, flagAction);
            SetEnable(pbMUBattery, flagAction);
            SetEnable(pbMUBypass, flagAction);
            SetEnable(pbMUUPS, flagAction);
        }

        /// <summary>
        /// UPS 상태를 표시한다.
        /// </summary>
        public void nmsUPSSt_Display(UPSData upsData)
        {
            if (clsCommon.nmsGUIUser == "중앙선") return;

            if (!lblUPS1.Enabled) UpsStInit(true);

            SetText(lblMUIP, upsData.inVoltage + " V");               //입력전압
            SetText(lblMUFault, upsData.faultVoltage + " V");         //과실전압
            SetText(lblMUOP, upsData.outVoltage + " V");              //출력전압
            SetText(lblMUOPCurrent, upsData.currentPercent + " %");   //출력전류
            SetText(lblMUFrequency, upsData.frequency + " Hz");       //주파수
            SetText(lblMUBattery, upsData.batteryVoltage + " V");     //배터리전압
            SetText(lblMUTemperature, upsData.temperature + " ℃");   //온도

            //UPS 정상/불량
            if (upsData.otherSt[4] == 0) SetImage(pbMUIP, NMS.Properties.Resources.st_Normal);
            else SetImage(pbMUIP, NMS.Properties.Resources.st_Error);

            if (clsCommon.nmsGUIUser == "경춘선")
            {
                //2012년01월05일 Bypass 무조건 정상으로 표시(마석 현장에서 수정)
                SetImage(pbMUBypass, NMS.Properties.Resources.st_Normal);
            }
            else
            {
                //Bypass 상태
                if (upsData.otherSt[5] == 0) SetImage(pbMUBypass, NMS.Properties.Resources.st_Normal);
                else SetImage(pbMUBypass, NMS.Properties.Resources.st_Error);
            }

            //Battery Low(저전압)
            if (upsData.otherSt[6] == 0) SetImage(pbMUBattery, NMS.Properties.Resources.st_Normal);
            else SetImage(pbMUBattery, NMS.Properties.Resources.st_Error);

            //Utility Fail(정전)
            if (upsData.otherSt[7] == 0) SetImage(pbMUUPS, NMS.Properties.Resources.st_Normal);
            else SetImage(pbMUUPS, NMS.Properties.Resources.st_Error);
        }
    }
}
