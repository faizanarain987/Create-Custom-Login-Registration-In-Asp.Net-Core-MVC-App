﻿using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
