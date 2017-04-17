/*
 * Created by SharpDevelop.
 * User: AL
 * Date: 22.02.2017
 * Time: 22:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Alarm
{
	partial class Settings
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox soundFileTextBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown soundDurationNumericUpDown;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox soundCheckBox;
		private System.Windows.Forms.RadioButton tooltipRadioButton;
		private System.Windows.Forms.RadioButton popupRadioButton;
		private System.Windows.Forms.CheckBox minimizeProgramCheckBox;
		
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
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.soundFileTextBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.soundDurationNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.soundCheckBox = new System.Windows.Forms.CheckBox();
			this.tooltipRadioButton = new System.Windows.Forms.RadioButton();
			this.popupRadioButton = new System.Windows.Forms.RadioButton();
			this.minimizeProgramCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.soundDurationNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(12, 198);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(146, 40);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(236, 198);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(66, 40);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = false;
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(164, 198);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(66, 40);
			this.resetButton.TabIndex = 8;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Sound file:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// soundFileTextBox
			// 
			this.soundFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.soundFileTextBox.Location = new System.Drawing.Point(12, 35);
			this.soundFileTextBox.Name = "soundFileTextBox";
			this.soundFileTextBox.Size = new System.Drawing.Size(190, 23);
			this.soundFileTextBox.TabIndex = 0;
			// 
			// browseButton
			// 
			this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
			this.browseButton.FlatAppearance.BorderSize = 0;
			this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browseButton.Location = new System.Drawing.Point(208, 35);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(94, 23);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "Browse...";
			this.browseButton.UseVisualStyleBackColor = false;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Sound duration (in ms):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// soundDurationNumericUpDown
			// 
			this.soundDurationNumericUpDown.Increment = new decimal(new int[] {
			100,
			0,
			0,
			0});
			this.soundDurationNumericUpDown.Location = new System.Drawing.Point(208, 70);
			this.soundDurationNumericUpDown.Maximum = new decimal(new int[] {
			100000,
			0,
			0,
			0});
			this.soundDurationNumericUpDown.Minimum = new decimal(new int[] {
			100,
			0,
			0,
			0});
			this.soundDurationNumericUpDown.Name = "soundDurationNumericUpDown";
			this.soundDurationNumericUpDown.Size = new System.Drawing.Size(94, 23);
			this.soundDurationNumericUpDown.TabIndex = 2;
			this.soundDurationNumericUpDown.Value = new decimal(new int[] {
			3000,
			0,
			0,
			0});
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Default settings:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// soundCheckBox
			// 
			this.soundCheckBox.Location = new System.Drawing.Point(14, 139);
			this.soundCheckBox.Name = "soundCheckBox";
			this.soundCheckBox.Size = new System.Drawing.Size(80, 24);
			this.soundCheckBox.TabIndex = 3;
			this.soundCheckBox.Text = "Sound";
			this.soundCheckBox.UseVisualStyleBackColor = true;
			// 
			// tooltipRadioButton
			// 
			this.tooltipRadioButton.Location = new System.Drawing.Point(130, 138);
			this.tooltipRadioButton.Name = "tooltipRadioButton";
			this.tooltipRadioButton.Size = new System.Drawing.Size(83, 24);
			this.tooltipRadioButton.TabIndex = 4;
			this.tooltipRadioButton.TabStop = true;
			this.tooltipRadioButton.Text = "Tooltip";
			this.tooltipRadioButton.UseVisualStyleBackColor = true;
			// 
			// popupRadioButton
			// 
			this.popupRadioButton.Location = new System.Drawing.Point(219, 138);
			this.popupRadioButton.Name = "popupRadioButton";
			this.popupRadioButton.Size = new System.Drawing.Size(83, 24);
			this.popupRadioButton.TabIndex = 5;
			this.popupRadioButton.TabStop = true;
			this.popupRadioButton.Text = "Popup";
			this.popupRadioButton.UseVisualStyleBackColor = true;
			// 
			// minimizeProgramCheckBox
			// 
			this.minimizeProgramCheckBox.Checked = true;
			this.minimizeProgramCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.minimizeProgramCheckBox.Location = new System.Drawing.Point(14, 168);
			this.minimizeProgramCheckBox.Name = "minimizeProgramCheckBox";
			this.minimizeProgramCheckBox.Size = new System.Drawing.Size(288, 24);
			this.minimizeProgramCheckBox.TabIndex = 6;
			this.minimizeProgramCheckBox.Text = "Minimize program after alarm start";
			this.minimizeProgramCheckBox.UseVisualStyleBackColor = true;
			// 
			// Settings
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(314, 250);
			this.Controls.Add(this.minimizeProgramCheckBox);
			this.Controls.Add(this.popupRadioButton);
			this.Controls.Add(this.tooltipRadioButton);
			this.Controls.Add(this.soundCheckBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.soundDurationNumericUpDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.soundFileTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.soundDurationNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
