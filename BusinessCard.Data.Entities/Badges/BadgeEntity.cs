namespace BusinessCard.Data.Entities.Badges
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BadgeEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
