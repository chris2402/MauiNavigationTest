
namespace maui_navigation_sandbox;

public partial class MyGlobalPage : ContentPage
{
    private readonly MyGlobalViewModel _viewModel;

    public MyGlobalPage(MyGlobalViewModel myGlobalViewModel)
	{
		InitializeComponent();

		BindingContext = _viewModel = myGlobalViewModel;
	}

    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}