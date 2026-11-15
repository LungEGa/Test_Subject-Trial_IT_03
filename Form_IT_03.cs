using System;
using System.Windows.Forms;

namespace Trial_IT_03
{
    public partial class Form_IT_03 : Form
    {
        public Form_IT_03()
        {
            InitializeComponent();
        }

        private void BTN_Approve_Click(object sender, EventArgs e)
        {
            // --- Initiate Form --- //
            Form_IT_03_Submit SubmitApprove = new Form_IT_03_Submit();
            SubmitApprove.Text = "ยืนยันการอนุมัติ";
            // --- Presenting -- //
            SubmitApprove.ShowDialog();
        }

        private void BTN_Reject_Click(object sender, EventArgs e)
        {
            // --- Initiate Form --- //
            Form_IT_03_Submit SubmitReject = new Form_IT_03_Submit();
            SubmitReject.Text = "ยืนยันการไม่อนุมัติ";
            // --- Presenting -- //
            SubmitReject.ShowDialog();
        }
    }
}
