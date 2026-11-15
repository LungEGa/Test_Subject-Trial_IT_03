using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial_IT_03
{
    public partial class Form_IT_03_Submit : Form
    {
        public Form_IT_03_Submit()
        {
            InitializeComponent();
        }

        // ----- Transforming Submission Form on Status ----- //
        public void SubmitStatusForm(string submit_status)
        {
            if (submit_status.ToLower().Trim() == "approve")
            {
                this.Text = "ยืนยันการอนุมัติ";
                this.BTN_Submit.Text = "อนุมัติ";
            }
            else if (submit_status.ToLower().Trim() == "reject") 
            {
                this.Text = "ยืนยันการไม่อนุมัติ";
                this.BTN_Submit.Text = "ไม่อนุมัติ";
            }

        }
    }
}
