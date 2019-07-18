using Lab.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab.Data.Mappings
{
    public class TabelaINSSMappings : IEntityTypeConfiguration<TabelaINSS>
    {
        public void Configure(EntityTypeBuilder<TabelaINSS> builder)
        {
            builder.HasKey(c=>c.Id);
            builder.Property(c=>c.InitialValue)
            .IsRequired(true);
            builder.Property(c=>c.EndValues)
            .IsRequired(true);

            builder.Ignore(c=>c.ValidationResult);
            builder.Ignore(c => c.CascadeMode);
            builder.ToTable("TabelaINSS");
        }
    }
}