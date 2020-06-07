namespace BusinessCard.Data.Entities.Users
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserEntity : IdentityUser<Guid>
    {
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public Guid CountryId { get; set; }

        [Required]
        public DateTime LastLogInDate { get; set; }
    }
}
