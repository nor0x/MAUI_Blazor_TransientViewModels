namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewmodel)
    {
        BindingContext = viewmodel;
        InitializeComponent();
        MyBlazorWebView.Parameters = new Dictionary<string, object>
        {
           { "ViewModel", viewmodel }
        };
    }
}