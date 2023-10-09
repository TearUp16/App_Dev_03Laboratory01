namespace MauiApp3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	async void OnDial (object sender, EventArgs e)
	{
		try
		{
			PhoneDialer.Open(PhoneNum.Text);
			
		}
		catch (Exception)
		{
            await DisplayAlert("Invalid input", "Please enter a valid phone number", "OK");
			throw;
        }
	}
}

