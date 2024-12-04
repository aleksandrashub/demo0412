using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;

namespace demo02121;

public partial class SelectType : Window
{
    public SelectType()
    {
        InitializeComponent();

        grImg.Source = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Assets\\group.png");
        lichImg.Source = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "Assets\\lichnoe.png");
    }
    private void lichnoe_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

    }
    private void group_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

    }

}