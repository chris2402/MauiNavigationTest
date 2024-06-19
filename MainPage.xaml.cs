namespace maui_navigation_sandbox;

public partial class MainPage : Microsoft.Maui.Controls.ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void MyGlobalPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MyGlobalPage), AnimateCheckBox.IsChecked, new Dictionary<string, object>()
        {
            {
                MyNavigationParameter.KEY, 
                new MyNavigationParameter()
                {
                    DateTimeValue  = DateTime.Now,
                    StringValue = "Hello from MainPage"
                }
            },
        });
    }

    private async void MyContentPageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MyContentPage", AnimateCheckBox.IsChecked, new Dictionary<string, object>()
        {
            {
                MyNavigationParameter.KEY,
                new MyNavigationParameter()
                {
                    DateTimeValue  = DateTime.Now,
                    StringValue = "Hello from MainPage"
                }
            },
        });
    }
}

