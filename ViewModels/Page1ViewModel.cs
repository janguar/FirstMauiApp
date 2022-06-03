﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{


    [QueryProperty("Text", "Text")]
    public partial class Page1ViewModel: ObservableObject
    {
        [ObservableProperty]
        string text;
         
        [ICommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
