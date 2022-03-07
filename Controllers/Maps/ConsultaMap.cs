using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Controllers.Maps
{
    internal class ConsultaMap: IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");
            builder.HasKey(x=>x.Id);
            builder.Property(x =>x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            //propriedades
            builder.Property(x => x.IdDentista);
            builder.Property(x => x.IdPaciente);
            builder.Property(x => x.Data);
            builder.Property(x => x.HoraMarcada);
            builder.Property(x => x.HoraInicio);
            builder.Property(x => x.HoraFim);
            builder.Property(x => x.Observacao);
            builder.Property(x => x.Status);









        }
    }
}
