﻿using DataBase.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataBase.Fluent
{
    public static class FluentExtention
    {
        public static void BaseEntityLinksConfiguration<T,T1,T2>(this EntityTypeBuilder<T> builder, 
                                                           Expression<Func<T1, IEnumerable<T>>> withMany1 = default,
                                                           Expression<Func<T2, IEnumerable<T>>> withMany2 = default) 
            where T: BaseEntityWithLinks<T1,T2>
            where T1: BaseEntity
            where T2: BaseEntity
        {
            builder.ToTable($"{typeof(T).Name}s");

            builder.HasKey(e => new { e.Entity1Id, e.Entity2Id });

            builder.Property(e => e.Entity1Id).HasColumnName($"{typeof(T1).Name}Id");
            builder.Property(e => e.Entity2Id).HasColumnName($"{typeof(T2).Name}Id");

            builder.HasOne(e => e.Entity1).WithMany(withMany1).HasForeignKey(e => e.Entity1Id);
            builder.HasOne(e => e.Entity2).WithMany(withMany2).HasForeignKey(e => e.Entity2Id);

        }
    }
}
