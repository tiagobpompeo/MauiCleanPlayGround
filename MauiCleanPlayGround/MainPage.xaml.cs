using MauiCleanPlayGround.ViewModels;

namespace MauiCleanPlayGround;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainPageViewModel();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
	}
}


