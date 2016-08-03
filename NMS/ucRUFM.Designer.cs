namespace NMS
{
    partial class ucRUFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRUFM));
            this.panelRuFM = new System.Windows.Forms.Panel();
            this.pbRuFmRf = new System.Windows.Forms.PictureBox();
            this.label241 = new System.Windows.Forms.Label();
            this.pbRuFmPower = new System.Windows.Forms.PictureBox();
            this.lblRuFmRf = new System.Windows.Forms.Label();
            this.lblRuFmPower = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRuFM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuFmRf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuFmPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRuFM
            // 
            this.panelRuFM.Controls.Add(this.pbRuFmRf);
            this.panelRuFM.Controls.Add(this.label241);
            this.panelRuFM.Controls.Add(this.pbRuFmPower);
            this.panelRuFM.Controls.Add(this.lblRuFmRf);
            this.panelRuFM.Controls.Add(this.lblRuFmPower);
            this.panelRuFM.Controls.Add(this.pictureBox1);
            this.panelRuFM.Location = new System.Drawing.Point(0, 0);
            this.panelRuFM.Name = "panelRuFM";
            this.panelRuFM.Size = new System.Drawing.Size(200, 193);
            this.panelRuFM.TabIndex = 237;
            // 
            // pbRuFmRf
            // 
            this.pbRuFmRf.Image = ((System.Drawing.Image)(resources.GetObject("pbRuFmRf.Image")));
            this.pbRuFmRf.Location = new System.Drawing.Point(59, 127);
            this.pbRuFmRf.Name = "pbRuFmRf";
            this.pbRuFmRf.Size = new System.Drawing.Size(20, 20);
            this.pbRuFmRf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRuFmRf.TabIndex = 148;
            this.pbRuFmRf.TabStop = false;
            // 
            // label241
            // 
            this.label241.BackColor = System.Drawing.Color.Blue;
            this.label241.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label241.ForeColor = System.Drawing.Color.White;
            this.label241.Location = new System.Drawing.Point(6, 6);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(188, 34);
            this.label241.TabIndex = 219;
            this.label241.Text = "FM 재방송 장치";
            this.label241.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRuFmPower
            // 
            this.pbRuFmPower.Image = ((System.Drawing.Image)(resources.GetObject("pbRuFmPower.Image")));
            this.pbRuFmPower.Location = new System.Drawing.Point(59, 88);
            this.pbRuFmPower.Name = "pbRuFmPower";
            this.pbRuFmPower.Size = new System.Drawing.Size(20, 20);
            this.pbRuFmPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRuFmPower.TabIndex = 147;
            this.pbRuFmPower.TabStop = false;
            // 
            // lblRuFmRf
            // 
            this.lblRuFmRf.AutoSize = true;
            this.lblRuFmRf.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRuFmRf.Location = new System.Drawing.Point(85, 132);
            this.lblRuFmRf.Name = "lblRuFmRf";
            this.lblRuFmRf.Size = new System.Drawing.Size(40, 13);
            this.lblRuFmRf.TabIndex = 146;
            this.lblRuFmRf.Text = "UNIT";
            this.lblRuFmRf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRuFmPower
            // 
            this.lblRuFmPower.AutoSize = true;
            this.lblRuFmPower.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRuFmPower.Location = new System.Drawing.Point(85, 93);
            this.lblRuFmPower.Name = "lblRuFmPower";
            this.lblRuFmPower.Size = new System.Drawing.Size(60, 13);
            this.lblRuFmPower.TabIndex = 145;
            this.lblRuFmPower.Text = "POWER";
            this.lblRuFmPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 193);
            this.pictureBox1.TabIndex = 223;
            this.pictureBox1.TabStop = false;
            // 
            // ucRUFM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelRuFM);
            this.Name = "ucRUFM";
            this.Size = new System.Drawing.Size(200, 193);
            this.panelRuFM.ResumeLayout(false);
            this.panelRuFM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuFmRf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRuFmPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRuFM;
        private System.Windows.Forms.PictureBox pbRuFmRf;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.PictureBox pbRuFmPower;
        private System.Windows.Forms.Label lblRuFmRf;
        private System.Windows.Forms.Label lblRuFmPower;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
