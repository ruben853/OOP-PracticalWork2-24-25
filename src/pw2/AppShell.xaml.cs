namespace practicalwork2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
		Routing.RegisterRoute(nameof(OperationsPage), typeof(OperationsPage));
		Routing.RegisterRoute(nameof(PasswordRecoverPage), typeof(PasswordRecoverPage));

	}
}
