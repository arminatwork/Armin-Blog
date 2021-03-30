using AB.Domain.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AB.Infrastructure.EfCore.Configurations
{
    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            //selected by default
            builder.ToTable("ArticleCategories");

            builder.HasKey(key => key.Id);
            builder.Property(prop => prop.Title);
            builder.Property(prop => prop.CreationDate);
            builder.Property(prop => prop.IsDeleted);
        }
    }
}