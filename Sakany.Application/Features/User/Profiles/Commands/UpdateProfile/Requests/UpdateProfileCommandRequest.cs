using Sakany.Application.Features.User.Profiles.Commands.UpdateProfile.DTOs;
using Sakany.Shared.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Sakany.Application.Features.User.Profiles.Commands.UpdateProfile.Requests
{
    public class UpdateProfileCommandRequest : IRequest<Response<UpdateProfileCommandDTO>>
    {
        #region Properties

        #region User Properties

        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }

        #endregion User Properties

        #region User Profile Properties

        public string? Bio { get; set; }
        public IFormFile? Image { get; set; }

        #endregion User Profile Properties

        #endregion Properties
    }
}