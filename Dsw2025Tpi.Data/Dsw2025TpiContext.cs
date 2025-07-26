using Microsoft.EntityFrameworkCore;

namespace Dsw2025Tpi.Data;

public class Dsw2025TpiContext: DbContext
{
	public Dsw2025TpiContext(DbContextOptions options) : base(options)
	{

	}


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
	/*
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Category>(eb =>
		{
			eb.ToTable("Categories");
			eb.Property(p => p.Name)
			.HasMaxLength(50)
			.IsRequired();
		});
		modelBuilder.Entity<Product>(eb =>
		{
			eb.ToTable("Products");
			eb.Property(p => p.Sku)
			.HasMaxLength(20)
			.IsRequired();
			eb.Property(p => p.Name)
			.HasMaxLength(60);
			eb.Property(p => p.CurrentUnitPrice)
			.HasPrecision(15, 2);
		});
	*/
	}
}
