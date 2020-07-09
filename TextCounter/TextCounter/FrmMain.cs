using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HNP.Text;

namespace TextCounter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 사용자 추가 메소드
        private void SetupUI()
        {
            LblCountByteWoW.Text = "0";
            LblCountByteWW.Text = "0";
            LblCountWoW.Text = "0";
            LblCountWW.Text = "0";
        }
        #endregion 사용자 메소드

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetupUI();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtInput.Clear();
            TxtInput.Focus();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (TxtInput.Text != string.Empty)
            {
                Clipboard.SetText(TxtInput.Text);
            }
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            LblCountWW.Text = TextUtils.GetStringLength(TxtInput.Text).ToString();
            LblCountByteWW.Text = TextUtils.GetStringByteLength(TxtInput.Text).ToString();
            LblCountWoW.Text = TextUtils.GetStringLength(TxtInput.Text, true).ToString();
            LblCountByteWoW.Text = TextUtils.GetStringByteLength(TxtInput.Text, true).ToString();
        }
    }
}
