using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cud_Api.Data
{
    public partial class online_storeContext : DbContext
    {
        public online_storeContext()
        {
        }

        public online_storeContext(DbContextOptions<online_storeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Kid> Kids { get; set; }
        public virtual DbSet<Man> Men { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Woman> Women { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=RENTAL-044\\SQLEXPRESS;Database=online_store;User Id=DapperMock;Password=password");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories", "production");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers", "sales");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Street)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("street");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zip_code");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender", "production");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("gender_name");
            });

            modelBuilder.Entity<Kid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Kids", "production");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("list_price");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("product_name");
            });

            modelBuilder.Entity<Man>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Men", "production");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("list_price");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("product_name");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__order_it__46596229E5735747");

                entity.ToTable("order_items", "sales");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("list_price");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__order_ite__produ__68487DD7");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products", "production");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("list_price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__products__catego__3B75D760");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__products__gender__3C69FB99");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__stocks__47027DF5B024E624");

                entity.ToTable("stocks", "production");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.Stock)
                    .HasForeignKey<Stock>(d => d.ProductId)
                    .HasConstraintName("FK__stocks__product___47DBAE45");
            });

            modelBuilder.Entity<Woman>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Women", "production");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("list_price");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("product_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
