﻿namespace HigiaServer.Infra.Data.Mappings;

public class BaseUserMap : IEntityTypeConfiguration<BaseUserEntity>
{
    public void Configure(EntityTypeBuilder<BaseUserEntity> builder)
    {
        builder.ToTable("user")
            .HasDiscriminator<bool>(x => x.IsAdmin)
            .HasValue<Collaborator>(false)
            .HasValue<Administrator>(true);

        builder.HasIndex(x => x.Id)
            .IsUnique();

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("uuid")
            .IsRequired();
        
        builder.Property(x => x.FirstName)
            .HasColumnName("first_name")
            .HasColumnType("NVARCHAR(255)")
            .IsRequired();
        
        builder.Property(x => x.LastName)
            .HasColumnName("last_name")
            .HasColumnType("NVARCHAR(255)")
            .IsRequired();

        builder.Property(x => x.Address)
            .HasColumnName("address")   
            .HasColumnType("NVARCHAR(255)")
            .IsRequired();

        builder.Property(x => x.IsAdmin)
            .HasColumnName("is_admin")
            .HasColumnType("BOOLEAN")
            .IsRequired();

        builder.Property(x => x.Birthday)
            .HasColumnName("birthday")
            .HasColumnType("TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.PhoneNumber)
            .HasColumnName("phone_number")
            .HasColumnType("NVARCHAR(255)")
            .IsRequired();

        builder.Property(x => x.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("TIMESTAMP")
            .IsRequired();
        
        builder.Property(x => x.LastModifiedAt)
            .HasColumnName("last_modified_at")
            .HasColumnType("TIMESTAMP")
            .IsRequired();

        builder.Property(x => x.CreatedBy)
            .HasColumnName("created_by")
            .HasColumnType("uuid")
            .IsRequired();

        builder.Property(x => x.LastModifiedBy)
            .HasColumnName("last_modified_by")
            .HasColumnType("uuid")
            .IsRequired();
    }
}