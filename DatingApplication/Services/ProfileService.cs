using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.Services
{
    public class ProfileService
    {
        private readonly static IEnumerable<Profile> _profiles = new List<Profile>
        {
            new Profile
            {
                Name = "Lars",
                Age = 18,
                Bio = "Krachttraining"
            },
            new Profile
            {
                Name = "Jasper",
                Age = 19,
                Bio ="Gezellig"
            }
        };
        public IEnumerable<Profile> GetAllProfiles() => _profiles;
        public IEnumerable<Profile> GetProfiles(string type) => string.IsNullOrWhiteSpace(type) ? _profiles : _profiles.Where(p => p.Name.Contains(type, StringComparison.OrdinalIgnoreCase));
    }
}
