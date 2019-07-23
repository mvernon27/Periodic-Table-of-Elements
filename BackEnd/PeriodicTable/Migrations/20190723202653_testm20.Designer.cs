﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeriodicTable;

namespace PeriodicTable.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190723202653_testm20")]
    partial class testm20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeriodicTable.Models.Element", b =>
                {
                    b.Property<int>("ElementId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AtomicNumber");

                    b.Property<double>("AtomicWeight");

                    b.Property<string>("Class");

                    b.Property<string>("Description");

                    b.Property<int>("GroupId");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("PeriodId");

                    b.Property<string>("Symbol");

                    b.HasKey("ElementId");

                    b.HasIndex("GroupId");

                    b.HasIndex("PeriodId");

                    b.ToTable("Elements");

                    b.HasData(
                        new { ElementId = 1, AtomicNumber = 1, AtomicWeight = 1.07794, Class = "PN", Description = "HydrogenHydrogen", GroupId = 1, Image = "https://metaphysicalexperience.files.wordpress.com/2010/06/physical-universe.jpg", Name = "Hydrogen", PeriodId = 1, Symbol = "H" },
                        new { ElementId = 2, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 2, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 3, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 3, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 4, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 4, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 5, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 5, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 6, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 6, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 7, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 7, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 8, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 8, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 9, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 9, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 10, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 10, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 11, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 11, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 12, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 12, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 13, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 13, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 14, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 14, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 15, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 15, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 16, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 16, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 17, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 17, Image = "", Name = "ADD NEW", PeriodId = 1, Symbol = "+" },
                        new { ElementId = 18, AtomicNumber = 2, AtomicWeight = 4.003, Class = "NG", Description = "", GroupId = 18, Image = "", Name = "Helium", PeriodId = 1, Symbol = "HE" },
                        new { ElementId = 19, AtomicNumber = 3, AtomicWeight = 6.941, Class = "AM", Description = "", GroupId = 1, Image = "", Name = "Lithium", PeriodId = 2, Symbol = "LI" },
                        new { ElementId = 20, AtomicNumber = 4, AtomicWeight = 9.012, Class = "AEM", Description = "", GroupId = 2, Image = "", Name = "Beryllium", PeriodId = 2, Symbol = "BE" },
                        new { ElementId = 21, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 3, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 22, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 4, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 23, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 5, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 24, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 6, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 25, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 7, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 26, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 8, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 27, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 9, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 28, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 10, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 29, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 11, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 30, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 12, Image = "", Name = "ADD NEW", PeriodId = 2, Symbol = "+" },
                        new { ElementId = 31, AtomicNumber = 5, AtomicWeight = 10.811, Class = "M", Description = "", GroupId = 13, Image = "", Name = "Boron", PeriodId = 2, Symbol = "B" },
                        new { ElementId = 32, AtomicNumber = 6, AtomicWeight = 12.011, Class = "PN", Description = "", GroupId = 14, Image = "", Name = "Carbon", PeriodId = 2, Symbol = "C" },
                        new { ElementId = 33, AtomicNumber = 7, AtomicWeight = 14.007, Class = "PN", Description = "", GroupId = 15, Image = "", Name = "Nitrogen", PeriodId = 2, Symbol = "N" },
                        new { ElementId = 34, AtomicNumber = 8, AtomicWeight = 15.999, Class = "PN", Description = "", GroupId = 16, Image = "", Name = "Oxygen", PeriodId = 2, Symbol = "O" },
                        new { ElementId = 35, AtomicNumber = 9, AtomicWeight = 18.998, Class = "DN", Description = "", GroupId = 17, Image = "", Name = "Flourine", PeriodId = 2, Symbol = "F" },
                        new { ElementId = 36, AtomicNumber = 10, AtomicWeight = 20.18, Class = "NG", Description = "", GroupId = 18, Image = "", Name = "Neon", PeriodId = 2, Symbol = "Ne" },
                        new { ElementId = 37, AtomicNumber = 11, AtomicWeight = 22.99, Class = "AM", Description = "", GroupId = 1, Image = "", Name = "Sodium", PeriodId = 3, Symbol = "Na" },
                        new { ElementId = 38, AtomicNumber = 12, AtomicWeight = 24.305, Class = "AEM", Description = "", GroupId = 2, Image = "", Name = "Magnesium", PeriodId = 3, Symbol = "Mg" },
                        new { ElementId = 39, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 3, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 40, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 4, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 41, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 5, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 42, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 6, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 43, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 7, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 44, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 8, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 45, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 9, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 46, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 10, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 47, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 11, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 48, AtomicNumber = 1, AtomicWeight = 0.0, Class = "NON", Description = "", GroupId = 12, Image = "", Name = "ADD NEW", PeriodId = 3, Symbol = "+" },
                        new { ElementId = 49, AtomicNumber = 13, AtomicWeight = 26.982, Class = "PTM", Description = "", GroupId = 13, Image = "", Name = "Aluminum", PeriodId = 3, Symbol = "Al" },
                        new { ElementId = 50, AtomicNumber = 14, AtomicWeight = 28.066, Class = "M", Description = "", GroupId = 14, Image = "", Name = "Silicon", PeriodId = 3, Symbol = "Si" },
                        new { ElementId = 51, AtomicNumber = 15, AtomicWeight = 30.974, Class = "PN", Description = "", GroupId = 15, Image = "", Name = "Phosphorus", PeriodId = 3, Symbol = "P" },
                        new { ElementId = 52, AtomicNumber = 16, AtomicWeight = 32.066, Class = "PN", Description = "", GroupId = 16, Image = "", Name = "Sulfur", PeriodId = 3, Symbol = "S" },
                        new { ElementId = 53, AtomicNumber = 17, AtomicWeight = 35.453, Class = "DN", Description = "", GroupId = 17, Image = "", Name = "Chlorine", PeriodId = 3, Symbol = "Al" },
                        new { ElementId = 54, AtomicNumber = 18, AtomicWeight = 39.948, Class = "NG", Description = "", GroupId = 18, Image = "", Name = "Argon", PeriodId = 3, Symbol = "Ar" },
                        new { ElementId = 55, AtomicNumber = 19, AtomicWeight = 39.098, Class = "AM", Description = "", GroupId = 1, Image = "", Name = "Potassium", PeriodId = 4, Symbol = "K" },
                        new { ElementId = 56, AtomicNumber = 20, AtomicWeight = 40.078, Class = "AEM", Description = "", GroupId = 2, Image = "", Name = "Calcium", PeriodId = 4, Symbol = "Ca" },
                        new { ElementId = 57, AtomicNumber = 21, AtomicWeight = 44.956, Class = "TM", Description = "", GroupId = 3, Image = "", Name = "Scandium", PeriodId = 4, Symbol = "Sc" },
                        new { ElementId = 58, AtomicNumber = 22, AtomicWeight = 47.867, Class = "TM", Description = "", GroupId = 4, Image = "", Name = "Titanium", PeriodId = 4, Symbol = "Ti" },
                        new { ElementId = 59, AtomicNumber = 23, AtomicWeight = 50.942, Class = "TM", Description = "", GroupId = 5, Image = "", Name = "Vanadium", PeriodId = 4, Symbol = "V" },
                        new { ElementId = 60, AtomicNumber = 24, AtomicWeight = 51.996, Class = "TM", Description = "", GroupId = 6, Image = "", Name = "Chromium", PeriodId = 4, Symbol = "Cr" },
                        new { ElementId = 61, AtomicNumber = 25, AtomicWeight = 54.938, Class = "TM", Description = "", GroupId = 7, Image = "", Name = "Manganese", PeriodId = 4, Symbol = "Mn" },
                        new { ElementId = 62, AtomicNumber = 26, AtomicWeight = 55.845, Class = "TM", Description = "", GroupId = 8, Image = "", Name = "Iron", PeriodId = 4, Symbol = "Fe" },
                        new { ElementId = 63, AtomicNumber = 27, AtomicWeight = 58.933, Class = "TM", Description = "", GroupId = 9, Image = "", Name = "Cobalt", PeriodId = 4, Symbol = "Co" },
                        new { ElementId = 64, AtomicNumber = 28, AtomicWeight = 58.693, Class = "TM", Description = "", GroupId = 10, Image = "", Name = "Nickel", PeriodId = 4, Symbol = "Ni" },
                        new { ElementId = 65, AtomicNumber = 29, AtomicWeight = 63.546, Class = "TM", Description = "", GroupId = 11, Image = "", Name = "Copper", PeriodId = 4, Symbol = "Cu" },
                        new { ElementId = 66, AtomicNumber = 30, AtomicWeight = 65.38, Class = "TM", Description = "", GroupId = 12, Image = "", Name = "Zinc", PeriodId = 4, Symbol = "Zn" },
                        new { ElementId = 67, AtomicNumber = 31, AtomicWeight = 69.723, Class = "PTM", Description = "", GroupId = 13, Image = "", Name = "Gallium", PeriodId = 4, Symbol = "Ga" },
                        new { ElementId = 68, AtomicNumber = 32, AtomicWeight = 72.631, Class = "M", Description = "", GroupId = 14, Image = "", Name = "Germanium", PeriodId = 4, Symbol = "Ge" },
                        new { ElementId = 69, AtomicNumber = 33, AtomicWeight = 74.922, Class = "M", Description = "", GroupId = 15, Image = "", Name = "Arsenic", PeriodId = 4, Symbol = "As" },
                        new { ElementId = 70, AtomicNumber = 34, AtomicWeight = 78.971, Class = "PN", Description = "", GroupId = 16, Image = "", Name = "Selenium", PeriodId = 4, Symbol = "Se" },
                        new { ElementId = 71, AtomicNumber = 35, AtomicWeight = 79.904, Class = "DN", Description = "", GroupId = 17, Image = "", Name = "Bromine", PeriodId = 4, Symbol = "Br" },
                        new { ElementId = 72, AtomicNumber = 36, AtomicWeight = 83.798, Class = "NG", Description = "", GroupId = 18, Image = "", Name = "Krypton", PeriodId = 4, Symbol = "Kr" },
                        new { ElementId = 73, AtomicNumber = 37, AtomicWeight = 84.468, Class = "AM", Description = "", GroupId = 1, Image = "", Name = "Rubidium", PeriodId = 5, Symbol = "Rb" },
                        new { ElementId = 74, AtomicNumber = 38, AtomicWeight = 87.62, Class = "AEM", Description = "", GroupId = 2, Image = "", Name = "Stronium", PeriodId = 5, Symbol = "Sr" },
                        new { ElementId = 75, AtomicNumber = 39, AtomicWeight = 86.906, Class = "TM", Description = "", GroupId = 3, Image = "", Name = "Yitrium", PeriodId = 5, Symbol = "Y" },
                        new { ElementId = 76, AtomicNumber = 40, AtomicWeight = 91.224, Class = "TM", Description = "", GroupId = 4, Image = "", Name = "Zirconium", PeriodId = 5, Symbol = "Zr" },
                        new { ElementId = 77, AtomicNumber = 41, AtomicWeight = 92.906, Class = "TM", Description = "", GroupId = 5, Image = "", Name = "Niobium", PeriodId = 5, Symbol = "Nb" },
                        new { ElementId = 78, AtomicNumber = 42, AtomicWeight = 95.95, Class = "TM", Description = "", GroupId = 6, Image = "", Name = "Molybdenum", PeriodId = 5, Symbol = "Mo" },
                        new { ElementId = 79, AtomicNumber = 43, AtomicWeight = 98.907, Class = "TM", Description = "", GroupId = 7, Image = "", Name = "Technetium", PeriodId = 5, Symbol = "Tc" },
                        new { ElementId = 80, AtomicNumber = 44, AtomicWeight = 101.07, Class = "TM", Description = "", GroupId = 8, Image = "", Name = "Ruthenium", PeriodId = 5, Symbol = "Ru" },
                        new { ElementId = 81, AtomicNumber = 45, AtomicWeight = 102.906, Class = "TM", Description = "", GroupId = 9, Image = "", Name = "Rhodium", PeriodId = 5, Symbol = "Rh" },
                        new { ElementId = 82, AtomicNumber = 46, AtomicWeight = 106.42, Class = "TM", Description = "", GroupId = 10, Image = "", Name = "Palladium", PeriodId = 5, Symbol = "Pd" },
                        new { ElementId = 83, AtomicNumber = 47, AtomicWeight = 107.868, Class = "TM", Description = "", GroupId = 11, Image = "", Name = "Silver", PeriodId = 5, Symbol = "Ag" },
                        new { ElementId = 84, AtomicNumber = 48, AtomicWeight = 112.411, Class = "TM", Description = "", GroupId = 12, Image = "", Name = "Cadmium", PeriodId = 5, Symbol = "Cd" },
                        new { ElementId = 85, AtomicNumber = 49, AtomicWeight = 114.818, Class = "PTM", Description = "", GroupId = 13, Image = "", Name = "Indium", PeriodId = 5, Symbol = "n" },
                        new { ElementId = 86, AtomicNumber = 50, AtomicWeight = 118.711, Class = "PTM", Description = "", GroupId = 14, Image = "", Name = "Tin", PeriodId = 5, Symbol = "Sn" },
                        new { ElementId = 87, AtomicNumber = 51, AtomicWeight = 121.76, Class = "M", Description = "", GroupId = 15, Image = "", Name = "Antimony", PeriodId = 5, Symbol = "Sb" },
                        new { ElementId = 88, AtomicNumber = 52, AtomicWeight = 127.6, Class = "M", Description = "", GroupId = 16, Image = "", Name = "Tellurium", PeriodId = 5, Symbol = "Te" },
                        new { ElementId = 89, AtomicNumber = 53, AtomicWeight = 126.904, Class = "DN", Description = "", GroupId = 17, Image = "", Name = "Iodine", PeriodId = 5, Symbol = "I" },
                        new { ElementId = 90, AtomicNumber = 54, AtomicWeight = 131.294, Class = "NG", Description = "", GroupId = 18, Image = "", Name = "Zenon", PeriodId = 5, Symbol = "Xe" },
                        new { ElementId = 91, AtomicNumber = 55, AtomicWeight = 132.905, Class = "AM", Description = "", GroupId = 1, Image = "", Name = "Cesium", PeriodId = 6, Symbol = "Cs" },
                        new { ElementId = 92, AtomicNumber = 56, AtomicWeight = 137.328, Class = "AEM", Description = "", GroupId = 2, Image = "", Name = "Barium", PeriodId = 6, Symbol = "Ba" },
                        new { ElementId = 93, AtomicNumber = 0, AtomicWeight = 0.0, Class = "L", Description = "", GroupId = 3, Image = "", Name = "Lanthanides", PeriodId = 6, Symbol = "57-71" },
                        new { ElementId = 94, AtomicNumber = 72, AtomicWeight = 178.49, Class = "TM", Description = "", GroupId = 4, Image = "", Name = "Hafnium", PeriodId = 6, Symbol = "Hf" },
                        new { ElementId = 95, AtomicNumber = 73, AtomicWeight = 180.948, Class = "TM", Description = "", GroupId = 5, Image = "", Name = "Tantalum", PeriodId = 6, Symbol = "Ta" },
                        new { ElementId = 96, AtomicNumber = 74, AtomicWeight = 183.948, Class = "TM", Description = "", GroupId = 6, Image = "", Name = "Tungsten", PeriodId = 6, Symbol = "W" },
                        new { ElementId = 97, AtomicNumber = 75, AtomicWeight = 186.207, Class = "TM", Description = "", GroupId = 7, Image = "", Name = "Rhenium", PeriodId = 6, Symbol = "Re" },
                        new { ElementId = 98, AtomicNumber = 76, AtomicWeight = 190.23, Class = "TM", Description = "", GroupId = 8, Image = "", Name = "Osminium", PeriodId = 6, Symbol = "Os" },
                        new { ElementId = 99, AtomicNumber = 77, AtomicWeight = 192.217, Class = "TM", Description = "", GroupId = 9, Image = "", Name = "Iridium", PeriodId = 6, Symbol = "Ir" },
                        new { ElementId = 100, AtomicNumber = 78, AtomicWeight = 195.085, Class = "TM", Description = "", GroupId = 10, Image = "", Name = "Platinum", PeriodId = 6, Symbol = "Pt" },
                        new { ElementId = 101, AtomicNumber = 79, AtomicWeight = 196.967, Class = "TM", Description = "", GroupId = 11, Image = "", Name = "Gold", PeriodId = 6, Symbol = "Au" },
                        new { ElementId = 102, AtomicNumber = 80, AtomicWeight = 200.592, Class = "TM", Description = "", GroupId = 12, Image = "", Name = "Mercury", PeriodId = 6, Symbol = "Hg" },
                        new { ElementId = 103, AtomicNumber = 81, AtomicWeight = 204.383, Class = "PTM", Description = "", GroupId = 13, Image = "", Name = "Thallium", PeriodId = 6, Symbol = "Ti" },
                        new { ElementId = 104, AtomicNumber = 82, AtomicWeight = 207.2, Class = "PTM", Description = "", GroupId = 14, Image = "", Name = "Lead", PeriodId = 6, Symbol = "Pb" },
                        new { ElementId = 105, AtomicNumber = 83, AtomicWeight = 208.98, Class = "PTM", Description = "", GroupId = 15, Image = "", Name = "Bismuth", PeriodId = 6, Symbol = "BI" },
                        new { ElementId = 106, AtomicNumber = 84, AtomicWeight = 208.982, Class = "PTM", Description = "", GroupId = 16, Image = "", Name = "Polonium", PeriodId = 6, Symbol = "Po" },
                        new { ElementId = 107, AtomicNumber = 85, AtomicWeight = 208.982, Class = "M", Description = "", GroupId = 17, Image = "", Name = "Astatine", PeriodId = 6, Symbol = "At" },
                        new { ElementId = 108, AtomicNumber = 86, AtomicWeight = 208.982, Class = "NG", Description = "", GroupId = 18, Image = "", Name = "Radon", PeriodId = 6, Symbol = "Rn" }
                    );
                });

            modelBuilder.Entity("PeriodicTable.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new { GroupId = 1 },
                        new { GroupId = 2 },
                        new { GroupId = 3 },
                        new { GroupId = 4 },
                        new { GroupId = 5 },
                        new { GroupId = 6 },
                        new { GroupId = 7 },
                        new { GroupId = 8 },
                        new { GroupId = 9 },
                        new { GroupId = 10 },
                        new { GroupId = 11 },
                        new { GroupId = 12 },
                        new { GroupId = 13 },
                        new { GroupId = 14 },
                        new { GroupId = 15 },
                        new { GroupId = 16 },
                        new { GroupId = 17 },
                        new { GroupId = 18 }
                    );
                });

            modelBuilder.Entity("PeriodicTable.Models.Period", b =>
                {
                    b.Property<int>("PeriodId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("PeriodId");

                    b.ToTable("Periods");

                    b.HasData(
                        new { PeriodId = 1 },
                        new { PeriodId = 2 },
                        new { PeriodId = 3 },
                        new { PeriodId = 4 },
                        new { PeriodId = 5 },
                        new { PeriodId = 6 },
                        new { PeriodId = 7 }
                    );
                });

            modelBuilder.Entity("PeriodicTable.Models.Element", b =>
                {
                    b.HasOne("PeriodicTable.Models.Group")
                        .WithMany("Elements")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PeriodicTable.Models.Period")
                        .WithMany("Elements")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
