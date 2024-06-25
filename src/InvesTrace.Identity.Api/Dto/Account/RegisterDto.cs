﻿using System.ComponentModel.DataAnnotations;

namespace InvesTrace.Identity.Api.Dto.Account;

public class RegisterDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    [Compare(nameof(Password), ErrorMessage = "Passwords mismatch")]
    public string ConfirmPassword { get; set; }
}
