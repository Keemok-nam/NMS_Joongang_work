namespace NMS
{
    partial class stationSt
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
            this.gbStation = new System.Windows.Forms.GroupBox();
            this.btStation = new System.Windows.Forms.Button();
            this.btSpare = new System.Windows.Forms.Button();
            this.btMain = new System.Windows.Forms.Button();
            this.gbStation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStation
            // 
            this.gbStation.BackColor = System.Drawing.Color.White;
            this.gbStation.Controls.Add(this.btStation);
            this.gbStation.Controls.Add(this.btSpare);
            this.gbStation.Controls.Add(this.btMain);
            this.gbStation.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbStation.Location = new System.Drawing.Point(0, -7);
            this.gbStation.Name = "gbStation";
            this.gbStation.Size = new System.Drawing.Size(270, 127);
            this.gbStation.TabIndex = 98;
            this.gbStation.TabStop = false;
            // 
            // btStation
            // 
            this.btStation.BackColor = System.Drawing.Color.Transparent;
            this.btStation.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btStation.Location = new System.Drawing.Point(6, 17);
            this.btStation.Name = "btStation";
            this.btStation.Size = new System.Drawing.Size(115, 104);
            this.btStation.TabIndex = 104;
            this.btStation.Tag = "0";
            this.btStation.UseVisualStyleBackColor = false;
            this.btStation.Click += new System.EventHandler(this.btStation_Click);
            // 
            // btSpare
            // 
            this.btSpare.BackColor = System.Drawing.Color.Transparent;
            this.btSpare.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSpare.Location = new System.Drawing.Point(127, 71);
            this.btSpare.Name = "btSpare";
            this.btSpare.Size = new System.Drawing.Size(137, 50);
            this.btSpare.TabIndex = 103;
            this.btSpare.Tag = "2";
            this.btSpare.Text = "예비";
            this.btSpare.UseVisualStyleBackColor = false;
            this.btSpare.Click += new System.EventHandler(this.btStation_Click);
            // 
            // btMain
            // 
            this.btMain.BackColor = System.Drawing.Color.Transparent;
            this.btMain.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btMain.Location = new System.Drawing.Point(127, 17);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(137, 50);
            this.btMain.TabIndex = 102;
            this.btMain.Tag = "1";
            this.btMain.Text = "주";
            this.btMain.UseVisualStyleBackColor = false;
            this.btMain.Click += new System.EventHandler(this.btStation_Click);
            // 
            // stationSt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gbStation);
            this.Name = "stationSt";
            this.Size = new System.Drawing.Size(270, 120);
            this.Resize += new System.EventHandler(this.stationSt_Resize);
            this.gbStation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStation;
        private System.Windows.Forms.Button btStation;
        private System.Windows.Forms.Button btSpare;
        private System.Windows.Forms.Button btMain;
    }
}
