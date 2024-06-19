using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace maui_navigation_sandbox;


// RESEARCH: QueryPropertyAttribute - This is one of two ways to register the parameter for the Page/ViewModel.
// Paramterers are sent from Event Handler in MainPage.xaml.cs
[QueryProperty(nameof(Parameter), MyNavigationParameter.KEY)]
public class MyGlobalViewModel : INotifyPropertyChanged
{
    

    private MyNavigationParameter _parameter;

    public MyNavigationParameter Parameter
    {
        get { return _parameter; }
        set
        {
            _parameter = value;
            OnPropertyChanged();
            
            ContentString = $"String: {value.StringValue} - DateTime: {value.DateTimeValue}";
        }
    }

    private string _contentString;
    public string ContentString 
    { 
        get => _contentString; 
        private set
        { 
            _contentString = value;
            OnPropertyChanged();
        }
    }

    private void OnPropertyChanged([CallerMemberName] string path = null) 
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(path));

    public event PropertyChangedEventHandler PropertyChanged;
}
