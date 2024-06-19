
namespace maui_navigation_sandbox;



public partial class MyContentPage : ContentPage, IQueryAttributable
{
	public MyContentPage()
	{
		InitializeComponent();
	}


    // RESEARCH: IQueryAttributable - This is one of two ways to register the parameter for the Page/ViewModel - 
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue(MyNavigationParameter.KEY, out var navParam) 
            && navParam is MyNavigationParameter customParam)
        {
            MyLabel.Text = $"String: {customParam.StringValue} - DateTime: {customParam.DateTimeValue}";
        }
    }

    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//MainPage");
    }
}