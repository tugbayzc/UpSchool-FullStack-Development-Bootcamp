using Domain.Entities;
using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Application;

public class AddressConfiguration:IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.Property(x => x.AddressType).IsRequired();

        builder.Property(x => x.AddressType).HasConversion<int>();//dönüşümü var mı?
        
        
        //Relationships
        builder.HasOne<User>().WithMany()
            .HasForeignKey(X => X.UserId);
    }
}