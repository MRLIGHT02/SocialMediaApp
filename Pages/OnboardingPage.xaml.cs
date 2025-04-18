namespace SocialMediaApp.Pages;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
        {
        await Shell.Current.GoToAsync($"//{(nameof(LoginPage))}");// for Changing Page
        }

    //private async void GoToTest_Clicked(object sender, EventArgs e)
    //    {
    //    await Shell.Current.GoToAsync($"{(nameof(TestPage), typeof(TestPage))}");
    //    }
    }