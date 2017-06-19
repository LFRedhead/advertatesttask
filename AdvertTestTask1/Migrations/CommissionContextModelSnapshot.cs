using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AdvertTestTask1.ViewModels;

namespace AdvertTestTask1.Migrations
{
    [DbContext(typeof(CommissionContext))]
    partial class CommissionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvertTestTask1.ViewModels.Commission", b =>
                {
                    b.Property<int>("CommissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommEmail")
                        .IsRequired();

                    b.Property<bool>("CommTime");

                    b.Property<string>("CommUser")
                        .IsRequired();

                    b.Property<int>("CommissionPrice");

                    b.Property<string>("OrderText")
                        .IsRequired()
                        .HasMaxLength(4096);

                    b.HasKey("CommissionId");

                    b.ToTable("Commissions");
                });

            modelBuilder.Entity("AdvertTestTask1.ViewModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
        }
    }
}
