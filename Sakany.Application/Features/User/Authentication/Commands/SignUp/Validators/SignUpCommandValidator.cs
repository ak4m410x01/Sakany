using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Sakany.Application.Features.User.Authentication.Commands.SignUp.Requests;
using Sakany.Domain.Enumerations.Users;
using Sakany.Domain.IdentityEntities;
using System.Data;

namespace Sakany.Application.Features.User.Authentication.Commands.SignUp.Validators
{
    public class SignUpCommandValidator : AbstractValidator<SignUpCommandRequest>
    {
        #region Properties

        public readonly UserManager<ApplicationUser> _userManager;

        #endregion Properties

        #region Constructors

        public SignUpCommandValidator(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            InitializeRoles();
        }

        #endregion Constructors

        #region Methods

        private void InitializeRoles()
        {
            EmailValidator();
            PasswordValidator();
            ConfirmPasswordValidator();
            RoleValidator();
        }

        private void EmailValidator()
        {
            RuleFor(request => request.Email)
                   .NotEmpty().WithMessage("Email is a required field.")
                   .NotNull().WithMessage("Email can't be null.")
                   .Matches("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$").WithMessage("Email must be valid.")
                   .MustAsync(async (email, cancellationToken) => (await _userManager.FindByEmailAsync(email)) is null).WithMessage("Email already exists.");
        }

        private void PasswordValidator()
        {
            RuleFor(request => request.Password)
                   .NotEmpty().WithMessage("Password is a required field.")
                   .NotNull().WithMessage("Password can't be null.")
                   .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                   .Must(password => password.Any(char.IsUpper)).WithMessage("Password must contain an uppercase letter.")
                   .Must(password => password.Any(char.IsLower)).WithMessage("Password must contain a lowercase letter.")
                   .Must(password => password.Any(char.IsDigit)).WithMessage("Password must contain a digit.")
                   .Must(password => password.Any(c => !char.IsLetterOrDigit(c))).WithMessage("Password must contain a special character.");
        }

        private void ConfirmPasswordValidator()
        {
            RuleFor(request => request.ConfirmPassword)
                   .Equal(request => request.Password).WithMessage("Passwords must match.");
        }

        private void RoleValidator()
        {
            RuleFor(request => request.Role)
                   .NotEmpty().WithMessage("Role is a required field.")
                   .NotNull().WithMessage("Role can't be null.")
                   .Must(role => role == UserRole.Customer.ToString() || role == UserRole.Realtor.ToString()).WithMessage("Role must be either Customer or Realtor.");
        }

        #endregion Methods
    }
}