namespace DatingApplication.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void LogInButton_Clicked(object sender, EventArgs e)
    {
        bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

        if (isUsernameEmpty)
        {
            UsernameEntry.Placeholder = "Vul je Username in!";
        }
        else if (isPasswordEmpty)
        {
            PasswordEntry.Placeholder = "Vul je Password in!";
        }
        else
        {
            Navigation.PushAsync(new HomePage());
        }
    }

}