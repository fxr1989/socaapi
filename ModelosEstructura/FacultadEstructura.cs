﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Utilities;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelosEstructura
{
    public class FacultadEstructura : IEntityTypeConfiguration<Facultad>
    {
        public void Configure(EntityTypeBuilder<Facultad> builder)
        {
            builder.Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descripcion).HasMaxLength(500);
            builder.HasOne(x => x.Tenant)
                    .WithMany(x => x.Facultades)
                    .HasForeignKey(x => x.TenantId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
