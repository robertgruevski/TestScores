namespace TestScores
{
	public partial class MainPage : ContentPage
	{
		int totalScore = 0; // Accumulated Score
		int testScoreCount = 0;
		float averageScore = 0f;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnAddScoreClicked(object sender, EventArgs e)
		{
			// Validate the user input with TryParse
			if (int.TryParse(txtScoreEntry.Text, out int testScore) && testScore >= 0 && testScore <= 100)
			{
				// Conversion Worked
				++testScoreCount; // Increment the test score count

				// Math
				totalScore += testScore; // Add the score to the total
				averageScore = (float)totalScore / testScoreCount; // Calculate the average score

				// Output the result to the label
				lblTotalScore.Text = $"\t{totalScore}";
				lblScoreCount.Text = $"\t{testScoreCount}";
				lblAverageScore.Text = $"\t{averageScore}";
			}
			else
			{
				// Conversion Failed
				DisplayAlert("Invalid Input", "Please enter a valid score.", "OK");
			}
			txtScoreEntry.Text = string.Empty; // Clear the input field
		}

		private void OnClearClicked(object sender, EventArgs e)
		{
			lblTotalScore.Text = string.Empty;
			lblScoreCount.Text = string.Empty;
			lblAverageScore.Text = string.Empty;
			totalScore = 0;
			testScoreCount = 0;
			averageScore = 0f;
			txtScoreEntry.Text = string.Empty; // Clear the input field
		}

		private void OnExitClicked(object sender, EventArgs e) => Application.Current.Quit();
	}
}
