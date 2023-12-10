﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.Models
{
    public class Profile
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? ProfilePicture {  get; set; }
        public string? Bio {  get; set; }
        public int? Age { get; set; }
        public int? Area { get; set; }
    }
}
