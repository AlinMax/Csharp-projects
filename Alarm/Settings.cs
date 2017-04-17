/*
 * Created by SharpDevelop.
 * User: AL
 * Date: 22.02.2017
 * Time: 22:41
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Alarm
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public partial class Settings : Form
	{
		public Settings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			LoadSettings();
		}
		
		
		void SetDefaultSettings()
		{
			soundFileTextBox.Text = "";
			soundDurationNumericUpDown.Value = 3000;
			soundCheckBox.Checked = true;
			tooltipRadioButton.Checked = true;
			minimizeProgramCheckBox.Checked = true;
		}
		
		
		void LoadSettings()
		{
			Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			Directory.SetCurrentDirectory(Application.StartupPath);
			
			try
			{
				string[] settings = File.ReadAllLines(@"Settings.txt");
				
				if (settings[0] != "")
				{
					if (settings[0] == "No audio file") soundFileTextBox.Text = "";
					else soundFileTextBox.Text = settings[0];

					soundDurationNumericUpDown.Value = Convert.ToDecimal(settings[1]);
					soundCheckBox.Checked = Convert.ToBoolean(settings[2]);
					tooltipRadioButton.Checked = Convert.ToBoolean(settings[3]);
					
					if (!tooltipRadioButton.Checked) popupRadioButton.Checked = true;
					
					minimizeProgramCheckBox.Checked = Convert.ToBoolean(settings[4]);
				}
			}
			catch
			{
				Console.WriteLine("Error loading Settings.txt.");
				SetDefaultSettings();
			}
		}
		
		
		void SaveSettings()
		{
			try
			{
				Directory.SetCurrentDirectory(Application.StartupPath);
				TextWriter tw = new StreamWriter("Settings.txt");
				
				if (soundFileTextBox.Text == "") tw.WriteLine("No audio file");
				else tw.WriteLine(soundFileTextBox.Text);
				
				tw.WriteLine(soundDurationNumericUpDown.Value);
				tw.WriteLine(soundCheckBox.Checked);
				tw.WriteLine(tooltipRadioButton.Checked);
				tw.WriteLine(minimizeProgramCheckBox.Checked);
				tw.Close();
			}
			catch(Exception x)
			{
				MessageBox.Show("Error saving to Settings.txt");
			}
		}
		
		
		void BrowseButtonClick(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.Filter = "WAV|*.wav; *.wave";
			ofd.CheckFileExists = true;
			ofd.CheckPathExists = true;
			ofd.Title = "Select a WAV file";

			if ((ofd.ShowDialog() == DialogResult.OK) && (ofd.FileName.Length > 0)) soundFileTextBox.Text = ofd.FileName;
			
			ofd.Dispose();
		}
		
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			SetDefaultSettings();
		}
		
		
		void SaveButtonClick(object sender, EventArgs e)
		{
			SaveSettings();
		}

	}
}
