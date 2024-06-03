using MauiCleanPlayGround.ViewModels;

namespace MauiCleanPlayGround;

public partial class MainPage : ContentPage
{
	int count = 0;

    public  MainPageViewModel vm { get; set; }

    public MainPage()
	{
		InitializeComponent();

        vm = new MainPageViewModel();
        BindingContext = vm;
	}

    void SwipeView_HandlerChanged(System.Object sender, System.EventArgs e)
    {
        vm.SwipeView_HandlerChanged.Execute(true);
    }
}


