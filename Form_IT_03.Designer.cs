namespace Trial_IT_03
{
    partial class Form_IT_03
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
            this.BTN_Approve = new System.Windows.Forms.Button();
            this.BTN_Reject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Approve
            // 
            this.BTN_Approve.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_Approve.Font = new System.Drawing.Font("Angsana New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Approve.ForeColor = System.Drawing.Color.White;
            this.BTN_Approve.Location = new System.Drawing.Point(12, 12);
            this.BTN_Approve.Name = "BTN_Approve";
            this.BTN_Approve.Size = new System.Drawing.Size(221, 52);
            this.BTN_Approve.TabIndex = 0;
            this.BTN_Approve.Text = "อนุมัติ";
            this.BTN_Approve.UseVisualStyleBackColor = false;
            this.BTN_Approve.Click += new System.EventHandler(this.BTN_Approve_Click);
            // 
            // BTN_Reject
            // 
            this.BTN_Reject.BackColor = System.Drawing.Color.Red;
            this.BTN_Reject.Font = new System.Drawing.Font("Angsana New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reject.ForeColor = System.Drawing.Color.White;
            this.BTN_Reject.Location = new System.Drawing.Point(239, 12);
            this.BTN_Reject.Name = "BTN_Reject";
            this.BTN_Reject.Size = new System.Drawing.Size(221, 52);
            this.BTN_Reject.TabIndex = 2;
            this.BTN_Reject.Text = "ไม่อนุมัติ";
            this.BTN_Reject.UseVisualStyleBackColor = false;
            this.BTN_Reject.Click += new System.EventHandler(this.BTN_Reject_Click);
            // 
            // Form_IT_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.BTN_Approve);
            this.Controls.Add(this.BTN_Reject);
            this.Name = "Form_IT_03";
            this.Text = "IT 03-1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Approve;
        private System.Windows.Forms.Button BTN_Reject;
    }
}

