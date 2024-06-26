﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sakany.Domain.Enumerations.Users;
using Sakany.Domain.IdentityEntities;

namespace Sakany.Persistence.EntityConfiguration.Users
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            #region Config Table Name

            builder.ToTable("Users", "User");

            #endregion Config Table Name

            #region Config Properties

            builder.Property(user => user.Status)
                   .HasDefaultValue(UserStatus.Active.ToString())
                   .IsRequired();

            builder.Property(user => user.FirstName)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(user => user.LastName)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(user => user.CreatedAt)
                   .HasDefaultValue(DateTime.UtcNow)
                   .IsRequired();

            builder.Property(user => user.ModifiedAt)
                   .HasDefaultValue(DateTime.UtcNow)
                   .IsRequired();

            builder.Property(user => user.DeletedAt)
                   .IsRequired(false);

            #endregion Config Properties
        }
    }
}