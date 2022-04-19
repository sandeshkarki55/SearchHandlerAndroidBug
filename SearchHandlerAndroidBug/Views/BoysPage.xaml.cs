using SearchHandlerAndroidBug.ViewModels;

namespace SearchHandlerAndroidBug.Views;

public partial class BoysPage : ContentPage
{
	public BoysPage()
	{
		InitializeComponent();
		this.BindingContext = new BoysPageViewModel();
	}

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}