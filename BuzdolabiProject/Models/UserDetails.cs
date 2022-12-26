﻿using Microsoft.AspNetCore.Identity;

namespace BuzdolabiProject.Models
{
    public class UserDetails : IdentityUser
    {
        public string AdSoyad { get; set; }
        public string ozluSoz { get; set; }
        public string cinsiyet { get; set; }
        public string sosyalMedya { get; set; }
    }
}
