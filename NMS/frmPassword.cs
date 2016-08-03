using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NMS
{
    /// <summary>
    ///  확인/취소 버튼을 Click 할경우를 위한 이벤트
    /// </summary>
    /// <param name="flagAction">true : 확인, false : 취소</param>
    /// <param name="tmpPW">비밀번호</param>
    public delegate void OK_Cancel_Click_Event(bool flagAction);

    public partial class frmPassword : Form
    {
        /// <summary>
        ///  확인/취소 버튼을 Click 할경우를 위한 이벤트
        /// </summary>
        /// <param name="tmpPW">비밀번호</param>
        public event OK_Cancel_Click_Event OK_Cancel_Click = null;

        public frmPassword()
        {
            InitializeComponent();
        }

        public void tbPW_Focus()
        {
            tbPW.Select();
        }

        private void tbPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PWOK_Click();
        }

        private void btPWOK_Click(object sender, EventArgs e)
        {
            PWOK_Click();
        }

        private void PWOK_Click()
        {
            if (tbPW.Text == "ktcc" + (DateTime.Now.Month + DateTime.Now.Day).ToString())
            {
                this.OK_Cancel_Click(true);
                this.Hide();
            }
            else
                MessageBox.Show("비밀번호가 틀렸습니다. 확인후 다시 시도해주시기 바랍니다.");

            tbPW.Text = "";
            tbPW_Focus();
        }

        private void btPWCancel_Click(object sender, EventArgs e)
        {
            this.OK_Cancel_Click(false);
            this.Hide();

            tbPW.Text = "";
            tbPW_Focus();             
        }
    }
}
