using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;
using TaskM.Models.WorkItems;


namespace TaskM.Data.Configurations
{
    public class WorkItemConfiguration : IEntityTypeConfiguration<WorkItem> 
    {
        public void Configure(EntityTypeBuilder<WorkItem> builder)
        {
            builder.ToTable("WorkItem");

            builder
                .Property<Guid>(_ => _.Id)
                .HasColumnType("TEXT")
                .IsRequired();
            
            builder
                .Property(_=>_.Title)
                .IsRequired();

            builder
                .Property(_ => _.Description)
                .IsRequired();

        }

    }
}
