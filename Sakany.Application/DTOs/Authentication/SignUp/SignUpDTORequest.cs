﻿namespace Sakany.Application.DTOs.Authentication.SignUp
{
    public class SignUpDTORequest
    {
        #region Properties

        public string Role { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string ConfirmPassword { get; set; } = default!;

        #endregion Properties
    }
}