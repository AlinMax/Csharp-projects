/*
 * Created by SharpDevelop.
 * User: AL
 * Date: 26.12.2016
 * Time: 21:46
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alarm
{
	/// <summary>
	/// Description of Calculate.
	/// </summary>
	public partial class Calculate : Form
	{
		public int h;
		public int m;
		public int s;
		public bool startNow;
		
		public Calculate()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void CalculateLoad(object sender, EventArgs e)
		{
			Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			
			timer1.Start();
			hoursTextBox2.Focus();
		}
		
		
		void ValidateData()
		{
			h = Convert.ToInt32(hoursTextBox2.Text);
			m = Convert.ToInt32(minutesTextBox2.Text);
			s = Convert.ToInt32(secondsTextBox2.Text);
			
			if ((h > 23) || (h < 0) || (m > 60) || (m < 0) || (s > 60) || (s < 0))
			{
				MessageBox.Show("Input time in a correct format (HH:MM:SS)");
				DialogResult = DialogResult.None;
			}
			else
			{
				ProcessData();
			}
		}
		
		
		void ProcessData()
		{
			TimeSpan start = TimeSpan.Parse(hoursTextBox1.Text + ":" + minutesTextBox1.Text + ":" + secondsTextBox1.Text);
			TimeSpan end = TimeSpan.Parse(h.ToString().PadLeft(2, '0') + ":" + m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0'));
			TimeSpan duration = (end - start);
			
			if (end < start)
			{
				TimeSpan a = TimeSpan.FromHours(24);
				var b = duration.Add(a);
				h = b.Hours;
				m = b.Minutes;
				s = b.Seconds;
			}
			else
			{
				h = duration.Hours;
				m = duration.Minutes;
				s = duration.Seconds;
			}
			
			timer1.Stop();
		}
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			var time = DateTime.Now;
			hoursTextBox1.Text = time.Hour.ToString().PadLeft(2, '0');
			minutesTextBox1.Text = time.Minute.ToString().PadLeft(2, '0');
			secondsTextBox1.Text = time.Second.ToString().PadLeft(2, '0');
		}
		
		
		void CalculateButtonClick(object sender, EventArgs e)
		{
			ValidateData();
		}
		
		
		void StartNowButtonClick(object sender, EventArgs e)
		{
			startNow = true;
			ValidateData();
		}
		

		void CancelButtonClick(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			h = 0;
			m = 0;
			s = 0;
			hoursTextBox2.Text = "00";
			minutesTextBox2.Text = "00";
			secondsTextBox2.Text = "00";
		}
		
		
		void HoursTextBox2Enter(object sender, EventArgs e)
		{
			hoursTextBox2.Select(0, hoursTextBox2.Text.Length);
		}
		
		
		void MinutesTextBox2Enter(object sender, EventArgs e)
		{
			minutesTextBox2.Select(0, minutesTextBox2.Text.Length);
		}
		
		
		void SecondsTextBox2Enter(object sender, EventArgs e)
		{
			secondsTextBox2.Select(0, secondsTextBox2.Text.Length);
		}
		
		
		void HoursTextBox2Click(object sender, EventArgs e)
		{
			hoursTextBox2.Select(0, hoursTextBox2.Text.Length);
		}
		
		
		void MinutesTextBox2Click(object sender, EventArgs e)
		{
			minutesTextBox2.Select(0, minutesTextBox2.Text.Length);
		}
		
		
		void SecondsTextBox2Click(object sender, EventArgs e)
		{
			secondsTextBox2.Select(0, secondsTextBox2.Text.Length);
		}
		
		
		void CalculateKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				startNow = true;
				ValidateData();
			}
			else if (e.KeyCode == Keys.Escape)
			{
				CancelButtonClick(null, null);
			}
		}
		
	}
}