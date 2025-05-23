using practicalwork2.Conversion;

namespace practicalwork2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnButtonClicked(object sender, EventArgs e)
		{
			if (sender is Button btn)
				InputEntry.Text += btn.Text;
		}

		private void OnClearClicked(object sender, EventArgs e)
		{
			InputEntry.Text = string.Empty;
		}

		private async void OnConvertClicked(object sender, EventArgs e)
		{
			if (sender is not Button btn) return;

			string input = InputEntry.Text;
			if (string.IsNullOrEmpty(input))
			{
				await DisplayAlert("Error", "Please enter a value to convert.", "OK");
				return;
			}

			string conversionType = btn.Text;
			string result = string.Empty;

			try
			{
				switch (conversionType)
				{
					case "DecimalToBinary":
						result = new DecimalToBinary("Decimal to binary", "Binary").Change(input);
						break;
					case "DecimalToTwoComplement":
						result = new DecimalToTwoComplement("Decimal to binary (TwoComplement)", "TwoComplement").Change(input);
						break;
					case "DecimalToOctal":
						result = new DecimalToOctal("Decimal to octal", "Octal").Change(input);
						break;
					case "DecimalToHexadecimal":
						result = new DecimalToHexadecimal("Decimal to hexadecimal", "Hexadecimal").Change(input);
						break;
					case "BinaryToDecimal":
						result = new BinaryToDecimal("Binary to decimal", "Decimal").Change(input);
						break;
					case "TwoComplementToDecimal":
						result = new TwoComplementToDecimal("Binary(TwoComplement) to Decimal", "Decimal").Change(input);
						break;
					case "OctalToDecimal":
						result = new OctalToDecimal("Octal to Decimal", "Decimal").Change(input);
						break;
					case "HexadecimalToDecimal":
						result = new HexadecimalToDecimal("Hexadecimal to Decimal", "Decimal").Change(input);
						break;
					default:
						await DisplayAlert("Error", $"Unknown conversion: {conversionType}", "OK");
						return;
				}

				await DisplayAlert("Result", $"Result: {result}", "OK");
				IncrementUserOperations();
			}
			catch (Exception ex)
			{
				await DisplayAlert("Conversion Failed", ex.Message, "OK");
			}
		}

		private void IncrementUserOperations()
		{
			var username = Preferences.Get("CurrentUser", string.Empty);
			if (string.IsNullOrEmpty(username)) return;

			var lines = File.ReadAllLines("users.csv").ToList();
			for (int i = 0; i < lines.Count; i++)
			{
				var fields = lines[i].Split(',');
				if (fields.Length >= 4 && fields[1] == username)
				{
					if (int.TryParse(fields[3], out int count))
						fields[3] = (count + 1).ToString();
					else
						fields[3] = "1";
					lines[i] = string.Join(",", fields);
					break;
				}
			}
			File.WriteAllLines("users.csv", lines);
		}

		private async void OnLogoutClicked(object sender, EventArgs e)
		{
			Preferences.Remove("CurrentUser");
			await Shell.Current.GoToAsync(nameof(LoginPage));
		}

		private async void OnBackClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync(nameof(LoginPage));
		}
	}
	
}



