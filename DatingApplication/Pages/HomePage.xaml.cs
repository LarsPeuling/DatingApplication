using DatingApplication.Models;

namespace DatingApplication.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
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

    /*public async void AddProfileCard(ProfileCard card)
    {
        // Create a new profile card view
        var cardView = new ProfileCardView(card);

        // Add the card view to the grid
        CardGrid.Children.Add(cardView);

        // Start the card entrance animation
        await cardView.EntranceAnimation();
    }

    public async void SwipeProfileCard(ProfileCardView cardView, SwipeDirection direction)
    {
        // Play the card swipe animation
        await cardView.SwipeAnimation(direction);

        // Remove the card view from the grid
        CardGrid.Children.Remove(cardView);

        // Update the swipes, likes, and dislikes count
        // ...
    }*/
}