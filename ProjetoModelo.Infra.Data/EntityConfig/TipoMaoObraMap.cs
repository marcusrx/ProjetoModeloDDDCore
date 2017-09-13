
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Infra.Data.Extensions;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class TipoMaoObraMap : EntityTypeConfiguration<TipoMaoObra>
    {
        public override void Map(EntityTypeBuilder<TipoMaoObra> builder)
        {
            builder.ToTable("TipoMaoObra");
            builder.HasKey(tp => tp.ID);
            builder.Property(tp => tp.ID)
                .HasColumnName("Id");

            builder.Property(tp => tp.Descricao)
                .HasColumnType("varchar(100)")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
