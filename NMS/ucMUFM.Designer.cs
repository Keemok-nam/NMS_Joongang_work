namespace NMS
{
    partial class ucMUFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMUFM));
            this.panelMuFM = new System.Windows.Forms.Panel();
            this.pbMuFmRf = new System.Windows.Forms.PictureBox();
            this.label228 = new System.Windows.Forms.Label();
            this.pbMuFmPower = new System.Windows.Forms.PictureBox();
            this.lblMuFmRf = new System.Windows.Forms.Label();
            this.lblMuFmPower = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMuFM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuFmRf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuFmPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMuFM
            // 
            this.panelMuFM.Controls.Add(this.pbMuFmRf);
            this.panelMuFM.Controls.Add(this.label228);
            this.panelMuFM.Controls.Add(this.pbMuFmPower);
            this.panelMuFM.Controls.Add(this.lblMuFmRf);
            this.panelMuFM.Controls.Add(this.lblMuFmPower);
            this.panelMuFM.Controls.Add(this.pictureBox1);
            this.panelMuFM.Location = new System.Drawing.Point(0, 0);
            this.panelMuFM.Name = "panelMuFM";
            this.panelMuFM.Size = new System.Drawing.Size(274, 180);
            this.panelMuFM.TabIndex = 227;
            // 
            // pbMuFmRf
            // 
            this.pbMuFmRf.Image = ((System.Drawing.Image)(resources.GetObject("pbMuFmRf.Image")));
            this.pbMuFmRf.Location = new System.Drawing.Point(96, 130);
            this.pbMuFmRf.Name = "pbMuFmRf";
            this.pbMuFmRf.Size = new System.Drawing.Size(20, 20);
            this.pbMuFmRf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMuFmRf.TabIndex = 152;
            this.pbMuFmRf.TabStop = false;
            // 
            // label228
            // 
            this.label228.BackColor = System.Drawing.Color.Blue;
            this.label228.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label228.ForeColor = System.Drawing.Color.White;
            this.label228.Location = new System.Drawing.Point(6, 6);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(262, 54);
            this.label228.TabIndex = 221;
            this.label228.Text = "FM 재방송 장치";
            this.label228.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMuFmPower
            // 
            this.pbMuFmPower.Image = ((System.Drawing.Image)(resources.GetObject("pbMuFmPower.Image")));
            this.pbMuFmPower.Location = new System.Drawing.Point(96, 94);
            this.pbMuFmPower.Name = "pbMuFmPower";
            this.pbMuFmPower.Size = new System.Drawing.Size(20, 20);
            this.pbMuFmPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMuFmPower.TabIndex = 151;
            this.pbMuFmPower.TabStop = false;
            // 
            // lblMuFmRf
            // 
            this.lblMuFmRf.AutoSize = true;
            this.lblMuFmRf.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMuFmRf.Location = new System.Drawing.Point(122, 135);
            this.lblMuFmRf.Name = "lblMuFmRf";
            this.lblMuFmRf.Size = new System.Drawing.Size(40, 13);
            this.lblMuFmRf.TabIndex = 150;
            this.lblMuFmRf.Text = "UNIT";
            this.lblMuFmRf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMuFmPower
            // 
            this.lblMuFmPower.AutoSize = true;
            this.lblMuFmPower.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMuFmPower.Location = new System.Drawing.Point(122, 99);
            this.lblMuFmPower.Name = "lblMuFmPower";
            this.lblMuFmPower.Size = new System.Drawing.Size(60, 13);
            this.lblMuFmPower.TabIndex = 149;
            this.lblMuFmPower.Text = "POWER";
            this.lblMuFmPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 180);
            this.pictureBox1.TabIndex = 222;
            this.pictureBox1.TabStop = false;
            // 
            // ucMUFM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMuFM);
            this.Name = "ucMUFM";
            this.Size = new System.Drawing.Size(274, 180);
            this.panelMuFM.ResumeLayout(false);
            this.panelMuFM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuFmRf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuFmPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMuFM;
        private System.Windows.Forms.PictureBox pbMuFmRf;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.PictureBox pbMuFmPower;
        private System.Windows.Forms.Label lblMuFmRf;
        private System.Windows.Forms.Label lblMuFmPower;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
