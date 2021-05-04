
namespace SharedRepositoryDemo
{
	partial class MainWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.firstNumberTextBox = new System.Windows.Forms.TextBox();
			this.secondNumberTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// firstNumberTextBox
			// 
			this.firstNumberTextBox.Location = new System.Drawing.Point(71, 30);
			this.firstNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.firstNumberTextBox.Name = "firstNumberTextBox";
			this.firstNumberTextBox.Size = new System.Drawing.Size(262, 31);
			this.firstNumberTextBox.TabIndex = 0;
			this.firstNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
			// 
			// secondNumberTextBox
			// 
			this.secondNumberTextBox.Location = new System.Drawing.Point(71, 71);
			this.secondNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.secondNumberTextBox.Name = "secondNumberTextBox";
			this.secondNumberTextBox.Size = new System.Drawing.Size(262, 31);
			this.secondNumberTextBox.TabIndex = 1;
			this.secondNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 312);
			this.Controls.Add(this.secondNumberTextBox);
			this.Controls.Add(this.firstNumberTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainWindow";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNumberTextBox;
		private System.Windows.Forms.TextBox secondNumberTextBox;
	}
}

