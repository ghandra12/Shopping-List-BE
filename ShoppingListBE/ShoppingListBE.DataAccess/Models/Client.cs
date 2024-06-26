﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public bool IsAdmin { get; set; }
        public string PhoneNumber { get; set; } = "";

        public ICollection<Product> Products { get; }= new List<Product>();
        public ICollection<Category> Categories { get; } = new List<Category>();
        public ICollection<List> Lists { get; } = new List<List>();
    }
}
