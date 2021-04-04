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

            builder.Property(prop => prop.Title)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(prop => prop.CreationDate)
                .IsRequired();

            builder.Property(prop => prop.IsDeleted);

            builder.HasMany(rel => rel.Articles)
                .WithOne(relMirror => relMirror.ArticleCategory)
                .HasForeignKey(foreignKey => foreignKey.ArticleCategoryId);
        }
    }
}