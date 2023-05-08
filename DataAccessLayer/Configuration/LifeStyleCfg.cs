﻿using EntitiyLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class LifeStyleCfg : IEntityTypeConfiguration<LifeStyle>
    {
        public void Configure(EntityTypeBuilder<LifeStyle> builder)
        {
            builder.Property(b => b.Description).HasMaxLength(100);
        }
    }
}
