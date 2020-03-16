﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaGraphQL.Entities.Context;

namespace PizzaGraphQL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaGraphQL.Entities.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "4 fromage"
                        },
                        new
                        {
                            Id = 2,
                            Name = "4 saisons"
                        },
                        new
                        {
                            Id = 3,
                            Name = "the best"
                        });
                });

            modelBuilder.Entity("PizzaGraphQL.Entities.PizzaTopping", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("ToppingId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "ToppingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzaToppings");

                    b.HasData(
                        new
                        {
                            PizzaId = 1,
                            ToppingId = 1
                        },
                        new
                        {
                            PizzaId = 1,
                            ToppingId = 2
                        },
                        new
                        {
                            PizzaId = 2,
                            ToppingId = 2
                        },
                        new
                        {
                            PizzaId = 3,
                            ToppingId = 3
                        });
                });

            modelBuilder.Entity("PizzaGraphQL.Entities.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "bacon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "pepperoni"
                        },
                        new
                        {
                            Id = 3,
                            Name = "tomato"
                        });
                });

            modelBuilder.Entity("PizzaGraphQL.Entities.PizzaTopping", b =>
                {
                    b.HasOne("PizzaGraphQL.Entities.Pizza", "Pizza")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaGraphQL.Entities.Topping", "Topping")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
