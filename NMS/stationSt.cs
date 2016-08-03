using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace NMS
{
    public delegate void ButtonClickEvent(int MyID);

    public partial class stationSt : UserControl
    {
        public event ButtonClickEvent ClickEvent = null;
        public int MyID;

        public bool flagAlarmSet = false;

        private Color colorSelect = new Color();    //선택 색
        private Color colorError = new Color();    //선택 색
        private Color colorBase = new Color();      //기본 색

        private  double rateX = 0;
        private double rateY = 0;

        private double baseX = 270.0;
        private double baseY = 120.0;

        private Point ptBTStation = new Point();
        private Point ptBTMain = new Point();
        private Point ptBTSpare = new Point();

        public stationSt()
        {
            InitializeComponent();

            colorSelect = Color.Lime;
            colorError = Color.Red;
            colorBase = Color.Transparent;

            //각 컨트롤의 크기
            ptBTStation.X = 115; ptBTStation.Y = 104;
            ptBTMain.X = 137; ptBTMain.Y = 50;
            ptBTSpare.X = 137; ptBTSpare.Y = 50;
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
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void stationSt_Resize(object sender, EventArgs e)
        {
            //              left    top     width   height
            // Base            0      0       270      120
            // gbStation       0     -7       270      127
            // btStation       6     17       115      104
            // btMain        127     17       137       50
            // btSpare       127     71       137       50
            //
            // 180 : 1 = 변경된 크기 : rate_X ==> rate_X = 변경된 크기 / 270
            //  80 : 1 = 변경된 크기 : rate_Y ==> rate_Y = 변경된 크기 / 120
            
            if (this.Width < 100) this.Width = 100;
            if (this.Height < 50) this.Height = 50;

            rateX = this.Width / (double)baseX;
            rateY = this.Height / (double)baseY;

            gbStation.Width = this.Width;
            gbStation.Height = this.Height + 7;

            btStation.Width = (int)(ptBTStation.X * rateX);
            btStation.Height = (int)(ptBTStation.Y * rateY);

            btMain.Width = (int)(ptBTMain.X * rateX);
            btMain.Height = (int)(ptBTMain.Y * rateY);

            btSpare.Width = (int)(ptBTSpare.X * rateX);
            btSpare.Height = (int)(ptBTSpare.Y * rateY);

            btStation.Left = (gbStation.Width - (btStation.Width + btMain.Width + 3)) / 2;
            btStation.Top = (gbStation.Height - btStation.Height) / 2 + 5;

            btMain.Top = btStation.Top;
            btSpare.Top = (int)(btStation.Top + btStation.Height / 2 + 3);

            btMain.Left = (int)(btStation.Left + btStation.Width + 4);
            btSpare.Left = btMain.Left;
        }

        public void AlarmSet(bool flagAlarm)
        {
            flagAlarmSet = flagAlarm;

            if (flagAlarmSet)
            {
                SetText(btMain, "경보설정");
                SetText(btSpare, "경보해제");

                if (clsCommon.flagStationAlarm[MyID])
                {
                    SetColor(btStation, colorSelect);   //경보설정
                    SetColor(btMain, colorSelect);
                }
            }
            else
            {
                SetText(btMain, "주");
                SetText(btSpare, "예비");
            }
        }

        public void SetStationName(string name)
        {
            SetText(btStation, name);
        }

        public void SetMainSpareChange(byte mainSpareValue)
        {
            if (mainSpareValue == 0)
            {
                SetColor(btMain, colorSelect);
                SetColor(btSpare, colorBase);
            }
            else
            {
                SetColor(btMain, colorBase);
                SetColor(btSpare, colorSelect);
            }
        }

        public void SetErrorDisplay(int result)
        {
            if (result == 0) SetColor(btStation, colorSelect);
            else SetColor(btStation, colorError);
        }

        public void SetCommErrorDisplay()
        {
            /*
            if (btStation.BackColor == colorBase) SetColor(btStation, colorError);
            else SetColor(btStation, colorBase);
            */

            SetColor(btStation, colorBase);
            SetColor(btSpare, colorBase);
            SetColor(btMain, colorBase);
        }

        private void btStation_Click(object sender, EventArgs e)
        {
            if (flagAlarmSet)
            {
                int index = Convert.ToInt16(((Button)sender).Tag);

                switch (index)
                {
                    case 0:
                        return;

                    case 1:     //경보설정
                        clsCommon.flagStationAlarm[MyID] = true;
                        SetColor(btMain, colorSelect);
                        SetColor(btStation, colorSelect);
                        break;

                    case 2:     //경보해제
                        clsCommon.flagStationAlarm[MyID] = false;
                        SetColor(btMain, colorBase);
                        SetColor(btStation, colorBase);
                        break;
                }

                try
                {
                    StreamWriter fw = File.CreateText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_AlarmSetup.txt");

                    for (int i = 0; i < clsCommon.stationCount; i++)
                        fw.WriteLine(clsCommon.flagStationAlarm[i]);

                    fw.Close();
                }
                catch
                {
                }
            }
            else
            {
                if (this.ClickEvent != null)
                    this.ClickEvent(MyID);
            }
        }
    }
}
