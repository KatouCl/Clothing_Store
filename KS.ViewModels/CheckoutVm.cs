﻿using KS.Entities.Enums;

namespace KS.ViewModels
{
    public class CheckoutVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }
        public DeliveryType DeliveryType { get; set; } 
    }
}