using CommunityToolkit.Mvvm.ComponentModel;
using DatingApplication.Models;
using DatingApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly ProfileService _profileService;
        public HomeViewModel(ProfileService profileService)
        {
            _profileService = profileService;
            
        }
    }
}
