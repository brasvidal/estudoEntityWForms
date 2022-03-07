using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Controllers.Maps
{
    internal class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            // Tabela
            builder.ToTable("Paciente");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity Geração de ID
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("VARCHAR)");

            builder.Property(x => x.Telefone1)
                .IsRequired()
                .HasColumnName("Telefone1")
                .HasColumnType("VARCHAR");

            builder.Property(x => x.Telefone2)
                .IsRequired(false)
                .HasColumnName("Telefone2")
                .HasColumnType("VARCHAR");


            builder.Property(x => x.Telefone3)
                .IsRequired(false)
                .HasColumnName("Telefone3")
                .HasColumnType("VARCHAR");

            builder.Property(x => x.CEP)
                .IsRequired(false)
                .HasColumnName("CEP")
                .HasColumnType("VARCHAR");


            builder.Property(x => x.Endereco)
                .IsRequired(false)
                .HasColumnName("Endereco")
                .HasColumnType("VARCHAR");


            builder.Property(x => x.Numero)
                .IsRequired()
                .HasColumnName("Numero")
                .HasColumnType("INTEGER");


            builder.Property(x => x.Complemento)
                .IsRequired()
                .HasColumnName("Complemento")
                .HasColumnType("VARCHAR");


            builder.Property(x => x.DataNasc)
                .IsRequired()
                .HasColumnName("DataNascimento")
                .HasColumnType("DATE");


            builder.Property(x => x.Sexo)
                .IsRequired(false)
                .HasColumnName("Sexo")
                .HasColumnType("VARCHAR");





            // Índices
            builder
                .HasIndex(x => x.Name, "IX_Paciente_Name")
                .IsUnique();
        }
    }
}
