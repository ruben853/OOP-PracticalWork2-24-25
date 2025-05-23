namespace practicalwork2
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (name == username || password != confirmPassword || !PolicyCheckBox.IsChecked || !IsValidPassword(password))
            {
                await DisplayAlert("Error", "Check your input fields.", "OK");
                return;
            }

            // Save user to JSON (add logic here)
            string csvLine = $"{name},{username},{password},0";
            File.AppendAllText("users.csv", csvLine + Environment.NewLine);

            await DisplayAlert("Success", "User registered successfully.", "OK");
            await Shell.Current.GoToAsync("../");
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsDigit) &&
                password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../");
        }
    }
}