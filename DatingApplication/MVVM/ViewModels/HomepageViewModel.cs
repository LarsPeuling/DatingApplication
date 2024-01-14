using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DatingApplication.MVVM.Pages;

namespace DatingApplication.MVVM.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _likeCount;
        public int LikeCount
        {
            get { return _likeCount; }
            set
            {
                _likeCount = value;
                OnPropertyChanged(nameof(LikeCount));
            }
        }

        public ICommand LikeCommand => new Command(() =>
        {
            LikeCount++;
        });

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
