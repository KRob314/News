﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.ViewModels;

namespace News
{
    internal class Navigator : INavigate
    {
        public async Task NavigateTo(string route) => await Shell.Current.GoToAsync(route);

        public async Task PopModal() => await Shell.Current.Navigation.PopModalAsync();

        public async Task PushModal(Page page) => await Shell.Current.Navigation.PushModalAsync(page);
    }
}
