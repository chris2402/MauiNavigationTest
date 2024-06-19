namespace maui_navigation_sandbox;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(MyGlobalPage), typeof(MyGlobalPage));
	}
}
