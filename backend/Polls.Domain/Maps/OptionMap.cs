using backend.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Maps;

public class OptionMap : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.HasIndex(o => o.Id);
        builder.Property(o => o.Id).ValueGeneratedOnAdd();
        builder.Property(o => o.Name);
        builder.Property(o => o.Index);
        builder.Property(o => o.Votes);
        builder.Property(o => o.CreatedAt);
        builder.Property(o => o.IsActive);
    }
}