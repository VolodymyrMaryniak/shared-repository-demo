
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.subtractionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(50, 18);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(185, 23);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(50, 43);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(185, 23);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericTextBox_KeyPress);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(50, 128);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(45, 15);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result: ";
            // 
            // subtractionBtn
            // 
            this.subtractionBtn.Location = new System.Drawing.Point(50, 85);
            this.subtractionBtn.Name = "subtractionBtn";
            this.subtractionBtn.Size = new System.Drawing.Size(75, 23);
            this.subtractionBtn.TabIndex = 3;
            this.subtractionBtn.Text = "-";
            this.subtractionBtn.UseVisualStyleBackColor = true;
            this.subtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 187);
            this.Controls.Add(this.subtractionBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstNumberTextBox;
		private System.Windows.Forms.TextBox secondNumberTextBox;
		private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button subtractionBtn;
    }
}

