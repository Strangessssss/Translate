using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TaskManager.Views.CustomControls;

public partial class TitleBar : UserControl
{
    public TitleBar()
    {
        InitializeComponent();
        MouseLeftButtonDown += CustomTitleBar_MouseLeftButtonDown;
    }

    private void CustomTitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        Window.GetWindow(this)?.DragMove();
    }
}