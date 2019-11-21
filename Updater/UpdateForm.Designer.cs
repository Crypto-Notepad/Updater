﻿namespace Updater
{
    partial class UpdateForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.RlsNotesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.isAppRunningTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(69, 6);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(222, 60);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 73);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Updater.Properties.Resources.arrow_down;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.updaterPictureBox.TabStop = false;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(214, 79);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.TabStop = false;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // releaseNotesLabel
            // 
            this.releaseNotesLabel.AutoSize = true;
            this.releaseNotesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseNotesLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.releaseNotesLabel.Location = new System.Drawing.Point(3, 83);
            this.releaseNotesLabel.Name = "releaseNotesLabel";
            this.releaseNotesLabel.Size = new System.Drawing.Size(103, 15);
            this.releaseNotesLabel.TabIndex = 2;
            this.releaseNotesLabel.Text = "View release notes";
            this.releaseNotesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReleaseNotesLabel_LinkClicked);
            // 
            this.RlsNotesLinkLabel.AutoSize = true;
            this.RlsNotesLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RlsNotesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.RlsNotesLinkLabel.Location = new System.Drawing.Point(3, 83);
            this.RlsNotesLinkLabel.Name = "RlsNotesLinkLabel";
            this.RlsNotesLinkLabel.Size = new System.Drawing.Size(110, 15);
            this.RlsNotesLinkLabel.TabIndex = 6;
            this.RlsNotesLinkLabel.Text = "View release notes";
            this.RlsNotesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RlsNotesLinkLabel_LinkClicked);
            // isAppRunningTimer
            // 
            this.isAppRunningTimer.Enabled = true;
            this.isAppRunningTimer.Tick += new System.EventHandler(this.IsAppRunningTimer_Tick);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 107);
            this.Controls.Add(this.releaseNotesLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Updater";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updaterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox updaterPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel releaseNotesLabel;
        private System.Windows.Forms.Timer isAppRunningTimer;
    }
}

