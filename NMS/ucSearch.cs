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
    /// <param name="kind">검색 구분</param>
    /// <param name="errKind">검색할 Error 항목</param>
    /// <param name="searchWord">검색 단어</param>
    /// <param name="startTime">검색 시간 범위(시작)</param>
    /// <param name="stopTime">검색 시간 범위(종료)</param>
    public delegate void UserControl_Search(int muID, int ruID, int bdaID, int kind, int errKind, string searchWord, DateTime startDateTime, DateTime stopDateTime);

    public partial class ucSearch : UserControl
    {
        public event UserControl_Search searchClick = null;

        public ucSearch()
        {
            InitializeComponent();
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
            //운용정보 저장/검색 관련 DB 초기화
            ImageList dummyImageSearch = new ImageList();
            dummyImageSearch.ImageSize = new System.Drawing.Size(1, 25);

            lvError.SmallImageList = dummyImageSearch;    //운용정보 ListView의 높이설정
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

        public void ucSearch_Init(List<String> stationList)
        {
            cbSearchRUID.Items.Add("선택 안함");    //검색화면의 RU 선택
            cbSearchBDAID.Items.Add("선택 안함");   //검색화면의 BDA 선택

            for (int i = 0; i < stationList.Count; i++)
            {
                cbSearchMUID.Items.Add(stationList[i].ToString());  //검색화면의 MU
            }

            cbSearchMUID.SelectedIndex = 0;
        }

        public byte searchIndex = 0;
        private void rbItem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(rbItem1)) searchIndex = 0;
            else if (sender.Equals(rbItem2)) searchIndex = 1;
            else if (sender.Equals(rbItem3)) searchIndex = 2;
            else if (sender.Equals(rbItem4)) searchIndex = 3;
            else if (sender.Equals(rbItem5)) searchIndex = 4;

            switch (searchIndex)
            {
                case 0:     //MU
                    SetEnable(gbSearchMUID, true);
                    SetEnable(gbSearchRUID, false);
                    SetEnable(gbSearchBDAID, false);
                    SetEnable(gbSearchError, true);
                    SetEnable(gbWord, false);
                    break;

                case 1:     //RU
                    SetEnable(gbSearchMUID, true);
                    SetEnable(gbSearchRUID, true);
                    SetEnable(gbSearchBDAID, false);
                    SetEnable(gbSearchError, true);
                    SetEnable(gbWord, false);
                    break;

                case 2:     //BDA
                case 3:     //FM
                    SetEnable(gbSearchMUID, true);
                    SetEnable(gbSearchRUID, true);
                    SetEnable(gbSearchBDAID, true);
                    SetEnable(gbSearchError, true);
                    SetEnable(gbWord, false);
                    break;

                case 4:     //운용내역
                    SetEnable(gbSearchMUID, false);
                    SetEnable(gbSearchRUID, false);
                    SetEnable(gbSearchBDAID, false);
                    SetEnable(gbSearchError, false);
                    SetEnable(gbWord, true);
                    break;
            }

            ErrorItemInput(searchIndex);
        }

        public void ErrorItemInput(int kind)
        {
            cbSearchError.Items.Clear();
            SetText(cbSearchError, "");

            for (int i = 0; i < clsCommon.errContent[kind].errContent.Count; i++)
                cbSearchError.Items.Add(clsCommon.errContent[kind].errContent[i]);

            try { cbSearchError.SelectedIndex = 0; }
            catch { }
        }

        private void rbTerm_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            int index = 0;

            if (sender.Equals(rbTerm1)) index = 0;
            else if (sender.Equals(rbTerm2)) index = 1;
            else if (sender.Equals(rbTerm3)) index = 2;
            else if (sender.Equals(rbTerm4)) index = 3;

            switch (index)
            {
                case 0:     //1일
                    //dtSearchStart.Value = DateTime.Now;
                    //dtSearchStop.Value = DateTime.Now;
                    dtSearchStop.Value = dtSearchStart.Value;
                    break;

                case 1:     //3일
                    //dtSearchStart.Value = DateTime.Now.AddDays(-3);
                    //dtSearchStop.Value = DateTime.Now;
                    dtSearchStop.Value = dtSearchStart.Value.AddDays(3);
                    break;

                case 2:     //일주일
                    //dtSearchStart.Value = DateTime.Now.AddDays(-7);
                    //dtSearchStop.Value = DateTime.Now;
                    dtSearchStop.Value = dtSearchStart.Value.AddDays(7);
                    break;

                case 3:     //한달
                    //dtSearchStart.Value = DateTime.Now.AddMonths(-1);
                    //dtSearchStop.Value = DateTime.Now;
                    dtSearchStop.Value = dtSearchStart.Value.AddMonths(1);
                    break;
            }
        }

        private void cbSearchMUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmpMuID = cbSearchMUID.SelectedIndex;

            cbSearchRUID.Items.Clear();
            cbSearchRUID.Items.Add("선택 안함");
            cbSearchRUID.SelectedIndex = 0;

            for (int i = 0; i < 4; i++)
                cbSearchRUID.Items.Add(clsCommon.muruName[tmpMuID].ruName[i].ruName);

            cbSearchBDAID.Items.Clear();
            cbSearchBDAID.Items.Add("선택 안함");
            cbSearchBDAID.SelectedIndex = 0;
        }

        private void cbSearchRUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmpRuID = cbSearchRUID.SelectedIndex;

            cbSearchBDAID.Items.Clear();
            cbSearchBDAID.Items.Add("선택 안함");
            cbSearchBDAID.SelectedIndex = 0;

            if (tmpRuID < 1) return;

            for (int i = 0; i < 4; i++)
                cbSearchBDAID.Items.Add(clsCommon.muruName[cbSearchMUID.SelectedIndex].ruName[tmpRuID - 1].bdaName[i]);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //검색할 날자/시간
            int intYear = dtSearchStart.Value.Year;
            int intMonth = dtSearchStart.Value.Month;
            int intDay = dtSearchStart.Value.Day;
            DateTime startDateTime = new DateTime(intYear, intMonth, intDay);

            intYear = dtSearchStop.Value.Year;
            intMonth = dtSearchStop.Value.Month;
            intDay = dtSearchStop.Value.Day;
            DateTime stopDateTime = new DateTime(intYear, intMonth, intDay);

            this.searchClick(cbSearchMUID.SelectedIndex + 1, cbSearchRUID.SelectedIndex, cbSearchBDAID.SelectedIndex, searchIndex, cbSearchError.SelectedIndex, tbWord.Text, startDateTime, stopDateTime);
                                                                                                                                  
        }

        private void btExcelSave_Click(object sender, EventArgs e)
        {
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ListViewClear();
        }

        public void ListViewInsert(int index, ListViewItem tmpLV)
        {
            SetListViewItemInster(lvError, index, tmpLV);
        }        

        public void ListViewClear()
        {
            SetListViewItemClear(lvError);
        }

        public string GetSearchWord()
        {
            return tbWord.Text;
        }
    }
}
