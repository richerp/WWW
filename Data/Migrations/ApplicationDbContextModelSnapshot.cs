using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WWW.Data;
using WWW.Models;

namespace WWW.Data.Migrations
{
    [DbContext(typeof(WWWDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WWW.Models.Organization", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("OrgName");

                    b.HasKey("OrgId");

                    b.ToTable("Orgs");
                });

            modelBuilder.Entity("WWW.Models.OrgUserRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("JoinTime");

                    b.Property<int>("OrgId");

                    b.Property<short>("Type");

                    b.Property<string>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("OrgId");

                    b.HasIndex("UserID");

                    b.ToTable("OURelations");
                });

            modelBuilder.Entity("WWW.Models.PersonalCourse", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("CourseId");

                    b.HasIndex("CreatorId");

                    b.ToTable("PersonalCourse");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PersonalCourse");
                });

            modelBuilder.Entity("WWW.Models.PersonalProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("ProductId");

                    b.HasIndex("CreatorId");

                    b.ToTable("PersonalProducts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PersonalProduct");
                });

            modelBuilder.Entity("WWW.Models.WWWUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime>("AccountCreateTime");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("HeadImgUrl");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NickName");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PreferedLanguage");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Sex");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WWW.Models.OrgCourse", b =>
                {
                    b.HasBaseType("WWW.Models.PersonalCourse");

                    b.Property<int>("OrgId");

                    b.HasIndex("OrgId");

                    b.ToTable("OrgCourse");

                    b.HasDiscriminator().HasValue("OrgCourse");
                });

            modelBuilder.Entity("WWW.Models.OrgProduct", b =>
                {
                    b.HasBaseType("WWW.Models.PersonalProduct");

                    b.Property<int>("OrgId");

                    b.HasIndex("OrgId");

                    b.ToTable("OrgProduct");

                    b.HasDiscriminator().HasValue("OrgProduct");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WWW.Models.WWWUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WWW.Models.WWWUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WWW.Models.WWWUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WWW.Models.OrgUserRelation", b =>
                {
                    b.HasOne("WWW.Models.Organization", "Org")
                        .WithMany("Users")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WWW.Models.WWWUser", "User")
                        .WithMany("Orgs")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("WWW.Models.PersonalCourse", b =>
                {
                    b.HasOne("WWW.Models.WWWUser", "Creator")
                        .WithMany("MyCourses")
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("WWW.Models.PersonalProduct", b =>
                {
                    b.HasOne("WWW.Models.WWWUser", "Creator")
                        .WithMany("MyProducts")
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("WWW.Models.OrgCourse", b =>
                {
                    b.HasOne("WWW.Models.Organization", "BelongingOrg")
                        .WithMany("Courses")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WWW.Models.OrgProduct", b =>
                {
                    b.HasOne("WWW.Models.Organization", "BelongingOrg")
                        .WithMany("Products")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
