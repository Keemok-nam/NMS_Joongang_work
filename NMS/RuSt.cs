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
    public partial class RuSt : UserControl
    {
        public event ButtonClickEvent ClickEvent = null;
        public int MyID;

        private Color colorSelect = new Color();    //선택 색
        private Color colorError = new Color();    //선택 색
        private Color colorBase = new Color();      //기본 색

        private double rateX = 0;
        private double rateY = 0;

        private double baseX = 135.0;
        private double baseY = 120.0;

        private Point ptBTStation = new Point();
        private Point ptBTMain = new Point();
        private Point ptBTSpare = new Point();

        private bool flagBtStationColor = new bool();

        public RuSt()
        {
            InitializeComponent();

            colorSelect = Color.Lime;
            colorError = Color.Red;
            colorBase = Color.Transparent;

            ptBTStation.X = 123; ptBTStation.Y = 50;
            ptBTMain.X = 123; ptBTMain.Y = 30;
            ptBTSpare.X = 123; ptBTSpare.Y = 30;
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

        private void RuSt_Resize(object sender, EventArgs e)
        {
            //              left    top     width   height
            // Base            0      0       135      120
            // gbStation       0     -7       135      127
            // btStation       6     13       123       50
            // btMain          6     64       123       30
            // btSpare         6     95       123       30
            //
            // 135 : 1 = 변경된 크기 : rate_X ==> rate_X = 변경된 크기 / 135
            // 120 : 1 = 변경된 크기 : rate_Y ==> rate_Y = 변경된 크기 / 120

            if (this.Width < 90) this.Width = 90;
            if (this.Height < 80) this.Height = 80;

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

            btStation.Left = (gbStation.Width - btStation.Width) / 2;
            btStation.Top = (gbStation.Height - (btStation.Height + btMain.Height + btSpare.Height)) / 2 + 4;

            btMain.Left = btStation.Left;
            btMain.Top = btStation.Top + btStation.Height;

            btSpare.Left = btMain.Left;
            btSpare.Top = btMain.Top + btMain.Height;
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
            else if (mainSpareValue == 1)
            {
                SetColor(btMain, colorBase);
                SetColor(btSpare, colorSelect);
            }
            else if (mainSpareValue == 2)
            {
                SetColor(btStation, colorBase);
                SetColor(btMain, colorBase);
                SetColor(btSpare, colorBase);
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
            flagBtStationColor = !flagBtStationColor;

            if (flagBtStationColor) SetColor(btStation, colorError);
            else SetColor(btStation, colorBase);
            */

            SetColor(btStation, colorBase);
            SetColor(btSpare, colorBase);
            SetColor(btMain, colorBase);
        }

        private void btStation_Click(object sender, EventArgs e)
        {
            if (this.ClickEvent != null)
                this.ClickEvent(MyID);
        }
    }
}
