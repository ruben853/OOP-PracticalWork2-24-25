namespace practicalwork2
{
    public partial class OperationsPage : ContentPage
    {
        public OperationsPage()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Load user info from file and update labels
            NameLabel.Text = "Name: John Doe";
            UsernameLabel.Text = "Username: johnd";
            PasswordLabel.Text = "Password: ********";
            OpsLabel.Text = "Operations Executed: 12";
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("MainPage");
        }
    }
}