using BindingToColourProblem.ViewModels;

namespace BindingToColourProblem;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainPageViewModel();
	}

}

