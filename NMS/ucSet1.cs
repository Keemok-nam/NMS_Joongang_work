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
    public partial class ucSet1 : UserControl
    {
        /// <summary>
        /// 사용자 정의 컨트롤에서의 제어 이벤트
        /// </summary>
        /// <param name="btCode">Click한 버튼 Code</param>
        public event UserControl_Control setControlClick = null;

        #region 설정화면 컨트롤 배열
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private List<TextBox> tbRuName = new List<TextBox>();
        private List<TextBox> tbRcName = new List<TextBox>();
        private List<TextBox> tbBdaName = new List<TextBox>();

        private List<CheckBox> chkRuFm = new List<CheckBox>();
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion        

        public ucSet1()
        {
            InitializeComponent();

            #region 설정화면 컨트롤 배열 초기화
            //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //private List<TextBox> tbRuName = new List<TextBox>();
            tbRuName.Add(tbRuName1); tbRuName.Add(tbRuName2); tbRuName.Add(tbRuName3); tbRuName.Add(tbRuName4);
            //private List<TextBox> tbRcName = new List<TextBox>();
            tbRcName.Add(tbRcName1); tbRcName.Add(tbRcName2); tbRcName.Add(tbRcName3); tbRcName.Add(tbRcName4);
            //private List<TextBox> tbBdaName = new List<TextBox>();
            tbBdaName.Add(tbBDAName1); tbBdaName.Add(tbBDAName2); tbBdaName.Add(tbBDAName3); tbBdaName.Add(tbBDAName4);

            //private List<CheckBox> chkRuFm = new List<CheckBox>();
            chkRuFm.Add(chkRuFM1); chkRuFm.Add(chkRuFM2); chkRuFm.Add(chkRuFM3); chkRuFm.Add(chkRuFM4);
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

        #region MU/RU 이름 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int lbMuRuNameSelectedIndex = 0;

        private void tbMuRuName_TextChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Tag);

            if (index == 0)  //MU Name
                clsCommon.muruName[lbMuRuNameSelectedIndex].muName = ((TextBox)sender).Text;
            else            //RU Name(1~4)
                clsCommon.muruName[lbMuRuNameSelectedIndex].ruName[index - 1].ruName = ((TextBox)sender).Text;
        }

        private void tbMuRcName_TextChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((TextBox)sender).Tag);
            clsCommon.muruName[lbMuRuNameSelectedIndex].rcName[index] = ((TextBox)sender).Text;
        }

        private void lbMuRuName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMuRuNameSelectedIndex = lbMuRuName.SelectedIndex;

            SetText(tbMuName, clsCommon.muruName[lbMuRuNameSelectedIndex].muName);

            for (int i = 0; i < 4; i++)
            {
                SetText(tbRuName[i], clsCommon.muruName[lbMuRuNameSelectedIndex].ruName[i].ruName);
                SetText(tbRcName[i], clsCommon.muruName[lbMuRuNameSelectedIndex].rcName[i]);
            }
        }

        private void btMuRuNameSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("RU이름 및 역사이름을 저장하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            StreamWriter fw = File.CreateText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_MuRuName.txt");

            try
            {
                fw.WriteLine(thisVer);      //버젼 저장

                for (int i = 0; i < muruNowData.Length; i++)
                {
                    fw.WriteLine(clsCommon.muruName[i].muName);

                    for (int j = 0; j < 4; j++) fw.WriteLine(clsCommon.muruName[i].ruName[j].ruName);
                    for (int j = 0; j < 4; j++) fw.WriteLine(clsCommon.muruName[i].rcName[j]);
                }

                AddStatus("MU/RU 이름을 저장하였습니다.");
            }
            catch
            {
                AddStatus("MU/RU 이름을 저장하는데 문제가 발생하였습니다. 확인후 다시 시도하시기 바랍니다.");
            }

            fw.Close();
        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 이름 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private int bdaNameSetMuSelectedIndex = 0;
        private int bdaNameSetRuSelectedIndex = 0;

        //BDA 이름 설정 관련
        private void cbSetupBDANameMU_SelectedIndexChanged(object sender, EventArgs e)
        {
            bdaNameSetMuSelectedIndex = cbSetupBDANameMU.SelectedIndex;

            cbSetupBDANameRU.Items.Clear();
            cbSetupBDANameRU.Items.Add("선택 안함");
            cbSetupBDANameRU.SelectedIndex = 0;

            if (bdaNameSetMuSelectedIndex < 1) return;

            for (int i = 0; i < 4; i++)
                cbSetupBDANameRU.Items.Add(clsCommon.muruName[bdaNameSetMuSelectedIndex - 1].ruName[i].ruName);
        }

        private void cbSetupBDANameRU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            bdaNameSetRuSelectedIndex = cbSetupBDANameRU.SelectedIndex;

            if (bdaNameSetRuSelectedIndex < 1)
            {
                for (i = 0; i < 4; i++)
                    SetText(tbBdaName[i], "");

                return;
            }

            for (i = 0; i < 4; i++)
                SetText(tbBdaName[i], clsCommon.muruName[bdaNameSetMuSelectedIndex - 1].ruName[bdaNameSetRuSelectedIndex - 1].bdaName[i]);
        }

        private void tbBDAName_TextChanged(object sender, EventArgs e)
        {
            if (bdaNameSetRuSelectedIndex < 1) return;

            int index = Convert.ToInt32(((TextBox)sender).Tag);
            clsCommon.muruName[bdaNameSetMuSelectedIndex - 1].ruName[bdaNameSetRuSelectedIndex - 1].bdaName[index] = ((TextBox)sender).Text;
        }

        private void btBdaNameSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BDA이름을 저장하시겠습니까?",
                "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            StreamWriter fw = File.CreateText(clsCommon.DefaultPath + clsCommon.nmsGUIUser + "_BdaName.txt");

            try
            {
                fw.WriteLine(thisVer);      //버젼 저장

                for (int i = 0; i < muruNowData.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                            fw.WriteLine(clsCommon.muruName[i].ruName[j].bdaName[k]);
                    }
                }

                AddStatus("BDA 이름을 저장하였습니다.");
            }
            catch
            {
                AddStatus("BDA 이름을 저장하는데 문제가 발생하였습니다. 확인후 다시 시도하시기 바랍니다.");
            }

            fw.Close();
        }

        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion

        #region BDA 이름 설정 관련
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        private void chkFM_CheckedChanged(object sender, EventArgs e)
        {

        }
        //'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        #endregion
    }
}
