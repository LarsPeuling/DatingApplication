using DatingApplication.Pages;

namespace DatingApplication.MVVM.Pages;

public partial class WorldMapPage : ContentPage
{
	public WorldMapPage()
	{
		InitializeComponent();
	}
    private async void CheckUserLocation_Clicked(object sender, EventArgs e)
    {
        try
        {
            var status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            if (status == PermissionStatus.Granted)
            {
                var location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    double latitude = location.Latitude;
                    double longitude = location.Longitude;
                    //await DisplayAlert("Huidige Locatie", $"Latitude: {latitude}\nLongitude: {longitude}, dit is hier:\n{location}", "OK");
                    await DisplayAlert("Huidige Locatie", $"Dit is jou Locatie\n {location}", "OK");
                }
                else
                {
                    await DisplayAlert("Huidige Locatie", "Huidige locatie niet gevonden.", "OK");
                }
            }
            else
            {
                await DisplayAlert("Fout", "Toestemming voor locatie is niet verleend", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Fout", $"Er is een fout opgetreden: {ex.Message}", "OK");
        }
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
    private void WorldMap_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WorldMapPage());
    }

}