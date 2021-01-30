﻿using CMS_Rest_API.EntityLayer.Entities.Concrete;
using CMS_Rest_API.MappingLayer.Mapping.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Rest_API.MappingLayer.Mapping.Concrete
{
    public class PageMap:BaseMap<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.Slug).IsRequired(false);
            builder.Property(x => x.Sorting).IsRequired(false);
            builder.Property(x => x.Content).IsRequired(true);
            base.Configure(builder);
        }
    }
}
