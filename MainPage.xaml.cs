namespace TestScores
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddScoreClicked(object sender, EventArgs e)
		{
			lblTotalScore.Text = "Total Score";

		}

		private void OnClearClicked(object sender, EventArgs e)
		{
			lblTotalScore.Text = "0";
		}

		private void OnExitClicked(object sender, EventArgs e)
		{
			Application.Current.Quit();
		}
	}
}
