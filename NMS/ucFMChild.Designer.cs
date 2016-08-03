namespace NMS
{
    partial class ucFMChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFMChild));
            this.gbBettery = new System.Windows.Forms.GroupBox();
            this.gbBetteryVoltage = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBetteryVoltage = new System.Windows.Forms.Label();
            this.gbBetteryChangeCurrent = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.lblBetteryChangeCurrent = new System.Windows.Forms.Label();
            this.gbBetteryDischangeCurrent = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.lblBetteryDischangeCurrent = new System.Windows.Forms.Label();
            this.gbPower = new System.Windows.Forms.GroupBox();
            this.pbAcInputFail = new System.Windows.Forms.PictureBox();
            this.lblAcInputFail = new System.Windows.Forms.Label();
            this.pbDCOutputFail = new System.Windows.Forms.PictureBox();
            this.lblDCOutputFail = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTssiRev = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTssiFwd = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRssi = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPDPower = new System.Windows.Forms.Label();
            this.pbPDAlarm = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLDPower = new System.Windows.Forms.Label();
            this.pbLDAlarm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBettery.SuspendLayout();
            this.gbBetteryVoltage.SuspendLayout();
            this.gbBetteryChangeCurrent.SuspendLayout();
            this.gbBetteryDischangeCurrent.SuspendLayout();
            this.gbPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcInputFail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDCOutputFail)).BeginInit();
            this.gbOther.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDAlarm)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLDAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBettery
            // 
            this.gbBettery.BackColor = System.Drawing.Color.Transparent;
            this.gbBettery.Controls.Add(this.gbBetteryVoltage);
            this.gbBettery.Controls.Add(this.gbBetteryChangeCurrent);
            this.gbBettery.Controls.Add(this.gbBetteryDischangeCurrent);
            this.gbBettery.Enabled = false;
            this.gbBettery.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBettery.Location = new System.Drawing.Point(18, 139);
            this.gbBettery.Name = "gbBettery";
            this.gbBettery.Size = new System.Drawing.Size(364, 80);
            this.gbBettery.TabIndex = 265;
            this.gbBettery.TabStop = false;
            this.gbBettery.Text = "Bettery 상태";
            // 
            // gbBetteryVoltage
            // 
            this.gbBetteryVoltage.Controls.Add(this.label11);
            this.gbBetteryVoltage.Controls.Add(this.lblBetteryVoltage);
            this.gbBetteryVoltage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBetteryVoltage.Location = new System.Drawing.Point(16, 23);
            this.gbBetteryVoltage.Name = "gbBetteryVoltage";
            this.gbBetteryVoltage.Size = new System.Drawing.Size(105, 50);
            this.gbBetteryVoltage.TabIndex = 258;
            this.gbBetteryVoltage.TabStop = false;
            this.gbBetteryVoltage.Text = "Voltage";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(69, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 26);
            this.label11.TabIndex = 242;
            this.label11.Text = "V";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBetteryVoltage
            // 
            this.lblBetteryVoltage.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBetteryVoltage.Location = new System.Drawing.Point(13, 20);
            this.lblBetteryVoltage.Name = "lblBetteryVoltage";
            this.lblBetteryVoltage.Size = new System.Drawing.Size(50, 26);
            this.lblBetteryVoltage.TabIndex = 241;
            this.lblBetteryVoltage.Text = "0";
            this.lblBetteryVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBetteryChangeCurrent
            // 
            this.gbBetteryChangeCurrent.Controls.Add(this.label37);
            this.gbBetteryChangeCurrent.Controls.Add(this.lblBetteryChangeCurrent);
            this.gbBetteryChangeCurrent.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBetteryChangeCurrent.Location = new System.Drawing.Point(127, 23);
            this.gbBetteryChangeCurrent.Name = "gbBetteryChangeCurrent";
            this.gbBetteryChangeCurrent.Size = new System.Drawing.Size(216, 50);
            this.gbBetteryChangeCurrent.TabIndex = 259;
            this.gbBetteryChangeCurrent.TabStop = false;
            this.gbBetteryChangeCurrent.Text = "Change/Dischange Current";
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.Location = new System.Drawing.Point(124, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 26);
            this.label37.TabIndex = 244;
            this.label37.Text = "A";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBetteryChangeCurrent
            // 
            this.lblBetteryChangeCurrent.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBetteryChangeCurrent.Location = new System.Drawing.Point(68, 19);
            this.lblBetteryChangeCurrent.Name = "lblBetteryChangeCurrent";
            this.lblBetteryChangeCurrent.Size = new System.Drawing.Size(50, 26);
            this.lblBetteryChangeCurrent.TabIndex = 243;
            this.lblBetteryChangeCurrent.Text = "0";
            this.lblBetteryChangeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBetteryDischangeCurrent
            // 
            this.gbBetteryDischangeCurrent.Controls.Add(this.label42);
            this.gbBetteryDischangeCurrent.Controls.Add(this.lblBetteryDischangeCurrent);
            this.gbBetteryDischangeCurrent.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBetteryDischangeCurrent.Location = new System.Drawing.Point(238, 28);
            this.gbBetteryDischangeCurrent.Name = "gbBetteryDischangeCurrent";
            this.gbBetteryDischangeCurrent.Size = new System.Drawing.Size(105, 41);
            this.gbBetteryDischangeCurrent.TabIndex = 260;
            this.gbBetteryDischangeCurrent.TabStop = false;
            this.gbBetteryDischangeCurrent.Text = "Dischange Current";
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.Location = new System.Drawing.Point(69, 15);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(25, 26);
            this.label42.TabIndex = 242;
            this.label42.Text = "A";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBetteryDischangeCurrent
            // 
            this.lblBetteryDischangeCurrent.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBetteryDischangeCurrent.Location = new System.Drawing.Point(13, 15);
            this.lblBetteryDischangeCurrent.Name = "lblBetteryDischangeCurrent";
            this.lblBetteryDischangeCurrent.Size = new System.Drawing.Size(50, 26);
            this.lblBetteryDischangeCurrent.TabIndex = 241;
            this.lblBetteryDischangeCurrent.Text = "0";
            this.lblBetteryDischangeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbPower
            // 
            this.gbPower.BackColor = System.Drawing.Color.Transparent;
            this.gbPower.Controls.Add(this.pbAcInputFail);
            this.gbPower.Controls.Add(this.lblAcInputFail);
            this.gbPower.Controls.Add(this.pbDCOutputFail);
            this.gbPower.Controls.Add(this.lblDCOutputFail);
            this.gbPower.Enabled = false;
            this.gbPower.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbPower.Location = new System.Drawing.Point(18, 73);
            this.gbPower.Name = "gbPower";
            this.gbPower.Size = new System.Drawing.Size(364, 60);
            this.gbPower.TabIndex = 264;
            this.gbPower.TabStop = false;
            this.gbPower.Text = "전원부 상태";
            // 
            // pbAcInputFail
            // 
            this.pbAcInputFail.Image = ((System.Drawing.Image)(resources.GetObject("pbAcInputFail.Image")));
            this.pbAcInputFail.Location = new System.Drawing.Point(31, 27);
            this.pbAcInputFail.Name = "pbAcInputFail";
            this.pbAcInputFail.Size = new System.Drawing.Size(20, 20);
            this.pbAcInputFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcInputFail.TabIndex = 250;
            this.pbAcInputFail.TabStop = false;
            // 
            // lblAcInputFail
            // 
            this.lblAcInputFail.AutoSize = true;
            this.lblAcInputFail.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAcInputFail.Location = new System.Drawing.Point(67, 32);
            this.lblAcInputFail.Name = "lblAcInputFail";
            this.lblAcInputFail.Size = new System.Drawing.Size(96, 13);
            this.lblAcInputFail.TabIndex = 249;
            this.lblAcInputFail.Text = "AC Input Fail";
            this.lblAcInputFail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbDCOutputFail
            // 
            this.pbDCOutputFail.Image = ((System.Drawing.Image)(resources.GetObject("pbDCOutputFail.Image")));
            this.pbDCOutputFail.Location = new System.Drawing.Point(189, 27);
            this.pbDCOutputFail.Name = "pbDCOutputFail";
            this.pbDCOutputFail.Size = new System.Drawing.Size(20, 20);
            this.pbDCOutputFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDCOutputFail.TabIndex = 252;
            this.pbDCOutputFail.TabStop = false;
            // 
            // lblDCOutputFail
            // 
            this.lblDCOutputFail.AutoSize = true;
            this.lblDCOutputFail.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDCOutputFail.Location = new System.Drawing.Point(225, 32);
            this.lblDCOutputFail.Name = "lblDCOutputFail";
            this.lblDCOutputFail.Size = new System.Drawing.Size(108, 13);
            this.lblDCOutputFail.TabIndex = 251;
            this.lblDCOutputFail.Text = "DC Output Fail";
            this.lblDCOutputFail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Blue;
            this.label20.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(388, 54);
            this.label20.TabIndex = 263;
            this.label20.Text = "F  M  (  자  장  치  )    상  태";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOther
            // 
            this.gbOther.BackColor = System.Drawing.Color.Transparent;
            this.gbOther.Controls.Add(this.groupBox7);
            this.gbOther.Controls.Add(this.groupBox6);
            this.gbOther.Controls.Add(this.groupBox5);
            this.gbOther.Controls.Add(this.groupBox4);
            this.gbOther.Controls.Add(this.pbPDAlarm);
            this.gbOther.Controls.Add(this.label4);
            this.gbOther.Controls.Add(this.groupBox3);
            this.gbOther.Controls.Add(this.pbLDAlarm);
            this.gbOther.Controls.Add(this.label1);
            this.gbOther.Enabled = false;
            this.gbOther.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbOther.Location = new System.Drawing.Point(18, 225);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(364, 153);
            this.gbOther.TabIndex = 266;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "기타 상태";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.lblTemperature);
            this.groupBox7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(241, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(105, 72);
            this.groupBox7.TabIndex = 264;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temperature";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(64, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 26);
            this.label12.TabIndex = 242;
            this.label12.Text = "℃";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemperature.Location = new System.Drawing.Point(13, 26);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(50, 26);
            this.lblTemperature.TabIndex = 241;
            this.lblTemperature.Text = "0";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblTssiRev);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lblTssiFwd);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(127, 75);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(105, 72);
            this.groupBox6.TabIndex = 264;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TSSI";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(2, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 11);
            this.label10.TabIndex = 250;
            this.label10.Text = "(REV)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(2, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 11);
            this.label8.TabIndex = 249;
            this.label8.Text = "(FWD)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(59, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 248;
            this.label3.Text = "dBm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTssiRev
            // 
            this.lblTssiRev.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTssiRev.Location = new System.Drawing.Point(8, 46);
            this.lblTssiRev.Name = "lblTssiRev";
            this.lblTssiRev.Size = new System.Drawing.Size(50, 26);
            this.lblTssiRev.TabIndex = 247;
            this.lblTssiRev.Text = "0";
            this.lblTssiRev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(59, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 26);
            this.label9.TabIndex = 246;
            this.label9.Text = "dBm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTssiFwd
            // 
            this.lblTssiFwd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTssiFwd.Location = new System.Drawing.Point(8, 19);
            this.lblTssiFwd.Name = "lblTssiFwd";
            this.lblTssiFwd.Size = new System.Drawing.Size(50, 26);
            this.lblTssiFwd.TabIndex = 245;
            this.lblTssiFwd.Text = "0";
            this.lblTssiFwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lblRssi);
            this.groupBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(16, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(105, 72);
            this.groupBox5.TabIndex = 263;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RSSI";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(64, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 26);
            this.label7.TabIndex = 242;
            this.label7.Text = "dBm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRssi
            // 
            this.lblRssi.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRssi.Location = new System.Drawing.Point(13, 26);
            this.lblRssi.Name = "lblRssi";
            this.lblRssi.Size = new System.Drawing.Size(50, 26);
            this.lblRssi.TabIndex = 241;
            this.lblRssi.Text = "0";
            this.lblRssi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblPDPower);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(241, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 55);
            this.groupBox4.TabIndex = 261;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PD Power";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(64, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 26);
            this.label5.TabIndex = 242;
            this.label5.Text = "dBm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPDPower
            // 
            this.lblPDPower.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPDPower.Location = new System.Drawing.Point(13, 22);
            this.lblPDPower.Name = "lblPDPower";
            this.lblPDPower.Size = new System.Drawing.Size(50, 26);
            this.lblPDPower.TabIndex = 241;
            this.lblPDPower.Text = "0";
            this.lblPDPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbPDAlarm
            // 
            this.pbPDAlarm.Image = ((System.Drawing.Image)(resources.GetObject("pbPDAlarm.Image")));
            this.pbPDAlarm.Location = new System.Drawing.Point(16, 46);
            this.pbPDAlarm.Name = "pbPDAlarm";
            this.pbPDAlarm.Size = new System.Drawing.Size(20, 20);
            this.pbPDAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPDAlarm.TabIndex = 262;
            this.pbPDAlarm.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(44, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 261;
            this.label4.Text = "PD Alarm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblLDPower);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(127, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 55);
            this.groupBox3.TabIndex = 260;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LD Power";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(64, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 242;
            this.label2.Text = "dBm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLDPower
            // 
            this.lblLDPower.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLDPower.Location = new System.Drawing.Point(13, 22);
            this.lblLDPower.Name = "lblLDPower";
            this.lblLDPower.Size = new System.Drawing.Size(50, 26);
            this.lblLDPower.TabIndex = 241;
            this.lblLDPower.Text = "0";
            this.lblLDPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbLDAlarm
            // 
            this.pbLDAlarm.Image = ((System.Drawing.Image)(resources.GetObject("pbLDAlarm.Image")));
            this.pbLDAlarm.Location = new System.Drawing.Point(16, 22);
            this.pbLDAlarm.Name = "pbLDAlarm";
            this.pbLDAlarm.Size = new System.Drawing.Size(20, 20);
            this.pbLDAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLDAlarm.TabIndex = 245;
            this.pbLDAlarm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 244;
            this.label1.Text = "LD Alarm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucFMChild
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbBettery);
            this.Controls.Add(this.gbPower);
            this.Controls.Add(this.label20);
            this.Name = "ucFMChild";
            this.Size = new System.Drawing.Size(400, 385);
            this.gbBettery.ResumeLayout(false);
            this.gbBetteryVoltage.ResumeLayout(false);
            this.gbBetteryChangeCurrent.ResumeLayout(false);
            this.gbBetteryDischangeCurrent.ResumeLayout(false);
            this.gbPower.ResumeLayout(false);
            this.gbPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcInputFail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDCOutputFail)).EndInit();
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPDAlarm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLDAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBettery;
        private System.Windows.Forms.GroupBox gbBetteryVoltage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBetteryVoltage;
        private System.Windows.Forms.GroupBox gbBetteryChangeCurrent;
        private System.Windows.Forms.GroupBox gbBetteryDischangeCurrent;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblBetteryDischangeCurrent;
        private System.Windows.Forms.GroupBox gbPower;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRssi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPDPower;
        private System.Windows.Forms.PictureBox pbPDAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLDPower;
        private System.Windows.Forms.PictureBox pbLDAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTssiRev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTssiFwd;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblBetteryChangeCurrent;
        private System.Windows.Forms.PictureBox pbAcInputFail;
        private System.Windows.Forms.Label lblAcInputFail;
        private System.Windows.Forms.PictureBox pbDCOutputFail;
        private System.Windows.Forms.Label lblDCOutputFail;

    }
}
