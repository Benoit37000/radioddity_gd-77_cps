﻿namespace DMR
{
	partial class OpenGD77Form
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
			this.btnBackupEEPROM = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnBackupFlash = new System.Windows.Forms.Button();
			this.btnRestoreEEPROM = new System.Windows.Forms.Button();
			this.btnRestoreFlash = new System.Windows.Forms.Button();
			this.btnReadCodeplug = new System.Windows.Forms.Button();
			this.btnWriteCodeplug = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.Label();
			this.btnBackupCalibration = new System.Windows.Forms.Button();
			this.btnRestoreCalibration = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBackupEEPROM
			// 
			this.btnBackupEEPROM.Location = new System.Drawing.Point(16, 12);
			this.btnBackupEEPROM.Name = "btnBackupEEPROM";
			this.btnBackupEEPROM.Size = new System.Drawing.Size(131, 23);
			this.btnBackupEEPROM.TabIndex = 3;
			this.btnBackupEEPROM.Text = "Backup EEPROM";
			this.btnBackupEEPROM.UseVisualStyleBackColor = true;
			this.btnBackupEEPROM.Click += new System.EventHandler(this.btnBackupEEPROM_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(16, 261);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(477, 23);
			this.progressBar1.TabIndex = 4;
			// 
			// btnBackupFlash
			// 
			this.btnBackupFlash.Location = new System.Drawing.Point(16, 81);
			this.btnBackupFlash.Name = "btnBackupFlash";
			this.btnBackupFlash.Size = new System.Drawing.Size(131, 23);
			this.btnBackupFlash.TabIndex = 5;
			this.btnBackupFlash.Text = "Backup Flash";
			this.btnBackupFlash.UseVisualStyleBackColor = true;
			this.btnBackupFlash.Click += new System.EventHandler(this.btnBackupFlash_Click);
			// 
			// btnRestoreEEPROM
			// 
			this.btnRestoreEEPROM.Location = new System.Drawing.Point(16, 41);
			this.btnRestoreEEPROM.Name = "btnRestoreEEPROM";
			this.btnRestoreEEPROM.Size = new System.Drawing.Size(131, 23);
			this.btnRestoreEEPROM.TabIndex = 3;
			this.btnRestoreEEPROM.Text = "Restore EEPROM";
			this.btnRestoreEEPROM.UseVisualStyleBackColor = true;
			this.btnRestoreEEPROM.Click += new System.EventHandler(this.btnRestoreEEPROM_Click);
			// 
			// btnRestoreFlash
			// 
			this.btnRestoreFlash.Location = new System.Drawing.Point(16, 110);
			this.btnRestoreFlash.Name = "btnRestoreFlash";
			this.btnRestoreFlash.Size = new System.Drawing.Size(131, 23);
			this.btnRestoreFlash.TabIndex = 5;
			this.btnRestoreFlash.Text = "Restore Flash";
			this.btnRestoreFlash.UseVisualStyleBackColor = true;
			this.btnRestoreFlash.Click += new System.EventHandler(this.btnRestoreFlash_Click);
			// 
			// btnReadCodeplug
			// 
			this.btnReadCodeplug.Location = new System.Drawing.Point(362, 12);
			this.btnReadCodeplug.Name = "btnReadCodeplug";
			this.btnReadCodeplug.Size = new System.Drawing.Size(131, 23);
			this.btnReadCodeplug.TabIndex = 3;
			this.btnReadCodeplug.Text = "Read codeplug";
			this.btnReadCodeplug.UseVisualStyleBackColor = true;
			this.btnReadCodeplug.Click += new System.EventHandler(this.btnReadCodeplug_Click);
			// 
			// btnWriteCodeplug
			// 
			this.btnWriteCodeplug.Location = new System.Drawing.Point(362, 41);
			this.btnWriteCodeplug.Name = "btnWriteCodeplug";
			this.btnWriteCodeplug.Size = new System.Drawing.Size(131, 23);
			this.btnWriteCodeplug.TabIndex = 3;
			this.btnWriteCodeplug.Text = "Write codeplug";
			this.btnWriteCodeplug.UseVisualStyleBackColor = true;
			this.btnWriteCodeplug.Click += new System.EventHandler(this.btnWriteCodeplug_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(16, 233);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(477, 25);
			this.txtMessage.TabIndex = 6;
			this.txtMessage.Text = " OpenGD77 has been detected";
			// 
			// btnBackupCalibration
			// 
			this.btnBackupCalibration.Location = new System.Drawing.Point(16, 156);
			this.btnBackupCalibration.Name = "btnBackupCalibration";
			this.btnBackupCalibration.Size = new System.Drawing.Size(131, 23);
			this.btnBackupCalibration.TabIndex = 5;
			this.btnBackupCalibration.Text = "Backup Calibration";
			this.btnBackupCalibration.UseVisualStyleBackColor = true;
			this.btnBackupCalibration.Click += new System.EventHandler(this.btnBackupCalibration_Click);
			// 
			// btnRestoreCalibration
			// 
			this.btnRestoreCalibration.Location = new System.Drawing.Point(16, 185);
			this.btnRestoreCalibration.Name = "btnRestoreCalibration";
			this.btnRestoreCalibration.Size = new System.Drawing.Size(131, 23);
			this.btnRestoreCalibration.TabIndex = 5;
			this.btnRestoreCalibration.Text = "Restore Calibration";
			this.btnRestoreCalibration.UseVisualStyleBackColor = true;
			this.btnRestoreCalibration.Click += new System.EventHandler(this.btnRestoreCalibration_Click);
			// 
			// OpenGD77Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 290);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnRestoreCalibration);
			this.Controls.Add(this.btnBackupCalibration);
			this.Controls.Add(this.btnRestoreFlash);
			this.Controls.Add(this.btnBackupFlash);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnRestoreEEPROM);
			this.Controls.Add(this.btnWriteCodeplug);
			this.Controls.Add(this.btnReadCodeplug);
			this.Controls.Add(this.btnBackupEEPROM);
			this.Name = "OpenGD77Form";
			this.Text = "OpenGD77 Support";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenGD77Form_FormClosed);
			this.Load += new System.EventHandler(this.OpenGD77Form_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBackupEEPROM;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnBackupFlash;
		private System.Windows.Forms.Button btnRestoreEEPROM;
		private System.Windows.Forms.Button btnRestoreFlash;
		private System.Windows.Forms.Button btnReadCodeplug;
		private System.Windows.Forms.Button btnWriteCodeplug;
		private System.Windows.Forms.Label txtMessage;
		private System.Windows.Forms.Button btnBackupCalibration;
		private System.Windows.Forms.Button btnRestoreCalibration;
	}
}