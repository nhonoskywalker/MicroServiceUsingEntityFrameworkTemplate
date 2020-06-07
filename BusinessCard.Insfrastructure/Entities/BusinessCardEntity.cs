namespace BusinessCard.Insfrastructure.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BusinessCardEntity
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public string Site { get; set; }

        [Required]
        public string About { get; set; }
    }
}
