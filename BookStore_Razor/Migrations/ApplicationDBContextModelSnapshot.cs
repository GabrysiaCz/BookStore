// <auto-generowane />
using BookStore_Razor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreRazor.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("WersjaProduktu", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UżyjKolumnIdentity(modelBuilder);

            modelBuilder.Entity("BookStore_Razor.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UżyjKolumnyIdentity(b.Property<int>("Id"));

                    b.Property<int>("KolejnośćWyświetlania")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.DoTabeli("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KolejnośćWyświetlania = 1,
                            Nazwa = "Akcja"
                        },
                        new
                        {
                            Id = 2,
                            KolejnośćWyświetlania = 2,
                            Nazwa = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            KolejnośćWyświetlania = 3,
                            Nazwa = "Historia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
