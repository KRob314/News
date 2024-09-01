using CommunityToolkit.Mvvm.ComponentModel;
using News.ViewModels;
using System.Windows.Input;

namespace News.Views;

public partial class SettingsView : ContentPage
{
	readonly SettingsViewModel viewModel;
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));



    public SettingsView(SettingsViewModel settingsViewModel)
	{
		this.viewModel = settingsViewModel;
		InitializeComponent();
		BindingContext = viewModel;
	}

}