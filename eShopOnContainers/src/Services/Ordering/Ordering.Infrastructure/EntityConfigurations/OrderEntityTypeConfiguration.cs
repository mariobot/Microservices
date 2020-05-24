using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.BuyerAggregate;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
using Microsoft.eShopOnContainers.Services.Ordering.Infrastructure;
using System;

namespace Ordering.Infrastructure.EntityConfigurations
{
    class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> orderConfiguration)
        {
            // Se define el nombre de la tabla
            // Asigna el nombre de orders
            // Asignado al esquema por defecto de la base de datos
            orderConfiguration.ToTable("orders", OrderingContext.DEFAULT_SCHEMA);

            // Establece el Identificador
            orderConfiguration.HasKey(o => o.Id);

            orderConfiguration.Ignore(b => b.DomainEvents);

            // Establece la propiedad HiLo
            orderConfiguration.Property(o => o.Id)
                .UseHiLo("orderseq", OrderingContext.DEFAULT_SCHEMA);

            // En esta parte se mapea el objeto valor direccion
            //Address value object persisted as owned entity type supported since EF Core 2.0
            orderConfiguration
                .OwnsOne(o => o.Address, a =>
                {
                    a.WithOwner();
                });

            // Establece la propiedad BuyerId
            orderConfiguration
                .Property<int?>("_buyerId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("BuyerId")
                .IsRequired(false);

            // Establece OrderDate
            orderConfiguration
                .Property<DateTime>("_orderDate")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("OrderDate")
                .IsRequired();

            // Establece OrderStatusId
            orderConfiguration
                .Property<int>("_orderStatusId")
                // .HasField("_orderStatusId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("OrderStatusId")
                .IsRequired();

            // Establece PaymentMethodId
            orderConfiguration
                .Property<int?>("_paymentMethodId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("PaymentMethodId")
                .IsRequired(false);

            // Establece Descripcion
            orderConfiguration.Property<string>("Description").IsRequired(false);

            var navigation = orderConfiguration.Metadata.FindNavigation(nameof(Order.OrderItems));

            // DDD Patterns comment:
            //Set as field (New since EF 1.1) to access the OrderItem collection property through its field
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            // Establece la relacion con otras tablas
            orderConfiguration.HasOne<PaymentMethod>()
                .WithMany()
                // .HasForeignKey("PaymentMethodId")
                .HasForeignKey("_paymentMethodId")
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            orderConfiguration.HasOne<Buyer>()
                .WithMany()
                .IsRequired(false)
                // .HasForeignKey("BuyerId");
                .HasForeignKey("_buyerId");

            orderConfiguration.HasOne(o => o.OrderStatus)
                .WithMany()
                // .HasForeignKey("OrderStatusId");
                .HasForeignKey("_orderStatusId");
        }
    }
}
