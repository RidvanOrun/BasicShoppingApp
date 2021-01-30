﻿using CMS_Rest_API.EntityLayer.Entities.Concrete;
using CMS_Rest_API.MappingLayer.Mapping.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Rest_API.MappingLayer.Mapping.Concrete
{
    public class CategoryMap:BaseMap<Category>
    {

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(true);

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            base.Configure(builder);
        }
    }
}
