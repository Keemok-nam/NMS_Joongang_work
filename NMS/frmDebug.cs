using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace NMS
{
    public partial class frmDebug : Form
    {
        #region ��Ʈ�� �迭
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<CheckBox> chkBoxRx = new List<CheckBox>();
        private List<CheckBox> chkBoxTx = new List<CheckBox>();

        private List<TextBox> txtBoxRx = new List<TextBox>();
        private List<TextBox> txtBoxTx = new List<TextBox>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        string strID = string.Empty;
        byte[] tmpID = new byte[2];

        public frmDebug()
        {
            InitializeComponent();

            //private ArrayList chkBoxRx = new ArrayList();
            chkBoxRx.Add(chkRx1); chkBoxRx.Add(chkRx2); chkBoxRx.Add(chkRx3); chkBoxRx.Add(chkRx4); chkBoxRx.Add(chkRx5);
            chkBoxRx.Add(chkRx6); chkBoxRx.Add(chkRx7); chkBoxRx.Add(chkRx8);
            //private ArrayList chkBoxTx = new ArrayList();
            chkBoxTx.Add(chkTx1); chkBoxTx.Add(chkTx2); chkBoxTx.Add(chkTx3); chkBoxTx.Add(chkTx4); chkBoxTx.Add(chkTx5);
            chkBoxTx.Add(chkTx6); chkBoxTx.Add(chkTx7); chkBoxTx.Add(chkTx8);

            //private ArrayList txtBoxRx = new ArrayList();
            txtBoxRx.Add(txtRx1); txtBoxRx.Add(txtRx2); txtBoxRx.Add(txtRx3); txtBoxRx.Add(txtRx4); txtBoxRx.Add(txtRx5);
            txtBoxRx.Add(txtRx6); txtBoxRx.Add(txtRx7); txtBoxRx.Add(txtRx8);
            //private ArrayList txtBoxTx = new ArrayList();
            txtBoxTx.Add(txtTx1); txtBoxTx.Add(txtTx2); txtBoxTx.Add(txtTx3); txtBoxTx.Add(txtTx4); txtBoxTx.Add(txtTx5);
            txtBoxTx.Add(txtTx6); txtBoxTx.Add(txtTx7); txtBoxTx.Add(txtTx8);

            Debug_Set();
        }

        #region ��Ʈ�� ����(�������, Ȱ��ȭ ����, ������)
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        //��Ʈ�ѿ� ���ڸ� ����ϱ� ����
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

        //��Ʈ�ѿ� ���ڸ� ����ϱ� ����
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

                ((TextBox)control).SelectionStart = ((TextBox)control).Text.Length;//�� ������ ����...
                ((TextBox)control).ScrollToCaret();
            }
        }

        //��Ʈ���� Ȱ��ȭ ���θ� �����ϱ� ����
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

        //��Ʈ�ѿ� ���� �����ϱ� ����
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

        //��Ʈ���� ���ڻ��� �����ϱ� ����
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

        //��Ʈ���� Visible���� �����ϱ� ����
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

        //��Ʈ�ѿ� üũ�ϱ� ����
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
            clsCommon.flagDataViewTypeASCII = chkBoxASCII.Checked;
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
            SetText(txtBoxRx[tabControl.SelectedIndex], "");
            SetText(txtBoxTx[tabControl.SelectedIndex], "");
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clsCommon.CNTMACHINE; i++)
                clsCommon.flagDebug[i] = false;

            this.Close();
        }

        public void cbMURUSet(List<string> stationName)
        {
            cbMU.Items.Add("���� ����");
            for (int i = 0; i < stationName.Count; i++)
                cbMU.Items.Add(stationName[i]);

            cbMU.SelectedIndex = 0;
        }

        private void rbOption_CheckedChanged(object sender, EventArgs e)
        {
            SetEnable(gbMU, rbOption2.Checked);
            SetEnable(gbRU, rbOption2.Checked);

            MakeID();
        }

        private void cbMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            cbRU.Items.Clear();
            cbRU.Items.Add("���� ����");

            if (cbMU.SelectedIndex != 0)
            {
                for (i = 0; i < 4; i++)
                    cbRU.Items.Add(clsCommon.muruName[cbMU.SelectedIndex - 1].ruName[i].ruName);
            }

            cbRU.SelectedIndex = 0;

            MakeID();
        }

        private void cbRU_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeID();
        }

        private void MakeID()
        {
            strID = string.Empty;

            if (cbMU.SelectedIndex == 0)
            {
                tmpID[0] = 0;
                tmpID[1] = 0;
            }
            else
            {
                tmpID[0] = (byte)(cbMU.SelectedIndex + 0x40);
                tmpID[1] = (byte)(cbRU.SelectedIndex + 0x30);
            }

            for (int i = 0; i < 2; i++)
                strID += string.Format(" {0:X2}", tmpID[i]);
        }

        #region �ۼ��� Data ���
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        public void SetRxData(int index, string s)
        {
            try
            {
                if (rbOption2.Checked)
                {
                    if (strID != s.Substring(6, 6))
                        return;
                }

                if (((CheckBox)chkBoxRx[index]).Checked)
                    SetTextAppend(txtBoxRx[index], s + "\r\n");

                if (chkBoxSave.Checked)     //���Ϸ� ����
                {
                    try
                    {
                        string FilePath = clsCommon.LogPath + DateTime.Now.Year.ToString();
                        if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);

                        string fileName = FilePath + @"\";
                        switch (index)
                        {
                            case clsCommon.NMS: fileName += "NMS_RX_"; break;
                            case clsCommon.CCE1: fileName += "CCE1_RX_"; break;
                            case clsCommon.CCE2: fileName += "CCE2_RX_"; break;
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
                if (rbOption2.Checked)
                {
                    if (strID != s.Substring(6, 6))
                        return;
                }

                if (((CheckBox)chkBoxTx[index]).Checked)
                    SetTextAppend(txtBoxTx[index], s + "\r\n");

                if (chkBoxSave.Checked)     //���Ϸ� ����
                {
                    try
                    {
                        string FilePath = clsCommon.LogPath + DateTime.Now.Year.ToString();
                        if (!Directory.Exists(FilePath)) Directory.CreateDirectory(FilePath);

                        string fileName = FilePath + @"\";
                        switch (index)
                        {
                            case clsCommon.NMS: fileName += "NMS_TX_"; break;
                            case clsCommon.CCE1: fileName += "CCE1_TX_"; break;
                            case clsCommon.CCE2: fileName += "CCE2_TX_"; break;
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