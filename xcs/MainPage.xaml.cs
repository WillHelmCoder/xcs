using System.ComponentModel;
using xcs.Models;

namespace xcs;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new PersonPageViewModel();
	}
    protected override void OnAppearing()
    {
        //redraw?
        base.OnAppearing();
    }

}

