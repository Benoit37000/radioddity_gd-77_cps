﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace DMR
{
	public partial class CalibrationForm : Form
	{
		//private const int MEMORY_LOCATION = 0x8F000;//0x7c00;
		public static int CALIBRATION_MEMORY_LOCATION = 0x7c00;
		private const int VHF_OFFSET = 0x70;

		public CalibrationForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);// Roger Clark. Added correct icon on main form!
			// Need to setup the VHF and UHF data storage class first, as its used when initialising the components
			int calibrationDataSize = Marshal.SizeOf(typeof(CalibrationData));
			byte[] array = new byte[calibrationDataSize];
			Array.Copy(MainForm.CommsBuffer, CALIBRATION_MEMORY_LOCATION, array, 0, calibrationDataSize);
			this.calibrationBandControlUHF.data  = (CalibrationData)ByteToData(array);

			array = new byte[calibrationDataSize];
			Array.Copy(MainForm.CommsBuffer, CALIBRATION_MEMORY_LOCATION + VHF_OFFSET, array, 0, calibrationDataSize);
			this.calibrationBandControlVHF.data  = (CalibrationData)ByteToData(array);
		}

		private void btnWrite_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes != MessageBox.Show("Writing the calibration data to Radioddity GD-77 or any other compatible radio, could potentially damage your radio. By clicking 'Yes' you acknowledge that you use this feature entirely at your own risk", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2))
			{
				return;
			}

			// Pre-read to see if the Calibration area appears to be writable
			CodeplugComms.CommunicationMode = CodeplugComms.CommunicationType.dataRead;
			CommPrgForm commPrgForm = new CommPrgForm(true);// true =  close download form as soon as download is complete
			commPrgForm.StartPosition = FormStartPosition.CenterParent;
			CodeplugComms.startAddress = CALIBRATION_MEMORY_LOCATION;
			CodeplugComms.transferLength = 0x20;
			DialogResult result = commPrgForm.ShowDialog();

			/*
			if (MainForm.CommsBuffer[MEMORY_LOCATION] == 0x00 && MainForm.CommsBuffer[MEMORY_LOCATION+1] == 0x00)
			{
				MessageBox.Show(Settings.dicCommon["EnableMemoryAccessMode"]);
				return;
			}*/

			int calibrationDataSize = Marshal.SizeOf(typeof(CalibrationData));

			byte[] array = DataToByte(this.calibrationBandControlUHF.data);
			Array.Copy(array, 0, MainForm.CommsBuffer, CALIBRATION_MEMORY_LOCATION, calibrationDataSize);

			array = DataToByte(this.calibrationBandControlVHF.data);
			Array.Copy(array, 0, MainForm.CommsBuffer, CALIBRATION_MEMORY_LOCATION + VHF_OFFSET, calibrationDataSize);

			CodeplugComms.CommunicationMode = CodeplugComms.CommunicationType.calibrationWrite;

			commPrgForm = new CommPrgForm(true);// true =  close download form as soon as download is complete
			commPrgForm.StartPosition = FormStartPosition.CenterParent;
			commPrgForm.ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				btnWrite.Visible = true;	
			}
			else
			{
				this.DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		private CalibrationData ByteToData(byte[] byte_0)
		{
			int num = Marshal.SizeOf(typeof(CalibrationData));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, typeof(CalibrationData));
			Marshal.FreeHGlobal(intPtr);
			return (CalibrationData)result;
		}

		public static byte[] DataToByte(CalibrationData object_0)
		{
			int num = Marshal.SizeOf(typeof(CalibrationData));
			byte[] array = new byte[num];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(object_0, intPtr, false);
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		private void onFormShown(object sender, EventArgs e)
		{
			MessageBox.Show("This feature is still in development. It currently only allows the calibration data to be viewed");
		}
	}
}