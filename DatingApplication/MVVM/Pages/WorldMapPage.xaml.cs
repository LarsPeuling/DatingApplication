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
			var location = await Geolocation.GetLocationAsync();
			if (location != null)
			{
				double latitude = location.Latitude;
				double longitude = location.Longitude;
				DisplayAlert("Huidige Locatie", $"Latitude: {latitude}\nLongitude: {longitude}, dit is hier:\n{location}", "OK");
			}
			else
			{
				DisplayAlert("Huidige Locatie", "Huidige locatie niet gevonden.", "OK");
			}
		}
		catch (PermissionException)
		{
			DisplayAlert("Fout", "Toestemming voor locatie is niet verleend", "OK");
		}
		catch (Exception ex)
		{
			DisplayAlert("Fout", $"Er is een fout opgetreden : {ex.Message}", "OK");
		}
	}
}