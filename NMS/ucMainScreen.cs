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
    public partial class ucMainScreen : UserControl
    {
        private List<Button> mMuList;
        private List<Button> mRuList;
        public ucMainScreen()
        {
            InitializeComponent();

            mMuList = new List<Button>();

            mMuList.Add(btMu1); mMuList.Add(btMu2); mMuList.Add(btMu3); mMuList.Add(btMu4);
            mMuList.Add(btMu5); mMuList.Add(btMu6); mMuList.Add(btMu7); mMuList.Add(btMu8);


            mRuList = new List<Button>();
            mRuList.Add(btRu1); mRuList.Add(btRu2); mRuList.Add(btRu3); mRuList.Add(btRu4);
            mRuList.Add(btRu5); mRuList.Add(btRu6); mRuList.Add(btRu7); mRuList.Add(btRu8);
            mRuList.Add(btRu9); mRuList.Add(btRu10); mRuList.Add(btRu11);
        }

        private void ucMainScreen_Load(object sender, EventArgs e)
        {
            

        }

        public List<Button> MuList
        {
            get
            {
                return mMuList;
            }
        }

        public List<Button> RuList
        {
            get
            {
                return mRuList;
            }
        }
    }
}

