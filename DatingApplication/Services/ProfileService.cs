using DatingApplication.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.Services
{
    public class ProfileService
    {
        private readonly static IEnumerable<User> _profiles = new List<User>
        {
            new User
            {
                Name = "Lars",
                Age = 18,
                Bio = "Krachttraining"
            },
            new User
            {
                Name = "Jasper",
                Age = 19,
                Bio ="Gezellig"
            }
        };
        public IEnumerable<User> GetAllProfiles() => _profiles;
        public IEnumerable<User> GetProfiles(string type) => string.IsNullOrWhiteSpace(type) ? _profiles : _profiles.Where(p => p.Name.Contains(type, StringComparison.OrdinalIgnoreCase));
    }
}
