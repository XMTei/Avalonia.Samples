using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RectPainter.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Save some enveironmental setting before closing this application
    /// </summary>
    /// <param name="e"></param>
    protected override void OnClosing(WindowClosingEventArgs e)
    {
        base.OnClosing(e);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="e"></param>
    protected override void OnLoaded(RoutedEventArgs e)
    {
        //base.OnLoaded(e);
        //here is how to set this window size while this app is loaded
        Width = 500;
        Height = 500;
    }
}
