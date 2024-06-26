﻿using AutoMapper;
using Sakany.Application.Features.User.Profiles.Commands.UpdateProfile.DTOs;
using Sakany.Application.Features.User.Profiles.Commands.UpdateProfile.Requests;
using Sakany.Domain.IdentityEntities;

namespace Sakany.Application.Mapping.User.Profiles.Commands.UpdateProfile
{
    public class UpdateProfileMappingProfile : Profile
    {
        #region Constructors

        public UpdateProfileMappingProfile()
        {
            CreateMap<UpdateProfileCommandRequest, ApplicationUser>()
                .ForMember(destination => destination.UserName, options => options.Condition(source => source.Username != null))
                .ForMember(destination => destination.FirstName, options => options.Condition(source => source.FirstName != null))
                .ForMember(destination => destination.LastName, options => options.Condition(source => source.LastName != null))
                .ForMember(destination => destination.PhoneNumber, options => options.Condition(source => source.PhoneNumber != null))
                .ForPath(destination => destination.UserProfile!.Bio, options => options.Condition(source => source.Source.Bio != null))
                .ForPath(destination => destination.UserProfile!.Bio, options => options.MapFrom(source => source.Bio));

            CreateMap<ApplicationUser, UpdateProfileCommandDTO>()
                .ForMember(destination => destination.Bio, options => options.MapFrom(source => source.UserProfile!.Bio))
                .ForMember(destination => destination.ImageUrl, options => options.MapFrom(source => source.UserProfile!.ImageUrl));
        }

        #endregion Constructors
    }
}