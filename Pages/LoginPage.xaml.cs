namespace SocialMediaApp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnRegister_Clicked(object sender, EventArgs e)
        {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
        }
    }