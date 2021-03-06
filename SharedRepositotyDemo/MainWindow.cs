using System;
using System.Windows.Forms;

namespace SharedRepositoryDemo
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(sender is TextBox textBox))
				throw new ArgumentException(nameof(sender));

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if (e.KeyChar == '.' && textBox.Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void AddBtn_Click(object sender, EventArgs e)
        {
	        var fistNumber = Convert.ToDecimal(firstNumberTextBox.Text);
	        var secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

            SetResult(fistNumber + secondNumber);
        }

		private void SubtractionBtn_Click(object sender, EventArgs e)
		{
			var firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
			var secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

			SetResult(firstNumber - secondNumber);
		}

		private void SetResult(decimal result)
        {
	        // ReSharper disable once LocalizableElement
	        resultLabel.Text = $"Result: {result}";
        }
	}
}
