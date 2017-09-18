using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class CommodityMap : EntityTypeConfiguration<Commodity>
    {
        public override void Map(EntityTypeBuilder<Commodity> builder)
        {
            builder.ToTable("Commodity");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID)
                .HasColumnName("ID");

            builder.Property(C => C.Nome)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(C => C.Descricao)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150);


            builder.Property(c => c.TipoMaoObraID)
                .IsRequired();

            builder.Property(c => c.DisciplinaID)
                .IsRequired();

        }
    }
}
