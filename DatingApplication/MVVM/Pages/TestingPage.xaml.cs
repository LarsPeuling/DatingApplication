namespace DatingApplication.Pages;

public partial class TestingPage : ContentPage
{
	public TestingPage()
	{
		InitializeComponent();
	}
    private void ProfileButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
    }
    private void HomeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());
    }

    private void Testing_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TestingPage());
    }
}