﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MovieRent.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfMember]
        public DateTime? BirthDate { get; set; }
    }
}