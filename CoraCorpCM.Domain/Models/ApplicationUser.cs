﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CoraCorpCM.Domain.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser, IMuseumEntity
    {
        public ApplicationUser() : base()
        {
        }

        public virtual Museum Museum { get; set; }
        public int MuseumId { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
