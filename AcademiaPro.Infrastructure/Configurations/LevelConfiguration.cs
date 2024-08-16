using AcademiaPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Infrastructure.Configurations
{
    internal class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder
                .HasIndex(l => l.Name)
                .IsUnique();

            builder.HasData(
                new Level
                { 
                    LevelId = 1,
                    Name = "Class 1",
                    SortOrder = 1,
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                },
                new Level
                {
                    LevelId = 2,
                    Name = "Class 2",
                    SortOrder = 2,
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                },
                new Level
                {
                    LevelId = 3,
                    Name = "Class 3",
                    SortOrder = 3,
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                },new Level
                {
                    LevelId = 4,
                    Name = "Class 4",
                    SortOrder = 4,
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                },
                new Level
                {
                    LevelId = 5,
                    Name = "Class 5",
                    SortOrder = 5,
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                },
                new Level
                {
                    LevelId = 6,
                    Name = "Class 6",
                    SortOrder = 6,
                    CreatedAt = DateTime.Now,
                    LastModifiedAt = DateTime.Now,
                }
            );
        }
    }
}
