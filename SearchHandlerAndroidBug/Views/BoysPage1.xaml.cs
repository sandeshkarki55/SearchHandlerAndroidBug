using SearchHandlerAndroidBug.ViewModels;

namespace SearchHandlerAndroidBug.Views;

public partial class BoysPage1 : ContentPage
{
	public BoysPage1()
	{
		InitializeComponent();
		this.BindingContext = new BoysPageViewModel(1);
	}

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}