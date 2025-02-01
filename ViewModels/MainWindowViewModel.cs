namespace MyApp.ViewModels;
using MyApp.Views;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";



    private SubWindow _subWindow;

    public void OpenSubWindow()
    {
        _subWindow = new SubWindow();
        _subWindow.Show();
    }
}
