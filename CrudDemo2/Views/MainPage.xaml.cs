using CrudDemo2.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace CrudDemo2.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
