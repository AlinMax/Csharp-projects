/*
 * Created by SharpDevelop.
 * User: AL
 * Date: 26.12.2016
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alarm
{
	partial class Calculate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button startNowButton;
		private System.Windows.Forms.TextBox hoursTextBox1;
		private System.Windows.Forms.TextBox minutesTextBox1;
		private System.Windows.Forms.TextBox secondsTextBox1;
		private System.Windows.Forms.TextBox secondsTextBox2;
		private System.Windows.Forms.TextBox minutesTextBox2;
		private System.Windows.Forms.TextBox hoursTextBox2;
		
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
			this.resetButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.startNowButton = new System.Windows.Forms.Button();
			this.hoursTextBox1 = new System.Windows.Forms.TextBox();
			this.minutesTextBox1 = new System.Windows.Forms.TextBox();
			this.secondsTextBox1 = new System.Windows.Forms.TextBox();
			this.secondsTextBox2 = new System.Windows.Forms.TextBox();
			this.minutesTextBox2 = new System.Windows.Forms.TextBox();
			this.hoursTextBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// calculateButton
			// 
			this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.calculateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.calculateButton.FlatAppearance.BorderSize = 0;
			this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calculateButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculateButton.Location = new System.Drawing.Point(170, 172);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(126, 40);
			this.calculateButton.TabIndex = 3;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = false;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(91, 172);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(73, 40);
			this.resetButton.TabIndex = 6;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(195, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 37);
			this.label2.TabIndex = 100;
			this.label2.Text = ":";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 37);
			this.label1.TabIndex = 100;
			this.label1.Text = ":";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(195, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 37);
			this.label3.TabIndex = 112;
			this.label3.Text = ":";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(88, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 37);
			this.label4.TabIndex = 113;
			this.label4.Text = ":";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(177, 23);
			this.label5.TabIndex = 100;
			this.label5.Text = "Current time";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(9, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 23);
			this.label6.TabIndex = 100;
			this.label6.Text = "Target time";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(9, 172);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(73, 40);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// startNowButton
			// 
			this.startNowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.startNowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.startNowButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.startNowButton.FlatAppearance.BorderSize = 0;
			this.startNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startNowButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startNowButton.Location = new System.Drawing.Point(9, 218);
			this.startNowButton.Name = "startNowButton";
			this.startNowButton.Size = new System.Drawing.Size(287, 40);
			this.startNowButton.TabIndex = 4;
			this.startNowButton.Text = "Start Now";
			this.startNowButton.UseVisualStyleBackColor = false;
			this.startNowButton.Click += new System.EventHandler(this.StartNowButtonClick);
			// 
			// hoursTextBox1
			// 
			this.hoursTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hoursTextBox1.Enabled = false;
			this.hoursTextBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hoursTextBox1.Location = new System.Drawing.Point(9, 35);
			this.hoursTextBox1.Name = "hoursTextBox1";
			this.hoursTextBox1.Size = new System.Drawing.Size(70, 40);
			this.hoursTextBox1.TabIndex = 100;
			this.hoursTextBox1.TabStop = false;
			this.hoursTextBox1.Text = "00";
			this.hoursTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// minutesTextBox1
			// 
			this.minutesTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.minutesTextBox1.Enabled = false;
			this.minutesTextBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesTextBox1.Location = new System.Drawing.Point(116, 35);
			this.minutesTextBox1.Name = "minutesTextBox1";
			this.minutesTextBox1.Size = new System.Drawing.Size(70, 40);
			this.minutesTextBox1.TabIndex = 115;
			this.minutesTextBox1.TabStop = false;
			this.minutesTextBox1.Text = "00";
			this.minutesTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// secondsTextBox1
			// 
			this.secondsTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.secondsTextBox1.Enabled = false;
			this.secondsTextBox1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondsTextBox1.Location = new System.Drawing.Point(226, 35);
			this.secondsTextBox1.Name = "secondsTextBox1";
			this.secondsTextBox1.Size = new System.Drawing.Size(70, 40);
			this.secondsTextBox1.TabIndex = 116;
			this.secondsTextBox1.TabStop = false;
			this.secondsTextBox1.Text = "00";
			this.secondsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// secondsTextBox2
			// 
			this.secondsTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.secondsTextBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondsTextBox2.Location = new System.Drawing.Point(228, 115);
			this.secondsTextBox2.Name = "secondsTextBox2";
			this.secondsTextBox2.Size = new System.Drawing.Size(70, 40);
			this.secondsTextBox2.TabIndex = 2;
			this.secondsTextBox2.Text = "00";
			this.secondsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.secondsTextBox2.Click += new System.EventHandler(this.SecondsTextBox2Click);
			this.secondsTextBox2.Enter += new System.EventHandler(this.SecondsTextBox2Enter);
			// 
			// minutesTextBox2
			// 
			this.minutesTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.minutesTextBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesTextBox2.Location = new System.Drawing.Point(118, 115);
			this.minutesTextBox2.Name = "minutesTextBox2";
			this.minutesTextBox2.Size = new System.Drawing.Size(70, 40);
			this.minutesTextBox2.TabIndex = 1;
			this.minutesTextBox2.Text = "00";
			this.minutesTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.minutesTextBox2.Click += new System.EventHandler(this.MinutesTextBox2Click);
			this.minutesTextBox2.Enter += new System.EventHandler(this.MinutesTextBox2Enter);
			// 
			// hoursTextBox2
			// 
			this.hoursTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.hoursTextBox2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hoursTextBox2.Location = new System.Drawing.Point(11, 115);
			this.hoursTextBox2.Name = "hoursTextBox2";
			this.hoursTextBox2.Size = new System.Drawing.Size(70, 40);
			this.hoursTextBox2.TabIndex = 0;
			this.hoursTextBox2.Text = "00";
			this.hoursTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.hoursTextBox2.Click += new System.EventHandler(this.HoursTextBox2Click);
			this.hoursTextBox2.Enter += new System.EventHandler(this.HoursTextBox2Enter);
			// 
			// Calculate
			// 
			this.AcceptButton = this.startNowButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(308, 270);
			this.Controls.Add(this.secondsTextBox2);
			this.Controls.Add(this.minutesTextBox2);
			this.Controls.Add(this.hoursTextBox2);
			this.Controls.Add(this.secondsTextBox1);
			this.Controls.Add(this.minutesTextBox1);
			this.Controls.Add(this.hoursTextBox1);
			this.Controls.Add(this.startNowButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "Calculate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Calculate";
			this.Load += new System.EventHandler(this.CalculateLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculateKeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
