using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using demo02121.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace demo02121;

public partial class CurrentZayavki : Window
{
    public List<Order> zayavkas = Helper.user11037.Orders.Where(x => x.IdUser == Helper.curruser.IdUser)
        .Include(x => x.IdEmployeeNavigation).Include(x => x.IdEmployeeNavigation.IdDepNavigation.Dep).
        Include(x => x.IdStatusNavigation).ToList();
    public CurrentZayavki()
    {
        InitializeComponent();
        update();
    }

    private void update()
    {
        var list = zayavkas;
        //Helper.context.Zayavkas;
        listB.ItemsSource = list.ToList();
    }

    private void vyhod_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainWindow main = new MainWindow();
        main.Show();
        this.Close();
    }

    private void NewZ_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        SelectType select = new SelectType();
        select.Show();
        this.Close();

    }


}