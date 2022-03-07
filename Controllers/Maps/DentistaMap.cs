
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Controllers.Maps
{
    internal class DentistaMap : IEntityTypeConfiguration<Dentista>
    {
        public void Configure(EntityTypeBuilder<Dentista> builder)
        {
            // Tabela
            builder.ToTable("Dentista");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR");
            
            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasColumnName("Email");

            
            
            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasColumnName("Telefone");

            builder.Property(x => x.CRO)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasColumnName("CRO");



            // Índices
            builder
                .HasIndex(x => x.Name, "IX_Dentista_Name")
                .IsUnique();
        }
    }
}
