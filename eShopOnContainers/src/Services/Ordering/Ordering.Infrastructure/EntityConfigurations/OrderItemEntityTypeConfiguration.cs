using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure;

namespace Ordering.Infrastructure.EntityConfigurations
{
    // En esta clase de configuracion de Orden item se establecen todas las propiedades de la entidad en la base de datos
    class OrderItemEntityTypeConfiguration
        : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> orderItemConfiguration)
        {
            // Nombre de tabla
            orderItemConfiguration.ToTable("orderItems", OrderingContext.DEFAULT_SCHEMA);

            // Identificador
            orderItemConfiguration.HasKey(o => o.Id);

            orderItemConfiguration.Ignore(b => b.DomainEvents);
            
            orderItemConfiguration.Property(o => o.Id)
                .UseHiLo("orderitemseq");

            orderItemConfiguration.Property<int>("OrderId")
                .IsRequired();

            // Propiedades
            orderItemConfiguration
                .Property<decimal>("_discount")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Discount")
                .IsRequired();

            orderItemConfiguration.Property<int>("ProductId")
                .IsRequired();

            orderItemConfiguration
                .Property<string>("_productName")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("ProductName")
                .IsRequired();

            orderItemConfiguration
                .Property<decimal>("_unitPrice")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("UnitPrice")
                .IsRequired();

            orderItemConfiguration
                .Property<int>("_units")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Units")
                .IsRequired();

            orderItemConfiguration
                .Property<string>("_pictureUrl")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("PictureUrl")
                .IsRequired(false);
        }
    }
}
