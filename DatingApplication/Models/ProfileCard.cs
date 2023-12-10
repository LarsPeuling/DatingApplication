using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.Models
{
    public class ProfileCard
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhotoUrl { get; set; }
        public SwipeDirection SwipeDirection { get; set; }
    }

    public enum SwipeDirection
    {
        None,
        Left,
        Right
    }
}
