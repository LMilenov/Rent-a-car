﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ViewModels.Users
{
    public class IndexUserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Full name")]
        public string Name { get; set; }

        [Display(Name = "UCN")]
        public string UCN { get; set; }

        [Display(Name = "User roles")]
        public string Role { get; set; }
    }
}
