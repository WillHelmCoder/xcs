using xcs.Models;

namespace xcs;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new PersonPageViewModel();
  



	}

    private void lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }

    private void lista_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}

