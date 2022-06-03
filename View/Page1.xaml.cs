using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiApp1.VIews;

public partial class Page1 : ContentPage
{
	public Page1(Page1ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}