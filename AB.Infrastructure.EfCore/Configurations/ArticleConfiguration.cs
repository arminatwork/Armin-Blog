using AB.Domain.Article;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AB.Infrastructure.EfCore.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            //selected by default
            builder.ToTable("Articles");

            builder.HasKey(key => key.Id);

            builder.Property(prop => prop.Title)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(prop => prop.ShortDescription)
                .HasMaxLength(1500).IsRequired();

            builder.Property(prop => prop.Content)
                .IsRequired();

            builder.Property(prop => prop.Image);

            builder.Property(prop => prop.IsDeleted);

            builder.Property(prop => prop.CreationDate)
                .IsRequired();


            builder.HasOne(rel => rel.ArticleCategory)
                .WithMany(relMirror => relMirror.Articles)
                .HasForeignKey(foreignKey => foreignKey.ArticleCategoryId);
        }
    }
}
