/*
 * Created by SharpDevelop.
 * User: AL
 * Date: 26.12.2016
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alarm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button startPauseButton;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.RadioButton tooltipRadioButton;
		private System.Windows.Forms.RadioButton popupRadioButton;
		private System.Windows.Forms.CheckBox soundCheckBox;
		private System.Windows.Forms.TextBox secondsTextBox;
		private System.Windows.Forms.TextBox minutesTextBox;
		private System.Windows.Forms.TextBox hoursTextBox;
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.calculateButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.resetButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startPauseButton = new System.Windows.Forms.Button();
			this.soundCheckBox = new System.Windows.Forms.CheckBox();
			this.popupRadioButton = new System.Windows.Forms.RadioButton();
			this.tooltipRadioButton = new System.Windows.Forms.RadioButton();
			this.secondsTextBox = new System.Windows.Forms.TextBox();
			this.minutesTextBox = new System.Windows.Forms.TextBox();
			this.hoursTextBox = new System.Windows.Forms.TextBox();
			this.settingsButton = new System.Windows.Forms.Button();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// calculateButton
			// 
			this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.calculateButton.FlatAppearance.BorderSize = 0;
			this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calculateButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculateButton.Location = new System.Drawing.Point(12, 64);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(68, 40);
			this.calculateButton.TabIndex = 4;
			this.calculateButton.Text = "Calc";
			this.calculateButton.UseVisualStyleBackColor = false;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 37);
			this.label1.TabIndex = 100;
			this.label1.Text = ":";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(195, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 37);
			this.label2.TabIndex = 100;
			this.label2.Text = ":";
			// 
			// textBox
			// 
			this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox.Location = new System.Drawing.Point(302, 11);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(357, 40);
			this.textBox.TabIndex = 3;
			this.textBox.Text = "Time\'s up!";
			this.textBox.Enter += new System.EventHandler(this.TextBoxEnter);
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(374, 64);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(66, 40);
			this.resetButton.TabIndex = 9;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Text = "Alarm";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.showToolStripMenuItem,
			this.aboutToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.showToolStripMenuItem.Text = "Show";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// startPauseButton
			// 
			this.startPauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.startPauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.startPauseButton.FlatAppearance.BorderSize = 0;
			this.startPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startPauseButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startPauseButton.Location = new System.Drawing.Point(446, 64);
			this.startPauseButton.Name = "startPauseButton";
			this.startPauseButton.Size = new System.Drawing.Size(213, 40);
			this.startPauseButton.TabIndex = 10;
			this.startPauseButton.Text = "Start";
			this.startPauseButton.UseVisualStyleBackColor = false;
			this.startPauseButton.Click += new System.EventHandler(this.StartPauseButtonClick);
			// 
			// soundCheckBox
			// 
			this.soundCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
			this.soundCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.soundCheckBox.Checked = true;
			this.soundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.soundCheckBox.FlatAppearance.BorderSize = 0;
			this.soundCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
			this.soundCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.soundCheckBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soundCheckBox.Location = new System.Drawing.Point(86, 64);
			this.soundCheckBox.Name = "soundCheckBox";
			this.soundCheckBox.Size = new System.Drawing.Size(66, 40);
			this.soundCheckBox.TabIndex = 5;
			this.soundCheckBox.Text = "Sound";
			this.soundCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.soundCheckBox.UseVisualStyleBackColor = false;
			// 
			// popupRadioButton
			// 
			this.popupRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.popupRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.popupRadioButton.FlatAppearance.BorderSize = 0;
			this.popupRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
			this.popupRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.popupRadioButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.popupRadioButton.Location = new System.Drawing.Point(230, 64);
			this.popupRadioButton.Name = "popupRadioButton";
			this.popupRadioButton.Size = new System.Drawing.Size(66, 40);
			this.popupRadioButton.TabIndex = 7;
			this.popupRadioButton.Text = "Popup";
			this.popupRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.popupRadioButton.UseVisualStyleBackColor = false;
			// 
			// tooltipRadioButton
			// 
			this.tooltipRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.tooltipRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.tooltipRadioButton.Checked = true;
			this.tooltipRadioButton.FlatAppearance.BorderSize = 0;
			this.tooltipRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(159)))), ((int)(((byte)(162)))));
			this.tooltipRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tooltipRadioButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tooltipRadioButton.Location = new System.Drawing.Point(158, 64);
			this.tooltipRadioButton.Name = "tooltipRadioButton";
			this.tooltipRadioButton.Size = new System.Drawing.Size(66, 40);
			this.tooltipRadioButton.TabIndex = 6;
			this.tooltipRadioButton.TabStop = true;
			this.tooltipRadioButton.Text = "Tooltip";
			this.tooltipRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.tooltipRadioButton.UseVisualStyleBackColor = false;
			// 
			// secondsTextBox
			// 
			this.secondsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.secondsTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondsTextBox.Location = new System.Drawing.Point(226, 11);
			this.secondsTextBox.Name = "secondsTextBox";
			this.secondsTextBox.Size = new System.Drawing.Size(70, 40);
			this.secondsTextBox.TabIndex = 2;
			this.secondsTextBox.Text = "00";
			this.secondsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.secondsTextBox.Click += new System.EventHandler(this.SecondsTextBoxClick);
			this.secondsTextBox.Enter += new System.EventHandler(this.SecondsTextBoxEnter);
			// 
			// minutesTextBox
			// 
			this.minutesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.minutesTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesTextBox.Location = new System.Drawing.Point(116, 11);
			this.minutesTextBox.Name = "minutesTextBox";
			this.minutesTextBox.Size = new System.Drawing.Size(70, 40);
			this.minutesTextBox.TabIndex = 1;
			this.minutesTextBox.Text = "00";
			this.minutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.minutesTextBox.Click += new System.EventHandler(this.MinutesTextBoxClick);
			this.minutesTextBox.Enter += new System.EventHandler(this.MinutesTextBoxEnter);
			// 
			// hoursTextBox
			// 
			this.hoursTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hoursTextBox.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hoursTextBox.Location = new System.Drawing.Point(9, 11);
			this.hoursTextBox.Name = "hoursTextBox";
			this.hoursTextBox.Size = new System.Drawing.Size(70, 40);
			this.hoursTextBox.TabIndex = 0;
			this.hoursTextBox.Text = "00";
			this.hoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.hoursTextBox.Click += new System.EventHandler(this.HoursTextBoxClick);
			this.hoursTextBox.Enter += new System.EventHandler(this.HoursTextBoxEnter);
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.settingsButton.FlatAppearance.BorderSize = 0;
			this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingsButton.Location = new System.Drawing.Point(302, 64);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(66, 40);
			this.settingsButton.TabIndex = 8;
			this.settingsButton.Text = "Set";
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(670, 116);
			this.Controls.Add(this.settingsButton);
			this.Controls.Add(this.secondsTextBox);
			this.Controls.Add(this.minutesTextBox);
			this.Controls.Add(this.hoursTextBox);
			this.Controls.Add(this.tooltipRadioButton);
			this.Controls.Add(this.popupRadioButton);
			this.Controls.Add(this.soundCheckBox);
			this.Controls.Add(this.startPauseButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.calculateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alarm";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
