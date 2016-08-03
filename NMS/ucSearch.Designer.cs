namespace NMS
{
    partial class ucSearch
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSearch));
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvError = new System.Windows.Forms.ListView();
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader65 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.rbItem5 = new System.Windows.Forms.RadioButton();
            this.rbItem4 = new System.Windows.Forms.RadioButton();
            this.rbItem3 = new System.Windows.Forms.RadioButton();
            this.rbItem2 = new System.Windows.Forms.RadioButton();
            this.rbItem1 = new System.Windows.Forms.RadioButton();
            this.gbSearchError = new System.Windows.Forms.GroupBox();
            this.cbSearchError = new System.Windows.Forms.ComboBox();
            this.gbSearchBDAID = new System.Windows.Forms.GroupBox();
            this.cbSearchBDAID = new System.Windows.Forms.ComboBox();
            this.gbSearchRUID = new System.Windows.Forms.GroupBox();
            this.cbSearchRUID = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbTerm4 = new System.Windows.Forms.RadioButton();
            this.rbTerm3 = new System.Windows.Forms.RadioButton();
            this.rbTerm2 = new System.Windows.Forms.RadioButton();
            this.rbTerm1 = new System.Windows.Forms.RadioButton();
            this.btExcelSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbWord = new System.Windows.Forms.GroupBox();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.gbSearchMUID = new System.Windows.Forms.GroupBox();
            this.cbSearchMUID = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtSearchStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtSearchStop = new System.Windows.Forms.DateTimePicker();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.gbSearchError.SuspendLayout();
            this.gbSearchBDAID.SuspendLayout();
            this.gbSearchRUID.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbWord.SuspendLayout();
            this.gbSearchMUID.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.lvError);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(695, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(850, 718);
            this.panel6.TabIndex = 12;
            // 
            // lvError
            // 
            this.lvError.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader37,
            this.columnHeader45,
            this.columnHeader56,
            this.columnHeader65});
            this.lvError.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvError.FullRowSelect = true;
            this.lvError.GridLines = true;
            this.lvError.HideSelection = false;
            this.lvError.Location = new System.Drawing.Point(15, 76);
            this.lvError.Name = "lvError";
            this.lvError.Size = new System.Drawing.Size(820, 631);
            this.lvError.TabIndex = 269;
            this.lvError.UseCompatibleStateImageBehavior = false;
            this.lvError.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "순번";
            this.columnHeader37.Width = 100;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "날  자";
            this.columnHeader45.Width = 120;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "시  간";
            this.columnHeader56.Width = 120;
            // 
            // columnHeader65
            // 
            this.columnHeader65.Text = "내     용";
            this.columnHeader65.Width = 600;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(838, 54);
            this.label6.TabIndex = 268;
            this.label6.Text = "검   색   결   과";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.groupBox17);
            this.panel1.Controls.Add(this.gbSearchError);
            this.panel1.Controls.Add(this.gbSearchBDAID);
            this.panel1.Controls.Add(this.gbSearchRUID);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.btExcelSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gbWord);
            this.panel1.Controls.Add(this.gbSearchMUID);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(230, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 718);
            this.panel1.TabIndex = 11;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btClear.Location = new System.Drawing.Point(10, 641);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(211, 65);
            this.btClear.TabIndex = 276;
            this.btClear.Text = "검색내용 지우기";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.rbItem5);
            this.groupBox17.Controls.Add(this.rbItem4);
            this.groupBox17.Controls.Add(this.rbItem3);
            this.groupBox17.Controls.Add(this.rbItem2);
            this.groupBox17.Controls.Add(this.rbItem1);
            this.groupBox17.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox17.Location = new System.Drawing.Point(10, 199);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(433, 100);
            this.groupBox17.TabIndex = 275;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "내역 선택";
            // 
            // rbItem5
            // 
            this.rbItem5.AutoSize = true;
            this.rbItem5.Location = new System.Drawing.Point(162, 62);
            this.rbItem5.Name = "rbItem5";
            this.rbItem5.Size = new System.Drawing.Size(81, 17);
            this.rbItem5.TabIndex = 18;
            this.rbItem5.Text = "운용내역";
            this.rbItem5.UseVisualStyleBackColor = true;
            this.rbItem5.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbItem4
            // 
            this.rbItem4.AutoSize = true;
            this.rbItem4.Location = new System.Drawing.Point(35, 62);
            this.rbItem4.Name = "rbItem4";
            this.rbItem4.Size = new System.Drawing.Size(106, 17);
            this.rbItem4.TabIndex = 17;
            this.rbItem4.Text = "FM 장애내역";
            this.rbItem4.UseVisualStyleBackColor = true;
            this.rbItem4.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbItem3
            // 
            this.rbItem3.AutoSize = true;
            this.rbItem3.Location = new System.Drawing.Point(284, 32);
            this.rbItem3.Name = "rbItem3";
            this.rbItem3.Size = new System.Drawing.Size(115, 17);
            this.rbItem3.TabIndex = 16;
            this.rbItem3.Text = "BDA 장애내역";
            this.rbItem3.UseVisualStyleBackColor = true;
            this.rbItem3.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbItem2
            // 
            this.rbItem2.AutoSize = true;
            this.rbItem2.Location = new System.Drawing.Point(162, 32);
            this.rbItem2.Name = "rbItem2";
            this.rbItem2.Size = new System.Drawing.Size(106, 17);
            this.rbItem2.TabIndex = 15;
            this.rbItem2.Text = "RU 장애내역";
            this.rbItem2.UseVisualStyleBackColor = true;
            this.rbItem2.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbItem1
            // 
            this.rbItem1.AutoSize = true;
            this.rbItem1.Checked = true;
            this.rbItem1.Location = new System.Drawing.Point(35, 32);
            this.rbItem1.Name = "rbItem1";
            this.rbItem1.Size = new System.Drawing.Size(108, 17);
            this.rbItem1.TabIndex = 14;
            this.rbItem1.TabStop = true;
            this.rbItem1.Text = "MU 장애내역";
            this.rbItem1.UseVisualStyleBackColor = true;
            this.rbItem1.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // gbSearchError
            // 
            this.gbSearchError.Controls.Add(this.cbSearchError);
            this.gbSearchError.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSearchError.Location = new System.Drawing.Point(232, 393);
            this.gbSearchError.Name = "gbSearchError";
            this.gbSearchError.Size = new System.Drawing.Size(211, 82);
            this.gbSearchError.TabIndex = 274;
            this.gbSearchError.TabStop = false;
            this.gbSearchError.Text = "고장 내역";
            // 
            // cbSearchError
            // 
            this.cbSearchError.FormattingEnabled = true;
            this.cbSearchError.Location = new System.Drawing.Point(15, 38);
            this.cbSearchError.Name = "cbSearchError";
            this.cbSearchError.Size = new System.Drawing.Size(180, 21);
            this.cbSearchError.TabIndex = 267;
            // 
            // gbSearchBDAID
            // 
            this.gbSearchBDAID.Controls.Add(this.cbSearchBDAID);
            this.gbSearchBDAID.Enabled = false;
            this.gbSearchBDAID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSearchBDAID.Location = new System.Drawing.Point(10, 393);
            this.gbSearchBDAID.Name = "gbSearchBDAID";
            this.gbSearchBDAID.Size = new System.Drawing.Size(211, 82);
            this.gbSearchBDAID.TabIndex = 273;
            this.gbSearchBDAID.TabStop = false;
            this.gbSearchBDAID.Text = "BDA 선택";
            // 
            // cbSearchBDAID
            // 
            this.cbSearchBDAID.FormattingEnabled = true;
            this.cbSearchBDAID.Location = new System.Drawing.Point(15, 38);
            this.cbSearchBDAID.Name = "cbSearchBDAID";
            this.cbSearchBDAID.Size = new System.Drawing.Size(180, 21);
            this.cbSearchBDAID.TabIndex = 267;
            // 
            // gbSearchRUID
            // 
            this.gbSearchRUID.Controls.Add(this.cbSearchRUID);
            this.gbSearchRUID.Enabled = false;
            this.gbSearchRUID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSearchRUID.Location = new System.Drawing.Point(232, 305);
            this.gbSearchRUID.Name = "gbSearchRUID";
            this.gbSearchRUID.Size = new System.Drawing.Size(211, 82);
            this.gbSearchRUID.TabIndex = 272;
            this.gbSearchRUID.TabStop = false;
            this.gbSearchRUID.Text = "RU 선택";
            // 
            // cbSearchRUID
            // 
            this.cbSearchRUID.FormattingEnabled = true;
            this.cbSearchRUID.Location = new System.Drawing.Point(15, 38);
            this.cbSearchRUID.Name = "cbSearchRUID";
            this.cbSearchRUID.Size = new System.Drawing.Size(180, 21);
            this.cbSearchRUID.TabIndex = 267;
            this.cbSearchRUID.SelectedIndexChanged += new System.EventHandler(this.cbSearchRUID_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbTerm4);
            this.groupBox6.Controls.Add(this.rbTerm3);
            this.groupBox6.Controls.Add(this.rbTerm2);
            this.groupBox6.Controls.Add(this.rbTerm1);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(232, 93);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 100);
            this.groupBox6.TabIndex = 271;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "기  간";
            // 
            // rbTerm4
            // 
            this.rbTerm4.AutoSize = true;
            this.rbTerm4.Location = new System.Drawing.Point(116, 59);
            this.rbTerm4.Name = "rbTerm4";
            this.rbTerm4.Size = new System.Drawing.Size(61, 17);
            this.rbTerm4.TabIndex = 7;
            this.rbTerm4.Text = "1개월";
            this.rbTerm4.UseVisualStyleBackColor = true;
            this.rbTerm4.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // rbTerm3
            // 
            this.rbTerm3.AutoSize = true;
            this.rbTerm3.Location = new System.Drawing.Point(33, 59);
            this.rbTerm3.Name = "rbTerm3";
            this.rbTerm3.Size = new System.Drawing.Size(67, 17);
            this.rbTerm3.TabIndex = 6;
            this.rbTerm3.Text = "일주일";
            this.rbTerm3.UseVisualStyleBackColor = true;
            this.rbTerm3.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // rbTerm2
            // 
            this.rbTerm2.AutoSize = true;
            this.rbTerm2.Location = new System.Drawing.Point(116, 30);
            this.rbTerm2.Name = "rbTerm2";
            this.rbTerm2.Size = new System.Drawing.Size(52, 17);
            this.rbTerm2.TabIndex = 5;
            this.rbTerm2.Text = "3 일";
            this.rbTerm2.UseVisualStyleBackColor = true;
            this.rbTerm2.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // rbTerm1
            // 
            this.rbTerm1.AutoSize = true;
            this.rbTerm1.Checked = true;
            this.rbTerm1.Location = new System.Drawing.Point(33, 30);
            this.rbTerm1.Name = "rbTerm1";
            this.rbTerm1.Size = new System.Drawing.Size(52, 17);
            this.rbTerm1.TabIndex = 4;
            this.rbTerm1.TabStop = true;
            this.rbTerm1.Text = "1 일";
            this.rbTerm1.UseVisualStyleBackColor = true;
            this.rbTerm1.CheckedChanged += new System.EventHandler(this.rbTerm_CheckedChanged);
            // 
            // btExcelSave
            // 
            this.btExcelSave.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btExcelSave.Location = new System.Drawing.Point(10, 569);
            this.btExcelSave.Name = "btExcelSave";
            this.btExcelSave.Size = new System.Drawing.Size(211, 65);
            this.btExcelSave.TabIndex = 269;
            this.btExcelSave.Text = "검색내용 엑셀 파일로 저장";
            this.btExcelSave.UseVisualStyleBackColor = true;
            this.btExcelSave.Click += new System.EventHandler(this.btExcelSave_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 54);
            this.label5.TabIndex = 268;
            this.label5.Text = "검 색 조 건";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbWord
            // 
            this.gbWord.Controls.Add(this.tbWord);
            this.gbWord.Enabled = false;
            this.gbWord.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbWord.Location = new System.Drawing.Point(10, 481);
            this.gbWord.Name = "gbWord";
            this.gbWord.Size = new System.Drawing.Size(211, 82);
            this.gbWord.TabIndex = 267;
            this.gbWord.TabStop = false;
            this.gbWord.Text = "검색어";
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(15, 37);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(180, 22);
            this.tbWord.TabIndex = 266;
            // 
            // gbSearchMUID
            // 
            this.gbSearchMUID.Controls.Add(this.cbSearchMUID);
            this.gbSearchMUID.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSearchMUID.Location = new System.Drawing.Point(10, 305);
            this.gbSearchMUID.Name = "gbSearchMUID";
            this.gbSearchMUID.Size = new System.Drawing.Size(211, 82);
            this.gbSearchMUID.TabIndex = 2;
            this.gbSearchMUID.TabStop = false;
            this.gbSearchMUID.Text = "MU 선택";
            // 
            // cbSearchMUID
            // 
            this.cbSearchMUID.FormattingEnabled = true;
            this.cbSearchMUID.Location = new System.Drawing.Point(15, 38);
            this.cbSearchMUID.Name = "cbSearchMUID";
            this.cbSearchMUID.Size = new System.Drawing.Size(180, 21);
            this.cbSearchMUID.TabIndex = 267;
            this.cbSearchMUID.SelectedIndexChanged += new System.EventHandler(this.cbSearchMUID_SelectedIndexChanged);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSearch.Location = new System.Drawing.Point(232, 481);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(211, 226);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "검 색";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtSearchStart);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtSearchStop);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(10, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색 시간";
            // 
            // dtSearchStart
            // 
            this.dtSearchStart.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtSearchStart.Location = new System.Drawing.Point(14, 31);
            this.dtSearchStart.Name = "dtSearchStart";
            this.dtSearchStart.Size = new System.Drawing.Size(140, 22);
            this.dtSearchStart.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(161, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "까지";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(161, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "부터";
            // 
            // dtSearchStop
            // 
            this.dtSearchStop.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtSearchStop.Location = new System.Drawing.Point(14, 58);
            this.dtSearchStop.Name = "dtSearchStop";
            this.dtSearchStop.Size = new System.Drawing.Size(140, 22);
            this.dtSearchStop.TabIndex = 19;
            // 
            // ucSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(1774, 781);
            this.Load += new System.EventHandler(this.ucSearch_Load);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.gbSearchError.ResumeLayout(false);
            this.gbSearchBDAID.ResumeLayout(false);
            this.gbSearchRUID.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbWord.ResumeLayout(false);
            this.gbWord.PerformLayout();
            this.gbSearchMUID.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lvError;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader56;
        private System.Windows.Forms.ColumnHeader columnHeader65;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton rbItem5;
        private System.Windows.Forms.RadioButton rbItem4;
        private System.Windows.Forms.RadioButton rbItem3;
        private System.Windows.Forms.RadioButton rbItem2;
        private System.Windows.Forms.RadioButton rbItem1;
        private System.Windows.Forms.GroupBox gbSearchError;
        private System.Windows.Forms.ComboBox cbSearchError;
        private System.Windows.Forms.GroupBox gbSearchBDAID;
        private System.Windows.Forms.ComboBox cbSearchBDAID;
        private System.Windows.Forms.GroupBox gbSearchRUID;
        private System.Windows.Forms.ComboBox cbSearchRUID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbTerm4;
        private System.Windows.Forms.RadioButton rbTerm3;
        private System.Windows.Forms.RadioButton rbTerm2;
        private System.Windows.Forms.RadioButton rbTerm1;
        private System.Windows.Forms.Button btExcelSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbWord;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.GroupBox gbSearchMUID;
        private System.Windows.Forms.ComboBox cbSearchMUID;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtSearchStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtSearchStop;
    }
}
