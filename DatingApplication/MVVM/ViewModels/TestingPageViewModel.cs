//using AuthenticationServices;
using CommunityToolkit.Mvvm.ComponentModel;
using DatingApplication.MVVM.Models;
using PropertyChanged;
using System.Windows.Input;
using Bogus;

namespace DatingApplication.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public partial class TestingPageViewModel : ObservableObject
    {
        public List<User>? Users { get; set; }
        public User? CurrentUser { get; set; }
        public ICommand? AddOrUpdateCommand { get; set; }
        public ICommand? DeleteCommand { get; set; }


        public TestingPageViewModel()
        {
            Refresh();
            GenerateNewUser();
            AddOrUpdateCommand = new Command(async () =>
            {
                App.UserRepo.AddOrUpdate(CurrentUser);
                Console.WriteLine(App.UserRepo.statusMessage);
                GenerateNewUser();
                Refresh();
            });

            DeleteCommand = new Command(() =>
            {
                App.UserRepo.Delete(CurrentUser.Id);
                Refresh();
                GenerateNewUser();
            });
        }

        private void GenerateNewUser()
        {
            CurrentUser = new Faker<User>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Adress, f => f.Person.Address.Street)
                .Generate();
        }

        private void Refresh()
        {
            Users = App.UserRepo.GetAll();
        }
        

    }
}
