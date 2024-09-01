
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ViewModels
{
    public partial class SettingsViewModel :ViewModel
    {
        [ObservableProperty]
        public string apiKey;

        public SettingsViewModel(INavigate navigate) : base(navigate) 
        {
            // ApiKey = Settings.NewsApiKey;
            Init();
        }

        public async void Init()
        {
            ApiKey = await Settings.GetNewsApiToken();
        }


        [RelayCommand]
        private async Task SaveSettingsAsync()
        {
            await Settings.SaveToken(this.ApiKey);

            //await Navigation.NavigateTo(new HeadlinesViewModel())
        }
    }
}
