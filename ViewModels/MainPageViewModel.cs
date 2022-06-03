using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.VIews;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels
{
	public partial class MainPageViewModel : ObservableObject
	{
		[ObservableProperty] // source generator
		private ObservableCollection<string> items;

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
		private string title;

		[ObservableProperty] // source generator
		private string text;

		//private IConnectivity connectivity;

		public MainPageViewModel() // IConnectivity connectivity
		{
			Items = new ObservableCollection<string>();
			//this.connectivity = connectivity;
		}

		[ICommand]
		private void Add()
		{
			if (string.IsNullOrEmpty(text))
				return;

			//if (connectivity.NetworkAccess != NetworkAccess.Internet)
			//{
			//	await Shell.Current.DisplayAlert("Network", "No Internet", "Ok");
			//}

			Items.Add(text);
			Text = string.Empty;
		}

		[ICommand]
		private void Remove(string s)
		{
			if (Items.Contains(s))
				Items.Remove(s);
		}

		[ICommand]
		private async void Tap(string s)
		{
			await Shell.Current.GoToAsync($"{nameof(Page1)}?Text={s}");
		}
	}
}