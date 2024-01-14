using DatingApplication.Pages;
using Microsoft.Maui.Platform;

namespace DatingApplication.MVVM.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private void RegisterButton_Clicked(object sender, EventArgs e)
    {
        int age;
        bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
        bool isAgeEmpty = string.IsNullOrEmpty(AgeEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(PassowrdEntry.Text);

        if (isUsernameEmpty)
        {
            UsernameEntry.Placeholder = "Vul je Username in!";
        }
        else if (isPasswordEmpty)
        {
            PassowrdEntry.Placeholder = "Vul je Password in!";
        }
        else if (isAgeEmpty)
        {
            AgeEntry.Placeholder = "Vul je Leeftijd in!";
        }
        else if (!int.TryParse(AgeEntry.Text, out age))
        {
            DisplayAlert("Incorrect Input", "Vul een getal in hoger dan 18", "OK");
        }
        else if (age < 18)
        {
            DisplayAlert("Incorrect Age", "Vul een leeftijd in boven 18 jaar", "OK");
        }
        else
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}