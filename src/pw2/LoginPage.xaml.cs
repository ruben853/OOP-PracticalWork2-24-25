namespace practicalwork2
{
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        //var username = UsernameEntry.Text;
        //var password = PasswordEntry.Text;

        await Shell.Current.GoToAsync("//MainPage");
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//RegisterPage");
    }

    private async void OnPasswordClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//PasswordRecoverPage");
    }
}    
}