using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace News.ViewModels
{
    [ObservableObject]
    public abstract partial class ViewModel 
    {
       public INavigate Navigation { get; set; }
        internal ViewModel(INavigate navigation) => Navigation = navigation;
    }
}
