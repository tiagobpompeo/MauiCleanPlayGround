using System;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace MauiCleanPlayGround.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
        public ICommand ChangeTextCommand { get; }
        public ICommand SwipeView_HandlerChanged { get; set; }

        public MainPageViewModel()
		{
            ChangeTextCommand = new Command(ChangeText);
            SwipeView_HandlerChanged = new Command(ChangeSwipeText);
        }

        private void ChangeText()
        {
            Console.WriteLine("Changed Method");
        }

        public void ChangeSwipeText()
        {
            Console.WriteLine("Changed ChangeSwipeText");
        }
    }
}

