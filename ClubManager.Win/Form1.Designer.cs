﻿namespace ClubManager.Win
{
    partial class Form1
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
            this.memberBasicInfo1 = new ClubManager.Win.Controls.MemberBasicInfo();
            this.SuspendLayout();
            // 
            // memberBasicInfo1
            // 
            this.memberBasicInfo1.Location = new System.Drawing.Point(108, 23);
            this.memberBasicInfo1.Name = "memberBasicInfo1";
            this.memberBasicInfo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.memberBasicInfo1.Size = new System.Drawing.Size(600, 400);
            this.memberBasicInfo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 476);
            this.Controls.Add(this.memberBasicInfo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MemberBasicInfo memberBasicInfo1;
    }
}

