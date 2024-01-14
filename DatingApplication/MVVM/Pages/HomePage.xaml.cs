using DatingApplication.MVVM.Models;
//using DatingApplication.MVVM.Pages;
using DatingApplication.MVVM.ViewModels;

namespace DatingApplication.Pages;

public partial class HomePage : ContentPage
{
    //public int LikeCountString { get; set; } = 0;
    public Label LikeCountLabel { get; set; }
    public Label DislikeCountLabel { get; set; }
    public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomePageViewModel();
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

    private void LikeButton_Clicked(object sender, EventArgs e)
    {
        LikeButton.Source = "heart.png";
        LikeCountLabel = new Label { Text = LikeCount.ToString() };
    }

    private void DislikeButton_Clicked(object sender, EventArgs e)
    {
        DislikeButton.Source = "unlike.png";
        DislikeCountLabel = new Label { Text = DislikeCount.ToString() };
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