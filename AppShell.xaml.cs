﻿using MauiApp1.VIews;

namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(Page1), typeof(Page1));
        Routing.RegisterRoute(nameof(Page2), typeof(Page2));
    }
}
