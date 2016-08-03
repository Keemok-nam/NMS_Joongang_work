namespace NMS
{
    partial class frmPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPWOK = new System.Windows.Forms.Button();
            this.btPWCancel = new System.Windows.Forms.Button();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btPWOK
            // 
            this.btPWOK.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btPWOK.Location = new System.Drawing.Point(12, 62);
            this.btPWOK.Name = "btPWOK";
            this.btPWOK.Size = new System.Drawing.Size(80, 50);
            this.btPWOK.TabIndex = 0;
            this.btPWOK.Text = "확 인";
            this.btPWOK.UseVisualStyleBackColor = true;
            this.btPWOK.Click += new System.EventHandler(this.btPWOK_Click);
            // 
            // btPWCancel
            // 
            this.btPWCancel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btPWCancel.Location = new System.Drawing.Point(100, 62);
            this.btPWCancel.Name = "btPWCancel";
            this.btPWCancel.Size = new System.Drawing.Size(80, 50);
            this.btPWCancel.TabIndex = 1;
            this.btPWCancel.Text = "취 소";
            this.btPWCancel.UseVisualStyleBackColor = true;
            this.btPWCancel.Click += new System.EventHandler(this.btPWCancel_Click);
            // 
            // tbPW
            // 
            this.tbPW.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPW.Location = new System.Drawing.Point(12, 17);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(168, 39);
            this.tbPW.TabIndex = 2;
            this.tbPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPW_KeyDown);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 121);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.btPWCancel);
            this.Controls.Add(this.btPWOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "비밀번호 입력";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPWOK;
        private System.Windows.Forms.Button btPWCancel;
        private System.Windows.Forms.TextBox tbPW;
    }
}