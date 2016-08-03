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
    public partial class ucBDASourcetel : UserControl
    {
        #region 소스텔의 BDA 감시화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<GroupBox> gbBda = new List<GroupBox>();

        private List<Label> lblFmTemperature = new List<Label>();
        private List<Label> lblFmTssi = new List<Label>();
        private List<PictureBox> pbFmAlarm = new List<PictureBox>();

        private List<PictureBox> pbVhfAcAlarm = new List<PictureBox>();
        private List<PictureBox> pbVhfDcAlarm = new List<PictureBox>();
        private List<PictureBox> pbVhfBatteryAlarm = new List<PictureBox>();
        private List<PictureBox> pbVhfAmp = new List<PictureBox>();
        private List<PictureBox> pbVhfPtt1 = new List<PictureBox>();
        private List<PictureBox> pbVhfPtt2 = new List<PictureBox>();

        private List<PictureBox> pbUhfAcAlarm = new List<PictureBox>();
        private List<PictureBox> pbUhfDcAlarm = new List<PictureBox>();
        private List<PictureBox> pbUhfBatteryAlarm = new List<PictureBox>();
        private List<PictureBox> pbUhfAmp = new List<PictureBox>();
        private List<PictureBox> pbUhfPtt1 = new List<PictureBox>();
        private List<PictureBox> pbUhfPtt2 = new List<PictureBox>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public ucBDASourcetel()
        {
            InitializeComponent();

            #region 소스텔의 BDA 감시화면 컨트롤 배열 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<GroupBox> gbBda = new List<GroupBox>();
            gbBda.Add(gbBda1); gbBda.Add(gbBda2); gbBda.Add(gbBda3);

            //private List<Label> lblFmTemperature = new List<Label>();
            lblFmTemperature.Add(lblFmTemperature1); lblFmTemperature.Add(lblFmTemperature2); lblFmTemperature.Add(lblFmTemperature3);
            //private List<Label> lblFmTssi = new List<Label>();
            lblFmTssi.Add(lblFmTssi1); lblFmTssi.Add(lblFmTssi2); lblFmTssi.Add(lblFmTssi3);
            //private List<PictureBox> pbFmAlarm = new List<PictureBox>();
            pbFmAlarm.Add(pbFmAlarm1); pbFmAlarm.Add(pbFmAlarm2); pbFmAlarm.Add(pbFmAlarm3);

            //private List<PictureBox> pbVhfAcAlarm = new List<PictureBox>();
            pbVhfAcAlarm.Add(pbVhfAc1); pbVhfAcAlarm.Add(pbVhfAc2); pbVhfAcAlarm.Add(pbVhfAc3);
            //private List<PictureBox> pbVhfDcAlarm = new List<PictureBox>();
            pbVhfDcAlarm.Add(pbVhfDc1); pbVhfDcAlarm.Add(pbVhfDc2); pbVhfDcAlarm.Add(pbVhfDc3);
            //private List<PictureBox> pbVhfBatteryAlarm = new List<PictureBox>();
            pbVhfBatteryAlarm.Add(pbVhfBattery1); pbVhfBatteryAlarm.Add(pbVhfBattery2); pbVhfBatteryAlarm.Add(pbVhfBattery3);
            //private List<PictureBox> pbVhfAmp = new List<PictureBox>();
            pbVhfAmp.Add(pbVhfAmp1); pbVhfAmp.Add(pbVhfAmp2); pbVhfAmp.Add(pbVhfAmp3);
            //private List<PictureBox> pbVhfPtt1 = new List<PictureBox>();
            pbVhfPtt1.Add(pbVhfPtt1_1); pbVhfPtt1.Add(pbVhfPtt1_2); pbVhfPtt1.Add(pbVhfPtt1_3);
            //private List<PictureBox> pbVhfPtt2 = new List<PictureBox>();
            pbVhfPtt2.Add(pbVhfPtt2_1); pbVhfPtt2.Add(pbVhfPtt2_2); pbVhfPtt2.Add(pbVhfPtt2_3);

            //private List<PictureBox> pbUhfAcAlarm = new List<PictureBox>();
            pbUhfAcAlarm.Add(pbUhfAc1); pbUhfAcAlarm.Add(pbUhfAc2); pbUhfAcAlarm.Add(pbUhfAc3);
            //private List<PictureBox> pbUhfDcAlarm = new List<PictureBox>();
            pbUhfDcAlarm.Add(pbUhfDc1); pbUhfDcAlarm.Add(pbUhfDc2); pbUhfDcAlarm.Add(pbUhfDc3);
            //private List<PictureBox> pbUhfBatteryAlarm = new List<PictureBox>();
            pbUhfBatteryAlarm.Add(pbUhfBattery1); pbUhfBatteryAlarm.Add(pbUhfBattery2); pbUhfBatteryAlarm.Add(pbUhfBattery3);
            //private List<PictureBox> pbUhfAmp = new List<PictureBox>();
            pbUhfAmp.Add(pbUhfAmp1); pbUhfAmp.Add(pbUhfAmp2); pbUhfAmp.Add(pbUhfAmp3);
            //private List<PictureBox> pbUhfPtt1 = new List<PictureBox>();
            pbUhfPtt1.Add(pbUhfPtt1_1); pbUhfPtt1.Add(pbUhfPtt1_2); pbUhfPtt1.Add(pbUhfPtt1_3);
            //private List<PictureBox> pbUhfPtt2 = new List<PictureBox>();
            pbUhfPtt2.Add(pbUhfPtt2_1); pbUhfPtt2.Add(pbUhfPtt2_2); pbUhfPtt2.Add(pbUhfPtt2_3);
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            #endregion
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
        /// BDA 상태를 초기화(활성화/비활성화)한다.
        /// </summary>
        /// <param name="bdaId">bdaId</param>
        /// <param name="flagAction">활성화/비활성화</param>
        public void StInit(byte bdaId, bool flagAction)
        {
            try
            {
                SetEnable(gbBda[bdaId], flagAction);

                SetImage(pbFmAlarm[bdaId], NMS.Properties.Resources.st_OFF);

                SetImage(pbVhfAcAlarm[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbVhfDcAlarm[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbVhfBatteryAlarm[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbVhfAmp[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbVhfPtt1[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbVhfPtt2[bdaId], NMS.Properties.Resources.st_OFF);

                SetImage(pbUhfAcAlarm[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbUhfDcAlarm[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbUhfBatteryAlarm[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbUhfAmp[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbUhfPtt1[bdaId], NMS.Properties.Resources.st_OFF);
                SetImage(pbUhfPtt2[bdaId], NMS.Properties.Resources.st_OFF);
            }
            catch
            {
            }
        }

        /// <summary>
        /// BDA 상태를 표시한다.
        /// </summary>
        /// <param name="bdaId">bdaId</param>
        /// <param name="bdaInfo">BDA 정보 </param>
        public void nmsSt_Display(byte bdaId, BDA_St bdaInfo)
        {
            if (!gbBda[bdaId].Enabled) StInit(bdaId, true);

            SetText(lblFmTemperature[bdaId], bdaInfo.fmTemperature.ToString());
            SetText(lblFmTssi[bdaId], bdaInfo.fmTssi.ToString());
            if (bdaInfo.fmAlarm == 1) SetImage(pbFmAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbFmAlarm[bdaId], NMS.Properties.Resources.st_Error);

            if (bdaInfo.vhfAcAlarm == 1) SetImage(pbVhfAcAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbVhfAcAlarm[bdaId], NMS.Properties.Resources.st_Error);
            if (bdaInfo.vhfDcAlarm == 1) SetImage(pbVhfDcAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbVhfDcAlarm[bdaId], NMS.Properties.Resources.st_Error);
            if (bdaInfo.vhfBatteryAlarm == 1) SetImage(pbVhfBatteryAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbVhfBatteryAlarm[bdaId], NMS.Properties.Resources.st_Error);
            if (bdaInfo.vhfBypass == 0) SetImage(pbVhfAmp[bdaId], NMS.Properties.Resources.st_Normal);  //정상
            else SetImage(pbVhfAmp[bdaId], NMS.Properties.Resources.st_Error);  //이상
            if (bdaInfo.vhfPtt1 == 1) SetImage(pbVhfPtt1[bdaId], NMS.Properties.Resources.st_ON);   //ON
            else SetImage(pbVhfPtt1[bdaId], NMS.Properties.Resources.st_OFF);   //OFF
            if (bdaInfo.vhfPtt2 == 1) SetImage(pbVhfPtt2[bdaId], NMS.Properties.Resources.st_ON);   //ON
            else SetImage(pbVhfPtt2[bdaId], NMS.Properties.Resources.st_OFF);   //OFF

            if (bdaInfo.uhfAcAlarm == 1) SetImage(pbUhfAcAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbUhfAcAlarm[bdaId], NMS.Properties.Resources.st_Error);
            if (bdaInfo.uhfDcAlarm == 1) SetImage(pbUhfDcAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbUhfDcAlarm[bdaId], NMS.Properties.Resources.st_Error);
            if (bdaInfo.uhfBatteryAlarm == 1) SetImage(pbUhfBatteryAlarm[bdaId], NMS.Properties.Resources.st_Normal);
            else SetImage(pbUhfBatteryAlarm[bdaId], NMS.Properties.Resources.st_Error);
            if (bdaInfo.uhfBypass == 0) SetImage(pbUhfAmp[bdaId], NMS.Properties.Resources.st_Normal);  //정상
            else SetImage(pbUhfAmp[bdaId], NMS.Properties.Resources.st_Error);  //이상
            if (bdaInfo.uhfPtt1 == 1) SetImage(pbUhfPtt1[bdaId], NMS.Properties.Resources.st_ON);   //ON
            else SetImage(pbUhfPtt1[bdaId], NMS.Properties.Resources.st_OFF);   //OFF
            if (bdaInfo.uhfPtt2 == 1) SetImage(pbUhfPtt2[bdaId], NMS.Properties.Resources.st_ON);   //ON
            else SetImage(pbUhfPtt2[bdaId], NMS.Properties.Resources.st_OFF);   //OFF
        }
    }
}
