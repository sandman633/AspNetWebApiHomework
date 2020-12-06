using DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Fluent
{
    public class AvailablityConfig : IEntityTypeConfiguration<Availability>
    {
        public void Configure(EntityTypeBuilder<Availability> builder)
        {
            builder.BaseEntityLinksConfiguration<Availability, Car, Shop>(e => e.Availabilities, e => e.Availabilities);
            builder.Property(x => x.Count)
                .IsRequired();

            builder.ToTable("Availabilities");
        }
    }
}
