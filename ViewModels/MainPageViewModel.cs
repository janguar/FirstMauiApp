using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.VIews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty] // source generator
        ObservableCollection<string> items;

        //public string Title { get; set; } = "Main Page";

        //string title;
        //public string Title
        //{
        //    get => title;
        //    set
        //    {
        //        title = value;
        //        OnPropertyChanged(nameof(Title));
        //    }
        //}

        [ObservableProperty] // source generator
        string title;

        [ObservableProperty] // source generator
        string text;


        public MainPageViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ICommand]
        void Add()
        {

            if (string.IsNullOrEmpty(text))
                return;
            // 
            Items.Add(text);
            Text = string.Empty;

        }


        [ICommand]
        void Remove(string s)
        { 
            if(Items.Contains(s))
                Items.Remove(s);
           
        }


        [ICommand]
        async void Tap(string s)
        {
           await Shell.Current.GoToAsync($"{nameof(Page1)}?Text={s}");
        }


    }
}
