namespace Trial_IT_03
{
    partial class Form_IT_03_Submit
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
            this.LTB_Reason = new System.Windows.Forms.TextBox();
            this.RTB_ReasonText = new System.Windows.Forms.RichTextBox();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTB_Reason
            // 
            this.LTB_Reason.BackColor = System.Drawing.SystemColors.Menu;
            this.LTB_Reason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LTB_Reason.Font = new System.Drawing.Font("Angsana New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTB_Reason.ForeColor = System.Drawing.Color.Black;
            this.LTB_Reason.Location = new System.Drawing.Point(33, 30);
            this.LTB_Reason.Name = "LTB_Reason";
            this.LTB_Reason.ReadOnly = true;
            this.LTB_Reason.Size = new System.Drawing.Size(74, 38);
            this.LTB_Reason.TabIndex = 0;
            this.LTB_Reason.Text = "เหตุผล :";
            // 
            // RTB_ReasonText
            // 
            this.RTB_ReasonText.Font = new System.Drawing.Font("Angsana New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_ReasonText.Location = new System.Drawing.Point(113, 30);
            this.RTB_ReasonText.Name = "RTB_ReasonText";
            this.RTB_ReasonText.Size = new System.Drawing.Size(552, 188);
            this.RTB_ReasonText.TabIndex = 1;
            this.RTB_ReasonText.Text = "";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.DarkBlue;
            this.BTN_Submit.Font = new System.Drawing.Font("Angsana New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.ForeColor = System.Drawing.Color.White;
            this.BTN_Submit.Location = new System.Drawing.Point(346, 230);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(154, 52);
            this.BTN_Submit.TabIndex = 2;
            this.BTN_Submit.Text = "บันทึก";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.Red;
            this.BTN_Cancel.Font = new System.Drawing.Font("Angsana New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.ForeColor = System.Drawing.Color.White;
            this.BTN_Cancel.Location = new System.Drawing.Point(511, 230);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(154, 52);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "ยกเลิก";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // Form_IT_03_Submit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 313);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.LTB_Reason);
            this.Controls.Add(this.RTB_ReasonText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_IT_03_Submit";
            this.Text = "ยืนยันการบันทึก";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LTB_Reason;
        private System.Windows.Forms.RichTextBox RTB_ReasonText;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}