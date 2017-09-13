using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public override void Map(EntityTypeBuilder<Disciplina> builder)
        {
            builder.ToTable("Disciplina");
            builder.HasKey(d => d.DisciplinaID);
            builder.Property(d => d.DisciplinaID)
                .HasColumnName("DisciplinaID");

            builder.Property(d => d.Nome)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
