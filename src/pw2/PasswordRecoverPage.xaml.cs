namespace practicalwork2
{
    public partial class PasswordRecoverPage : ContentPage
    {
        public PasswordRecoverPage()
        {
            InitializeComponent();
        }

        private async void OnRecoverClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            var lines = File.ReadAllLines("users.csv");
            foreach (var line in lines)
            {
                var fields = line.Split(',');
                if (fields.Length >= 3 && fields[1] == username)
                {
                    await DisplayAlert("Recovered", $"Your password is: {fields[2]}", "OK");
                    return;
                }
            }
            await DisplayAlert("Not Found", "Username not found", "OK");
        }
    }
}