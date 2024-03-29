﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class Transaction
    {
        [Key]
        [BindNever]
        public int TransactionId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required (ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Please enter the first address line")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required (ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage ="Please enter a state")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required (ErrorMessage = "Please enter a country") ]
        public string Country { get; set; }
        [Required (ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }
        [Required (ErrorMessage = "Please enter an email")]
        public string Email { get; set; }

        [BindNever]
        public bool Shipped { get; set; } = false; 
    }
}
