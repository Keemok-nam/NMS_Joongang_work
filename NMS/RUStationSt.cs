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
    public delegate void ButtonClickEvent(int MyID);

    public partial class stationSt : UserControl
    {
        public event ButtonClickEvent ClickEvent = null;
        public int MyID;

        private  double rateX = 0;
        private double rateY = 0;

        private double baseX = 180.0;
        private double baseY = 80.0;

        private Point[] ptBTStation = new Point[2];
        private Point[] ptBTMain = new Point[2];
        private Point[] ptBTSpare = new Point[2];
        private Point[] ptPBMain = new Point[2];
        private Point[] ptPBSpare = new Point[2];

        public stationSt()
        {
            InitializeComponent();

            ptBTStation[1].X = 6; ptBTStation[1].Y = 17;    //위치
            ptBTStation[0].X = 70; ptBTStation[0].Y = 60;   //크기

            ptBTMain[1].X = 101; ptBTMain[1].Y = 7;     //위치
            ptBTMain[0].X = 70; ptBTMain[0].Y = 30;     //크기

            ptBTSpare[1].X = 101; ptBTSpare[1].Y = 48;  //위치
            ptBTSpare[0].X = 70; ptBTSpare[0].Y = 30;   //크기

            ptPBMain[1].X = 78; ptPBMain[1].Y = 22;     //위치
            ptPBMain[0].X = 20; ptPBMain[0].Y = 20;     //크기

            ptPBSpare[1].X = 78; ptPBSpare[1].Y = 53;   //위치
            ptPBSpare[0].X = 20; ptPBSpare[0].Y = 20;   //크기
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
            // Base            0      0       180       80
            // gbStation       0     -7       180       87
            // btStation       6     17        70       60
            // btMain        101      7        70       30
            // btSpare       101     48        70       30
            // pbMain         79     22        20       20
            // pbSpare        79     53        20       20        
            //
            // 180 : 1 = 변경된 크기 : rate_X ==> rate_X = 변경된 크기 / 180
            //  80 : 1 = 변경된 크기 : rate_Y ==> rate_Y = 변경된 크기 /  80
            
            if (this.Width < 100) this.Width = 100;
            if (this.Height < 50) this.Height = 50;

            rateX = this.Width / (double)baseX;
            rateY = this.Height / (double)baseY;

            gbStation.Width = this.Width;
            gbStation.Height = this.Height + 7;

            btStation.Width = (int)(ptBTStation[0].X * rateX);
            btStation.Height = (int)(ptBTStation[0].Y * rateY);

            btMain.Width = (int)(ptBTMain[0].X * rateX);
            btMain.Height = (int)(ptBTMain[0].Y * rateY);

            btSpare.Width = (int)(ptBTSpare[0].X * rateX);
            btSpare.Height = (int)(ptBTSpare[0].Y * rateY);

            pbMain.Width = (int)(ptPBMain[0].X * rateX);
            pbMain.Height = (int)(ptPBMain[0].Y * rateY);

            pbSpare.Width = (int)(ptPBSpare[0].X * rateX);
            pbSpare.Height = (int)(ptPBSpare[0].Y * rateY);

            btStation.Left = (gbStation.Width - (btStation.Width + btMain.Width + pbMain.Width + 7)) / 2;
            btStation.Top = (gbStation.Height - btStation.Height) / 2 + 5;

            btMain.Top = btStation.Top;
            btSpare.Top = (int)(btStation.Top + btStation.Height / 2 + 3);

            pbMain.Left = (int)(btStation.Left + btStation.Width + 5);
            pbMain.Top = btMain.Top + (btMain.Height - pbMain.Height) / 2;

            pbSpare.Left = pbMain.Left;
            pbSpare.Top = btSpare.Top + (btSpare.Height - pbSpare.Height) / 2;

            btMain.Left = (int)(pbMain.Left + pbMain.Width + 4);
            btSpare.Left = btMain.Left;
        }

        public void SetStationName(string name)
        {
            SetText(btStation, name);
        }

        private void btStation_Click(object sender, EventArgs e)
        {
            if (this.ClickEvent != null)
                this.ClickEvent(MyID);
        }
    }
}
