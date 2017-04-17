/*
 * Created by SharpDevelop.
 * User: AL
 * Date: 26.12.2016
 * Time: 16:22
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Alarm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int h; // hours
		int m; // minutes
		int s; // seconds
		bool alarmStatus;
		string soundFile = "";
		int soundDuration = 3000;
		bool minimizeProgram = true;
		
		public MainForm()
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
		
		
		void LoadSettings()
		{
			Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			notifyIcon1.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			Directory.SetCurrentDirectory(Application.StartupPath);
			
			try
			{
				string[] settings = File.ReadAllLines(@"Settings.txt");
				
				if (settings[0] != "")
				{
					if (settings[0] == "No audio file") soundFile = "";
					else soundFile = settings[0];
					
					soundFile = settings[0];
					soundDuration = Convert.ToInt32(settings[1]);
					soundCheckBox.Checked = Convert.ToBoolean(settings[2]);
					tooltipRadioButton.Checked = Convert.ToBoolean(settings[3]);
					
					if (!tooltipRadioButton.Checked) popupRadioButton.Checked = true;
					
					minimizeProgram = Convert.ToBoolean(settings[4]);
				}
			}
			catch
			{
				Console.WriteLine("Error loading Settings.txt.");
			}
		}
		
		
		void MainFormResize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized) Hide();
		}
		
		
		void NotifyIcon1MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Show();
				WindowState = FormWindowState.Normal;
			}
		}
		
		
		void StartTimer()
		{
			bool hh = int.TryParse(hoursTextBox.Text, out h);
			bool mm = int.TryParse(minutesTextBox.Text, out m);
			bool ss = int.TryParse(secondsTextBox.Text, out s);
			
			if (((h == 0) && (m == 0) && (s == 0)) || ((hoursTextBox.Text == "") || (minutesTextBox.Text == "") || (secondsTextBox.Text == "")))
			{
				MessageBox.Show("Input a time higher than 00:00:00.");
				alarmStatus = false;
				hoursTextBox.Focus();
				return;
			}
			
			startPauseButton.Focus();
			
			if ((hh && mm && ss) && ((h < 24) && (h >= 0) && (m <= 60) && (m >= 0) && (s <= 60) && (s >= 0)))
			{
				hoursTextBox.Enabled = false;
				minutesTextBox.Enabled = false;
				secondsTextBox.Enabled = false;
				calculateButton.Enabled = false;
				settingsButton.Enabled = false;
				resetButton.Enabled = false;
				startPauseButton.Text = "Pause";
				timer1.Start();
				
				if (minimizeProgram) Hide();
			}
			else
			{
				MessageBox.Show("Input time in a correct format (HH:MM:SS).");
				alarmStatus = false;
				hoursTextBox.Focus();
			}
		}


		void StopTimer()
		{
			timer1.Stop();
			alarmStatus = false;
			hoursTextBox.Enabled = true;
			minutesTextBox.Enabled = true;
			secondsTextBox.Enabled = true;
			calculateButton.Enabled = true;
			settingsButton.Enabled = true;
			resetButton.Enabled = true;
			startPauseButton.Text = "Start";
		}


		void Timer1Tick(object sender, EventArgs e)
		{
			s = s - 1;
			
			if (s == -1)
			{
				m = m -1;
				s = 59;
			}
			
			if (m == -1)
			{
				h = h - 1;
				m = 59;
			}
			
			if ((h == 0) && (m == 0) && (s == 0))
			{
				StopTimer();
				ShowTimesUp();
			}
			else
			{
				hoursTextBox.Text = h.ToString().PadLeft(2, '0');
				minutesTextBox.Text = m.ToString().PadLeft(2, '0');
				secondsTextBox.Text = s.ToString().PadLeft(2, '0');
				notifyIcon1.Text = "Alarm - " + hoursTextBox.Text + " : " + minutesTextBox.Text + " : " + secondsTextBox.Text + " - " + textBox.Text;
			}
		}


		void ShowTimesUp()
		{
			secondsTextBox.Text = "00";
			notifyIcon1.Text = "Alarm";
			
			if (tooltipRadioButton.Checked)
			{
				notifyIcon1.BalloonTipTitle = "Alarm";
				notifyIcon1.BalloonTipText = "\n\n\n" + textBox.Text;
				notifyIcon1.ShowBalloonTip(4000);
				
				if (soundCheckBox.Checked) PlaySound();
			}
			else
			{
				if (soundCheckBox.Checked) PlaySound();
				
				Show();
				Activate();
				BringToFront();
				Focus();
				MessageBox.Show(textBox.Text, "Alarm");
			}
		}


		void PlaySound()
		{
			if (soundFile != "")
			{
				try
				{
					var p = new SoundPlayer(soundFile);
					
					p.PlayLooping();
					System.Threading.Thread.Sleep(soundDuration);
					p.Stop();
				}
				catch
				{
					Text = "Alarm: audio file not found or not valid";
				}
			}
		}


		void ShowCalculate()
		{
			var calc = new Calculate();
			
			if (calc.ShowDialog(this) == DialogResult.OK)
			{
				var hh = calc.h;
				var mm = calc.m;
				var ss = calc.s;
				
				hoursTextBox.Text = hh.ToString().PadLeft(2, '0');
				minutesTextBox.Text = mm.ToString().PadLeft(2, '0');
				secondsTextBox.Text = ss.ToString().PadLeft(2, '0');
				
				if (calc.startNow) StartPauseAlarm();
			}
			
			calc.Dispose();
		}


		void StartPauseAlarm()
		{
			alarmStatus = !alarmStatus;
			
			if (alarmStatus) StartTimer();
			else StopTimer();
		}


		void ResetAlarm()
		{
			h = 0;
			m = 0;
			s = 0;
			hoursTextBox.Text = "00";
			minutesTextBox.Text = "00";
			secondsTextBox.Text = "00";
			textBox.Text = "Time's up!";
		}
		
		
		void ShowSettings()
		{
			var settings = new Settings();
			
			if (settings.ShowDialog(this) == DialogResult.OK) LoadSettings();
			
			settings.Dispose();
		}


		#region Controls

		void CalculateButtonClick(object sender, EventArgs e)
		{
			ShowCalculate();
		}


		void StartPauseButtonClick(object sender, EventArgs e)
		{
			StartPauseAlarm();
		}


		void ResetButtonClick(object sender, EventArgs e)
		{
			ResetAlarm();
		}
		
		
		void SettingsButtonClick(object sender, EventArgs e)
		{
			ShowSettings();
		}


		void HoursTextBoxClick(object sender, EventArgs e)
		{
			hoursTextBox.Select(0, hoursTextBox.Text.Length);
		}


		void MinutesTextBoxClick(object sender, EventArgs e)
		{
			minutesTextBox.Select(0, minutesTextBox.Text.Length);
		}


		void SecondsTextBoxClick(object sender, EventArgs e)
		{
			secondsTextBox.Select(0, secondsTextBox.Text.Length);
		}


		void HoursTextBoxEnter(object sender, EventArgs e)
		{
			hoursTextBox.Select(0, hoursTextBox.Text.Length);
		}


		void MinutesTextBoxEnter(object sender, EventArgs e)
		{
			minutesTextBox.Select(0, minutesTextBox.Text.Length);
		}


		void SecondsTextBoxEnter(object sender, EventArgs e)
		{
			secondsTextBox.Select(0, secondsTextBox.Text.Length);
		}


		void TextBoxEnter(object sender, EventArgs e)
		{
			textBox.Select(0, textBox.Text.Length);
		}


		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				StartPauseAlarm();
			}
			else if (e.KeyCode == Keys.Oemtilde)
			{
				Application.Exit();
			}
			else if (e.KeyCode == Keys.Escape)
			{
				WindowState = FormWindowState.Minimized;
			}
			else if ((e.Control) && (e.KeyCode == Keys.C) && !alarmStatus)
			{
				ShowCalculate();
			}
			else if ((e.Control) && (e.KeyCode == Keys.P))
			{
				popupRadioButton.Checked = true;
			}
			else if ((e.Control) && (e.KeyCode == Keys.T))
			{
				tooltipRadioButton.Checked = true;
			}
			else if ((e.Control) && (e.KeyCode == Keys.S))
			{
				if (soundCheckBox.Checked) soundCheckBox.Checked = false;
				else soundCheckBox.Checked = true;
			}
			else if ((e.Control) && (e.KeyCode == Keys.R) && !alarmStatus)
			{
				ResetAlarm();
			}
		}


		void ShowToolStripMenuItemClick(object sender, EventArgs e)
		{
			Show();
			Activate();
		}
		
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Alarm\n\n" +
			                "Description:\n" +
			                "Alarm is a freeware program that mainly consists of a countdown timer for alerting the user. It has the option to calculate the time between the current time and a target time.\n\n" +
			                "Shortcuts:\n" +
			                "[Enter] - Start/pause alarm\n" +
			                "[CTRL C] - Calculate time\n" +
			                "[CTRL T] - Tooltip mode on/off\n" +
			                "[CTRL P] - Popup mode on/off\n" +
			                "[CTRL S] - Sound on/off\n" +
			                "[CTRL R] - Reset alarm\n" +
			                "[Esc] - Minimize program\n" +
			                "[~] - Close program\n\n" +
			                "(c) 2016 Alin Săndulache");
		}


		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		#endregion

	}
}
