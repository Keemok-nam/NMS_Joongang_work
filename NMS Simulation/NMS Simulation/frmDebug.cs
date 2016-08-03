using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace NMS_Simulation
{
    public partial class frmDebug : Form
    {
        private frmMain fMain;

        #region 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private ArrayList chkBoxRx = new ArrayList();
        private ArrayList chkBoxTx = new ArrayList();

        private ArrayList txtBoxRx = new ArrayList();
        private ArrayList txtBoxTx = new ArrayList();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        public frmDebug()
        {
            InitializeComponent();
        }

        public frmDebug(frmMain f)
            : this()
        {
            fMain = f;

            //private ArrayList chkBoxRx = new ArrayList();
            chkBoxRx.Add(chkRx1); chkBoxRx.Add(chkRx2); chkBoxRx.Add(chkRx3); chkBoxRx.Add(chkRx4); chkBoxRx.Add(chkRx5);
            chkBoxRx.Add(chkRx6); chkBoxRx.Add(chkRx7); chkBoxRx.Add(chkRx8);
            //private ArrayList chkBoxTx = new ArrayList();
            chkBoxTx.Add(chkTx1); chkBoxTx.Add(chkTx2); chkBoxTx.Add(chkTx3); chkBoxTx.Add(chkTx4); chkBoxTx.Add(chkTx5);
            chkBoxTx.Add(tabControl); chkBoxTx.Add(tabControl); chkBoxTx.Add(chkTx8);

            //private ArrayList txtBoxRx = new ArrayList();
            txtBoxRx.Add(txtRx1); txtBoxRx.Add(txtRx2); txtBoxRx.Add(txtRx3); txtBoxRx.Add(txtRx4); txtBoxRx.Add(txtRx5);
            txtBoxRx.Add(txtRx6); txtBoxRx.Add(txtRx7); txtBoxRx.Add(txtRx8);
            //private ArrayList txtBoxTx = new ArrayList();
            txtBoxTx.Add(txtTx1); txtBoxTx.Add(txtTx2); txtBoxTx.Add(txtTx3); txtBoxTx.Add(txtTx4); txtBoxTx.Add(txtTx5);
            txtBoxTx.Add(txtTx6); txtBoxTx.Add(txtTx7); txtBoxTx.Add(txtTx8);

            Debug_Set();
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
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        private void chkBoxASCII_CheckedChanged(object sender, EventArgs e)
        {
            fMain.flagDataViewTypeASCII = chkBoxASCII.Checked;
        }

        private void Debug_Set()
        {
            try
            {
                for (int i = 0; i < clsCommon.CNTMACHINE; i++)
                    clsCommon.flagDebug[i] = false;

                clsCommon.flagDebug[tabControl.SelectedIndex] = true;
            }
            catch
            {
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug_Set();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            Debug_Set();
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clsCommon.CNTMACHINE; i++)
                clsCommon.flagDebug[i] = false;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            SetText((TextBox)txtBoxRx[tabControl.SelectedIndex], "");
            SetText((TextBox)txtBoxTx[tabControl.SelectedIndex], "");
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clsCommon.CNTMACHINE; i++)
                clsCommon.flagDebug[i] = false;

            this.Close();
        }

        private void frmDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            fMain.frmClose(0);
        }

        #region 송수신 Data 출력
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void SetRxData(int index, string s)
        {
            try
            {
                if(((CheckBox)chkBoxRx[index]).Checked)
                    SetTextAppend((TextBox)txtBoxRx[index], s + "\r\n");

                if (chkBoxSave.Checked)     //파일로 저장
                {
                    try
                    {
                        string FilePath = clsCommon.LogPath + DateTime.Now.Year.ToString();
                        if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);

                        string fileName = FilePath + @"\";
                        switch (index)
                        {
                            case clsCommon.NMS: fileName += "NMS_RX_"; break;
                            //case clsCommon.GUI: fileName += "GUI_RX_"; break;
                            //case clsCommon.FingerPrint: fileName += "FP_RX_"; break;
                            //case clsCommon.DCU2: fileName += "DCU2_RX_"; break;
                            //case clsCommon.UDP: fileName += "UDP_RX_"; break;
                            //case clsCommon.UDP_Echelon: fileName += "UDP_Echelon_RX_"; break;
                            //case clsCommon.TCP_Unit: fileName += "TCP_Unit_RX_"; break;
                            //case clsCommon.E1_Unit: fileName += "E1_Unit_RX_"; break;
                        }

                        s = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + s + "\r\n";

                        fileName = fileName + DateTime.Now.ToShortDateString() + ".txt";

                        StreamWriter fw = File.AppendText(fileName);
                        fw.WriteLine(s);
                        fw.Close();
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }

        public void SetTxData(int index, string s)
        {
            try
            {
                if (((CheckBox)chkBoxTx[index]).Checked)
                    SetTextAppend((TextBox)txtBoxTx[index], s + "\r\n");

                if (chkBoxSave.Checked)     //파일로 저장
                {
                    try
                    {
                        string FilePath = clsCommon.LogPath + DateTime.Now.Year.ToString();
                        if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);

                        string fileName = FilePath + @"\";
                        switch (index)
                        {
                            case clsCommon.NMS: fileName += "NMS_TX_"; break;
                            //case clsCommon.GUI: fileName += "GUI_TX_"; break;
                            //case clsCommon.FingerPrint: fileName += "FP_TX_"; break;
                            //case clsCommon.DCU2: fileName += "DCU2_TX_"; break;
                            //case clsCommon.UDP: fileName += "UDP_TX_"; break;
                            //case clsCommon.UDP_Echelon: fileName += "UDP_Echelon_TX_"; break;
                            //case clsCommon.TCP_Unit: fileName += "TCP_Unit_TX_"; break;
                            //case clsCommon.E1_Unit: fileName += "E1_Unit_TX_"; break;
                        }

                        s = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + s + "\r\n";

                        fileName = fileName + DateTime.Now.ToShortDateString() + ".txt";

                        StreamWriter fw = File.AppendText(fileName);
                        fw.WriteLine(s);
                        fw.Close();
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }
}